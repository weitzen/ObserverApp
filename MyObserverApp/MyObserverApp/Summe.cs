using System;

namespace MyObserverApp
{
    /// <summary>
    /// Concrete Observer
    /// </summary>
    class Summe : Beobachter
    {
        public Operand OperandA { get; set; }
        public Operand OperandB { get; set; }

        public override void Update()
        {
            Console.WriteLine($"Summe der beiden Zellen: {OperandA.Wert + OperandB.Wert}");
        }
    }
}
