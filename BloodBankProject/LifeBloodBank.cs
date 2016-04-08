using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankProject
{
    class LifeBloodBank

    {
        private List<Donor> _lifeBloodList;
        public List<string> bloodTypeList = new List<string>();



        public LifeBloodBank()
        {
            _lifeBloodList = new List<Donor>();
            

        }

        public void addDonors(Donor bloodDonor)
        {
            // Create new Donor Object
            _lifeBloodList.Add(bloodDonor);
           


        }

        /*
        public void showAvailableBloodType()
        {
            //Objective: Get the count of available blood types available for donation
            //find the available item from the mainpage list and check to see if its in 
            // this list(bloodTypeAvailableList) if yes add one to the counter, if not then dont do anything

            int bloodTypeAPosCounter = 0;
            int bloodTypeANegCounter = 0;
            int bloodTypeBPosCounter = 0;
            int bloodTypeBNegCounter = 0;


            foreach (string x in _lifeBloodList)
            {
                if (x == "A+")
                {
                    bloodTypeAPosCounter += 1;

                }

                else if (x == "A-")
                {
                    bloodTypeANegCounter += 1;

                }

                else if (x == "B+")
                {
                    bloodTypeBPosCounter += 1;

                }

                else if (x == "B-")
                {
                    bloodTypeBNegCounter += 1;
                }

                else
                {


                }


            }


        }
        */
        
    }

   
}
