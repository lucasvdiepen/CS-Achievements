using System;

namespace Les6Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Quest quest = new Quest("Quest 0");
            quest.LogIntro();
            quest.LogOutro();

            Quest1 quest1 = new Quest1("Quest 1");
            quest1.LogIntro();
            quest1.LogOutro();

            Quest2 quest2 = new Quest2("Quest 2");
            quest2.LogIntro();
            quest2.LogOutro();

            Quest3 quest3 = new Quest3("Quest 3");
            quest3.LogIntro();
            quest3.LogOutro();
        }

        public class Quest
        {
            public string Title
            {
                get; private set;
            }

            public Quest(string title)
            {
                Title = title;
            }

            public virtual void LogIntro()
            {
                Console.WriteLine("Welcome to quest " + Title + "..");
            }

            public virtual void LogOutro()
            {
                Console.WriteLine("And they lived happily ever after..");
            }
        }

        public class Quest1 : Quest
        {
            public Quest1(string title) : base(title)
            {

            }

            public override void LogIntro()
            {
                base.LogIntro();

                Console.WriteLine("This is the start of quest 1");
            }

            public override void LogOutro()
            {
                Console.WriteLine("This is the end of quest 1");
            }
        }

        public class Quest2 : Quest
        {
            public Quest2(string title) : base(title)
            {

            }

            public override void LogIntro()
            {
                base.LogIntro();

                Console.WriteLine("This is the start of quest 2");
            }

            public override void LogOutro()
            {
                Console.WriteLine("This is the end of quest 2");
            }
        }

        public class Quest3 : Quest
        {
            public Quest3(string title) : base(title)
            {

            }

            public override void LogIntro()
            {
                base.LogIntro();

                Console.WriteLine("This is the start of quest 3");
            }

            public override void LogOutro()
            {
                Console.WriteLine("This is the end of quest 3");
            }
        }
    }
}
