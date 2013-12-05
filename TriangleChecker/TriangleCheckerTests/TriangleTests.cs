using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TestPoint()
        {
            Point myPoints = new Point(1, 1);
        }

        [TestMethod()]
        // Testar om lika/jämna värden ger liksidig triangel
        public void Equilateral_SameValues()
        {
            Triangle myTriangle = new Triangle(100, 100, 100);
            Assert.IsTrue(myTriangle.isEquilateral());
        }

        [TestMethod()]
        // Testar om udda värden ger liksidig triangel
        public void Equilateral_DiffrentValues()
        {
            Triangle myTriangle = new Triangle(123.5, 134.1, 1223.1);
            Assert.IsFalse(myTriangle.isEquilateral());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        // Testar om nollvärden ger liksidig triangel
        public void Equilateral_ValueOfZero()
        {
            Triangle myTriangle = new Triangle(0, 0, 0);
            
            Assert.Fail("Nollvärden accepteras, vilket ej är korrekt!");
        }

        [TestMethod()]
        // Testar om negativa värden ger en liksidig triangel
        public void Equilateral_NegativeValues()
        {
            Triangle myTriangle = new Triangle(-123.5, -134.1, -1223.1);
            Assert.IsFalse(myTriangle.isEquilateral());
        }

        [TestMethod()]
        // Testar om samma värden ger likbent triangel
        public void Isosceles_Same()
        {
            Triangle myTriangle = new Triangle(100, 100, 100);
            Assert.IsFalse(myTriangle.isIsosceles());
        }

        [TestMethod()]
        // Testar om olika värden ger likbent triangel
        public void Isosceles_DiffrentValues()
        {
            Triangle myTriangle = new Triangle(136, 258, 124);
            Assert.IsFalse(myTriangle.isIsosceles());
        }

        // Testar om korrekta värden för en likbent triangel fungerar
        [TestMethod()]
        public void Isosceles_AccurateValues()
        {
            Triangle myTriangle = new Triangle(6, 5, 6);
            Assert.IsTrue(myTriangle.isIsosceles());
        }

        [TestMethod()]
        // Testar om nollvärden ger likbent triangel
        public void Isosceles_ValueOfZero()
        {
            Triangle myTriangle = new Triangle(0, 0, 0);
            Assert.IsFalse(myTriangle.isIsosceles());
        }

        [TestMethod()]
        // Testar om nollvärden ger triangel som inte har någon sida lik den andra
        public void Scalene_ValueOfZero()
        {
            Triangle myTriangle = new Triangle(0, 0, 0);
            Assert.IsFalse(myTriangle.isScalene());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        // Testar om negativa värden ger triangel som inte har någon sida lik den andra
        public void Scalene_NegativeValues()
        {
            Triangle myTriangle = new Triangle(-16, -14, -12);
            Assert.Fail("När vi inte arbetar med points, skall ej negativa värden accepteras!");
        }

        [TestMethod()]
        // Testar om korrekta värden ger triangel som inte har någon sida lik den andra
        public void Scalene_AccurateValues()
        {
            Triangle myTriangle = new Triangle(10.0, 20.0, 30.0);
            Assert.IsTrue(myTriangle.isScalene());
        }

        [TestMethod()]

        public void TriangleConstructorThreeValues()
        {
            // Testar att skapa en triangel genom standardkonstruktor och korrekt antal värden
            Triangle myTriangle = new Triangle(41.5, 15.5, 21.5);

            // Testar att skapa en triangel genom arraykonstruktor och korrekt antal värden
            // Osäker på denna, points istället?
            double[] triangleValues = { 41.5, 15.5, 21.5 };
            Triangle myTriangle2 = new Triangle(triangleValues);
        }

        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TriangleConstructorTwoValues()
        {
            // Testar att skapa en triangel genom arryay och fel antal värden
            double[] triangleValuesWrong = { 41.5, 15.5 };
            Triangle myTriangle = new Triangle(triangleValuesWrong);
            //Assert.IsFalse(triangleValuesWrong[0] == 41.5 && triangleValuesWrong[1] == 15.5);
            Assert.Fail("Felaktigt antal värden kan matas in och accepteras!");
        }

        [TestMethod()]
        // Här testar jag att rita ut en triangel genom ett kordinatsystem.
        public void TriangleConstructorPoints()
        {
            Point cordinateOne = new Point(-5, 0);
            Point cordinateTwo = new Point(0, 5);
            Point cordinateThree = new Point(5, 0);

            Triangle cordinateTriangle = new Triangle(cordinateOne, cordinateTwo, cordinateThree);
            Assert.IsFalse(cordinateTriangle.isScalene());
        }

        // Gör här samma sak som ovan, men skapar en array istället för att initiera konstruktorn
        // som har hand om det.
        [TestMethod()]
        public void TriangleConstructorPointsArray()
        {
            Point cordinateOne = new Point(0, 0);
            Point cordinateTwo = new Point(0, 5);
            Point cordinateThree = new Point(0, 5);

            Point[] cordinates = new Point[3] { cordinateOne, cordinateTwo, cordinateThree };

            Triangle cordinateTriangle = new Triangle(cordinates);
        }

        // Gör här samma sak igen, fast med 2 värden. Förväntat resultat är att det blir fel.
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TriangleConstructorPointsArrayTwoValues()
        {
            Point cordinateOne = new Point(0, 0);
            Point cordinateTwo = new Point(0, 5);
            Point[] cordinates = new Point[2] { cordinateOne, cordinateTwo };
            Triangle cordinateTriangle = new Triangle(cordinates);
            Assert.IsFalse(cordinates.Length != 3);
        }


    }
}
