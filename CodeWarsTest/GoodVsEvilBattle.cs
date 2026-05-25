namespace CodeWarsTest
{
    public class GoodVsEvilBattle
    {
        public static string GoodVsEvil(string good, string evil)
        {
            int[] goodSide = Array.ConvertAll(good.Split(' '), int.Parse);
            int[] evilSide = Array.ConvertAll(evil.Split(' '), int.Parse);

            int[] goodArmy = { 1, 2, 3, 3, 4, 10 };
            int[] evilArmy = { 1, 2, 2, 2, 3, 5, 10 };

            int goodArmyTotal = 0;
            int evilArmyTotal = 0;

            for (int i = 0; i < goodSide.Length; i++)
            {
                goodArmyTotal += goodSide[i] * goodArmy[i];
            }

            for (int i = 0; i < evilSide.Length; i++)
            {
                evilArmyTotal += evilSide[i] * evilArmy[i];
            }

            if (goodArmyTotal == evilArmyTotal)
            {
                return "Battle Result: No victor on this battle field";
            }
            else if (goodArmyTotal > evilArmyTotal)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }
        }
    }
}
