using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class Subject
    {
        private List<Observer> observers;

        public void Attach(Observer observer) => observers.Add(observer);

        public void Detach(Observer observer) => observers.Remove(observer);

        public Subject()
        {
            observers = new List<Observer>();
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}