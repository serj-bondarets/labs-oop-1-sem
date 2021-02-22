using System;
using System.Windows;
using System.Windows.Controls;
using LibForLab2;
namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MatrixAdd.xaml
    /// </summary>
    public partial class MatrixAdd : Window
    {
        private MainWindow main;

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix1Add"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public MatrixAdd(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
      
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (main.NumberMatrix == 0) // инициализация 1 матрицы
                {
                    main.matrix1 = new Matrix(main.N1, main.M1);
                    for (int i = 0; i < main.N1; i++)
                        for (int j = 0; j < main.M1; j++)
                            if (main.MatrText[i, j].Text != "")
                            { 
                                main.matrix1.Mat[i, j] = Double.Parse(main.MatrText[i, j].Text);
                            }
                            else main.matrix1.Mat[i, j] = 0;
                    main.ResultLabel.Content = main.matrix1.ToString(); //вывод результата
                }
                else if (main.NumberMatrix == 1)  // инициализация 2 матрицы
                {
                    main.matrix2 = new Matrix(main.N2, main.M2);
                    for (int i = 0; i < main.N2; i++)
                        for (int j = 0; j < main.M2; j++)
                            if (main.MatrText[i, j].Text != "")
                            { 
                                main.matrix2.Mat[i, j] = Double.Parse(main.MatrText[i, j].Text);
                            }
                            else main.matrix2.Mat[i, j] = 0;
                    main.Matrix2label.Content = main.matrix2.ToString();//вывод результата
                }
            }
            catch(MatrixExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}