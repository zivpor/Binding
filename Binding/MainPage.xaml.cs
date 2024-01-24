using Binding.Models;
namespace Binding

{
    public partial class MainPage : ContentPage
    {
        public Student s;

        public MainPage()
        {
            s=new Student() {Name="Shahar",Age=16 };
            this.BindingContext = s;
            InitializeComponent();
        }

        private void ChangeName(object sender, EventArgs e)
        {
            s.Name = "זיו";
            
        }
    }
}