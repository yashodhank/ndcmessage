// Clasa derivata din clasa de baza, care ar fi o clasa de baza pentru alte cateva clase
// Marian V.

using System;

class CustomisationDataCommands : CentralToTerminal
{
    char MessageSubClass = '0';
    char Identifier = '0';
    public CustomisationDataCommands(string str) : base(str)
    {
        int sep1 = str.IndexOf('∟', 0);
        int sep2 = str.IndexOf('∟', sep1 + 1);
        int sep3 = str.IndexOf('∟', sep2 + 1);
        int len = str.Length;
        //FS
        MessageSubClass = Convert.ToChar(str[sep3 + 1]);
        Identifier = Convert.ToChar(str[sep3 + 2]);
    }
};

// State tables load
class StateTablesLoad : CustomisationDataCommands
{
    public string[] StateNumber = null;
    public string[] StateTableData = null;
    public string MessageAuthenticationCode = "";
    
    public StateTablesLoad(string str) : base(str)
    {
        Name = "State Tables Load";

        int sep = StrIndexOf('∟', str, 3);
        // nurara State-urile transmise
        int nrState = StrCount('∟', str, sep + 1);

        // nu exista State-uri
        if( nrState < 0 )
        {
            StateNumber = new string[1];
            StateTableData = new string[1];
            StateNumber[0] = "ERROR";
            StateTableData[0] = "ERROR";
        }
        else
        {
            StateNumber = new string[nrState];
            StateTableData = new string[nrState];
            // load state
            for( int i=0; i<StateTableData.Length; i++ )
            {
                StateNumber[i] = str.Substring(sep+1, 3);
                int lengthState = str.IndexOf('∟', sep + 1) - sep-1-3;
                StateTableData[i] = str.Substring(sep+1+3, lengthState);
                sep = str.IndexOf('∟', sep + 1);
            }
        }
        //FS
        // Optional
        if (str.Length - 1 < sep + 1) // afara din string
            return;

        MessageAuthenticationCode = str.Substring(sep + 1, 8);
        Trailer = str.Substring(sep + 1 + 8);
    }

};

