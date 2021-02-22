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
    public partial class AverageNumberOfPatients : Form
    {
        Polyclinic polyclinic = new Polyclinic();
        public AverageNumberOfPatients(Polyclinic polyclinic)
        {          
            InitializeComponent();
            this.polyclinic = polyclinic;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Предоставляет ссылку на объект, который вызвал событие</param>
        /// <param name="e">передает объект, относящийся к оюрабатываемому событию</param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">Предоставляет ссылку на объект, который вызвал событие</param>
        /// <param name="e">передает объект, относящийся к оюрабатываемому событию</param>
        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Text = "";
            label1.Text += "\nDentist: " + polyclinic.AverageNumberOfPatients((int)Doctors.Dentist) + "\n";
            label1.Text += "\nDermatologist: " + polyclinic.AverageNumberOfPatients((int)Doctors.Dermatologist) + "\n";
            label1.Text += "\nSurgeon: " + polyclinic.AverageNumberOfPatients((int)Doctors.Surgeon) + "\n";
            label1.Text += "\nNeurologist: " + polyclinic.AverageNumberOfPatients((int)Doctors.Neurologist) + "\n";
            label1.Text += "\nPsychiatrist: " + polyclinic.AverageNumberOfPatients((int)Doctors.Psychiatrist) + "\n";
            label1.Text += "\nOphthalmologist: " + polyclinic.AverageNumberOfPatients((int)Doctors.Ophthalmologist) + "\n";
        }
    }
}
