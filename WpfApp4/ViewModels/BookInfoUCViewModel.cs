using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp4.Commands;
using WpfApp4.Views.UsersControls;

namespace WpfApp4.ViewModels
{
    public class BookInfoUCViewModel:BaseViewModel
    {
        public Grid  MyGrid { get; internal set; }
        public RelayCommand  ReadCommand { get; set; }


        public BookInfoUCViewModel()
        {
            ReadCommand = new RelayCommand((p) =>
            {
                
                var viewModel = new DescriptionViewModel();
                var view = new DescriptionUC();
                view.DataContext= viewModel;
                MyGrid.Children.Add(view);

            });
        }
    }
}
