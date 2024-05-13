using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_11_1
{
    internal class Program
    {
        class Darbinieks
        {
            private string vards;
            private string uzvards;
            private int dzims_gads;
            private int vecums;

            public string Vards
            {
                get { return vards; }
                set
                {
                    if (value.Length <= 20)
                    {
                        vards = value;
                    }
                    else
                    {
                        vards = "nedefinēts";
                    }
                }
            }
            public string Uzvards
            {

                get { return uzvards; }
                set
                {
                    if (vards != "nedefinēts")
                    {
                        uzvards = value;
                    }
                    else
                    {
                        Console.WriteLine("Definē vārdu vispirms!");
                        return;
                    }
                }
            }
            public int Dzims_gads
            {
                get { return dzims_gads; }
                set { dzims_gads = value;} }

            public int Vecums
            {  
                get
                { 
                    int gads = DateTime.Now.Year;
                    return gads - Dzims_gads;
                }
            }

        }
        static void Main(string[] args)
        {
            Darbinieks darbinieks = new Darbinieks();

            darbinieks.Vards = "MārcisMārcisMārcisMārcisMārcisMārcisMārcis";
            Console.WriteLine($"Darbinieka vārds: {darbinieks.Vards}");

            darbinieks.Uzvards = "Grīnfelds";
            Console.WriteLine($"Darbinieka uzvārds: {darbinieks.Uzvards}");

            darbinieks.Dzims_gads = 2003;
            Console.WriteLine($"Darbinieka vecums: {darbinieks.Vecums}");

        }
    }
}
