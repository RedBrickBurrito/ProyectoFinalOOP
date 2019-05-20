using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Actos.A1;
using Ex_Tempore.Actos;
using Ex_Tempore.Control;

namespace Ex_Tempore.Control
{
    class MasterControl
    {
        Loc_1 l1 = new Loc_1();
        Loc_2 l2 = new Loc_2();
        Loc_3 l3 = new Loc_3();


        public void play()
        {

            //En los parametros va el nombre del archivo en texto
            FileControl.readOpciones("opcionesA1_1.0.txt");
            FileControl.readRespuestas("respuestasA1_1.txt");

            Console.WriteLine(l1.getDescription());




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
                        l1.seguir = true;
                        Console.WriteLine("\n");
                    }
                    else if (opcion2.ToString() == "b")
                    {
                        FileControl.clear();
                        break;
                    }

                }
                else
                {
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
                if (l3.conditionsMet == true || FileControl.allTheThings.Count == 0)
                {
                    break;
                }
                else
                {
                    FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));
                    Console.WriteLine(l3.getOpciones());
                }
            }

            Console.WriteLine("Check good");

        }

    }
}
