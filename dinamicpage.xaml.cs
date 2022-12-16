using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FORMCV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dinamicpage : ContentPage
    {
        private string mainContentProperty1;
        public string MainContentProperty1
        {
            get { return mainContentProperty1; }
            set { mainContentProperty1 = value;
                OnPropertyChanged(nameof(MainContentProperty1));
            }

        }
        public string MainContentProperty2
        {
            get { return mainContentProperty1; }
            set
            {
                mainContentProperty1 = value;
                OnPropertyChanged(nameof(MainContentProperty2));
            }

        }
        public string MainContentProperty3
        {
            get { return mainContentProperty1; }
            set
            {
                mainContentProperty1 = value;
                OnPropertyChanged(nameof(MainContentProperty3));
            }

        }
    
        public string MainContentProperty4
        {
            get { return mainContentProperty1; }
            set
            {
                mainContentProperty1 = value;
                OnPropertyChanged(nameof(MainContentProperty4));
            }

        }
        
        public string MainContentProperty5
        {
            get { return mainContentProperty1; }
            set
            {
                mainContentProperty1 = value;
                OnPropertyChanged(nameof(MainContentProperty5));
            }

        }
        
        public string MainContentProperty6
        {
            get { return mainContentProperty1; }
            set
            {
                mainContentProperty1 = value;
                OnPropertyChanged(nameof(MainContentProperty6));
            }

        }
        

        public dinamicpage(string mainContent1, string mainContent2, string mainContent3,string mainContent4, string mainContent5, string mainContent6 )
        {
            InitializeComponent();
            BindingContext = this;
            MainContentProperty1 = mainContent1;
            MainContentProperty2 = mainContent2;
            MainContentProperty3 = mainContent3;
            MainContentProperty4 = mainContent4;
            MainContentProperty5 = mainContent5;
            MainContentProperty6 = mainContent6;
            
        }
        
        
        
    }
}