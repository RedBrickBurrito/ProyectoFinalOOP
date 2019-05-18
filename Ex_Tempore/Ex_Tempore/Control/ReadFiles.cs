using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace Ex_Tempore.Control
{
    class ReadFiles
    {
        static public Dictionary<string, string> allTheThings = new Dictionary<string, string>();
        static public Dictionary<string, string> respuestas = new Dictionary<string, string>();
        string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
        

        public void read()
        {
            string opciones = dir + @"\Textos\Opciones\opcionesA1.txt";

            // los archivos se suben a la carpeta Debug que esta adentro de bin
            using (StreamReader sr = new StreamReader(opciones))
            {
                while (!sr.EndOfStream) // Keep reading until we get to the end
                {
                    string splitMe = sr.ReadLine();
                    string[] bananaSplits = splitMe.Split(new char[] { ':' }); //Split at the space

                    if (bananaSplits.Length < 2) // If we get less than 2 results, discard them
                        continue;
                    else if (bananaSplits.Length == 2) // Easy part. If there are 2 results, add them to the dictionary
                        allTheThings.Add(bananaSplits[0].Trim(), bananaSplits[1].Trim());
                    // else if (bananaSplits.Length > 2)
                    //SplitItGood(splitMe, allTheThings); // Hard part. If there are more than 2 results, use the method below.
                }
            }
        }

        public void readRespuestas()
        {
            string respuestas1 = dir + @"\Textos\Respuestas\respuesta.txt";

            using (StreamReader sr = new StreamReader(respuestas1))
            {
                while (!sr.EndOfStream) // Keep reading until we get to the end
                {
                    string splitMe = sr.ReadLine();
                    string[] bananaSplits = splitMe.Split(new char[] { ':' }); //Split at the space

                    if (bananaSplits.Length < 2) // If we get less than 2 results, discard them
                        continue;
                    else if (bananaSplits.Length == 2) // Easy part. If there are 2 results, add them to the dictionary
                        respuestas.Add(bananaSplits[0].Trim(), bananaSplits[1].Trim());
                    // else if (bananaSplits.Length > 2)
                    //SplitItGood(splitMe, allTheThings); // Hard part. If there are more than 2 results, use the method below.
                }
            }
        }
    }
}
