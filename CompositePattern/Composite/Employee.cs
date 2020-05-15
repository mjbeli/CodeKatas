namespace CompositePattern.CompositePattern
{
    public class Employee : EmployeeComponent // Leaf.
    {
        public Employee (string nombre, double salario) : base(nombre, salario)
        {}

        public override string GetEmployeeInfo() => $"Mi nombre es {this._nombre} y mi salario {this._salario}";

    }
}