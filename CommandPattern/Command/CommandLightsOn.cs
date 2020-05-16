using CommandPattern.Command.Devices;

namespace CommandPattern.Command
{
    public class CommandLightsOn : ICommand
    {
        private LightDevice _light;

        public CommandLightsOn(LightDevice l) => _light = l;
        
        public bool ExecuteOn()
        {
            if(_light == null)
                return false;
            _light.SwitchOn();
            return true;
        }
    }
}