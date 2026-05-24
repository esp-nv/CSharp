using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.ClassBoxData
{
    public class Box
    {
        //{0} -- placeholder който ще е различно всеки път когато ще се извика
        private const string INVALID_SIDE_MESSAGE = "{0} cannot be zero or negative.";
        private const double SIDE_MIN_VALUE = 0;

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                ValidateSide(value, nameof(this.Length));

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                ValidateSide(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                ValidateSide(value, nameof(this.Height));

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = (2 * this.Length * this.Width)
                + (2 * this.Length * this.Height)
                + (2 * this.Width * this.Height);

            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * this.Length * this.Height)
                + (2 * this.Width * this.Height);

            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }


        private void ValidateSide(double value, string sideName)
        {
            if (value <= SIDE_MIN_VALUE)
            {
                throw new ArgumentException(String.Format(INVALID_SIDE_MESSAGE, sideName));
            }
        }
    }
}
