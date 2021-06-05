using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _012.Models
{
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(16)")]
        public decimal CardNumber { get; set; }
        public string CardAccount { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal CardBalance { get; set; }

        public string CardHolderId { get; set; }
    }
}
