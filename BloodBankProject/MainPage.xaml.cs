﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BloodBankProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        LifeBloodBank bloodBank = new LifeBloodBank();
        List<string> bTypeList = new List<string>();

        //Initialize a counter to count the number of donors
        public int donorCounter = 0;


        public MainPage()
        {
            this.InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Required;


        }

 
        
        

        private void onRegButtonClicked(object sender, RoutedEventArgs e)
        {
            //When Register Button is clicked, make the donor object and store its Values

            Donor bloodDonor = new Donor();
            
            
            bloodDonor._name = donorNameBox.Text;
            int checkAge = Int32.Parse(donorAgeBox.Text);
            string checkBlood = donorBloodType.Text;
            string checkGender = donorGenderBox.Text;



            // Verify age: donors over age 18 are able to donate also verify blood type
            if (bloodDonor.verifyAge(checkAge) && bloodDonor.verifyBloodType(checkBlood) && bloodDonor.verifyGender(checkGender))

            {
                bloodDonor._age = Int32.Parse(donorAgeBox.Text);
                bloodDonor._bloodType = donorBloodType.Text;
                bloodDonor._gender = donorGenderBox.Text;
                donorCounter += 1;
                incrementDonorCountBlock.Text = donorCounter.ToString();
                bloodBank.addDonors(bloodDonor);
                bloodBank.bloodTypeList.Add(bloodDonor._bloodType);
                MessageDialog donorAddedDlg = new MessageDialog(String.Format("Donor {0} was added. Thank you for donating blood!", bloodDonor._name));
                donorAddedDlg.ShowAsync();
                bloodListBox.Items.Add(bloodDonor._name);
                


            }

            bTypeList = bloodBank.bloodTypeList;


            
        }

        //Reset Button: Clear all values when user clicks the reset button.
        private void OnResetButtonClicked(object sender, RoutedEventArgs e)
        {
            donorNameBox.Text = "";
            donorAgeBox.Text = "";
            donorBloodType.Text = "";
            donorGenderBox.Text = "";
            

        }
        

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NavigationCacheMode = NavigationCacheMode.Enabled;
            if (Frame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

            }

            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        private void OnGoToViewBloodTypes(object sender, RoutedEventArgs e)
        {
            //Iintialize LifeBloodBank object
            LifeBloodBank bBank = new LifeBloodBank()
            {
                bloodTypeList = bTypeList
            };
            
            
            this.Frame.Navigate(typeof(ViewAvailableBloodType),bBank);
        }
    }
}
