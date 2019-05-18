using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace Ex_Tempore.Control
{
    class FileControl
    {
        static public Dictionary<string, string> allTheThings = new Dictionary<string, string>();
        static public Dictionary<string, string> respuestas = new Dictionary<string, string>();
        static public List<string> roomDescriptions = new List<string>();
        

        public static void readOpciones(string filepath)
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //filepath esta en mastercontrol
            string opciones = dir + @"\Textos\Opciones\" + filepath;

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

        public static void readRespuestas(string filepath)
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //filepath esta en mastercontrol
            string respuestas1 = dir + @"\Textos\Respuestas\" + filepath;

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

        public static string addRoomDescription(string filepath)
        {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //filepath esta en mastercontrol
            string description = dir + @"\Textos\Rooms\" + filepath;

            using (StreamReader sr = new StreamReader(description))
            {
                while (!sr.EndOfStream) // Keep reading until we get to the end
                {
                    string splitMe = sr.ReadLine();
                    string[] bananaSplits = splitMe.Split(new char[] { '\n' }); //Split at the space
                    int spaces = bananaSplits.Count() -1;
                    roomDescriptions.Add(bananaSplits[spaces]);

                    return roomDescriptions.ToString();

                }
            }
            return "";

        }

        public static void clear()
        {
            allTheThings.Clear();
            respuestas.Clear();
        }

        public static void Add(string opciones,string respuestas)
        {
            clear();
            readOpciones(opciones);
            readRespuestas(respuestas);
        }
    }
}
