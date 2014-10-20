using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KnockKnockReadify
{
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        ContactDetails WhoAreYou();

        [OperationContract]
        [FaultContractAttribute(typeof(ArgumentOutOfRangeException), Name = "ArgumentOutOfRangeException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n);

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract]
        [FaultContractAttribute(typeof(ArgumentNullException), Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);
    }
}
