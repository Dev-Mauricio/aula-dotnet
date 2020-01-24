using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities
{   
    [Table("Todo")]
    public class EntityBase<T> where T : struct
    {
        [Key]
        [Column("Id")]
        public T Id { get; set; }
    }
}
