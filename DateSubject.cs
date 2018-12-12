namespace ObserverPattern
{
    public class DateSubject : Subject
    {
        private int _year;
        public int Year
        {
            get => _year;
            set
            {
                _year = value;
                Notify();
            }
        }

        private int _month;
        public int Month
        {
            get => _month;
            set
            {
                if(!IsValidDate(_year, value,_day))
                {
                    throw new System.Exception("Invalid date");
                }
                _month = value;
                Notify();
            }
        }

        private int _day;
        public int Day
        {
            get => _day;
            set
            {
                if(!IsValidDate(_year, _month,value))
                {
                    throw new System.Exception("Invalid date");
                }
                _day = value;
                Notify();
            }
        }

        private bool IsValidDate(int year, int month, int day)
        {
            //TODO: add logic
            return true;
        }
    }
}