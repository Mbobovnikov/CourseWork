using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CourseWork
{
    public class Resident //: INotifyPropertyChanged
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
            }
        }
        public string Secondname
        {
            get { return SecondName; }
            set { SecondName = value; }
        }
        public string Patronymicresident
        {
            get { return PatronymicResident; }
            set { PatronymicResident = value; }
        }
        public string Infomation
        {
            get { return InformationAboutResident; }
            set { InformationAboutResident= value; }
        }
         public int Ageresident
        {
            get { return AgeResident; }
            set { AgeResident = value; }
        }

    }
}
