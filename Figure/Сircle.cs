using System;

namespace Figure
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Figure.GeometricShapes" />
    public class Сircle : GeometricShapes
    {
        /// <summary>
        /// The type shape
        /// </summary>
        public new string typeShape = "окружность";
        private readonly double _x;
        private readonly double _y;
        private readonly double _radius;
        /// <summary>
        /// Initializes a new instance of the <see cref="Сircle"/> class.
        /// </summary>
        /// <param name="typeShape">The type shape.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="color">The color.</param>
        public Сircle(string typeShape, double x, double y, double radius, string color) : base(typeShape, color)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }
        /// <summary>
        /// Gets a value indicating whether this instance is first quarter.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is first quarter; otherwise, <c>false</c>.
        /// </value>
        public bool IsFirstQuarter { 
            get 
            {
                if (_x > 0 && _y > 0 && _x - _radius >= 0 && _y - _radius >= 0)
                    return true;
                else return false;
            } 
        }
        /// <summary>
        /// метод получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.Round(Math.PI * _radius * _radius,2);
        }
        /// <summary>
        /// Gets the lenth circles.
        /// </summary>
        /// <returns></returns>
        public double GetLenthCircles()
        {
            return Math.Round(2 * Math.PI * _radius, 2);
        }
        /// <summary>
        /// метод получения информации об фигуре
        /// </summary>
        /// <returns></returns>
        public override string GetInformationAboutShape()
        {
            return $"{typeShape} {_x} {_y} {_radius} {color} {GetArea()} {GetLenthCircles()}";
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{typeShape} {_x} {_y} {_radius} {color} {GetArea()} {GetLenthCircles()}";
        }
        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}