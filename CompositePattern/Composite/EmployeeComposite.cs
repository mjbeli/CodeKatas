using System.Collections.Generic;

namespace CompositePattern.CompositePattern
{
    public class EmployeeComposite : EmployeeComponent // Node of the tree. Implements employee manages.
    {
        private IList<EmployeeComponent> _employeeMinions; // this will store the childs of this node.
        public EmployeeComposite(string nombre, double salario) : base(nombre, salario)
        {
            _employeeMinions = new List<EmployeeComponent>();
        }

        public override string GetEmployeeInfo() // Custom operation for a node.
        {
            string s = $"Mi nombre es {this._nombre}, mi salario es {this._salario} y tengo los siguientes minions:";
            foreach (EmployeeComponent e in this._employeeMinions)
                s += " " + e.GetEmployeeInfo();
            return s;
        }

        #region ManageMyMinions
            public void AddMinion(EmployeeComponent e)
            {
                if(e != null)
                    _employeeMinions.Add(e);
            }

            public void RemoveMinion(EmployeeComponent e)
            {
                _employeeMinions.Remove(e);
            }
        #endregion
    }
}
