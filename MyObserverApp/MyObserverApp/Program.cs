using System;

namespace MyObserverApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Vorbemerkungen: Eigentlich sind Summe und Produkt auch beides Zellen.
             Da Beobachter in unsererm Fall aber eine abstrakte Klasse. Es ist nicht möglich zwei Basisklassen zu definieren, 
             deshalb sind Summe und Produkt in erster Linie Beobachter und keine Zellen.
             */

            Operand operandZelleA = new Operand(initialerZellenwert: 0);

            Summe ergebnisSumme = new Summe();

            // wir möchten, dass sich die Summe anpasst, wenn sich der Wert des OperandA in dessen Zelle ändert
            operandZelleA.Anmelden(ergebnisSumme);
            ergebnisSumme.OperandA = operandZelleA;

            Produkt ergebnisProdukt = new Produkt();

            // wir möchten, dass sich das Produkt anpasst, wenn sich der Wert des OperandA in dessen Zelle ändert
            operandZelleA.Anmelden(ergebnisProdukt);
            ergebnisProdukt.OperandA = operandZelleA;

            // nun noch für den zweiten Operanden
            // BEACHTE: das Summen- und Produktobjekt sind weiterhin die gleichen

            Operand operandZelleB = new Operand(initialerZellenwert: 0);
            
            // wir möchten, dass sich die Summe anpasst, wenn sich der Wert des OperandB in dessen Zelle ändert
            operandZelleB.Anmelden(ergebnisSumme);
            ergebnisSumme.OperandB = operandZelleB;

            // wir möchten, dass sich das Produkt anpasst, wenn sich der Wert des OperandB in dessen Zelle ändert
            operandZelleB.Anmelden(ergebnisProdukt);
            ergebnisProdukt.OperandB = operandZelleB;
            
            // etwas Programmcode für das ändern der Operandenwerte durch den Benutzer

            bool quit = false;

            do
            {
                Console.WriteLine($"Bitte Wert für OperandA eingeben: ");
                operandZelleA.Wert = int.Parse(Console.ReadLine());
                // Nachdem sich der Wert der Zelle geändert hat, wollen wir unsere Beobachter Summe und Produkt benachrichtigen.
                operandZelleA.BenachrichtigeObserver();

                Console.WriteLine($"Bitte Wert für OperandB eingeben: ");
                operandZelleB.Wert = int.Parse(Console.ReadLine());
                // Nachdem sich der Wert der Zelle geändert hat, wollen wir unsere Beobachter Summe und Produkt benachrichtigen.
                operandZelleB.BenachrichtigeObserver();

                Console.Write("\"true\" eingeben, um Programm zu beenden: ");
                string continueWithLoop = Console.ReadLine();

                if (bool.TryParse(continueWithLoop, out quit))
                {

                }
                else
                {
                    Console.WriteLine("Kein Boolen!");
                }

            } while (quit == false);
            

        }
    }
}
