using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;

namespace Ex_Tempore.Actos.A1
{
    class Loc_4 : Location, IOlocs
    {
        
        public Loc_4()
        {
            roomDescription = "Te encuentras en un páramo de casas con techos de lámina, " +
                " paredes con agujeros y paredes descarapeladas, " +
                " en general está lleno de basura y el olor es es nauseabundo. " +
                " Cerca está un tambo encendido en llamas donde está un grupo de gente discutiendo mientras están calentándose las manos.";
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
                    if(opcion.ToString() == "a")
                    {
                        FileControl.AddRespuestasTemp("respuestas_DistritoA.txt");
                        FileControl.AddOpcionesTemp("opciones_DistritoA.txt");
                        Console.WriteLine("\n" + value);
                        FileControl.respuestasTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));
                        while (FileControl.allTheThingsTemp.Count > 0)
                        {
                            foreach (KeyValuePair<string, string> entry1 in FileControl.respuestasTemp)
                            {

                                string value1 = entry1.Value;
                                int key1 = entry1.Key.Count();
                                if (FileControl.allTheThingsTemp.Count == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    if (opcion.ToString() == entry.Key)
                                    {
                                        //FileControl.allTheThingsTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));

                                        char opcion2 = Console.ReadKey().KeyChar;
                                        if (opcion2.ToString() == "a")
                                        {
                                            Console.WriteLine("\n" + value1);
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            FileControl.allTheThingsTemp.Clear();
                                            break;
                                        }
                                        else if (opcion2.ToString() == "b")
                                        {
                                            Console.WriteLine("\n" + value1);
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            FileControl.allTheThingsTemp.Clear();
                                            break;

                                        }
                                        else if (opcion2.ToString() == "c")
                                        {
                                            Console.WriteLine("\n" + value1);
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            FileControl.allTheThingsTemp.Clear();
                                            break;

                                        }
                                        
                                    }
                                }

                            }
      
                        }

                    }
                    else if(opcion.ToString() == "b")
                    {
                        Console.WriteLine("\n" + value);
                        conditionsMet = true;
                        break;
                        
                    }
                }
            }
                    return "";
        }
    }
}
