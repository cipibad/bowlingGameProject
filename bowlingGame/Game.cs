namespace bowlingGame{
    public class Game
    {
        private int _score = 0;
        public void roll(int pins)
        {
            _score += pins; //FIXME calculates score, while name is roll
        }
        public int score()
        {
            return _score; //FIXME does not calculate score
        }
    }
}
