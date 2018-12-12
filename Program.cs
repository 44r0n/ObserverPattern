using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer spanishOserver = new SpanishDateObserver();
            Observer englishObserver = new EnglishDateObserver();
            DateSubject date = new DateSubject();
            date.Day = 2;
            date.Month = 12;
            date.Year = 2018;
            date.Attach(spanishOserver);
            date.Attach(englishObserver);
            date.Notify();
            date.Month = 9;
            date.Day = 3;
        }
    }
}
