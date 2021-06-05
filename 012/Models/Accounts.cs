using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _012.Models
{
    public class Accounts
    {
        [Key]//primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        [DisplayName("the account's name")]
        //[MaxLength(ModelConstants.BankAccount.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]//makes the Warning about "No type was specified for the decimal property" disappear
        public decimal Balance { get; set; }

        [Required]
        //[MaxLength(ModelConstants.BankAccount.UniqueIdMaxLength)]
        public string UniqueId { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

       // [Required]    //ofcourse need to implement the inserting of the userID somehow
        public string UserId { get; set; }

       // public BankUser User { get; set; }

        //public ICollection<Card> Cards { get; set; }

       // public ICollection<MoneyTransfer> Transfers { get; set; }
    }
}
