using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FORMCV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void ButtonSubmitClicked(System.Object sender, System.EventArgs e)
        {
            
            var input_name = name.Text;
            var input_age = age.Text;
            var input_adress = adress.Text;
            var input_contact = contact.Text;
            var input_education = education.Text;
            var input_ocupation = ocupation.Text;
            

            Application.Current.MainPage.Navigation.PushModalAsync(new dinamicpage(input_name, input_age, input_adress,
                input_contact, input_education,input_ocupation), true);

            
        }
        void ButtonPlusOcupationClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your Occupation" };
            ocup2.Children.Add(entry);
            
        }
        void ButtonPlusEducationClicked(System.Object sender, System.EventArgs e)
        {
            var entry = new Entry() { Placeholder = "Enter your Occupation" };
            edu.Children.Add(entry);
            
        }
    }
}