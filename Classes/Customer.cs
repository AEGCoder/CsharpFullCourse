using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
     public int Id { get; set; } 
     private string _firstName;
     public string FirstNmae
     {
        get
        { 
             return "Mr." + _firstName;
        }
        set
        {
               _firstName = value;
        }
     }
     public string LastName{get;set;}
     public string City{get;set;}
    }
}