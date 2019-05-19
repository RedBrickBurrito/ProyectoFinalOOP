using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Tempore.Actos
{
    class Location
    {
        public string roomTitle;
        public string roomDescription;

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

        public Location(string title, string description)
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
