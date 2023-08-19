using System;

namespace Utilities;
public class UUID{
    static public string V4(){

        string OCID = "";
        Random random = new();
        // generating a OCID uuid
        int i = 0;
        while(i < 12){
            i++;
            int O = random.Next(1, 101);
            char C = (char)random.Next('A', 'Z' + 1);
            char I = (char)random.Next('a', 'z' + 1);

            OCID = OCID + O.ToString() + C + I;
        }

        Console.WriteLine(OCID);

        return OCID;
    }
}