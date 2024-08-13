using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Models
{
    internal class DogDoor
    {

        
        //edit
        private bool open;
        private List<string> allowedBarks;

        public DogDoor()
        {
            this.open = false;
            this.allowedBarks = new List<string>();
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;
        }

        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            open = false;
        }

        public bool IsOpen()
        {
            return open;
        }

        public void AddAllowedBark(string bark)
        {
            allowedBarks.Add(bark);
        }

        public List<string> GetAllowedBarks()
        {
            return allowedBarks;
        }
    }

}

