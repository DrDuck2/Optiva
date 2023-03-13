using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class BoxIterator : IAbstractBoxIterator
    {
        private Box box;
        private int currentPosition;

        public BoxIterator(Box box)
        {
            this.box = box;
            this.currentPosition = 0;
        }

        public Product First()
        {
            return this.box[0];
        }
        public Product Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.box[this.currentPosition];
            }
        }
        public bool IsDone 
        {
            get { return this.currentPosition >= this.box.Count; }
        }
        public Product Current
        { 
            get { return this.box[this.currentPosition]; }
        }
    }
}
