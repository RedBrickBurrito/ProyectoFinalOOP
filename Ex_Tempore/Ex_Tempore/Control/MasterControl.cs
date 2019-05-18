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

            ReadFiles readOpciones = new ReadFiles();
            ReadFiles readFiles = new ReadFiles();
            readFiles.readRespuestas();
            readOpciones.read();
            Console.WriteLine(l1.getDescription());


            Console.WriteLine("Opciones: ");
            while (ReadFiles.allTheThings.Count > 0)
            {
                ReadFiles.allTheThings.ToList().ForEach(x => Console.WriteLine(x.Key + " " + x.Value));

                Console.WriteLine(l1.getOpciones());
            }




        }

    }
}
