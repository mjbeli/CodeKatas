using System;
using Xunit;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.Test
{
    public class DecoratorTest
    {

        /*
        Price list:
            - Coffee: 1.5
            - Beer: 2.5
            - Ice: 0.5
            - GrandSize: 1.75
            - Canela: 0.15
        Description list:
            - Coffee: "Café"
            - Beer: "Cerveza"
            - Ice: ", con hielo"
            - GrandSize: ", tamaño grande"
            - Canela: ", con canela"
        */
        [Fact]
        public void CafeConHielo()
        {
            BeverageComponent b = new Coffee();
            b = new IceDecorator(b);
            Console.WriteLine(b.getDescription());
            Assert.True(b.getCost()==2.0);
            Assert.True(b.getDescription()==", con hielo");
            //Assert.True(b.getDescription()=="Café");
        }

        [Fact]
        public void CafeConHieloGrande()
        {
            BeverageComponent b = new Coffee();
            b = new IceDecorator(b);
            b = new GrandSizeDecorator(b);

            Console.WriteLine(b.getDescription());
            Assert.True(b.getCost()==3.75);
            //Assert.True(b.getDescription()=="Café, con hielo");
            //Assert.True(b.getDescription()=="Café");
        }

        [Fact]
        public void CervezaGrande()
        {
            BeverageComponent b = new Beer();
            b = new GrandSizeDecorator(b);

            Console.WriteLine(b.getDescription());
            Assert.True(b.getCost()==4.25);
            //Assert.True(b.getDescription()=="Café, con hielo");
            //Assert.True(b.getDescription()=="Café");
        }
    }
}
