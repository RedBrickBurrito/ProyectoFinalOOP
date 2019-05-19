using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;


namespace Ex_Tempore.Actos.A1
{
    class Loc_11:Loc_1
    {
       
        

        public Loc_11()
        {

            roomDescription = FileControl.addRoomDescription("Loc_A1.txt");
 
            roomDescription = "Abres la puerta y te encuentras en un pasillo, con dos puertas a los lados. " +
                " \nEscuchas un ruido, al final de pasillo.";


        }

        

            
    }


}


