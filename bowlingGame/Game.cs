namespace bowlingGame{
    public class Game
    {
        private int _score = 0;
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;

        public void roll(int pins)
        {
            _score += pins; //FIXME calculates score, while name is roll
            _rolls[_currentRoll] += pins;
        }
        public int score()
        {
            return _score; //FIXME does not calculate score
        }
    }
}
