using System;

namespace MyObserverApp
{
    /// <summary>
    /// Concrete Observer
    /// </summary>
    class Produkt : Beobachter
    {
        public Operand OperandA { get; set; }
        public Operand OperandB { get; set; }

        public override void Update()
        {
            //könnte man bspw noch auslagern in einen Methode "BerechneErgebnis" oder so Ähnlich
            Console.WriteLine($"Produkt der beiden Zellen: {OperandA.Wert * OperandB.Wert}");
        }
    }
}