using AbstractFactory.Class;
using AbstractFactory.Interfaces;
using System;

namespace AbstractFactory
{
    public class Exercice
    {
        public void ChooseProduct(string option, string type)
        {
            var typeUpperCase = type.ToUpper();
            if (typeUpperCase == "A")
            {
                CreateProduct(new ArtDecoFurnitureFactory(), option);
            }
            else if (typeUpperCase == "V")
            {
                CreateProduct(new VictorianFurnitureFactory(), option);
            }
            else if (typeUpperCase == "M")
            {
                CreateProduct(new ModernFurnitureFactory(), option);
            }
        }

        public void CreateProduct(IFurnitureFactory furnitureFactory, string option)
        {
            var optionUpperCase = option.ToUpper();
            if (optionUpperCase == "S")
            {
                var sofa = furnitureFactory.CreateSofa();
                Console.WriteLine(sofa.InformationAboutSofa());
            }
            else if (optionUpperCase == "C")
            {
                var chair = furnitureFactory.CreateChair();
                Console.WriteLine(chair.InformationAboutChair());
            }
            else if (optionUpperCase == "F")
            {
                var coffeeTable  = furnitureFactory.CreateCoffeeTable();
                Console.WriteLine(coffeeTable.InformationAboutCoffeeTable());
            }
        }
    }
}
