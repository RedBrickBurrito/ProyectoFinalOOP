using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;


namespace Ex_Tempore.Actos.A1
{
    class Loc_2 : Location
    {
        public bool endThis = false;


        public Loc_2()
        {

            //roomDescription = FileControl.addRoomDescription("Loc_A1.txt");

            roomDescription = "Abres la puerta y te encuentras en un pasillo, con dos puertas a los lados. " +
                "Escuchas un ruido, al final de pasillo.";


        }


        public string getOpciones()
        {
            char opcion = Console.ReadKey().KeyChar;
            Console.WriteLine("");





            foreach (KeyValuePair<string, string> entry in FileControl.respuestas)
            {

                string value = entry.Value;
                int key = entry.Key.Count();

                if (opcion.ToString() == entry.Key)
                {

                    if (opcion.ToString() == "a")
                    {
                        Console.WriteLine("Examinas la pila de juguetes pero no encuentras nada interesante.Sales del cuarto hacia el pasillo.");
                        FileControl.allTheThings.Remove(entry.Key);
                    }
                    else if (opcion.ToString() == "b")
                    {



                        FileControl.AddRespuestasTemp("respuestas_CuartoDerecha.txt");
                        FileControl.AddOpcionesTemp("opciones_CuartoDerecha.txt");
                        Console.WriteLine("\n" + value);
                        Console.WriteLine("");
                        FileControl.respuestasTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));
                   


                        while (FileControl.allTheThingsTemp.Count > 0)
                        {
                            foreach (KeyValuePair<string, string> entry1 in FileControl.respuestasTemp)
                            {
                        
                                if (FileControl.allTheThingsTemp.Count == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    if (opcion.ToString() == entry.Key)
                                    {
                                        char opcion2 = Console.ReadKey().KeyChar;
                                        if (opcion2.ToString() == "a")
                                        {
                                            mochila.space -= 1;
                                            botellaAgua.useable = true;
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            Console.WriteLine("\nHaz guardado el agua en tu mochila");
                                           


                                        }
                                        else if (opcion2.ToString() == "b")
                                        {
                                            mochila.space -= 1;
                                            antibioticos.useable = true;
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            Console.WriteLine("\nHaz guardado los antibioticos en tu mochila");


                                        }
                                        else if (opcion2.ToString() == "c")
                                        {
                                            mochila.space -= 1;
                                            vendas.useable = true;
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            Console.WriteLine("\nHaz guardado las vendas en tu mochila");


                                        }
                                        else if (opcion2.ToString() == "d")
                                        {

                                            FileControl.allTheThingsTemp.Clear();

                                        }
                                    }
                                }

                            }

                        }
                        
                    }
                    else if (opcion.ToString() == "c" || endThis == true)
                    {
                        conditionsMet = true;
                        FileControl.clear();
                        FileControl.allTheThings.Remove(entry.Key);
                        break;
                    }
                }

             }

            return "";
        }

          


        }
}


