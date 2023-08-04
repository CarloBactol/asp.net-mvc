using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverflowProject.DomainModel
{
    public class Question
    {
        [Key] // set primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // set identity id column 

        public int QuestionID { get; set; }
        public string QuestionName { get; set; }
        public DateTime QuestionDateAndTime { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int VotesCount { get; set; }
        public int AnswersCount { get; set; }
        public int ViewsCount { get; set; }


        // Bind User model 
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        // list of Answer 
        //public virtual List<Answers> Answers { get; set; }
    }
}
