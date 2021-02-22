using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Polyclinic
    {
        /// <summary>
        /// 
        /// </summary>
        public class RecordToDoctor
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="doctor"></param>
            /// <param name="patients"></param>
            /// <param name="date"></param>
            public RecordToDoctor(Doctors doctor, int patients, DateTime date)
            {
                Doctors = doctor;
                Patients = patients;
                Date = date;
            }
            /// <summary>
            /// 
            /// </summary>
            public Doctors Doctors { get; }
            /// <summary>
            /// 
            /// </summary>
            public int Patients { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public DateTime Date { get;  }
       
        }
        /// <summary>
        /// 
        /// </summary>
        public Polyclinic()
        {
            CreateRecord();
        }
        /// <summary>
        /// 
        /// </summary>
        private List<RecordToDoctor> recordList = new List<RecordToDoctor>();
        /// <summary>
        /// 
        /// </summary>
        private void CreateRecord()
        {
            Random random = new Random();
            RecordToDoctor record;
            Doctors doctor = 0;
            int patient;
            int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (var i = 0; i < 12; i++)
            {
                for(var k = 0; k < days[i]; k++)
                {
                    foreach (int j in Enum.GetValues(typeof(Doctors)).Cast<Doctors>())
                    {
                        doctor = (Doctors)Enum.GetValues(typeof(Doctors)).GetValue(j);
                        patient = random.Next(0, 4);
                        record = new RecordToDoctor(doctor, patient, new DateTime(2020, i+1, k+1));
                        recordList.Add(record);
                    }
                }               
            }                
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="setDate"></param>
        /// <returns></returns>
        public List<RecordToDoctor> PatientsPerDay( DateTime setDate)
        {         
            List<RecordToDoctor> recordToDoctors = new List<RecordToDoctor>();
            foreach (var record in recordList)
            {
                if (record.Date == setDate.Date)
                {
                    recordToDoctors.Add(record);
                }
            }
            return recordToDoctors;
        }
        /// <summary>
        /// Находит врачей, к ктором есть запись на указанный день 
        /// </summary>
        /// <param name="setDate"></param>
        /// <returns></returns>
        public List<RecordToDoctor> RegistratedPatients(DateTime setDate)
        {
            List<RecordToDoctor> recordToDoctors = new List<RecordToDoctor>();
            foreach (var record in recordList)
            {
                if(record.Date == setDate.Date)
                {
                    if (record.Patients > 0)
                        recordToDoctors.Add(record);
                }                               
            }
            return recordToDoctors;
        }
        /// <summary>
        /// Находит среденее количество пациетов в день ю
        /// </summary>
        /// <param name="doctors"></param>
        /// <returns></returns>
        public double AverageNumberOfPatients(int doctors)
        {
            int counter = 0;
            double averageValue = 0;
            int[] days = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            foreach (var record in recordList)
            {
                for (var i = 0; i < 12; i++)
                {
                    for (var k = 0; k < days[i]; k++)
                    {
                        if (record.Doctors == (Doctors)Enum.GetValues(typeof(Doctors)).GetValue(doctors))
                        {
                            averageValue += record.Patients;
                            counter++;
                        }
                    }
                }
            }
            return averageValue / counter;
        }
    }    
}
