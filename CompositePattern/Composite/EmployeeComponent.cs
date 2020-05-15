namespace CompositePattern.CompositePattern
{
    public abstract class EmployeeComponent
    {
        protected string _nombre;
        protected double _salario;
        public EmployeeComponent(string nombre, double salario)
        {
            _nombre = nombre; _salario = salario;
        }

        public abstract string GetEmployeeInfo(); // This is the common operation for internal nodes and leaves.
    }
}