using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CMS_Window_Systems_QRCode_Project.Models
{
    public class Heading
    {
        [Key]
        public int ID { get; set; }
        public int JobKeyID { get; set; }
        public DateTime DateInProduction { get; set; }
    }
}
