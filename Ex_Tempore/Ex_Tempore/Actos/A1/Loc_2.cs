﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;


namespace Ex_Tempore.Actos.A1
{
    class Loc_2 : Location, IOlocs
    {


        public Loc_2()
        {

            //roomDescription = FileControl.addRoomDescription("Loc_A1.txt");

            FileControl.recorrido.Add(roomDescription);
            roomDescription = "\nAbres la puerta y te encuentras en un pasillo, con dos puertas a los lados. " +
                "Escuchas un ruido, al final de pasillo.";
            FileControl.recorrido.Add(roomDescription);


        }


        public string getOpciones()
        {
            char opcion = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            FileControl.recorrido.Add(opcion.ToString());

            foreach (KeyValuePair<string, string> entry in FileControl.respuestas)
            {

                string value = entry.Value;
                int key = entry.Key.Count();

                if (opcion.ToString() == entry.Key)
                {

                    if (opcion.ToString() == "a")
                    {
                        FileControl.recorrido.Add(" Examinas la pila de juguetes pero no encuentras nada interesante.Sales del cuarto hacia el pasillo.");
                        Console.WriteLine("");
                        Console.WriteLine(" Examinas la pila de juguetes pero no encuentras nada interesante.Sales del cuarto hacia el pasillo.");
                        FileControl.allTheThings.Remove(entry.Key);
                    }
                    else if (opcion.ToString() == "b")
                    {


                        FileControl.recorrido.Add(value);
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
                                        FileControl.recorrido.Add(opcion2.ToString());
                                        if (opcion2.ToString() == "a")
                                        {
                                            mochila.space -= 1;
                                            botellaAgua.useable = true;
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            Console.WriteLine("\n Haz guardado el agua en tu mochila");
                                            FileControl.recorrido.Add("\n Haz guardado el agua en tu mochila");



                                        }
                                        else if (opcion2.ToString() == "b")
                                        {
                                            mochila.space -= 1;
                                            antibioticos.useable = true;
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            FileControl.recorrido.Add("\n Haz guardado los antibioticos en tu mochila");
                                            Console.WriteLine("\n Haz guardado los antibioticos en tu mochila");


                                        }
                                        else if (opcion2.ToString() == "c")
                                        {
                                            mochila.space -= 1;
                                            vendas.useable = true;
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);

                                            FileControl.recorrido.Add("\n Haz guardado las vendas en tu mochila");
                                            Console.WriteLine("\n Haz guardado las vendas en tu mochila");


                                        }
                                        else if (opcion2.ToString() == "d")
                                        {
                                            FileControl.recorrido.Add("\n Regresar Pasillo");
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


