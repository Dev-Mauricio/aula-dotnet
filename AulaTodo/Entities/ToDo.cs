using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ToDo : EntityBase<int>
    {   
        [Required]
        [Column("Tarefa")]
        public string Tarefa { get; set; }
    }
}
