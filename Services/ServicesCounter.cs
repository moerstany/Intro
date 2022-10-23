namespace Intro.Services
{
    public class ServicesCounter : iServiceCounter
    {
        public int Counter { get; set; }= 0;
        public int GetCounter()
        {
            Counter++;
            return Counter;
        }
    }
}
