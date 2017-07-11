using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transmax_Programming_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transmax_Programming_Test.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void StudentTest()
        {
            Student Bundy = new Student("BUNDY", "TERESSA", 88);
            Student Smith = new Student("SMITH", "ALLAN", 70);
            Student King = new Student("KING", "MADISON", 88);
            Student Smith1 = new Student("SMITH", "FRANCIS", 85);

            Assert.IsTrue(Bundy is Student, Bundy.FirstName + " is a Student");
            Assert.IsTrue(Smith is Student, Smith.FirstName + " is a Student");
            Assert.IsTrue(King is Student, King.FirstName + " is a Student" );
            Assert.IsTrue(Smith1 is Student, Smith1.FirstName + " is a Student");

        }

        [TestMethod()]
        public void ToStringTest()
        {
            Student Bundy = new Student("BUNDY", "TERESSA", 88);
            Assert.IsNotNull(Bundy.ToString());
        }
    }
}