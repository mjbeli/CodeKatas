using System;
using CommandPattern.Command;
using CommandPattern.Command.Devices;
using Xunit;

namespace CommandPattern
{
    public class CommandTest
    {
        [Fact]
        public void BasicCommandTest()
        {
            AutoHomeInvoker domotica = new AutoHomeInvoker();

            // Create Devices
            LightDevice luz = new LightDevice();
            NetflixDevice nerflis = new NetflixDevice();

            // Create Commands with concrete devices
            CommandLightsOn cmdLight = new CommandLightsOn(luz);
            NetflixModeOn cmdNetflix = new NetflixModeOn(nerflis);

            // Add commands to the invoker.
            domotica.AddCommand (cmdLight);
            domotica.AddCommand(cmdNetflix);

            // As client, invoke a command to activate one concrete device.
            domotica.ActivateDevice(1);          
        } // end BasicCommandTest()
    }
}
