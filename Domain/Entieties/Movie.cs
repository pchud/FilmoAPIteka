using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entieties
{
    [Table("Movies")]
    public class Movie : AuditableEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public string Director { get; set; }
        [Required]
        public int Year { get; set; }
        public int Rate { get; set; }
        public int ExtId { get; set; }

        public Movie() { }
        public Movie(int id, string title, int year)
        {
            (Id, Title, Year) = (id, title,year);
        }

    }
}
