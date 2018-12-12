namespace ObserverPattern
{
    public class EnglishDateObserver : Observer
    {
        private DateSubject date;
        public void Update(Subject subject)
        {
            date = (DateSubject)subject;
            System.Console.WriteLine("The date is: "+date.Month+"/"+date.Day+"/"+date.Year);
        }
    }
}