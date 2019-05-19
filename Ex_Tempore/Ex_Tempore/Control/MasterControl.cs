using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Actos.A1;

namespace Ex_Tempore.Control
{
    class MasterControl
    {

        Loc_1 l1 = new Loc_1();


        public void play()
        {

            //En los parametros va el nombre del archivo en texto
            FileControl.readOpciones("opcionesA1_1.0.txt");
            FileControl.readRespuestas("respuestasA1_1.txt");
 
            Console.WriteLine(l1.getDescription());


            Console.WriteLine("Opciones: ");
           
            while (FileControl.allTheThings.Count > 0)
            {
                
                FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));

                Console.WriteLine(l1.getOpciones());

            }

            FileControl.Add("opcionesA1_1.1.txt", "respuestasA1_1.txt");

            while (FileControl.allTheThings.Count > 0)
            {

                FileControl.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));

                Console.WriteLine(l1.getOpciones());

            }





        }

    }
}
