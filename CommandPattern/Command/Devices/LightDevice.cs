using System;

namespace CommandPattern.Command.Devices
{
    public class LightDevice 
    {
        public void SwitchOn()
        {
            Console.WriteLine("Encendida la luz del salón");
        }
    }
}