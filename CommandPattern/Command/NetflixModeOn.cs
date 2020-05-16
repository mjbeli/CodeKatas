using CommandPattern.Command.Devices;

namespace CommandPattern.Command
{
    public class NetflixModeOn : ICommand
    {
        private NetflixDevice _netflix;

        public NetflixModeOn(NetflixDevice n) => _netflix = n;
        
        public bool ExecuteOn()
        {
            if(_netflix == null)
                return false;
            _netflix.SwitchOnTheTv();
            _netflix.StartNetflixApp();
            _netflix.SelectAndRelax();
            return true;
        }
    }
}