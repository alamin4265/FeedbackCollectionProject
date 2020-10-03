using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App_Core.Entities
{
    [Table(name: "BlogPost")]
    public class BlogPost
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostedBy { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
