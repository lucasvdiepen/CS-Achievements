using System;

namespace Les6Overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();

            Console.WriteLine(horse.IsFed());

            horse.Feed();

            Console.WriteLine(horse.IsFed());

            horse.Feed();

            Console.WriteLine(horse.IsFed());
        }
    }

    class Animal
    {
        protected bool isFed;

        public virtual void Feed()
        {
            isFed = true;
        }

        public bool IsFed()
        {
            return isFed;
        }
    }

    class Horse : Animal
    {
        private int feedAmount = 0;
        private const int needsFeedAmount = 10;

        public override void Feed()
        {
            feedAmount += 1;
            if(feedAmount >= needsFeedAmount)
            {
                base.Feed();
            }
        }
    }
}
