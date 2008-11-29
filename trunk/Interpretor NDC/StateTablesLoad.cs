using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace Interpretor_NDC
{
    // State tables load
    class StateTablesLoad : CustomisationDataCommands
    {
        public bool[] StateOk = null;
        public string[] StateTableData = null;
        public string MessageAuthenticationCode = "";

        public StateTablesLoad(string str)
            : base(str)
        {
            Name = "State Tables Load";

            int sep = Utils.StrIndexOf((char)28, str, 3);
            // nurara State-urile transmise
            int nrState = GetNoStates(str);

            // nu exista State-uri
            if (nrState < 0)
            {
                StateOk = new bool[1];
                StateTableData = new string[1];
                StateOk[0] = false;
                StateTableData[0] = "ERROR";
            }
            else
            {
                StateOk = new bool[nrState];
                StateTableData = new string[nrState];
                // load state
                for (int i = 0; i < StateTableData.Length; i++)
                {
                    int start = Utils.StrIndexOf((char)28, str, 3 + i);
                    int stop = Utils.StrIndexOf((char)28, str, 3 + i + 1);
                    if (stop < 0)
                        stop = str.Length;

                    StateTableData[i] = str.Substring(start + 1, stop - 1 - start);
                    if (StateTableData[i].Length != 28)
                        StateOk[i] = false;
                    else
                        StateOk[i] = true;

                    sep = stop;
                }
            }
            //FS
            if (sep >= str.Length - 1)
                return;

            MessageAuthenticationCode = str.Substring(sep + 1, 8);
            Trailer = str.Substring(sep + 1 + 8);
        }

        public int GetNoStates(string str) // da numarul de state-uri din str
        {
            int reIndex = Utils.StrIndexOf((char)28, str, 3);   // se sare peste antetul de inceput si se trece la primul state probabil

            if (reIndex < 0)
                return -1;  // nu exista state-uri => eroare

            // numara posibilele state-uri
            int noStates = 0;
            while (reIndex > 0)
            {
                int lastIndex = reIndex;
                noStates++;
                reIndex = Utils.StrIndexOf((char)28, str, 3 + noStates); // urmatorul separator
                // urmeaza un state?
                if (reIndex < -1) // nu mai exista separator
                {
                    // ultimul a fost state sau nu?
                    if (lastIndex + 28 == str.Length - 1) // a fost
                        break;
                    else // nu a fost
                        noStates--;
                }
                else if (reIndex == str.Length - 1) // se termina brusc cu un separator
                    break;
            }
            return noStates;
        }

        public void SaveToFile(string pathToSave)
        {
            FileInfo stateDB = new FileInfo(pathToSave);
            if (!stateDB.Exists)
                return;
            StreamWriter append = stateDB.AppendText();

            for (int i = 0; i < StateTableData.Length; i++)
                append.WriteLine(StateTableData[i]);

            append.Close();

        }

    };


    // State Table
    class StateTable
    {
        public string[] part = null; // cele 8 parti 8*3
        public string[] descriptionPart = null; //
        public string[] namePart = null; //


       public string Numar;
       public char Type;
       public string descriptionType;

        public StateTable(string strNumarTypeCommon) // mesajul transmis cu numar tip si partea comuna
        {
            this.Numar = "###";
            this.Type = '#';
            this.descriptionType = "!!!Maybe is extended!!!";
           /*for (int i = 0; i < part.Length; i++)
            {
                part[i] = "###";
                descriptionPart[i] = "***";
                namePart[i] = "???";
            }*/

            if (strNumarTypeCommon.Length != 28)
                return;

            Numar = strNumarTypeCommon.Substring(0, 3);
            Type = strNumarTypeCommon[3];
            /*for (int i = 0; i < namePart.Length; i++)
            {
                part[i] = strNumarTypeCommon.Substring(3 * i + 4, 3);
            }*/
        }

        public void particulariseState(string pathConfigXML, string textMessage)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathConfigXML);

            XmlNode Node = xmlDoc.DocumentElement.FirstChild;
            while( Node != null)
            {
                if (Node.Attributes["type"].Value == textMessage[3].ToString())
                {
                    int lenPart = 10;
                    XmlNode childrenNode = Node.FirstChild.NextSibling; // este extins?
                    if (childrenNode != null)
                    {
                        lenPart += 10;
                        XmlNode childrenChildrenNode = childrenNode.FirstChild.NextSibling;
                        if (childrenChildrenNode != null)                       // dublu extins
                        {
                            lenPart += 10;
                        }
                    }

                    part = new string[lenPart];
                    descriptionPart = new string[lenPart];
                    namePart = new string[lenPart];

                    namePart[0] = Numar;
                    descriptionPart[0] = "Numar";
                    part[0] = textMessage.Substring(0, 3);
                    
                    namePart[1] = Type.ToString();
                    descriptionPart[1] = descriptionType = Node.Attributes["descriptionType"].Value;
                    part[1] = textMessage.Substring(3, 1);

                    for (int i = 2; i < 10; i++)
                    {
                        namePart[i] = Node.Attributes[i].Value;
                        descriptionPart[i] = Node.Attributes[i + 8].Value.Replace("\\r\\n", "\r\n");
                        part[i] = textMessage.Substring(3 * (i-2) + 4, 3);
                    }
                }
                Node = Node.NextSibling;
            }
        }

        public void SaveToXML(StreamWriter writer)
        {
            // <State>
            writer.Write("\t<State number=\"{0}\" type=\"{1}\" ", Numar, Type);
            for (int i = 0; i < part.Length; i++)
                writer.Write("part{0}=\"{1}\" ",i+1, part[i]);
            writer.WriteLine(">");
            //</State>
            writer.WriteLine("\t</State>");
        }
    };

}


