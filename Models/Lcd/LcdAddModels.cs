using System;
using System.ComponentModel.DataAnnotations;

namespace JPGStockServer.Models.Lcd
{
    public class LcdAddModels
    {


        [Required]
        public String PART_NUMBER { get; set; }

        [Required]
        public String HMI_MODEL { get; set; }

        [Required]
        public String LOCATION { get; set; }

        [Required]
        public Int64? QUANTITY { get; set; }
        [Required]
        public string COMPONENTS_ID { get; set; }

        [Required]
        public String CreateDate { get; set; }
        [Required]
        public String UpdateDate { get; set; }
    }
}
