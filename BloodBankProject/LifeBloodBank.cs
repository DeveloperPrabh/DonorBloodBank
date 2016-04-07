using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankProject
{
    class LifeBloodBank

    {
        public List<Donor> _lifeBloodList;
        //initalize a new list to store the names of blood type of donors.
        public List<string> _typeOfBloodGroupList = new List<string>();
        

        public LifeBloodBank()
        {
            List<Donor> _lifeBloodList = new List<Donor>();
            this._lifeBloodList = _lifeBloodList;

        }

        public void addDonors(Donor bloodDonor)
        {
            // Create new Donor Object
            this._lifeBloodList.Add(bloodDonor);
            this._typeOfBloodGroupList.Add(bloodDonor._bloodType);


        }

        public void showAvailableBloodType()
        {
            //Objective: Get the count of available blood types available for donation
            //find the available item from the mainpage list and check to see if its in 
            // this list(bloodTypeAvailableList) if yes add one to the counter, if not then dont do anything

            int bloodTypeAPosCounter = 0;
            int bloodTypeANegCounter = 0;
            int bloodTypeBPosCounter = 0;
            int bloodTypeBNegCounter = 0;


            foreach (string x in this._typeOfBloodGroupList)
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
        
    }

   
}
