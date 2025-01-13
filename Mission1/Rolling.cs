namespace Mission1
{
    internal class Rolling
    {
        public static int[] RollNum { get; private set; } 
        public static void Roll(int numberOfRolls)
        {
            RollNum = new int[12]; // 6 sides on 2 die
            SimulateRolls(numberOfRolls);
        }

        private static void SimulateRolls(int numberOfRolls)
        {
            var random = new Random();

            for (int i = 1; i < numberOfRolls; i++)
            {
                int diceRollone = random.Next(1, 7);
                int diceRolltwo = random.Next(1, 7);
                int diceRoll = diceRollone + diceRolltwo;
                RollNum[diceRoll - 1]++;
            }
        }
    }
}