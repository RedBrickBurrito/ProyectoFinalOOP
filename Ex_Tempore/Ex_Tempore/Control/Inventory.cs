
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Tempore.Control
{
    class Inventory
    {
        public string name;
        public bool isAlive = false;
        public byte space = 0;
        public bool useable = false;
        public int ammo = 0;
        private bool needsItem;
        private string description;



        public Inventory(string _name, bool canUse, string _description, bool _isAlive, byte _space)
        {
            name = _name;
            useable = canUse;
            description = _description;
            isAlive = _isAlive;
            space = _space;
        }

        public int Ammo
        {
            get { return ammo; }
        }

        public string Name
        {
            get { return name; }
        }

        public bool Useable
        {
            get { return useable; }
        }

        public string Description
        {
            get { return description; }
        }
    }
}

