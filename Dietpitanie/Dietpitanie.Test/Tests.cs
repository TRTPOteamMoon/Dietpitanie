using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dietpitanie.Test
{
    [TestClass]
    public class DeitpitanieTests
    {
        [TestMethod]
        public void CalculateIndexOfHumanWithHeight150Weight72Age25SexMale()
        {
            //arrange
            const double expected = 32;
            var human = new Human(150,72,25,1);

            //act
            human.CalcuteIndex();
            var actual = human.Index;
          
            //assert
            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void CalculateBmrOfHumanWithHeight150Weight72Age25SexMaleWithoutAnyTypeOfActivity()
        {
            //arrange
            const double expected = 1845.636;
            var human = new Human(150, 72, 25, 1);

            //act
            human.CalculateBmr("сидячая работа, отсутствие спорта", "ничего", "0");
            var actual = human.Bmr;
            
            //assert
            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void CalculateProteinsOfHumanWithHeight150Weight70Age25SexMaleWithActivityType1SportTo5TimeInWeekActivityType2CyclingFor60Min()
        {
            //arrange
            const double expected = 84;
            var human = new Human(150, 70, 25, 1);

            //act
            human.CalculateBmr("спорт до 5 раз за неделю", "велоспорт", "60");
            human.CalculateMacroelemnts();
            var actual = human.Proteins;

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateFatsOfHumanWithHeight150Weight72Age25SexMaleWithActivityType1SportTo5TimeInWeekActivityType2CyclingFor60Min()
        {
            //arrange
            const double expected = 36;
            var human = new Human(150, 72, 25, 1);

            //act
            human.CalculateBmr("спорт до 5 раз за неделю", "велоспорт", "60");
            human.CalculateMacroelemnts();
            var actual = human.Fats;

            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateCarbohydratesOfHumanWithHeight150Weight72Age25SexMaleWithActivityType1SportTo5TimeInWeekActivityType2CyclingFor60Min()
        {
            //arrange
            const double expected = 593.586625;
            var human = new Human(150, 72, 25, 1);

            //act
            human.CalculateBmr("спорт до 5 раз за неделю", "велоспорт", "60");
            human.CalculateMacroelemnts();
            var actual = human.Carbohydrates;

            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
