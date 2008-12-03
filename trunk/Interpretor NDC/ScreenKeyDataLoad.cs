using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Interpretor_NDC
{
    // State tables load
    class ScreenKeyDataLoad : CustomisationDataCommands
    {
        public string[] ScreenNumber = null;
        public string[] ScreenData = null;
        public string MessageAuthenticationCode = "";

        public ScreenKeyDataLoad(string str)
            : base(str)
        {
            Name = "Screen/Key Load";

            int sep = Utils.StrIndexOf((char)28, str, 3);
            // nurara Screen-urile transmise
            int nrScreen = Utils.StrCount((char)28, str, sep-1);

            // nu exista Screen-uri
            if (nrScreen < 0)
            {
                return;
            }
            else
            {
                ScreenNumber = new string[nrScreen];
                ScreenData = new string[nrScreen];
                // load state
                for (int i = 0; i < ScreenData.Length; i++)
                {
                    ScreenNumber[i] = str.Substring(sep + 1, 3);
                    int lengthState = str.IndexOf((char)28, sep + 1) - sep - 1 - 3;
                    if (lengthState < 0)
                        ScreenData[i] = str.Substring(sep + 1 + 3);
                    else
                        ScreenData[i] = str.Substring(sep + 1 + 3, lengthState);
                    sep = str.IndexOf((char)28, sep + 1);
                }
            }
            //FS
            // Optional
            if (str.Length - 1 < sep + 1) // afara din string
                return;

            //MessageAuthenticationCode = str.Substring(sep + 1, 8);
            //Trailer = str.Substring(sep + 1 + 8);
        }

        public static void SaveToFile(string strDownloadLine, string pathToSave, bool append_file)
        {
            ScreenKeyDataLoad temp = new ScreenKeyDataLoad( strDownloadLine );
            if( append_file == true )
            {
                FileInfo stateDB = new FileInfo(pathToSave);
                if (!stateDB.Exists)
                    return;
                StreamWriter append = stateDB.AppendText();

                for (int i = 0; i < temp.ScreenData.Length; i++)
                {
                    append.Write(temp.ScreenNumber[i]);
                    append.WriteLine(temp.ScreenData[i]);
                }
                append.Close();
            }
            else
            {
                FileInfo stateDB = new FileInfo(pathToSave);
                StreamWriter append = stateDB.CreateText();

                for (int i = 0; i < temp.ScreenData.Length; i++)
                {
                    append.Write(temp.ScreenNumber[i]);
                    append.WriteLine(temp.ScreenData[i]);
                }
                append.Close();
            }
        }
    }

    class ScreenKey
    {
        public string numar = null;
        public string text = null;

        public static List<ScreenKey> ScreenKeys = new List<ScreenKey>();
        public static byte NrOfCharScreenNumber = 3;

        public ScreenKey()
        {
            numar = "";
            text = "";
        }

        public ScreenKey(string _numar, string _text)
        {
            numar = _numar;
            text = _text;
        }

        public static ScreenKey GetScreenKey( string _numar )
        {
            for(int i = 0; i < ScreenKeys.Count; i++)
                if( ScreenKeys[i].numar == _numar )
                    return ScreenKeys[i];
            
            return null;
        }
    };

    struct BoxScreenControl // o casuta din ecran
    {
        public Point P_sus;
        public Point P_jos;
        public char character;

        public BoxScreenControl( Point _P_sus, Point _P_jos, char _character)
        {
            P_sus = new Point(_P_sus.X, _P_sus.Y);
            P_jos = new Point(_P_jos.X, _P_jos.Y);
            character = _character;
        }

        public BoxScreenControl( Point _P_sus, Point _P_jos )
        {
            P_sus = new Point(_P_sus.X, _P_sus.Y);
            P_jos = new Point(_P_jos.X, _P_jos.Y);
            character = (char)0;
        }

        public void DrawText(object sender, PaintEventArgs e)
        {
            if( character != (char)0 )
                e.Graphics.DrawString(character.ToString(), new Font("Arial", 15.25f), Brushes.Yellow, P_sus.X, P_sus.Y);
        }
    };

    class ScreenControl : Panel
    {
        public BoxScreenControl[,] ScreenBox = new BoxScreenControl[32,16];
        private char[] axes = { '@', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':', ';', '<', '=', '>', '?' };
        //public 
        public ScreenControl(bool visible)
        {
            this.BackColor = System.Drawing.Color.Navy;
            this.Location = new System.Drawing.Point(137, 186);
            this.Name = "panelVirtual";
            this.Size = new System.Drawing.Size(640, 480);
            this.Visible = visible;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawScreenControl);
            
            // init Box
            Point P1 = new Point(0, 0);
            Point P2 = new Point(20, 30);
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    ScreenBox[j, i] = new BoxScreenControl(P1, P2);
                    P1.X += 20;
                    P2.X += 20;
                }
                P1.X = 0;
                P2.X = 0;
                P1.Y += 30;
                P2.Y += 30;
            }
        }

        public int GetPos(char ch)
        {
            for (int i = 0; i < axes.Length; i++)
                if (axes[i] == ch)
                    return i;
            return -1;
        }

        public void LoadCharScreen( string strScreen ) // incarca aria scrinului cu caractere
        {
            int ii = 0;
            int jj = 0;

            for(int i = 0; i < strScreen.Length; i++)
            {
                char ch = strScreen[i];
                switch(ch)
                {
                    case (char)0x0C:    // FF
                        ii = 0;
                        jj = 0;
                        break;
                    case (char)0x0E:    // SO
                        break;
                    case (char)0x0F:    // SI
                        if( i + 2 < strScreen.Length )
                        {
                            int tempii = GetPos(strScreen[i + 1]);
                            if (tempii < 0)
                                break;
                            int tempjj = GetPos(strScreen[i + 2]);
                            if (tempjj < 0)
                                break;
                            ii = tempii;
                            jj = tempjj;
                            i = i + 2;
                        }
                        break;
                    case (char)0x09:    // HT
                        break;
                    case (char)0x11:    // DC1
                        break;
                    case (char)0x12:    // DC2
                        break;
                    case (char)0x1B:    // ESC
                        break;
                    case (char)0x0D:    // CR
                        ii++;
                        jj = 0;
                        break;
                    case (char)0x0B:    // VT
                        break;
                    default:
                        {
                            
                            if( jj >= 32 )
                            {
                                jj = 0;
                                ii++;
                            }
                            if (ii >= 16)
                                return;
                            
                            ScreenBox[jj, ii].character = ch;
                            jj++;
                            break;
                        }
                }

            }
        }

        public void DrawScreenControl(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            for (int i = 0; i < 32; i++ )
                G.DrawLine(new Pen(Color.Black), 20*i, 0, 20*i, 480);
            for (int i = 0; i < 16; i++)
                G.DrawLine(new Pen(Color.Black), 0, 30*i, 640, 30*i);
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 32; j++)
                    ScreenBox[j, i].DrawText(sender, e);
        }
        
    };
}
