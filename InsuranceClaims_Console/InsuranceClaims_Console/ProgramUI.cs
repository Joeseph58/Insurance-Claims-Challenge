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
            _claimsRepo.Seedlist();
            RunMenu();

        }
        //Menu
        public void RunMenu()
        {


            bool ContinueToRun = true;
            while (ContinueToRun)
            {

                Console.WriteLine("Welcome to the Claims Center. Enter the Menu Choice You would like.\n" +
                    "1. See All Claims\n" +
                    "2. Take care of next Claim\n" +
                    "3. Enter a new Claim\n" +
                    "4. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        NextClaim();
                        break;
                    case "3":
                        NewClaim();
                        break;
                    case "4":
                        ContinueToRun = false;
                        break;


                }

            }

        }
        //display options to claims officer


        public void SeeAllClaims()
        {
            Queue<Claims_Content> incidentQueue = _claimsRepo.GetClaimsContentQueue();

            Console.WriteLine($"Claim Id \t Claim Type \t Description \t Claim Amount \t Incident Date \t Claim Date\n");

            foreach (Claims_Content incident in incidentQueue)
            {
                Console.WriteLine($"{incident.ClaimId}\t\t {incident.ClaimType}\t\t {incident.Description}\t\t {incident.ClaimAmount}\t\t {incident.DateOfIncident}\t\t {incident.DateOfClaim}\t\t  {incident.IsValid}\n ");
            }
                Console.ReadKey();
        }

        public void NextClaim()
        {
            {
                Queue<Claims_Content> incidentQueue = _claimsRepo.GetClaimsContentQueue();
                Claims_Content incident = incidentQueue.Peek();
                Console.WriteLine($"Claim ID: {incident.ClaimId}, Claim type: {incident.ClaimType}, Description: {incident.Description}, \n" +
                        $"Claim amount($): {incident.ClaimAmount}, Date of incident: {incident.DateOfIncident}, \n" +
                        $"Date of claim: {incident.DateOfClaim}, Valid claim: {incident.IsValid}\n");
                Console.WriteLine("Please press any key to continue...\n");
                Console.ReadKey();
                Console.WriteLine("Would you like to deal with this claim now (y/n)?\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "y":
                        RemoveNextClaimFromQueue();
                        break;
                    case "n":
                        break;
                }

            }
        }

        public void RemoveNextClaimFromQueue()
        {
            Queue<Claims_Content> incidentQueue = _claimsRepo.GetClaimsContentQueue();
            Claims_Content incident = incidentQueue.Dequeue();
            Console.WriteLine("You have successfully removed this claim from the queue. Press any key to continue...\n");
            Console.ReadKey();
        }

        public void NewClaim()
        {
            Claims_Content claim = new Claims_Content();


            Console.WriteLine("Enter claim id");
            string claimidasString = Console.ReadLine();
            int claimId = int.Parse(claimidasString);

            Console.WriteLine("Enter Type of claim");
            string typeasString = Console.ReadLine();
            ClaimType claimType = (ClaimType)int.Parse(typeasString);

            Console.WriteLine("Enter a discription of the claim");
            string description = Console.ReadLine();

            Console.WriteLine("Enter a claim amount");
            string amountasString = Console.ReadLine();
            decimal claimAmount = decimal.Parse(amountasString);

            Console.WriteLine("Enter date of incident (yyyy/mm/dd)");
            string dateOfIncidentasString = Console.ReadLine();
            DateTime dateOfIncident = DateTime.Parse(dateOfIncidentasString);

            Console.WriteLine("Enter date of claim (yyyy/mm/dd)");
            string dateOfClaimasString = Console.ReadLine();
            DateTime dateOfClaim = DateTime.Parse(dateOfClaimasString);

            Claims_Content incident = new Claims_Content(claimId, claimType, description, claimAmount, dateOfIncident, dateOfClaim);

            _claimsRepo.NewClaim(incident);

        }


    }
}
