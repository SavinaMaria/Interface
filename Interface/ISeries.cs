namespace Interface
{
    public interface ISeries
    {
        //Объявление новых методов
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
