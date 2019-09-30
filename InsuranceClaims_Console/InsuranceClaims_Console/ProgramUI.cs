using InsuranceClaims_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims_Console
{

    internal class ProgramUI
    {


        Claims_Repository _claimsRepo = new Claims_Repository();
        
        public ProgramUI()
        {

        }
        //run menu
        public void Run()
        {

        }
        //Menu
        private void RunMenu()
        {
            Console.WriteLine("Welcome to the Claims Center. Enter the Menu Choice You would like.\n" +
                "1. See All Claims\n" +
                "2. Take care of next Claim\n" +
                "3. Enter a new Claim\n" +
                "");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    SeeAllClaims();
                    break;


            }

        }
            //display options to claims officer



            //Add claims id type decription amount dateOf Incident dateOfClaim isValid(bool by date need valid within 30 days)
            public void AddToList()
            {

            }
        



    }

}
