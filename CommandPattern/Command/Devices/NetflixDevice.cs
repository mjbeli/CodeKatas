using System;

namespace CommandPattern.Command.Devices
{
    public class NetflixDevice 
    {
        public void SwitchOnTheTv()
        {
            Console.WriteLine("Encender la TV");
        }

        public void StartNetflixApp()
        {
            Console.WriteLine("Iniciar Netflix App");
            Console.WriteLine("Seleccionar VOSE con subs en castellano");
        }

        public void SelectAndRelax()
        {
            Console.WriteLine("Seleccionar la serie que Netflix me dice que vea...");
        }
    } // end NetflixDevice
}