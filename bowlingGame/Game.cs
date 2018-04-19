namespace bowlingGame{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;

        public void roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }
        public int score()
        {    
            int score = 0;
            for (int i = 0; i < _rolls.Length; i++)
            {
                score += _rolls[i]; //fixme need to handle two roll/one frame at one time to check for spare (rolls[i] + rolls[i+1] == 10)
            }
            return score;
        }
    }
}
