
using TestDateFormat;

namespace Library.Tests
{
    // Definimos la clase que tendra las pruebas.
    public class DateFormatterTests
    {
        [Test]
        //primera prueba, probamos que devuelva la fecha 
        public void TestDataFormatter_CorrectFormat_ShouldReturnFormattedDate() 
        {
            // Datos de entrada y resultado esperado
            string inputDate = "13/09/2023";
            string expectedOutput = "2023-09-13"; // el resultado correcto 

            // La funcion que queremos probar
            string result = DateFormatter.ChangeFormat(inputDate);

            // probar si el resultado es el que esperamos 
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        // segunda prueba, probamos si devuelve el mensaje de error cuando el formato esta incorrecto 
        public void TestDataFormatter_IncorrectFormat_ShouldReturnErrorMessage()
        {
            // datos de entrada y resultado esperado
            string inputDate = "13/09/20233";
            string expectedOutput = "Error: Formato de fecha incorrecto";

            // la funcion que uqremos probar 
            string result = DateFormatter.ChangeFormat(inputDate);

            // probar si el resutado es el que esperabamos
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        // tercera prueba,probamos si devueve error cuando esta en blanco la fecha
        public void TestDataFormatter_BlankDate_ShouldReturnErrorMessage()
        {
            // datos de entrada y el resultado que queremos 
            string inputDate = "  ";
            string expectedOutput = "Error: Fecha en blanco"; 

            // la funcion que queremos probar 
            string result = DateFormatter.ChangeFormat(inputDate);

            // vemos si el resultado es el que esperamos 
            Assert.AreEqual(expectedOutput, result);
        }
    }
}



