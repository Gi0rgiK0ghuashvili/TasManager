using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Product : BaseEntity
    {

        public string ProductID { get; set; }           
        public int CategoryID { get; set; }            
        public Category Categories { get; set; }         
        public string Name { get; set; }                
        public decimal Cost { get; set; }               
        public decimal UnitPrice { get; set; }          
        public double Stock { get; set; } = 0.0;        
        public string LastSellDate { get; set; } = "";  
        public string LastBuyDate { get; set; }         
        public string Comment { get; set; }             

    }
}
