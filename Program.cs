using System;

namespace DenaroInteresse
{
    class Program
    {
        public class CalcoloInteressi
        {
            public static void Start()
            {
                bool isDouble = true;
                double importoDaVincolare = 0;
                int anni = 0;
                int interesseAnnuo = 3;

                do
                {
                    Console.WriteLine("Quale importo vuoi vincolare?");
                    bool isDouble = double.TryParse(Console.ReadLine(), out double importoDaVincolare);
                } while (!isDouble);
                bool IsInt = true;

                do
                {
                    Console.WriteLine("Per quanti anni?");

                    IsInt = int.TryParse(Console.ReadLine(), out int anni);

                } while (!isInt);
                double importoConInteressi = importoDaVincolare;
                for (var i = 0; i < anni; i++) ;
                {
                    double importoAnnoPrecedente = importoConInteressi;
                    double interessi = importoConInteressi * interesseAnnuo / 100;
                    importoConInteressi = importoConInteressi + interessi;
                    Console.WriteLine($"Dopo {interessi + 1} anni, da {importoAnnoPrecedente} avrai maturato {interessi} + $"e il tuo nuovo capitale sarà": { importoConInteressi});

                }
            }
        }
    }
}
