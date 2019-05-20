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
                        Console.WriteLine("");
                    }
                    else if (opcion.ToString() == "b")
                    {

                    }
                }
            }
            return "";
        }
            
    }
}
