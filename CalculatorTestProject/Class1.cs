using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Moq;



namespace CalculatorTestProject
{
    [TestFixture]
    public class CalculatorTestMethods
    {
        [Test]
       public void verifyclassattributes()
        {
            CheckPropertyValidation cpv = new CheckPropertyValidation();
            var emp = new Employee
            {
              // EmpId="EID001",
                EmpName="Krishna",
                Location="Bangalore",
                age=26,
                Email="krishnagmail.com"

            };
            var errorcount = cpv.myValidation(emp).Count();
            Assert.AreEqual(0, errorcount);


        }
    }
}
