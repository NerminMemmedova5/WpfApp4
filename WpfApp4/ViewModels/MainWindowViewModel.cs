using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp4.ViewModels
{
    public class MainWindowViewModel:BaseViewModel
    {
       
        public MainWindowViewModel()
        {

        }

        public Grid MyGrid { get; internal set; }
    }
}
