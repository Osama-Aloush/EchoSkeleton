using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        private string NameHolder;
        private string CardNO;
        private string CVVNo;
        private string IDNO;
        private Boolean mActive;
        private string Amount;
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        public string DateTime {
            get
            {
                return DateTime;
            }
            set 
            {
                DateTime = value;
            } 
        }
        public string NameAdded
        {
            get
            {
                return NameHolder;
            }
            set
            {
                NameHolder = value;
            }
        }
        public string CardAdded
        {
            get
            {
                return CardAdded;
            }
            set
            {
                CardAdded = value;
            }
        }
        public string CVVAdded
        {
            get
            {
                return CVVAdded;
            }
            set
            {
                CVVAdded = value;
            }
        }
        public string IDAdded
        {
            get
            {
                return IDAdded;
            }
            set
            {
                IDAdded = value;
            }
        }
        public string AmountAdded
        {
            get
            {
                return AmountAdded;
            }
            set
            {
                AmountAdded = value;
            }
        }
        public bool Find(string NameAdded)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer information to search for
            DB.AddParameter("@NameAdded", NameAdded);
            //execute the stored procedure
            DB.Execute("sproc_tblName_FilterByNameAdded");
            if (DB.Count == 1)
            {
                NameAdded = "Osama AlOush";
                CardAdded = "1234";
                CVVAdded = "123";
                IDAdded = "123456789";
                AmountAdded = "100";

                //Always return true
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string nameAdded, string cardAdded, string cVVAdded, string iDAdded, string amountAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //if the NameAdded is blank
            if (NameAdded.Length == 0)
            {
                Error = Error + "The Name should not be blank : ";
            }

            if (NameAdded.Length > 6)
            {
                //record the error
                Error = Error + "The Name Added must be less than 6 characters : ";
            }

            if (CardAdded.Length == 0)
            {
                Error = Error + "The Name should not be blank : ";
            }

            if (CardAdded.Length > 4)
            {
                //record the error
                Error = Error + "The Name Added must be less than 4 characters : ";
            }

            if (CVVAdded.Length == 0)
            {
                Error = Error + "The Name should not be blank : ";
            }

            if (CVVAdded.Length > 3)
            {
                //record the error
                Error = Error + "The Name Added must be less than 3 characters : ";
            }

            if (IDAdded.Length == 0)
            {
                Error = Error + "The Name should not be blank : ";
            }

            if (IDAdded.Length > 9)
            {
                //record the error
                Error = Error + "The Name Added must be less than 9 characters : ";
            }

            return Error;
        }
    }

}