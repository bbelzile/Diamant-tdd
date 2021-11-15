namespace TDD
{
    public class PratiqueFizzBuzz
    {
        public string FizzBuzz(int entierEnEntree)
        {
            string retour = entierEnEntree.ToString();

            if (entierEnEntree % 15 == 0)
            {
                return "fizzbuzz";
            }
            else if (entierEnEntree % 3 == 0)
            {
                return "fizz";
            }
            else if (entierEnEntree % 5 == 0)
            {
                return "buzz";
            }

            return retour;
        }
    }
}