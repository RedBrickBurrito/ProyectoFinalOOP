using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;

namespace Ex_Tempore.Actos.A1
{
    class Loc_6 : Location,IOlocs
    {
        public Loc_6()
        {
            roomDescription = "Narrador: Los policías te traen de nuevo, " +
                "donde empezaste el sol se ha cubierto y la luna brilla" +
                " y se refleja en charcos de agua que se encuentran alrededor del suelo. " +
                "Puedes observar el tambo lleno de fuego, " +
                "las luces de la patrulla a lo lejos, y la casa de Natalia. " +
                " Policía: El jefe nos pidió que te encaragaras de “Prometeo” es el supuesto líder," +
                " no hemos encontrado su nombre real, pero lo encontrarás por el alias. " +
                "Una última cosa el jefe nos pidió que te entregaremos esta arma de fuego de tu tiempo. " +
                "No vuelvas sin haberte encargado de Prometeo. [Guardas el arma de fuego que tiene 7 balas en el cartucho, en tu mochila.]";
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
                        FileControl.AddRespuestasTemp("respuestas_CuartoBlancoA.txt");
                        FileControl.AddOpcionesTemp("opciones_CuartoBlancoA.txt");
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
                                        char opcion2 = Console.ReadKey().KeyChar;
                                        if (opcion2.ToString() == "a")
                                        {
                                            Console.WriteLine("\nBueno no es cuestion de que quieras o no," +
                                                "los policias te lleavran de vuekta al distrito," +
                                                "necesito que acabes con los rebeldes.");
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            conditionsMet = true;
                                            break;
                                        }

                                    }
                                }

                            }

                        }

                    }
                    else if (opcion.ToString() == "b")
                    {
                        FileControl.AddRespuestasTemp("respuestas_CuartoBlancoA.txt");
                        FileControl.AddOpcionesTemp("opciones_CuartoBlancoA.txt");
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
                                        char opcion2 = Console.ReadKey().KeyChar;
                                        if (opcion2.ToString() == "a")
                                        {
                                            Console.WriteLine("\nMe gusta tu actitud lamentablemente esto no esta en discusión" +
                                                "Mataras a unos cuantos rebeldes, los policias te escoltaran" +
                                                "Buena Suerte....");
                                            FileControl.allTheThingsTemp.Remove(entry1.Key);
                                            conditionsMet = true;
                                            break;
                                        }

                                    }
                                }

                            }

                        }

                    }
                }
            }
            return "";
        }
    }
}
