using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_04
{
    public interface ITrackable
    {
        string GetTrackingStatus();
    }

    public interface IInsurable 
    {
        decimal CalculateInsurance();
    }
}
