namespace FactoryPattern.Factory
{
    using Business.Interfaces;
    using Business.Implementations;
    using System;
    using System.Collections.Generic;

    // An implementation of factory Pattern.

    // This Enum will represent each different implementations of pizzas that the factory will create.
    public enum PizzaTypes {MargarinaPizza,
                            BbqPizza};

    // Definition of an abstract class that will create the same inteface.
    // Each class that inherints from this abstract class and implement the Creator() 
    // method will be a different object that implements the interface IPizza. 
    public abstract class PizzaCreator
    {
        public abstract IPizza Creator();
    }


    // The classes that Inherints from PizzaCreator abstract class. The names of theses classes must be
    // the sames as enum types (se below why). Note that the Creator() method actually create a new
    // instance of concrete objects that implements IPizza interface.
    public class MargarinaPizza : PizzaCreator
    {
        public override IPizza Creator() => new MargarinaPizzaImplementation();
    }

    public class BbqPizza : PizzaCreator
    {
        public override IPizza Creator() => new BbqPizzaImplementation();
    }


    // This is de factory class. 
    // It has a dictionary that maps each enum type with a class that inherints
    // from PizzaCreator abstract class. The class is created dinamycally
    // using the name of the enum type --> that's why we need the classes has the same name that enum types.
    public class PizzaFactory
    {
        // readonly attributes can be initialized in the declaration or in constructor.
        private readonly Dictionary<PizzaTypes, PizzaCreator> _pizzaFactory;

        public PizzaFactory()
        {
            _pizzaFactory = new Dictionary<PizzaTypes, PizzaCreator>();

            foreach(PizzaTypes pizzaTypes in Enum.GetValues(typeof(PizzaTypes)))
            {
                var concreteFactory = (PizzaCreator)Activator.CreateInstance(
                                                                            Type.GetType("FactoryPattern.Factory." + 
                                                                            Enum.GetName(typeof(PizzaTypes), pizzaTypes))
                                                                            );
                _pizzaFactory.Add(pizzaTypes, concreteFactory);
                
            }
        }

        // This is the method that will be use to create the IPizza object. Each enum type map a different 
        // class that creates diferent object, but all these objects implements IPizza.
        public IPizza CreatePizza(PizzaTypes pizzaType) => _pizzaFactory[pizzaType]?.Creator();
    }

}