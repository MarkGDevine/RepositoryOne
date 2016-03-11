using System;
namespace HelloWorldApplication
{
    class StockHandler
    {
        
        class Stock
        {
            public Stock(string InSymbol, decimal InLast, decimal inParVal)
            {
                Symbol = InSymbol;
                LastDividend = InLast;
                ParValue = inParVal;

            }

            public Stock()
            {
                // TODO: Complete member initialization
                Symbol = "???";
                LastDividend = 0;
                ParValue = 0;

            }
            public string _symbol;
            public decimal _lastDividend;
            public decimal _parValue;

            public string Symbol 
            { 
                get {return _symbol;}
                set {_symbol = value;} 
            }

            public decimal LastDividend
            {
                get { return _lastDividend; }
                set{_lastDividend = value;}
            }
            public decimal ParValue
            {
                get { return _parValue; }
                set { _parValue = value; }
            }
            public void Display(decimal InPrice)
            {
                Console.WriteLine("Symbol {0}     Last Dividend {1}    ParValue {2}", Symbol, LastDividend, ParValue);
                Console.WriteLine("   DividendYield {0}   P/E Ratio {1}", DividendYield(InPrice).ToString(), PERatio(InPrice).ToString());
            }
            public decimal DividendYield(decimal iPrice)
            {
                return (LastDividend / iPrice);
            }
            public string PERatio(decimal iPrice) 
            {
                //const decimal Zero = 0m;
                string Answer = "Unknown Error";

                if (LastDividend == 0m)
                    Answer = "Error : Last Dividend is zero";
                else
                    Answer = (iPrice / LastDividend).ToString();

                return (Answer);
            }
        }

        static void Main(string[] args)
        {
            /* my first program in C# */
            //Console.WriteLine("Hello World");
            Stock MyStock = new Stock { Symbol = "TEA", LastDividend = 9000, ParValue = 100 };

            MyStock.Display(10m);
            Console.ReadKey();

            Stock MyOtherStock = new Stock();
            MyOtherStock.Display(1m);
            Console.WriteLine(MyStock.Symbol);
            Console.ReadKey();

        }
    }
}
