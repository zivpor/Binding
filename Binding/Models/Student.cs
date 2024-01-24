using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Binding.Models
{
    public class Student : INotifyPropertyChanged
    {
        private string name;
        private int age;
        public string Name { get => name; set{ name = value;OnPropertyChanged("Name"); } }
        public int Age { get=>age; set { age = value; OnPropertyChanged("Age"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
