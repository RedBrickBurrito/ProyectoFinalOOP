using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;


namespace Ex_Tempore.Actos.A1
{
    class Loc_1:Location
    {
        FileControl readopciones = new FileControl();
        Inventory mochila = new Inventory("mochila", true, "Una mochila donde puedes guardar 10 cosas", false, 10);

        public Loc_1()
        {
            //falta añadir las locaciones por texto
            roomDescription = FileControl.addRoomDescription("Loc_A1.txt");

            roomDescription = "Haz despertado en una habitación sucia y destrozada." +
                " \nTe duele la cabeza y tardas un tiempo en ponerte de pie." +
                "Lo único que tienes puesto es ropa desgastada." +
                "\nMiras a tu alrededor y hay una variedad de objetos;\n" +
                "un periódico, una foto,una llave,un uniforme sin usar, y una mochila un poco desgastada.";


        }

        public string getOpciones()
        {


            char opcion = Console.ReadKey().KeyChar;






            foreach (KeyValuePair<string, string> entry in FileControl.respuestas)
            {

                string value = entry.Value;
                int key = entry.Key.Count();

                if (opcion.ToString() == entry.Key)
                {
                    if (opcion.ToString() == "c" && mochila.isAlive == false)
                    {
                        Console.WriteLine("\n no tienes donde guardarla");
                    }
                    else if (opcion.ToString() == "c" && mochila.isAlive == true)
                    {
                        Console.WriteLine("\n" + value);
                        mochila.space -= 1;
                    }
                    else if (opcion.ToString() == "e")
                    {

                        mochila.isAlive = true;
                        Console.WriteLine("\n" + value);

                            
                    }
                    else if(key == 0)
                    {

                        Console.WriteLine("Que quieres hacer?");
                        FileControl.Add("opcionesA1_1.1.txt", "respuestasA1_1.txt");
                        foreach(KeyValuePair<string, string> entry_1 in FileControl.respuestas)
                        {
                            if (opcion.ToString() == "a")
                            {
                                break;
                            }
                            else if (opcion.ToString() == "b")
                            {

                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("\n" + value);
                        FileControl.allTheThings.Remove(entry.Key);
                    }

                }
            }

            return "";
        }


    }
}

