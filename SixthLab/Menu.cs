using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorLibrary;

namespace SixthLab
{
    public partial class Menu : Form
    {
        private Polyclinic polyclinic = new Polyclinic();
        public Menu(Polyclinic polyclinic)
        {
            InitializeComponent();
            this.polyclinic = polyclinic;
        }
        /// <summary>
        /// Кнопка вызова первого задания
        /// </summary>
        /// <param name="sender">Предоставляет ссылку на объект, который вызвал событие</param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ShowInfo showinfo = new ShowInfo(polyclinic);
            showinfo.Show();
        }
        /// <summary>
        /// Кнопка вызова алгоритма второго задания
        /// </summary>
        /// <param name="sender">Предоставляет ссылку на объект, который вызвал событие</param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            RegisteredPatients registeredPatients = new RegisteredPatients(polyclinic);
            registeredPatients.Show();
        }
        /// <summary>
        /// Кнопка вызова третьего задания
        /// </summary>
        /// <param name="sender">Предоставляет ссылку на объект, который вызвал событие </param>
        /// <param name="e"> передает объект, относящийся к оюрабатываемому событию </param>
        private void button3_Click(object sender, EventArgs e)
        {
            AverageNumberOfPatients averageNumber = new AverageNumberOfPatients(polyclinic);
            averageNumber.Show();
        }
        /// <summary>
        /// Кнопка выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
