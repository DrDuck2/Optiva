using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ1
{
    public class PcImage
    {
        private int Width;
        private int Height;
        private int byteNumber;

        public int width
        {
            get { return this.Width; }
            set { this.Width = value; }
        }
        public int height
        {
            get { return this.Height; }
            set { this.Height = value; }
        }
        public int bytenumber
        {
            get { return this.byteNumber; }
            set { this.byteNumber = value; }
        }

        public PcImage()
        {
            this.Width = 0;
            this.Height = 0;
            this.byteNumber = 0;
        }
        public PcImage(int Width, int Height, int byteNumber)
        {
            this.Width = Width;
            this.Height = Height;
            this.byteNumber = byteNumber;
        }

        public void Skaliranje(double sc)
        {
            if(sc >= 0.1)
            {
                this.Width = Convert.ToInt32(this.Width * sc);
                this.Height = Convert.ToInt32(this.Height * sc);
            }
        }

        public double Space()
        {
            return this.Width * this.Height * this.byteNumber / 8 / 1024; 
        }

        public double SpaceCompresion(double p)
        {
            if(p < 10 || p > 90)
            {
                return Space();
            }
            return Space() * p / 100;
        }
    }
}
