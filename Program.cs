using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChiffreDeCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            ChiffreDeCesar();
        }

        static void ChiffreDeCesar()
        {
            Console.WriteLine("Entrer une phrase à crypter :");
            string text = Console.ReadLine();
            text = text.ToUpper();
            string encodage = "";
            int clef = 3;
            int intCaract;
            int i;
            char[] carac = text.ToCharArray();
            for (i = 0; i < text.Length; i++)
            {
                if (Convert.ToInt32(carac[i]) >= 65 && Convert.ToInt32(carac[i]) < 90)
                {
                    if ((Convert.ToInt32(carac[i]) + clef) > 90)
                    {
                        intCaract = (Convert.ToInt32(carac[i]) + clef) - 26;
                        encodage += (char)intCaract;
                    }
                    else
                    {
                        intCaract = Convert.ToInt32(carac[i]) + clef;
                        encodage += (char)intCaract;
                    }
                }
                else
                {
                    encodage += carac[i];
                }
            }
            Console.WriteLine(encodage);
            Console.ReadKey();
        }
    }
}
