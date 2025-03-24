using Uebung;

namespace UebungTests
{
    [TestClass]
    public class ReisekostenTests
    {
        [TestMethod]
        [DataRow(0, 0.0)]
        [DataRow(1, 3.0)]  
        [DataRow(500, 150.0)]
        [DataRow(501, 152.5)]
        [DataRow(1000, 275.0)]
        [DataRow(1001, 275.0)]
        public void BerechneErstattung_WirdKorrektBerechnet(int kilometer, double erwarteteErstattung)
        {
            // Arrange
        
            // Act
            double ergebnis = Reisekosten.BerechneErstattung(kilometer);
        
            // Assert
            Assert.AreEqual(erwarteteErstattung, ergebnis);
        }
    
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BerechneErstattung_WirdKorrektBerechnet()
        {
            // Arrange
            int kilometer = -1;
        
            // Act
            double ergebnis = Reisekosten.BerechneErstattung(kilometer);
        }
    }
}