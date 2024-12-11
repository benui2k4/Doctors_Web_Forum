﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors_Web_Forum.DAL.Models
{
    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string? AnswerText { get; set; } // nội dung câu trả lời 
        public DateTime PostedDate { get; set; } // Ngày trả lời câu hỏi 
        public bool Status { get; set; }

    }
}
