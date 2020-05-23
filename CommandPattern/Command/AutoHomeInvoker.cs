using System.Collections.Generic;

namespace CommandPattern.Command
{
    public class AutoHomeInvoker
    {
        private IList<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand c)
        {
            if(c != null)
                _commands.Add(c);
        }

        public void RemoveCommand(ICommand c)
        {
            if(c != null)
                _commands.Remove(c);
        }

        public void ActivateDevice(int p)
        {
            if(p < 0 || p >= _commands.Count)
                return;
            
            _commands[p].ExecuteOn();
        }

    } // end class AutoHomeInvoker
}