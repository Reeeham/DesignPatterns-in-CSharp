using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPatternDemo
{
    public class NameRepository : Container
    {
        public static string[] names = { "Robert", "John", "Julie", "Lora" };

        public Iterator getIterator()
        {
            return new NameIterator();
        }
        private class NameIterator : Iterator
        {
            int index;

            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
    
