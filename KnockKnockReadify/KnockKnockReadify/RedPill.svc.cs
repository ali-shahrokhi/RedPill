using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KnockKnockReadify
{
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill
    {
        public ContactDetails WhoAreYou()
        {
            var contact = new ContactDetails();
            contact.GivenName = "Ali";
            contact.FamilyName = "Shahrokhi";
            contact.EmailAddress = "ali.shahrokhi@outlook.com";
            contact.PhoneNumber = "0431 317 257";
            return contact;
        }

        public long FibonacciNumber(long n)
        {
            if (n > 92)
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");

            return Helper.Fibonacci(n);
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return Helper.WhatShapeIsThis(a, b, c);
        }

        public string ReverseWords(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s", "Value cannot be null");

            return Helper.ReverseWords(s);
        }
    }
}
