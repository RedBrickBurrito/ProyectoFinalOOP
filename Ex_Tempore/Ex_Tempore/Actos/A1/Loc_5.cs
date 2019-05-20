using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;

namespace Ex_Tempore.Actos.A1
{
    class Loc_5 : Location,IOlocs
    {
        public Loc_5()
        {
            roomDescription = "Puedes escuchar un ligero sonido electrónico, y ves como la puerta se abre. " +
                "Un hombre alto y delgado con un traje blanco y corbata roja entra al cuarto. " +
                "Al principio no puedes ver como se ve por el sombrero que trae puesto, " +
                "pero cuanto más se acerca a ti puedes observar como tiene un rostro perfecto, " +
                "sin imperfecciones, sientes como sus  ojos verdes se clavan como cuchillas en los tuyos." +
                " El toma la silla enfrente de ti y se sienta. " +
                "Hombre del traje blanco: Sabes que es el primer mensaje que recibo al despertarme……." +
                " uno de mis genios del laboratorio me llama urgentemente en la mañana para decirme que supuestamente alguien cayó del cielo," +
                " puedes imaginar mi sorpresa cuando me lo confirmaron.Tú eres la prueba viviente que el viaje en el tiempo es posible," +
                " eres de verdad un ángel mandado del cielo para nosotros. " +
                "Se que tendrás muchas preguntas para mi, pero apenas te conozco y no se si puedo confiar en ti, " +
                "así que haremos esto. Tengo que hacerte unas preguntas primero," +
                " y después podemos hablar de hacer un tipo de trato.";
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
