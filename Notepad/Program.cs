namespace Notepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            ISpellChecker someChecker = factory.GetSomeSpellCheck("en");
            Notepad notepad = new Notepad(someChecker);

        }
    }

    public class Notepad
    {
        private ISpellChecker _checker;

        private Notepad(ISpellChecker checker)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            if (checker == null)
            {
                _checker = factory.GetSomeSpellCheck("en");
            }
            else
            {
                _checker = checker;
            }
        }
        public void Cut()
        {
            Console.WriteLine("Text Cut Functionality done");
        }
        public void Copy()
        {
            Console.WriteLine("Text Copy Functionality done");
        }
        public void Paste()
        {
            Console.WriteLine("Text Paste Functionality done");
        }
        public void SpellCheck()
        {
            _checker.DoSpellCheck();
        }
    }

    public interface ISpellChecker
    {
        void DoSpellCheck();
    }

    public class SpellCheckerFactory
    {
        ISpellChecker _someChecker = null;
        public ISpellChecker GetSomeSpellCheck(string lang)
        {
            switch (lang)
            {
                case "en":
                   _someChecker = new EnglishSpellChecker();
                    break;
                case "gr":
                   _someChecker = new GermanSpellChecker();
                    break;
                case "sp":
                   _someChecker = new SpanishSpellChecker();
                    break;
                default:
                    _someChecker = new EnglishSpellChecker();
                    break;

            }
            return _someChecker;
        }
    }

    public class EnglishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check done for English text");
        }
    }
    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check done for German text");
        }
    }
    public class SpanishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check done for Spanish text");
        }
    }
   
}
