using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BloodBankProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewAvailableBloodType : Page
    {

        private LifeBloodBank bloodBankObj;

        int bloodTypeAPlusCounter = 0;
        int bloodTypeANegCounter = 0;
        int bloodTypeBPlusCounter = 0;
        int bloodTypeBNegCounter = 0;
        int bloodTypeABPlusCounter = 0;
        int bloodTypeABNegCounter = 0;
        int bloodTypeOPlusCounter = 0;
        int bloodTypeONegCounter = 0;


        public ViewAvailableBloodType()
        {
            this.InitializeComponent();
        }

        //Objective: Get the count of available blood types available for donation
        //find the available item from the mainpage list and check to see if its in 
        // this list(bloodTypeAvailableList) if yes add one to the counter, if not then dont do anything

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            LifeBloodBank bloodBankObj = e.Parameter as LifeBloodBank;
            
            
            foreach (string x in bloodBankObj.bloodTypeList)
            {
                if (x == "A+")
                {
                    bloodTypeAPlusCounter += 1;
                    aPlusCounter.Text = bloodTypeAPlusCounter.ToString();
                }

                else if (x == "A-")
                {
                    bloodTypeANegCounter += 1;
                    aNegCounter.Text = bloodTypeANegCounter.ToString();
                }

                else if (x == "B+")
                {
                    bloodTypeBPlusCounter += 1;
                    bPlusCounter.Text = bloodTypeBPlusCounter.ToString();
                }

                else if (x == "B-")
                {
                    bloodTypeBNegCounter += 1;
                    bNegCounter.Text = bloodTypeBNegCounter.ToString();
                }

                else if (x == "AB+")
                {
                    bloodTypeABPlusCounter += 1;
                    abPlusCounter.Text = bloodTypeABPlusCounter.ToString();
                }

                else if (x == "AB-")
                {
                    bloodTypeABNegCounter += 1;
                    abNegCounter.Text = bloodTypeABNegCounter.ToString();
                }

                else if (x == "O+")
                {
                    bloodTypeOPlusCounter += 1;
                    oPlusCounter.Text = bloodTypeOPlusCounter.ToString();
                }

                else if ( x == "O-")
                {
                    bloodTypeONegCounter += 1;
                    oNegCounter.Text = bloodTypeONegCounter.ToString();
                    
                }

            }
            

           

            

           
            }


        }


        
 }

