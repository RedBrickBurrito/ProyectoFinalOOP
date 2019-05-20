using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;

namespace Ex_Tempore.Actos.A1
{
    class Loc_3 : Location
    {
        public Loc_3()
        {

            //roomDescription = FileControl.addRoomDescription("Loc_A1.txt");

            roomDescription = " Wooow, por fin despertaste!!! creí que no te levantarías, desde que caíste del cielo, " +
                "todos te daban por muerto, pero yo no. No perdí la esperanza y aquí estás, estuviste 3 días en cama, " +
                "así que me tomé la libertad de vestirte, espero y no te moleste.";


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
                        FileControl.AddRespuestasTemp("respuestas_Natalia1.txt");
                        FileControl.AddOpcionesTemp("opciones_Natalia1.txt");
                        //Console.WriteLine("\n" + value);
                        Console.WriteLine("");
                        FileControl.allTheThingsTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));

                        while (FileControl.allTheThingsTemp.Count > 0)
                        {
                            foreach (KeyValuePair<string, string> entry1 in FileControl.respuestasTemp)
                            {

                                Console.WriteLine("");

                                
                                    if (opcion.ToString() == entry.Key)
                                    {

                                    if (FileControl.allTheThingsTemp.Count > 0)
                                    {
                                        char opcion2 = Console.ReadKey().KeyChar;

                                        if (opcion2.ToString() == "a")
                                        {
                                            amistadNatalia += 1;
                                            Console.WriteLine("\n Si, no hay problema es muy común , que esten asi todas la casas, " +
                                                " en cuanto a tu amnesia “temporal” creo que se debe a que caiste del cielo.");
                                            Console.WriteLine(" Si, creo que fue por eso, por cierto cual es tu nombre ?");
                                            Console.WriteLine(" Introduce la letra a.......");
                                            char opcion3 = Console.ReadKey().KeyChar;

                                            if (opcion3.ToString() == "a")
                                            {
                                                Console.WriteLine(" Natalia - Ahh claro qué tonta, se me paso decirte, me llamo Natalia." +
                                                " Quieres salir afuera a tomar aire “fresco”?");
                                                Console.WriteLine("\n Presiona Esc para salir afuera...");
                                                do
                                                {
                                                    while (!Console.KeyAvailable)
                                                    {
                                                        FileControl.allTheThingsTemp.Clear();
                                                        endThis = true;
                                                        break;
                                                    }
                                                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                                            }

                                        }
                                        else if (opcion2.ToString() == "b")
                                        {
                                            Console.WriteLine(" Ey tranquilo, tranquilo todo el país está dividido en secciones, " +
                                                " empezando con la A y terminando en la Z, el 32 es el distrito y ya de alli se divide las colonias en Letras. " +
                                                " Te ves un poco intranquilo, que tal si vamos afuera a que tomes un poco de aire?");
                                            Console.WriteLine("\n Presiona Enter para salir afuera...");
                                            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
                                            {
                                                FileControl.allTheThingsTemp.Clear();
                                                endThis = true;
                                                break;
                                            }

                                        }
                                        else if (opcion2.ToString() == "c")
                                        {

                                            Console.WriteLine("\n Oh mi padre, bueno sufre de alzheimer, recuerda cómo llegar a la casa, " +
                                                " aunque a veces se pierde y lo tengo que buscar, pero no es muy diferente a todos, " +
                                                " la mayoría sufre de un grado de alzheimer, " +
                                                " pero no tan grave como mi padre, con el tengo que gastar mucho en medicinas.");
                                            Console.WriteLine("\n Presiona Enter para continuar...");
                                            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
                                            {
                                                amistadNatalia += 1;
                                                Console.WriteLine(" a:Vaya que has tenido una vida difícil me imagino. " +
                                                    " Por cierto nunca me mencionaste tu nombre?");
                                                Console.WriteLine("\n Natalia - Ahh claro qué tonta, se me paso decirte, me llamo Natalia." +
                                                " Quieres salir afuera a tomar aire “fresco”?");
                                                Console.WriteLine("\n Presiona Esc para salir afuera...");
                                                do
                                                {
                                                    while (!Console.KeyAvailable)
                                                    {
                                                        FileControl.allTheThingsTemp.Clear();
                                                        endThis = true;
                                                        break;
                                                    }
                                                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


                                            }



                                        }
                                        else if (opcion2.ToString() == "d")
                                        {
                                            amistadNatalia -= 1;
                                            Console.WriteLine("\n Heey, recuerda que yo fui quien te cuidó durante tres días, se mas agradecido!!!");
                                            Console.WriteLine(" Opciones:");
                                            Console.WriteLine("a Tranquila linda, no te alteres quería ver como respondias." +
                                                "b Vaya me despierto con un terrible dolor de cabeza, y lo primero que escucho son regaños de una niña.");
                                            char opciones3 = Console.ReadKey().KeyChar;
                                            if (opciones3.ToString() == "a")
                                            {
                                                Console.WriteLine(" Natalia: Quien te dio permiso de llamarme Linda, idiota.Sal de aquí!!!");
                                                Console.WriteLine("\n Presiona Esc para salir afuera...");
                                                do
                                                {
                                                    while (!Console.KeyAvailable)
                                                    {
                                                        FileControl.allTheThingsTemp.Clear();
                                                        endThis = true;
                                                        break;
                                                    }
                                                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                                            }
                                            else if (opciones3.ToString() == "b")
                                            {
                                                amistadNatalia -= 1;
                                                Console.WriteLine(" Natalia: Sal de mi casa idiota!!!");
                                                Console.WriteLine("\n Presiona Esc para salir afuera...");
                                                do
                                                {
                                                    while (!Console.KeyAvailable)
                                                    {
                                                        FileControl.allTheThingsTemp.Clear();
                                                        endThis = true;
                                                        break;
                                                    }
                                                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                                            }
                                        }
                                    } else if(FileControl.allTheThingsTemp.Count == 0)
                                    {
                                        break;
                                    }
                                    
                                    } else {

                                }
            

                            }

                        }
                        FileControl.allTheThings.Remove(entry.Key);
                    }
                    else if(opcion.ToString() == "b")
                    {
                        Console.WriteLine("\n" + value);
                        FileControl.allTheThings.Remove(entry.Key);
                    }
                    else if(opcion.ToString() == "c")
                    {
                        Console.WriteLine("\n" + value);
                        Console.WriteLine("\n Natalia - Pero creo que te vendria bien un poco de aire" +
                            "fresco");
                        Console.WriteLine("\n Presiona Esc para salir afuera...");
                        do
                        {
                            while (!Console.KeyAvailable)
                            {
                                FileControl.allTheThingsTemp.Clear();
                                endThis = true;
                                break;
                            }
                        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                        FileControl.allTheThings.Remove(entry.Key);
                    }
                    else if(opcion.ToString() == "d")
                    {
                        Console.WriteLine("\n" + value);
                        FileControl.allTheThings.Remove(entry.Key);
                    }


                    return "";
                }
            }
            return "";
        }
    }
}
