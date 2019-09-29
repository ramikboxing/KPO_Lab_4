using System;
using Kpo4381_nmv.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        private CarNewLoad_lab4 newLoader;
             
        public UnitTest()
        {
            newLoader = new CarNewLoad_lab4("Lab4Cars.txt");
        }
        //Test 1
        /*Проверка имени файла для загрузки*/
        [TestMethod]
        public void TestFileName()
        {
            var target = newLoader.getFileName;
            Assert.AreEqual("Lab4Cars.txt", target);
        }
        //Тест 2
        /*Проверка марки первой ммашины в получаемом списке*/
        [TestMethod]
        public void TestExecuteMethodCarModel()
        {
            newLoader.Execute();
            var targetCarModel = newLoader.carsList[0].Mark;
            Console.WriteLine("TestTest"+ newLoader.carsList[0].Mark);
            Assert.AreEqual("Mersedes", targetCarModel);
        }
        //Тест 3
        /*Проверка пустой список или нет*/
        [TestMethod]
        public void ChekListNotNull_File()
        {
            ICarFactory loader = new CarTestFactory(); // обращение к объектам через интер-с
            ICarsListLoader Loader = loader.CreateCarListLoader();
            Loader.Execute();// Заполнение списка
            Assert.IsNotNull(Loader.carsList);// Проверка списка на пустату          
        }

    }
}

