using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Actos.A1;
using Ex_Tempore.Actos;
using Ex_Tempore.Control;
using System.IO;

namespace Ex_Tempore.Control
{
    class MasterControl
    {
        Loc_1 l1 = new Loc_1();
        Loc_2 l2 = new Loc_2();
        Loc_3 l3 = new Loc_3();
        Loc_4 l4 = new Loc_4();
        Loc_5 l5 = new Loc_5();
        Loc_6 l6 = new Loc_6();
        Loc_7 l7 = new Loc_7();



        public void play()
        {
            bool gameisOver = false;

            while (!gameisOver)
            {
                //En los parametros va el nombre del archivo en texto
                FileControl.readOpciones("opcionesA1_1.0.txt");
                FileControl.readRespuestas("respuestasA1_1.txt");

                Console.WriteLine(l1.getDescription());



                if (Location.mochila.space > 0)
                {
                    while (FileControl.allTheThings.Count > 0)
                    {

                        if (l1.conditionsMet == true && l1.seguir == false || FileControl.allTheThings.Count == 0)
                        {
                            Console.WriteLine("\nQue quieres hacer?");
                            Console.WriteLine("\nOpciones:");
                            Console.WriteLine("\na Seguir Investigando");
                            Console.WriteLine("b Abrir la puerta");
                            char opcion2 = Console.ReadKey().KeyChar;

                            if (opcion2.ToString() == "a")
                            {
                                FileControl.recorrido.Add("Seguir Investigando");
                                l1.seguir = true;
                                Console.WriteLine("\n");
                            }
                            else if (opcion2.ToString() == "b")
                            {
                                FileControl.recorrido.Add("Abrir puerta");
                                FileControl.clear();
                                break;
                            }
                            Console.Clear();
                        }
                        else
                        {
                            FileControl.recorrido.Add("Opciones:");
                            Console.WriteLine("\nOpciones: ");
                            Console.WriteLine(" ");
                            FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));

                            Console.WriteLine(l1.getOpciones());
                        }



                    }



                    FileControl.Add("opciones_Pasillo.txt", "respuestas_Pasillo.txt");
                    Console.WriteLine(l2.getDescription());

                    l2.conditionsMet = false;
                    l2.seguir = true;

                    while (FileControl.allTheThings.Count > 0)
                    {
                        if (l2.conditionsMet == true || FileControl.allTheThings.Count == 0)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));
                            Console.WriteLine(l2.getOpciones());
                        }

                    }

                    FileControl.Add("opciones_CuartoNatalia.txt", "respuestas_CuartoNatalia.txt");
                    FileControl.clearOpcionesTemp();
                    FileControl.clearRespuestasTemp();
                    Console.WriteLine(l3.getDescription());

                    l3.conditionsMet = false;
                    l3.endThis = false;

                    while (FileControl.allTheThings.Count > 0)
                    {
                        if (l3.endThis == true || FileControl.allTheThings.Count == 0)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));
                            Console.WriteLine(l3.getOpciones());
                        }
                    }


                    FileControl.Add("opciones_Distrito.txt", "respuestas_Distrito.txt");
                    FileControl.clearOpcionesTemp();
                    FileControl.clearRespuestasTemp();
                    Console.WriteLine(l4.getDescription());

                    l4.conditionsMet = false;
                    l4.endThis = false;

                    while (FileControl.allTheThings.Count > 0)
                    {
                        if (l4.conditionsMet == true || FileControl.allTheThings.Count == 0)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));
                            Console.WriteLine(l4.getOpciones());
                        }
                    }

                    FileControl.Add("opciones_CuartoBlanco.txt", "respuestas_CuartoBlanco.txt");
                    FileControl.clearOpcionesTemp();
                    FileControl.clearRespuestasTemp();
                    Console.WriteLine(l5.getDescription());

                    l5.conditionsMet = false;
                    l5.endThis = false;

                    while (FileControl.allTheThings.Count > 0)
                    {
                        if (l5.conditionsMet == true || FileControl.allTheThings.Count == 0)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));
                            Console.WriteLine(l5.getOpciones());
                        }
                    }

                    FileControl.Add("opciones_DistritoNoche.txt", "respuestas_DistritoNoche.txt");
                    FileControl.clearOpcionesTemp();
                    FileControl.clearRespuestasTemp();
                    Console.WriteLine(l6.getDescription());

                    l6.conditionsMet = false;
                    l6.endThis = false;

                    while (FileControl.allTheThings.Count > 0)
                    {
                        if (l6.conditionsMet == true || FileControl.allTheThings.Count == 0)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));
                            Console.WriteLine(l6.getOpciones());
                        }
                    }

                    FileControl.Add("opciones_Guarida.txt", "respuestas_Guarida.txt");
                    FileControl.clearOpcionesTemp();
                    FileControl.clearRespuestasTemp();
                    Console.WriteLine(l7.getDescription());

                    l7.conditionsMet = false;
                    l7.endThis = false;

                    while (FileControl.allTheThings.Count > 0)
                    {
                        if (l7.conditionsMet == true || FileControl.allTheThings.Count == 0)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));
                            Console.WriteLine(l7.getOpciones());
                        }
                    }


                    Console.WriteLine("\nHaz llegado al final de esta historia, garcias por jugar.");
                    FileControl.Recorrido();
                    Console.WriteLine("\n Presiona Esc para continuar...");
                    do
                    {
                        while (!Console.KeyAvailable)
                        {
                            FileControl.allTheThings.Clear();
                            FileControl.respuestas.Clear();
                            gameisOver = true;
                        }
                    } while (Console.ReadKey(true).Key != ConsoleKey.Escape);



                }
                else if (Location.mochila.space == 0)
                {
                    Console.WriteLine("Se te acabo el espcacio de la mochila");
                }

            }
        }

    }
}
