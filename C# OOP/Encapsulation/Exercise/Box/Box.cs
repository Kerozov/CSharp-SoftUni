using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClassBoxData
{
    class Box
    {
        public const  string Massage = ("{0} cannot be zero or negative.");
        private double length;
        private double width;
        private double height;

        public Box(double length,double width,double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get => length;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException(String.Format(Massage,nameof(this.Length)));
                }

                length = value;
            }
        }

        public double Width
        {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(Massage, nameof(this.Width)));
                }

                width = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(Massage, nameof(this.Height)));
                }

                height = value;
            }
        }

        public double CalculateLateralSurface()
        {
            return 2 * (length * height + width * height);
        }

        public double CalculateVolume()
        {
            return length * width * height;
        }

        public double CalculateSurface()
        {
            return 2 * length * width + CalculateLateralSurface();
        }
    }
}
