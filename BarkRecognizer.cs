using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogDoorApp.Models;

namespace DogDoorAppV1
{
    internal class BarkRecognizer
    { 
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognize(string bark)
        {
            Console.WriteLine($"BarkRecognizer: Heard a '{bark}'");
            foreach (string allowedBark in door.GetAllowedBarks())
            {
                if (allowedBark.Equals(bark))
                {
                    door.Open();
                    return;
                }
            }
            Console.WriteLine("The bark is not recognized");
        }
    }

}
