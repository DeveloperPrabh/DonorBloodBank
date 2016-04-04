using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace BloodBankProject
{
    class Donor
    {
        public string _name;
        public int _age;
        public string _bloodType;
        public string _gender;


        public bool verifyAge(int donorAge)
        {
            if (donorAge < 18)
            {
                MessageDialog ageDlg = new MessageDialog("You have to be 18 or older to donate blood. Sorry!");
                ageDlg.ShowAsync();
                return false;
            }

            else
            {
                return true;
            }

            
        }

        public bool verifyBloodType(string donorBloodType)
        {
            List<String> typesOfBlood = new List<string>();
            typesOfBlood.Add("A+");
            typesOfBlood.Add("A-");
            typesOfBlood.Add("B+");
            typesOfBlood.Add("B-");
            typesOfBlood.Add("AB+");
            typesOfBlood.Add("AB-");
            typesOfBlood.Add("O+");
            typesOfBlood.Add("O+");

            if (typesOfBlood.Contains(donorBloodType))
            {
                return true;

            }

            else
            {
                MessageDialog bTypeDlg = new MessageDialog("Invalid Blood Type. Please Try Again!");
                bTypeDlg.ShowAsync();
                return false;
            }


        }
    }

    

}

