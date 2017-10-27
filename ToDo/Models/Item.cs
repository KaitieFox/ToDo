using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public DateTime DueDate { get; set; }
        public string Details { get; set; }
        public bool IsDone { get; set; }

        [ForeignKey("List")] //references the class we are linking with the foreignkey
        public int ListID { get; set; } //doesn't need to match name-wise
        public virtual List List { get; set; } //this element is for efficiency

    }
}