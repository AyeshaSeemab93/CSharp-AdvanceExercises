namespace Exercise005
{
    using System;
    public class Card : IComparable<Card>
    {
        public int value { get; }
        public Suit suit { get; }

        public Card(int value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }


        public override string ToString()
        {
            //if value is equal to the value of J,K,Q A then return the name for those values else return the given value
            if (this.value == 11)
            {
                return $"{this.suit} J";
            }
            else if (this.value == 12)
            {
                return $"{this.suit} Q";
            }
            else if (this.value == 13)
            {
                return $"{this.suit} K";
            }
            else if (this.value == 14)
            {
                return $"{this.suit} A";
            }
            else
            {
                return $"{this.suit} {this.value}";
            }

        }

        public int CompareTo(Card another)
        {
            if (this.value == another.value)
            {
                return this.suit.CompareTo(another.suit);
            }
            else
            {
                return this.value - another.value;
            }
        }


        public override bool Equals(object compared)
        {
            // if the variables are located in the same position, they are equal
            if (this == compared)
            {
                return true;
            }

            // if the compared object is null or not of type Card, the objects are not equal
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                // convert the object to a Card object
                Card comparedCard = (Card)compared;

                // if the values of the object variables are equal, the objects are, too
                return this.value == comparedCard.value && this.suit == comparedCard.suit;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.value, this.suit.GetHashCode());
        }

    }
}