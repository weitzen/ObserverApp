using System.Collections.Generic;

namespace MyObserverApp
{
    /// <summary>
    /// Subject
    /// </summary>
    class Zelle
    {
   
        protected List<Beobachter> AlleBeobachter{ get; set; }
        public double Wert { get; set; }


        public void Anmelden(Beobachter beobachter) {
            AlleBeobachter.Add(beobachter);
        }

        public void Abmelden(Beobachter beobachter)
        {
            AlleBeobachter.Remove(beobachter);
        }

        public void BenachrichtigeObserver()
        {
            foreach (Beobachter beobachter in AlleBeobachter)

            {
                beobachter.Update();
            }
        }

    }


}
