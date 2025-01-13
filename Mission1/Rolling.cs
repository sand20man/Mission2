namespace Mission1
{
    internal class Rolling
    {
        public static int[] RollNum { get; private set; } // Public property to access roll counts

        public static void Roll(int numberOfRolls)
        {
            RollNum = new int[12]; // 6 sides on a die
            SimulateRolls(numberOfRolls);
        }

        private static void SimulateRolls(int numberOfRolls)
        {
            var random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int diceRoll = random.Next(1, 13); // Generate a random number between 1 and 6
                RollNum[diceRoll - 1]++; // Increment the corresponding index (1 maps to index 0)
            }
        }
    }
}