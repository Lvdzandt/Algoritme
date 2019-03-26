using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Tests
{
    [TestClass()]
    public class TrainTests
    {

        [TestMethod()]
        public void OrderWagonSizeEmptyTest()
        {
            //arrange 
            Train train = new Train();
            Animal animal = new Animal(1, Animal.AnimalSize.big, true);
            //act check if animal can be added to the empty wagon
            bool compatible = train.Wagons[0].CheckRemainingSize(animal);
            //assert
            Assert.AreEqual(true, compatible);
        }

        [TestMethod()]
        public void OrderWagonSizeTest()
        {
            //arrange 
            Train train = new Train();
            Animal animal = new Animal(1, Animal.AnimalSize.big, true);
            train.Wagons[0].Animals.Add(new Animal(1, Animal.AnimalSize.big, true));
            //act check if animal can be added to the wagon with another animal in it
            bool compatible = train.Wagons[0].CheckRemainingSize(animal);
            //assert
            Assert.AreEqual(true, compatible);
        }

        [TestMethod()]
        public void OrderWagonSizeNoRoomTest()
        {
            //arrange
            Train train = new Train();
            train.Wagons[0].Animals.Add(new Animal(1, Animal.AnimalSize.big, true));
            train.Wagons[0].Animals.Add(new Animal(2, Animal.AnimalSize.big, true));
            train.Wagons[0].CurrSize = 10;
            Animal animal = new Animal(3, Animal.AnimalSize.big, true);
            //act check if the animal can be added in a wagon with no more room
            bool compatible = train.Wagons[0].CheckRemainingSize(animal);
            //assert
            Assert.AreEqual(false, compatible);
        }

        [TestMethod()]
        public void OrderWagonMeatEaterTest()
        {
            //arrange

            //act

            //assert
        }
    }
}