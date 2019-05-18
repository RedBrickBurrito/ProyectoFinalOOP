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
 
            roomDescription = "Haz despertado en una habitación sucia y destrozada." +
                " \nTe duele la cabeza y tardas un tiempo en ponerte de pie." +
                "Lo único que tienes puesto es ropa desgastada." +
                "\nMiras a tu alrededor y hay una variedad de objetos;\n" +
                "un periódico, una foto,una llave,un uniforme sin usar, y una mochila un poco desgastada.";


        }

        

            
        }


    }


