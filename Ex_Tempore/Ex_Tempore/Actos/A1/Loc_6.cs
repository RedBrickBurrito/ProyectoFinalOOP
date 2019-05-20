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
                        Console.WriteLine("\n" + value);
                        FileControl.AddRespuestasTemp("respuestas_DistritoNoche1.txt");
                        FileControl.AddOpcionesTemp("opciones_DistritoNoche1.txt");

                        //FileControl.respuestasTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));
                        while (FileControl.allTheThingsTemp.Count > 0)
                        {
                            foreach (KeyValuePair<string, string> entry1 in FileControl.respuestasTemp)
                            {
                                Console.WriteLine("a - Los atacantes al ver tu arma paran de golpearlo y se alejan," +
                                    " insultandome mientras lo hacen." +
                                    "Extraño (herido) - *Cof* *Cof* Gracias….. [Pierde la conciencia]." +
                                    " A lo lejos ves que salen un grupo de hombres armados," +
                                    " que se acercan a ti rápidamente." +
                                    "Hombre Armado - Manos a la cabeza si no quieres que te vuele la cabeza. (Apunta el arma hacia ti ).");
                                Console.WriteLine("");
                                
                                string value1 = entry1.Value;
                                int key1 = entry1.Key.Count();
                                //FileControl.respuestasTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));
                                if (FileControl.allTheThingsTemp.Count == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    if (opcion.ToString() == entry.Key)
                                    {
                                        Console.WriteLine("[El hombre amarra tus manos y te escolta ]");
                                        Console.WriteLine("\n Presiona Enter para continuar...");
                                        do
                                        {
                                            while (!Console.KeyAvailable)
                                            {
                                                FileControl.allTheThingsTemp.Clear();
                                                endThis = true;
                                                conditionsMet = true;
                                                break;
                                            }
                                        } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                                        break;

                                    }
                                }

                            }

                        }

                    }
                    else if (opcion.ToString() == "b")
                    {
                        FileControl.AddRespuestasTemp("respuestas_DistritoNoche1.txt");
                        FileControl.AddOpcionesTemp("opciones_DistritoNoche1.txt");
                        Console.WriteLine("\n" + value);
                        //FileControl.respuestasTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));
                        while (FileControl.allTheThingsTemp.Count > 0)
                        {
                            foreach (KeyValuePair<string, string> entry1 in FileControl.respuestasTemp)
                            {
                                if (amistadNatalia > 1)
                                {
                                    Console.WriteLine("Tocas la puerta de la casa de Natalia, escuchas pasos cada vez mas cerca de la puerta," +
                                        " cortos y livianos, es Natalia.");
                                    Console.WriteLine("Natalia - Vaya es demasiado tarde, me alegra que hayas venido" +
                                        "pero ahora necesito dormir ");
                                    Console.WriteLine("[Te regresas]");
                                    break;
                                }
                                else if(amistadNatalia < 0)
                                {
                                    Console.WriteLine("Narrador - Tocas la puerta de la casa de Natalia, pero no escuhas respuesta");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("Te diriges a su casa pero al parecer no hay ninguna luz prendida. [Te alejas]");
                                FileControl.allTheThingsTemp.Clear();
                                conditionsMet = true;
                                break;
                            }

                        }

                    }
                }
            }
            return "";
        }
    }
}
