namespace SDA.Score
{
    public class TimeSystem
    {
        private int miliseconds = 0;
        private int currentTime = 0;

        public void UpdateTime()
        {
            miliseconds += 1;
            if(miliseconds == 60)
            {
                currentTime += 1;
                miliseconds = 0;
            }
        }

        public int GetTime()
        {
            return currentTime;
        }
    } 
}
