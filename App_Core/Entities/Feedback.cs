using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace App_Core.Entities
{
    [Table(name: "Feedback")]
    public class Feedback
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public string CommentedBy { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }        
        public int BlogPostId { get; set; }

        [ForeignKey("BlogPostId")]
        public BlogPost BlogPost { get; set; }
    }
}
