using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    //step four

    public class LAPaperIterator : IIterator
    {
        private string[] _reporters;
        private int _current;

        public LAPaperIterator(string[] _reporters)
        {
            this._reporters = _reporters;
            _current = 0;
        }
        //the four methods below implement in IIterator.
        //implementations aren't exactly the same as NY.
        //eg, IsDone is Length v Count.
        //in the real world, the method differences could be much greater.
        public string CurrentItem()
        {
            return _reporters[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _reporters.Length;
        }

        public string Next()
        {
            return _reporters[_current++];
        }
    }
}
