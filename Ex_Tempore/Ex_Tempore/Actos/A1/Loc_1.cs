﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;


namespace Ex_Tempore.Actos.A1
{
    class Loc_1:Location,IOlocs
    {


        

        public Loc_1()
        {


            roomDescription = "Haz despertado en una habitación sucia y destrozada." +
                " \nTe duele la cabeza y tardas un tiempo en ponerte de pie." +
                "Lo único que tienes puesto es ropa desgastada." +
                "\nMiras a tu alrededor y hay una variedad de objetos;\n" +
                "un periódico, una foto,una llave,un uniforme sin usar, y una mochila un poco desgastada.";
            FileControl.recorrido.Add(roomDescription);



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
                        FileControl.recorrido.Add("no tienes donde guardarla");
                        Console.WriteLine("\n no tienes donde guardarla");
                    }
                    else if (opcion.ToString() == "c" && mochila.isAlive == true)
                    {
                        FileControl.recorrido.Add(value);
                        Console.WriteLine("\n" + value);

                        mochila.space -= 1;
                        llave.useable = true;
                        conditionsMet = true;
                        FileControl.allTheThings.Remove(entry.Key);
                    }
                    else if (opcion.ToString() == "e")
                    {
                        FileControl.recorrido.Add(value);
                        mochila.isAlive = true;
                        Console.WriteLine("\n" + value);
                        FileControl.allTheThings.Remove(entry.Key);


                    }
                   
                    else
                    {
                        FileControl.recorrido.Add(value);
                        Console.WriteLine("\n" + value);
                        FileControl.allTheThings.Remove(entry.Key);
                    }

                } 
                    
                
            }

            return "";
        }


    }
}

