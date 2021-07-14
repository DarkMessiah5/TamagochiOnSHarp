namespace TamagochiOnSharp
{
    class Tamagochi
    {
        public int health, hunger, fatigue;

        public Tamagochi()
        {
            health = 10;
            hunger = 0;
            fatigue = 0;
        }

        public void Harm()
        {
            health--;
        }
        public void Feed()
        {
            if (hunger == 0) Harm();
            else hunger--;
        }

        public void Play()
        {
            if (fatigue < 10) fatigue++;
            else Harm();
        }

        public void Sleep()
        {
            fatigue = 0;

            if (health < 10 && hunger < 10)
            {
                health++;
                hunger++;
            }
            else if (hunger < 10) hunger++;
            else if (hunger == 10) Harm();
        }
    }
}
