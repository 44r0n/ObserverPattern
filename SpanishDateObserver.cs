namespace ObserverPattern
{
    public class SpanishDateObserver : Observer
    {
        private DateSubject dateSubject;
        public void Update(Subject subject)
        {
            dateSubject = (DateSubject)subject;
            System.Console.WriteLine("La fecha es: "+dateSubject.Day+"/"+dateSubject.Month+"/"+dateSubject.Year);
        }
    }
}