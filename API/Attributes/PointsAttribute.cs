﻿using System;

namespace TestMyCode.CSharp.API.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PointsAttribute : Attribute
    {
        public string Name { get; }

        public PointsAttribute(string name)
        {
            this.Name = name;
        }
    }
}
