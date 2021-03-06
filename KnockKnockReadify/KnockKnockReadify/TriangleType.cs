﻿using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace KnockKnockReadify
{
    [GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {
        [EnumMemberAttribute()]
        Error = 0,

        [EnumMemberAttribute()]
        Equilateral = 1,

        [EnumMemberAttribute()]
        Isosceles = 2,

        [EnumMemberAttribute()]
        Scalene = 3,
    }
}
