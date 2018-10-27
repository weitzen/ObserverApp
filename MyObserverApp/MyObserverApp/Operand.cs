using System.Collections.Generic;

namespace MyObserverApp
{
    /// <summary>
    /// ConcreteSubject
    /// </summary>
    class Operand : Zelle
    {
        public Operand(int initialerZellenwert)
        {
            Wert = initialerZellenwert;
            AlleBeobachter = new List<Beobachter>();
        }
    }
}
