﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace dotNet5781_03b_4334_4835
{
    public class Bus
    {   
        private string licensePlate;
        private DateTime start_Date;
        public DateTime checkupDate;
        private const int fullTank = 1200;//max
        public int sumKm{get;set;}//the total KM traveled
        public int gas { get; set; }//avilable gas
        
        private string status;//bus status
        public List<string> State = new List<string>()//list of possible states
        { "Ready","In the middle","In checkup","In refuel" };
       
        public string Status
        {
            get
            {
                
                    return status;
                
                
            }
            set
            {
                bool x = false;
                foreach (string s in State)//making sure the state exists in list
                { if (value == s)
                    {
                        x = true; 
                    }

                } 
                if(x)//if state exists in list
                { status = value; 
                }
                else//does not exist
                {
                    try
                    {
                        throw new ArgumentException("Not one of the possible states");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }

            }
        }
        //get and set Start_Date
        public DateTime Start_Date { 
            get { return start_Date; }
            set { start_Date = value; }
        }
    
        //get and set licensePlate
        public string License_Plate
        {
            get
            {
                
                    return licensePlate;
                
            }
            set
            {
                //checking if license plate is valid.
               

                    if ((start_Date.Year < 2018 && value.Length == 7) || (start_Date.Year >= 2018 && value.Length == 8))
                    {
                        licensePlate = value;
                        


                    }
                

                else
                {
                    try
                    {
                        throw new ArgumentException("License plate not valid");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                }
            }
        }

      

      //constructor
        public Bus(ObservableCollection<Bus> busses,String license,DateTime start,int fuel, int sum)
        {
            foreach (Bus bus in busses)//checks if license already exists and if it does throws an ecexption
            {
                if (license == License_Plate)
                {
                    throw new ArgumentException("Invalid license plate");
                }
                
               
            }

            gas = fuel;
            sumKm = sum;
            Start_Date = start;
            checkupDate = start;
            License_Plate = license;
            Status = "Ready";
            
            
        }
        //default
        public Bus()
        {
        }

        //returns the fixed format of license plate and the km traveled.
        public override string ToString()
        {
            string begining, middle, end, fixedLicense;

            if (licensePlate.Length == 8)
            { // if equals 8 then the fixed format should be xxx-xx-xxx
                begining = licensePlate.Substring(0, 3);
                middle = licensePlate.Substring(3, 2);
                end = licensePlate.Substring(5, 3);
                fixedLicense = String.Format("{0}-{1}-{2}", begining, middle, end);
            }
            else
            {
                // if equals 7 then the fixed format should be xx-xxx-xx
                begining = licensePlate.Substring(0, 2);
                middle = licensePlate.Substring(2, 3);
                end = licensePlate.Substring(5, 2);
                fixedLicense = String.Format("{0}-{1}-{2}", begining, middle, end);


            }
            return String.Format("License is: {0,-10}, Total km: {1}", fixedLicense,sumKm );
        }
        

        /***fills tank***/
        public void Refuel()
        {
            this.gas = fullTank;
            Status = "In Refuel";
        }

        /*after a checkup updates the km to 0 and the checkup date to today and also refills gas if needed*/
        public void Checkup()
        {
            if (gas < 100) //if gas is low too... refuel
            { Refuel(); }
                this.sumKm = 0;
            this.checkupDate = DateTime.Today;
            Status = "In checkup";
            
        }
        

    }
}
