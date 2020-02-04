using System;

namespace PluralSite
{
    class Program
    {
        static void Main(string[] args)
        {

            BasicClass message = new BasicClass();

            message.FirstMessage("Alex");

            message.SecondMessage("Hlukhov");


            BasicClass setgetvalues = new BasicClass();

            setgetvalues.SetValue(31);
            setgetvalues.PrintValue();
            setgetvalues.ExampleArray();
            setgetvalues.ExampleList();

        }
    }
}
