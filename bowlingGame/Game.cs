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
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)  {
                if (isStrike(frameIndex)) {
                    score += 10 + strikeBonus(frameIndex);
                    frameIndex += 1;
                } else if (isSpare(frameIndex)) {
                    score += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                } else {
                    score += sumOfBallsInFrame(frameIndex);
                    frameIndex += 2;

                }
            }
            return score;
        }

        private int strikeBonus(int frameIndex)
        {
            return _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
        }
        private int spareBonus(int frameIndex)
        {
            return _rolls[frameIndex + 2];
        }

        private int sumOfBallsInFrame(int frameIndex)
        {
            return  _rolls[frameIndex] + _rolls[frameIndex+1];
        }
        private bool isSpare(int frameIndex) 
        {
            return _rolls[frameIndex] + _rolls[frameIndex+1] == 10;
        }
        private bool isStrike(int frameIndex) 
        {
            return _rolls[frameIndex] == 10;
        }
    }
}
