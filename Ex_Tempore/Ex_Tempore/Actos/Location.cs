using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_Tempore.Control;

namespace Ex_Tempore.Actos
{
    class Location
    {
        public string roomTitle;
        public string roomDescription;
        public bool conditionsMet = false;
        public static FileControl readopciones = new FileControl();
        public static FileControl readopcionesTemp = new FileControl();
        public static FileControl readrespuestasTemp = new FileControl();
        public static Inventory mochila = new Inventory("mochila", true, "Una mochila donde puedes guardar 10 cosas", false, 10);
        public static Inventory llave = new Inventory("llave", true, "una llave para abrir una puerta", false, 0);
        public static Inventory botellaAgua = new Inventory("botella de agua", false, "una botella con agua pura", false, 1);
        public static Inventory antibioticos = new Inventory("botella de agua", false, "una botella con agua pura", false, 1);
        public static Inventory vendas = new Inventory("botella de agua", false, "una botella con agua pura", false, 1);
        public static Inventory armadefuego = new Inventory("arma de fuego", false, "un arma de fuego", false, 1);
        public bool seguir = false;
        public bool endThis = false;
        public int amistadNatalia = 0;


        public Location()
        {
            roomTitle = "";
            roomDescription = "";
        }

        public Location(string title)
        {
            roomTitle = title;
            roomDescription = "";
        }

        public  Location(string title, string description)
        {
            roomTitle = title;
            roomDescription = description;
        }

        public override string ToString()
        {
            return roomTitle;
        }

        

        //public string getTitle()
        //{
        //    return roomTitle;
        //}

        //public void setTitle(string title)
        //{
        //    roomTitle = title;
        //}

        public string getDescription()
        {
            return roomDescription;
        }

        public void setDescription(string description)
        {
            roomDescription = description;
        }


        //puvlic bool Exit();M
        
       
    }
}
