using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaims_Repository
{
    public class Claims_Repository
    {

        //(<----------------Bring in List and make New------------------->)
        Queue<Claims_Content> _claimsContentQueue = new Queue<Claims_Content>();



        //(<----------------Add to List------------------->)

        public void NewClaim(Claims_Content content)
        { 

            _claimsContentQueue.Enqueue(content);
        }


        public Queue<Claims_Content> GetClaimsContentQueue()
        {
            return _claimsContentQueue;
        }

        //(<----------------Seed List------------------->)



        public void Seedlist()
        {

            Claims_Content claim = new Claims_Content(1, ClaimType.Car, "Accident", 6000.00m, new DateTime(2015, 09, 24), new DateTime(2015, 10, 01));
            Claims_Content claimtwo = new Claims_Content(2, ClaimType.Home, "Fire", 2300.00m, new DateTime(2017, 08, 28), new DateTime (2017, 09, 23));
            Claims_Content claimthree = new Claims_Content(3, ClaimType.Theft, "Break In", 2400.00m, new DateTime(2018, 09, 21), new DateTime(2018, 11, 02));

            NewClaim(claim);
            NewClaim(claimtwo);
            NewClaim(claimthree);


        }




    }
}

