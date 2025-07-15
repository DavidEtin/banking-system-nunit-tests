using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTProject.lab1;

namespace TestUTProject.lab1
{
    public class TempConverterTests
    {
        private TempConverter converter = new TempConverter();

        [Test]
        public void TestCelsiusToFahrenheit()
        {
            Assert.That(converter.ConvertTemp(0, 'C', 'F'), Is.EqualTo(32.0).Within(0.01));
        }

        [Test]
        public void TestCelsiusToKelvin()
        {
            Assert.That(converter.ConvertTemp(0, 'C', 'K'), Is.EqualTo(273.15).Within(0.01));
        }
    }
}
