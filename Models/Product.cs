using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

       

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Amount { get; set; }
        public long? Date { get; set; }
        public bool IsPrivate { get; set; }

        [NotMapped]
        public string strDate
        {
            get
            {
                if (Date > 0)
                    return new DateTime((long)Date).ToString("dd/MM/yyyy");

                else return null;
               
            }
            set
            {
                  if(Date>0)
                  Date=  Convert.ToDateTime(value, new CultureInfo("he-IL")).Ticks;
                 
                   


            }
            
        }
    }
}
