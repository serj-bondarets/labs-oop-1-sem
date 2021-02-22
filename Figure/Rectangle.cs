using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    /// <summary>
    /// класс прямоугольника
    /// </summary>
    /// <seealso cref="Figure.Polygon" />
    public class Rectangle:Polygon
    {
        /// <summary>
        /// The type shape
        /// </summary>
        public new string typeShape = "прямоугольник";
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="typeShape">The type shape.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="color">The color.</param>
        /// <exception cref="Exception">Недопустимые стороны прямоугольник.</exception>
        public Rectangle(string typeShape, double width, double height,string color): base(typeShape, new double[] { width, height },color)
        {
            if (width <= 0 || height <= 0)
                throw new Exception("Недопустимые стороны прямоугольник.");
        }
        /// <summary>
        /// Gets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public double Width
        {
            get => _sides[0];
        }
        /// <summary>
        /// Gets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public double Height
        {
            get => _sides[1];
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
        /// метод получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return  Math.Round( Width * Height,2);
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
        /// <summary>
        /// метод получения информации об фигуре
        /// </summary>
        /// <returns></returns>
        public override string GetInformationAboutShape()
        {
            return $"{typeShape} {Width} {Height} {GetArea()} {color}";
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() { return $"{typeShape} {Width} {Height} {GetArea()} {color}"; }

    }
}
