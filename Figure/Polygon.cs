using System;
using System.Text;

namespace Figure
{
    /// <summary>
    /// класс многоугольника
    /// </summary>
    /// <seealso cref="Figure.GeometricShapes" />
    /// <seealso cref="System.IComparable" />
    public abstract class Polygon : GeometricShapes, IComparable
    {   /// <summary>
        /// 
        /// </summary>
        public new string typeShape = "многоугольник";
        /// <summary>
        /// The sides
        /// </summary>
        protected double[] _sides;
        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon"/> class.
        /// </summary>
        /// <param name="typeShape">The type shape.</param>
        /// <param name="sides">The sides.</param>
        /// <param name="color">The color.</param>
        public Polygon(string typeShape, double[] sides, string color) : base(typeShape, color)
        {
            _sides = sides;
        }
        /// <summary>
        /// метод получения площади фигуры
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// метод получения информации об фигуре
        /// </summary>
        /// <returns></returns>
        public override string GetInformationAboutShape()
        {
            StringBuilder sides = new StringBuilder();
            foreach (var side in _sides)  sides.Append(side + " ");
            return $"{typeShape} {sides} {color} ";
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sides = new StringBuilder();
            foreach (var side in _sides) sides.Append(side + " ");
            return $"{typeShape} {sides} {color} ";
        }
        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns></returns>
        /// <exception cref="Exception">Невозможно сравнить два объекта</exception>
        public int CompareTo(object other) 
        {
            if (other is Polygon p)
                return this.GetArea().CompareTo(p.GetArea());
            else throw new Exception("Невозможно сравнить два объекта");

        }


        

    }
}