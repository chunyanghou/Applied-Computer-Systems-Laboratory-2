using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public class Member
    {
        public String id { get; set; }
        public Person name { get; set; }
        List<PaymentRequest> paymentRequests;

        public Member(string id, Person person)
        {
            this.id = id;
            this.person = person;

            paymentRequests = new List<PaymentRequest>();
        }

        public void FulfilPaymentRequest(PaymentRequest request)
        {
            if (paymentRequests.Contains(request))
            {
                _ = paymentRequests.Remove(request);
            }
        }

        public bool HasOngoingPaymentRequest()
        {
            return (paymentRequests.Count > 0);
        }

        public void AssignPaymentRequest(PaymentRequest request)
        {
            paymentRequests.Add(request);
        }
    }
}
