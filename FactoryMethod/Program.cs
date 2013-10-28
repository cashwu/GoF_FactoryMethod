using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class Hamburg
    {
        internal void prepare()
        {
            throw new NotImplementedException();
        }

        internal void cook()
        {
            throw new NotImplementedException();
        }

        internal void assembly()
        {
            throw new NotImplementedException();
        }

        internal void box()
        {
            throw new NotImplementedException();
        }
    }

    public class PorkHamburg : Hamburg
    {
    }

    public class BeefHamburg : Hamburg
    {
    }

    public class SweetPorkHamburg : Hamburg
    {
    }

    public class SweetBeefHamburg : Hamburg
    {
    }

    public abstract class HamburgStore
    {
        private Hamburg orderHamburg(string type)
        {
            Hamburg ham = null;
            ham = createHamburg(type);
            ham.prepare();
            ham.cook();
            ham.assembly();
            ham.box();
            return ham;
        }

        public abstract Hamburg createHamburg(string type);
    }

    public class TaipeiHamburgStore : HamburgStore
    {
        public override Hamburg createHamburg(string type)
        {
            Hamburg ham = null;
            switch (type)
            {
                case "pork":
                    ham = new PorkHamburg();
                    break;

                case "beef":
                    ham = new BeefHamburg();
                    break;

                default:
                    throw new Exception();
                    break;
            }

            return ham;
        }
    }

    public class TainanHamburgStore : HamburgStore
    {
        public override Hamburg createHamburg(string type)
        {
            Hamburg ham = null;
            switch (type)
            {
                case "pork":
                    ham = new SweetPorkHamburg();
                    break;

                case "beef":
                    ham = new SweetBeefHamburg();
                    break;

                default:
                    throw new Exception();
                    break;
            }

            return ham;
        }
    }
}