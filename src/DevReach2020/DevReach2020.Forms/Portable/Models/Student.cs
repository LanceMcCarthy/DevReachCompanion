using Prism.Mvvm;
using Xamarin.Forms;

namespace DevReach2020.Forms.Portable.Models
{
    public class Student : BindableBase
    {
        public string Name { get; set; }
        public Color BadgeColor { get; set; }
        public bool IsAbsent { get; set; }
    }
}