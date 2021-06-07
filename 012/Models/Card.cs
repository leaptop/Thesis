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
      //  [Required]
        [Column(TypeName = "decimal(16)")]
        public decimal CardNumber { get; set; }
        public string CardAccount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CardBalance { get; set; }
      //  [Required]
        public string CardHolderId { get; set; }// = has to be Identity UserId
       // [Required]
        public string CardHolderName { get; set; }
        //[Required]
        public DateTime expiryDate { get; set; }
       // [Required]
        public int cvi { get; set; }
    }
}
