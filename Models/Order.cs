using Shop.Models

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Order
    {
        [Key] public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int CreateDate { get; set; }
        public int DateUpdate { get; set; }
        public int OrderStatus { get; set; }
    }
}
