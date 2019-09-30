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

        public void AddToQueue(Claims_Content content)
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

            Claims_Content claim = new Claims_Content(1, "Car", "Accident", 6000.00m 9/24/15, dateofclaim);
            Claims_Content claimtwo = new Claims_Content(2, Home, "Natural Disaster", 23000.00m, 8/28/17, dateofclaim);
            Claims_Content claimthree = new Claims_Content(3, "Theft", "Break In", 2400.00m, 9/21/18, dateofclaim);

            AddToQueue(claim);
            AddToQueue(claimtwo);
            AddToQueue(claimthree);


        }




    }
}

