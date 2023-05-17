namespace Exercise006
{
    using System;
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        public bool Earlier(SimpleDate compared)
        {
            if (this.year < compared.year)
            {
                return true;
            }
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object compared)
        {
            // if the variables are located in the same position, they are equal
            if (this == compared)
            {
                return true;
            }

            // if the compared object is null or not of type Book, the objects are not equal
            if (compared == null || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                // convert the object to a Book object
                SimpleDate comparedDate = (SimpleDate)compared;
                return this.day == comparedDate.day
                                &&
               this.month == comparedDate.month
                               &&
               this.year == comparedDate.year;


            }
        }

        public override int GetHashCode()
        {

            return this.month + this.year + this.day.GetHashCode();
            //  Better way: 
            //return HashCode.Combine(this.day, this.month, this.year);
        }

    }
}
