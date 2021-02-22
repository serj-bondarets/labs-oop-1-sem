namespace Figure
{
    /// <summary>
    /// класс геометрической фигуры
    /// </summary>
    public abstract class GeometricShapes
    {
        /// <summary>
        ///  поле тип фигуры
        /// </summary>
        public string typeShape;
        /// <summary>
        ///  поле цвет фигуры
        /// </summary>
        public string color;
        /// <summary>
        ///  конструктор объекта класс геометрической фигуры
        /// </summary>
        /// <param name="typeShape"></param>
        /// <param name="color"></param>
        protected GeometricShapes(string typeShape,string color)
        {
            this.typeShape = typeShape;
            this.color = color;
        }
        /// <summary>
        /// метод получения информации об фигуре
        /// </summary>
        /// <returns></returns>
        public abstract string GetInformationAboutShape();
        /// <summary>
        /// метод получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();
        /// <summary>
        ///  метод получения хэш-кода
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        ///  метод сравнения фигур
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

    }
}