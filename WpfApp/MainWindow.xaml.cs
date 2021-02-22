using LibForLab2;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Matrix matrix1;  
        public Matrix matrix2;
        public const int MaxN = 10; // максимально допустимая размерность матрицы
        public MatrixAdd _Matrix1Add = null; // окно для инициализации матрицы
        public TextBox[,] MatrText = new TextBox[MaxN, MaxN];// матрица элементов типа TextBox
        Regex regex = new Regex(@"^[0-9]+$"); // регулярное выражение для ввода только цифр

        public int M1 { get; set; }// для первой матрицы кол-во колонок
        public int N1 { get; set; }//для первой матрицы кол-во строк
        public int N2 { get; set; }
        public int M2 { get; set; }
        public int NumberMatrix { get; set; } // переключение между матрицами для инициализацции

        //очистка матрицы
        private void Clear_MatrText(int n, int m)
        {
            try
            {
                if (n > 10 || m > 10)
                    throw new MatrixExeption(" N или M > 10");
                if (n < 1 || m < 1)
                    throw new MatrixExeption(" N или M < 1");
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        MatrText[i, j].Text = "0";
            }
            catch (MatrixExeption ex)
            {
                MessageBox.Show(ex.Message + $" {ex.GetType()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //добавление матрицы 1
        private void MatrixAddOne_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                InitMatrix();
                N1 = int.Parse(N1TextBox.Text);
                M1 = int.Parse(M1TextBox.Text);
                if (N1 < 1 || M1 < 1)
                    throw new MatrixExeption(" N или M < 1");
                Clear_MatrText(N1, M1);
                for (int i = 0; i < N1; i++)
                    for (int j = 0; j < M1; j++)
                            MatrText[i, j].Visibility = Visibility.Visible;
                NumberMatrix = 0; //ввод первой (левой) матрицы
                _Matrix1Add.Show(); // открытие окна
            }
            catch (MatrixExeption ex)
            {
                MessageBox.Show(ex.Message + $" {ex.GetType()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void InitMatrix()
        {
            try
            {
                _Matrix1Add = new MatrixAdd(this); // инициализация окна для ввода матрицы
                Grid grid = new Grid(); // создание сетки
                for (int i = 0; i < MaxN; i++)
                {
                    grid.RowDefinitions.Add(new RowDefinition()); // добавление строки 
                    grid.ColumnDefinitions.Add(new ColumnDefinition());//добавление колонки
                    for (int j = 0; j < MaxN; j++)
                    {
                        MatrText[i, j] = new TextBox();// создание текстбокса
                        MatrText[i, j].Text = "0";
                        MatrText[i, j].Visibility = Visibility.Hidden; // скрытие текстбокса 
                        Grid.SetRow(MatrText[i, j], i);// устанавливаем в какой строке находится текстбох
                        Grid.SetColumn(MatrText[i, j], j);//устанавливаем в какой колонке находится текстбох
                        grid.Children.Add(MatrText[i, j]);// делаем текст бокс дочерним элементом
                    }
                }
                _Matrix1Add.Content = grid;// новому окну добавляем нашу созданную сетку 
            }
            catch (MatrixExeption ex)
            {
                MessageBox.Show(ex.Message + $" {ex.GetType()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MatrixAddTwo_Click(object sender, RoutedEventArgs e) //тоже самое для второй матрицы
        {
            try
            {
                InitMatrix();
                
                N2 = int.Parse(N2TextBox.Text);
                M2 = int.Parse(M2TextBox.Text);
                if (N2 < 1 || M2 < 1)
                    throw new Exception(" N или M < 1");
                Clear_MatrText(N2, M2);
                for (int i = 0; i < N2; i++)
                    for (int j = 0; j < M2; j++)
                        {
                            MatrText[i, j].Visibility = Visibility.Visible;
                        }
                NumberMatrix = 1;
                _Matrix1Add.Show();
            }
            catch (MatrixExeption ex)
            {
                MessageBox.Show(ex.Message + $" {ex.GetType()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MultiNumber_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MultiNumberBox.Text=="") throw new MatrixExeption("Введите число");
                matrix1 *= double.Parse(MultiNumberBox.Text);
                ResultLabel.Content = matrix1.ToString();
            }
            catch (MatrixExeption ex)
            {
                MessageBox.Show(ex.Message + $" {ex.GetType()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MatrixMulti_Click(object sender, RoutedEventArgs e) //умножение матриц
        {
            try
            {
                matrix1 *= matrix2;
                ResultLabel.Content = matrix1.ToString();
            }
            catch (MatrixExeption ex)
            {
                MessageBox.Show(ex.Message + $" {ex.GetType()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void N1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        
            if (!regex.IsMatch(N1TextBox.Text)) N1TextBox.Text = ""; //  валидация чтобы были только цифры

        }

        private void M1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!regex.IsMatch(M1TextBox.Text)) M1TextBox.Text = "";//  валидация чтобы были только цифры

        }

        private void N2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!regex.IsMatch(N2TextBox.Text)) N2TextBox.Text = "";//  валидация чтобы были толькоцифры

        }

        private void M2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!regex.IsMatch(M2TextBox.Text)) M2TextBox.Text = "";//  валидация чтобы были толькоцифры

        }

        private void MultiNumberBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (!regex.IsMatch(MultiNumberBox.Text)) MultiNumberBox.Text = "";//  валидация чтобы были толькоцифры

        }

        private void Button_Click(object sender, RoutedEventArgs e) //  очистка матриц
        {
            matrix1 = new Matrix(int.Parse(N1TextBox.Text),int.Parse( M1TextBox.Text));
            ResultLabel.Content = matrix1.ToString();
            matrix2 = new Matrix(int.Parse(N2TextBox.Text), int.Parse(M2TextBox.Text));
            Matrix2label.Content = matrix2.ToString();
        }
    }
}