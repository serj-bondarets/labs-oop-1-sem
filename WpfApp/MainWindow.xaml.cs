using Figure;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The shapes
        /// </summary>
        public GeometricShapes[] shapes;
        private readonly string path = @"D:\repository\ООП\OOP_labs\OOP_labs\Lab8\text.txt";
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            InitShapes(path);
            InitializeList();
        }
        /// <summary>
        /// Initializes the shapes.
        /// </summary>
        /// <param name="path">The path.</param>
        public void InitShapes(string path)
        {
            int array_length = 0;
            string line;
            using (StreamReader stream = new StreamReader(path)) //Инициализация массивов
            {
                while ((line = stream.ReadLine()) != null)
                {
                    array_length += 1;
                }
                shapes = new GeometricShapes[array_length];
            }
            using (StreamReader stream = new StreamReader(path)) //Инициализация элементов массивов
            {
                int ind = 0;
                while ((line = stream.ReadLine()) != null)
                {
                    shapes[ind] = InitializationFigure(line);
                    ind += 1;
                }
            }
        }
        /// <summary>
        /// Initializations the figure.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public GeometricShapes InitializationFigure(string str)
        {
            string[] words = str.Split(new char[] { ' ' });
            GeometricShapes figure;
            switch (words[0])
            {
                case "окружность": figure = new Сircle(words[0], double.Parse(words[1]), double.Parse(words[2]), double.Parse(words[3]), words[4]); break;
                case "прямоугольник": figure = new Figure.Rectangle(words[0], double.Parse(words[1]), double.Parse(words[2]), words[3]); break;
                default: figure = null; break;
            };
            return figure;
        }
        /// <summary>
        /// Initializes the list.
        /// </summary>
        public void InitializeList()
        {
            ShapeList.Items.Clear();
            for (int i = 0; i < shapes.Length; i++)
            {
                switch (shapes[i].color)
                {
                    case "Red": ShapeList.Items.Add(new ListBoxItem { Content = shapes[i].ToString(), Background = Brushes.Red }); break;
                    case "Black": ShapeList.Items.Add(new ListBoxItem { Content = shapes[i].ToString(), Background = Brushes.Black }); break;
                    case "Green": ShapeList.Items.Add(new ListBoxItem { Content = shapes[i].ToString(), Background = Brushes.Green }); break;
                    case "White": ShapeList.Items.Add(new ListBoxItem { Content = shapes[i].ToString(), Background = Brushes.White }); break;
                    case "Yellow": ShapeList.Items.Add(new ListBoxItem { Content = shapes[i].ToString(), Background = Brushes.Yellow }); break;
                    case "Blue": ShapeList.Items.Add(new ListBoxItem { Content = shapes[i].ToString(), Background = Brushes.Blue }); break;
                    default:
                        ShapeList.Items.Add(shapes[i].ToString()); break;
                }
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InitShapes(shapes, out Polygon[] polygonIs);
            Array.Sort(polygonIs);
            ShapeList.Items.Clear();
            foreach(var polygon  in polygonIs)
                ShapeList.Items.Add(polygon.ToString()); 
        }

        private static void InitShapes(GeometricShapes[] polygons, out Polygon[] polygonIs)
        {
            int iPolygon = 0;
            foreach (var polygon in polygons)
                if (polygon is Polygon p) iPolygon++;
            polygonIs = new Polygon[iPolygon];
            iPolygon = 0;
            foreach (var polygon in polygons)
            {
                if (polygon is Polygon p)
                {
                    polygonIs[iPolygon] = (Polygon)polygon;
                    iPolygon++;
                }
            }
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            InitializeList();
        }

 

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShapeList.Items.Clear();
            string outputPath = path.Split('.')[0] + "-tmp.txt";
            using (StreamReader input = new StreamReader(path))
            using (StreamWriter output = new StreamWriter(outputPath))
            {
            }
            FileInfo fileToDelete = new FileInfo(path);
            fileToDelete.Delete();
            FileInfo fileToRename = new FileInfo(outputPath);
            fileToRename.MoveTo(path);
            InitShapes(path);
            InitializeList();
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            ClearInFile(path, ShapeList.SelectedIndex);
            InitShapes(path);
            InitializeList();
            ChangeInProgram();
        }
        private void ClearInFile(string inputPath, int ind)
        {
            string outputPath = inputPath.Split('.')[0] + "-tmp.txt";

            using (StreamReader input = new StreamReader(inputPath))
            using (StreamWriter output = new StreamWriter(outputPath))
            {
                string line;
                int i = 0;
                while ((line = input.ReadLine()) != null)
                {
                    if (i != ind)
                        output.WriteLine(line);
                    i += 1;
                }
            }
            FileInfo fileToDelete = new FileInfo(inputPath);
            fileToDelete.Delete();
            FileInfo fileToRename = new FileInfo(outputPath);
            fileToRename.MoveTo(inputPath);
        }
        private void ChangeInProgram()
        {
            try
            {
                ShapeList.Items.Remove(ShapeList.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Сircle[] circles;
            int iCircle = 0;
            foreach (var polygon in shapes)
                if (polygon is Сircle p) iCircle++;
            circles = new Сircle[iCircle];
            iCircle = 0;
            foreach (var polygon in shapes)
            {
                if (polygon is Сircle p)
                {
                    circles[iCircle] = (Сircle)polygon;
                    iCircle++;
                }
            }
            ShapeList.Items.Clear();
            int  findCirle=0;
            foreach(var cirle in circles)
            {
                if(cirle.color=="Green" && cirle.IsFirstQuarter)
                {
                    ShapeList.Items.Add(cirle.ToString() + $"Длина окружности{cirle.GetLenthCircles()}");
                    findCirle++;
                }
            }
            if(findCirle==0)
                ShapeList.Items.Add("нет окружностей удовлетворяющих условиям");


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            AddandEdit add = new AddandEdit(this);
                add.Show();
            
        }
    }
}