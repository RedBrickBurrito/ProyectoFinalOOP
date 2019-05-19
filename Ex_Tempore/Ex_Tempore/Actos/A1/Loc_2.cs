using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;


namespace Ex_Tempore.Actos.A1
{
    class Loc_2 : Location
    {



        public Loc_2()
        {

            //roomDescription = FileControl.addRoomDescription("Loc_A1.txt");

            roomDescription = "Abres la puerta y te encuentras en un pasillo, con dos puertas a los lados. " +
                "Escuchas un ruido, al final de pasillo.";


        }


        public string getOpciones()
        {
            char opcion = Console.ReadKey().KeyChar;






            foreach (KeyValuePair<string, string> entry in FileControl.respuestas)
            {

            }

            return "";
        }

          


        }
}


