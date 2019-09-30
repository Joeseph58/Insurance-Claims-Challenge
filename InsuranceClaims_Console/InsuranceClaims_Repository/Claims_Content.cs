using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims_Repository
{
    public enum ClaimType { Car, Home, Theft }

    public class Claims_Content
    {
        public Claims_Content()
        {

        }

        public Claims_Content(int claimId, ClaimType claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        { 

                ClaimId = claimId;
                ClaimType = claimType;
                Description = description;
                ClaimAmount = claimAmount;
                DateOfIncident = dateOfIncident;
                DateOfClaim = dateOfClaim;
                IsValid = (dateOfClaim - dateOfIncident).Days <= 30;

         }

        public int ClaimId { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }




    }
}
