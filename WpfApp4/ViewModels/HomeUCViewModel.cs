using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using WpfApp4.Commands;
using WpfApp4.Models;
using WpfApp4.Views;
using WpfApp4.Views.UsersControls;

namespace WpfApp4.ViewModels
{
    public class HomeUCViewModel:BaseViewModel
    {
        public ObservableCollection<Book> Books { get; set; }
        public RelayCommand SelectedCommand { get; set; }
        public RelayCommand AddBookCommand { get; set; }

        public Grid MyGrid { get; internal set; }
        private Book book;

        public Book Book
        {
            get { return book; }
            set { book = value; OnPropertyChanged(); }
        }

        public HomeUCViewModel()
        {
            Books = new ObservableCollection<Book>
            {
                new Book
                {
                    ImagePath="/Images/image1.1.jpeg",
                    Name="Dusun ve Varlan",
                    Author="Napoleon Hill",
                    Page=369,
                    Genre="Sexsi Inkisaf",
                    Price="9,20 Azn",
                    Description=$@"Napoleon Hill DÜŞÜN VƏ VARLAN
Yəqin ki, dünyada ən əhəmiyyətli və nüfuzlu kitab uğura, zənginliyə,
maneələri aşa bilən həyat enerjisinə və məqsədyönlülüyə yönləndirən dərsliksayılır. 
“Düşün və varlan” kitabı 70 il ərzində zənginliyin yaradılması üzrə
klassik dərslik sayılır. Napoleon Hill hər fəsildə pulun əldə edilməsinin
sirlərini açır və bu sirlərdən istifadə edən minlərlə insan nəinki zənginlik
əldə edir, üstəlik dayanmadan onu artırır və eyni zamanda öz şəxsi
potensiallarını inkişaf etdirir, zənginləşdirir."
                },
                new Book
                {
                    ImagePath="/Images/image2.jpg",
                    Name="Rich Dad Poor Dad",
                    Author="Robert T. Kiyosaki",
                    Page=500,
                    Genre="Sexsi Inkisaf",
                    Price="10,20 Azn",
                    Description=$@"Zəngin ata Kasıb ata Robert Kiyosaki və onun iki atası - onun əsl atası 
(kasıb ata) və ən yaxşı dostunun (zəngin atası) atası - və 
hər iki şəxsin pul və investisiya haqqında düşüncələrini 
necə formalaşdırdığı haqqındadır.",
                },
                new Book
                {
                    ImagePath="/Images/image3.jpg",
                    Name="C# Programming",
                    Author="Fahrettin Erdinc",
                    Price="16 Azn",
                    Page=790,
                    Genre="Programming",
                    Description="C#"

                },
                new Book
                {
                    ImagePath="/Images/cinayet_ceza_book.jpg",
                    Name="Cinayet ve Ceza",
                    Author="Fyodor Dostoyevski",
                    Price="12,50 Azn",
                    Page=790,
                    Genre="Dedektiv",
                    Description=$@" Fyodor Mixayloviç Dostoyevskinin romanı.
O, birinci dəfə 1866 və 1867 illərində 12 ay ərzində aylıq Rus Xəbərçi
ədəbi jurnalında hissələrlə nəşr olunurdu.
Bu Dostoyevskinin Sibir sürgündən sonra yazdığı ikinci romandır. 
Cinayət və cəza onun yetkin dövrün birinci romanı sayılır.
                    "
                },
                new Book
                {
                    ImagePath="/Images/DanBrown_book.jpg",
                    Name="Baslangic",
                    Author="Dan Brown",
                    Price="11,20 Azn",
                    Page=490,
                    Genre="Dedektiv",
                    Description=$@" Harvardda simvol və dini ikonoqrafiya professoru olan Robert Lenqdon
“Elmin üzünü əbədi olaraq dəyişdirəcək” bir kəşfi öyrənmək üçün 
Bilbaodakı Quqqenhaym muzeyinə gəlir. 
Tədbirə ev sahibliyi edən dostu və köhnə tələbəsi olan Edmond Körş 
gözqamaşdıran ixtiraları və dəqiq proqnozları ilə dünyada mübahisələrə
səbəb olan bir insan kimi tanınır.
                    "
                },
                new Book
                {
                    ImagePath="/Images/TimotiFerris_book.jpg",
                    Name="4 saatliq is heftesi",
                    Author="Dan Brown",
                    Price="13,40 Azn",
                    Page=490,
                    Genre="Sexsi Inkisaf",
                    Description=$@"kitabda müəllif iddia edir ki, insanın qarşısına qoyduğu məqsəd onun bu məqsədə hansı 
yollarla çatmasından daha vacib məsələdir.
Odur ki, görülmüş işin kəmiyyəti deyil, keyfiyyəti haqqında düşünmək lazımdır. 
Bununla da, müəllif zamanın idarə olunmasının yeni modelini təqdim edir, 
az vaxtda daha böyük məqsədlərə çatmağın, daha ahəngdar həyat tərzi qurmağın 
mümkünlüyündən danışır. Bütün bunları həyatdan götürülmüş real nümunələrlə əsaslandırır.
                    "
                },

            };
            Book = new Book();
            foreach (var item in Books)
            {
                book = item;
            }

            SelectedCommand = new RelayCommand((p) =>
            {

                var uc1 = new BookInfoUC();
                var viewModel = new BookInfoUCViewModel();

                uc1.DataContext = viewModel;
                
                viewModel.MyGrid.Children.Add(uc1);


            });

            AddBookCommand = new RelayCommand((p) =>
            {
                Books.Add(new Book
                {
                    ImagePath="/Images/C_book.jpg",
                    Name="C++",
                    Price="32 Azn",
                });
            });

        
    }

        
    }
}
