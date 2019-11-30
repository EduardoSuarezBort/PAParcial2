using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carlos;

namespace CarlosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSaveDeberiaSumar()
        {
            //Organizar

            double inicial = 420;
            double cantidadguardada = 96;
            double valoresperado = 516;
            Company Objeto = new Company("Eduardo", inicial);
            
            //Actuar

            Objeto.Save(cantidadguardada);

            //Afirmar

            double valoractual = Objeto.SaveProject;
            Assert.AreEqual(valoresperado, valoractual);
        }

        [TestMethod]
        public void TestSpendDeberiaGastar()
        {
            //Organizar

            double inicial = 540;
            double cantidadgastada = 65;
            double valoresperado = 475;
            Company Objeto = new Company("Eduardo", inicial);

            //Actuar

            Objeto.Spend(cantidadgastada);

            //Afirmar

            double valoractual = Objeto.SaveProject;
            Assert.AreEqual(valoresperado, valoractual);
        }

        [TestMethod]
        public void TestChangeNameDebeCambiar()
        {
            //Organizar

            string inicial = "Fernando";
            string nuevo = "Marcos" ;
            string valoresperado = "Marcos";
            Company Objeto = new Company( inicial, 999);

            //Actuar

            Objeto.ChangeName(nuevo);

            //Afirmar

            string valoractual = Objeto.Name;
            Assert.AreEqual(valoresperado, valoractual);
        }
    }
}
