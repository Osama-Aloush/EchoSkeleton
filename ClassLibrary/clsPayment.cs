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
            NameAdded = "Osama AlOush";
            CardAdded = "1234";
            CVVAdded = "123";
            IDAdded = "123456789";
            AmountAdded = "100";

            //Always return true
            return true;
        }

       
    }

}