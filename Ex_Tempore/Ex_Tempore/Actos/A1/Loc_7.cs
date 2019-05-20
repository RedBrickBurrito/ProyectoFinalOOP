using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;


namespace Ex_Tempore.Actos.A1
{
    class Loc_7 : Location
    {
        public Loc_7()
        {
            //Adentro de al guaridda

            roomDescription = "Te encuentras en lo que parece una mansión, pero de las ventanas no entra luz, hay muchas lámparas y algunos tambos con fuego para alumbrar esa gigantesca casa. Vez mucha gente con armas futuristas y equipamento suficiente para hacer una pequeña guerra. Te llevan con el lider." +
                "El profeta de oro: Entonces tu eres la persona que se supone que cayó del cielo cierto, me intriga mucho ese rumor, dime ¿Es cierto?";

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
                        FileControl.AddRespuestasTemp("respuestas_GuaridaFinal.txt");
                        FileControl.AddOpcionesTemp("opciones_GuaridaFinal.txt");
                        Console.WriteLine("");
                        FileControl.allTheThingsTemp.ToList().ForEach(x => Console.WriteLine(" " + x.Key + " " + x.Value));
                        while (FileControl.allTheThingsTemp.Count > 0)
                        {
                            foreach (KeyValuePair<string, string> entry1 in FileControl.respuestasTemp)
                            {

                                Console.WriteLine("\n Opciones:");
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
                                           
                                            
                                            Console.WriteLine("\n El profeta de oro: Me alegra que hayas elegido eso, prometo que estas tomando la respuesta correcta, juntos liberaremos el mundo. [Te unes al Profeta y a su rebelion, juntos empiezan a luchar contra la mafia del poder y liberando al pueblo, un sector a la vez]");
                                            FileControl.allTheThingsTemp.Clear();
                                            conditionsMet = true;
                                            break;

                                        }
                                        else if (opcion2.ToString() == "b")
                                        {
                                            
                                            Console.WriteLine("\nEl profeta de oro: Eres un tonto en confiar en gente como ellos," +
                                                " pero tienes la libertad de elegir tu destino, eres libre." +
                                                " [Regresas con el Hombre del traje blanco  y le reportas todo lo que aprendiste," +
                                                " te agradece y te da una casa lujosa en los mejores distritos con sirvientes y muchas mujeres." +
                                                " A los pocos meses caes enfermo a la cama y mueres, causa de muerte “envenenamiento” ]");
                                            FileControl.allTheThingsTemp.Clear();
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
                        Console.WriteLine("\n" + value);
                    }
                }
            }
            return "";
        }
            
    }
}
