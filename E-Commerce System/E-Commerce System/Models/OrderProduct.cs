using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Models
{
    public class OrderProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderProductId { get; set; }// system generated

        [Required]
        [Range(1, 999)]
        public int quantity { get; set; } // user input

        [ForeignKey("Order")]
        public int orderId { get; set; }// foreign key 

        [ForeignKey("Product")]
        public int productId { get; set; }// foreign key

        //navigation
        public Order Order { get; set; }
        public Product Product { get; set; }


    }
}
