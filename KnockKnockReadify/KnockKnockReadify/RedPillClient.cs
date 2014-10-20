using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace KnockKnockReadify
{
    [DataContractAttribute(Name = "RedPillClient", Namespace = "http://KnockKnock.readify.net")]
    public class RedPillClient : System.ServiceModel.ClientBase<IRedPill>, IRedPill
    {
        public RedPillClient()
        {
        }

        public RedPillClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public RedPillClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public RedPillClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public RedPillClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public ContactDetails WhoAreYou()
        {
            return base.Channel.WhoAreYou();
        }

        public long FibonacciNumber(long n)
        {
            return base.Channel.FibonacciNumber(n);
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return base.Channel.WhatShapeIsThis(a, b, c);
        }

        public string ReverseWords(string s)
        {
            return base.Channel.ReverseWords(s);
        }
    }
}