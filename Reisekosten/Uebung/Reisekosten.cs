namespace Uebung
{
    public static class Reisekosten
    {
        public static double BerechneErstattung(int kilometer)
        {
            if (kilometer < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            int letzteStelle = kilometer % 10;

            if (letzteStelle > 0)
            {
                kilometer = kilometer - letzteStelle;
                kilometer = kilometer + 10;
            }
            
            if (kilometer > 1000)
            {
                kilometer = 1000;
            }

            int volleErstattungKilometer = kilometer;
            int reduzierteErstattungKilometer = 0;
            
            if (kilometer > 500)
            {
                volleErstattungKilometer = 500;
                reduzierteErstattungKilometer = kilometer - volleErstattungKilometer;
            }

            return volleErstattungKilometer * 0.3 + reduzierteErstattungKilometer * 0.25;
        }
        
    }
}