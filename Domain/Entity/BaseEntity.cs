using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}
