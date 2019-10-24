using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CourseWork
{
    public class Resident : INotifyPropertyChanged
    {
        private string FirstName;
        private string SecondName;
        private string PatronymicResident;
        private string InformationAboutResident;
        private int AgeResident;
        private int RoomNumber;
        private bool SexResident;

        public string Firstname
        {
            get { return FirstName; }
            set { FirstName = value;
                OnPropertyChanged("FirstName"); 
            }
        }
        public string Secondname
        {
            get { return SecondName; }
            set { SecondName = value; OnPropertyChanged("SecondName"); }

        }
        public string Patronymicresident
        {
            get { return PatronymicResident; }
            set { PatronymicResident = value; OnPropertyChanged("PatronymicResident"); }
        }
        public string Infomation
        {
            get { return InformationAboutResident; }
            set { InformationAboutResident= value; OnPropertyChanged("InformationAboutResident"); }
        }
         public int Ageresident
        {
            get { return AgeResident; }
            set { AgeResident = value; OnPropertyChanged("AgeResident"); }
        }
        public int Roomnumber
        {
            get { return RoomNumber; }
            set { RoomNumber = value; OnPropertyChanged("RoomNumber"); }
        }
        public bool Sexresident
        {
            get { return SexResident; }
            set { SexResident = value; OnPropertyChanged("SexResident"); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
