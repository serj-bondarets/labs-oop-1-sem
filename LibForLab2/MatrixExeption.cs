using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibForLab2
{
    /// <summary>
    /// Класс ошибок (полностью наследуется от exeption)
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MatrixExeption : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixExeption"/> class.
        /// </summary>
        public MatrixExeption()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixExeption"/> class.
        /// </summary>
        /// <param name="message">Сообщение, описывающее ошибку.</param>
        public MatrixExeption(string message) : base(message)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixExeption"/> class.
        /// </summary>
        /// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
        /// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
        public MatrixExeption(string message, Exception innerException) : base(message, innerException)
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixExeption"/> class.
        /// </summary>
        /// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта о созданном исключении.</param>
        /// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
        protected MatrixExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
