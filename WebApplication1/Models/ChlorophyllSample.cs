using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public enum GreatLakes { Erie, Superior, Huron, Ontario, Michigan}

    public enum Sites { RR1B, BRD17D, CW88, CE92, CE100, BRD17I, WTP1, CW82, MFYBRD17D}

    public enum Parameters { ChlorophyllA, DRPhos, NH3, NO3NO2, TOTALP }

    public enum Codes {
        [Description("Estimated Value")] Estimated,
        [Description("Value is below method detection limit")] BelowLimit,
        [Description("Value is between method detection limit and pratical quantitation limit; estimated value")] Inbetween,
        [Description("Reading is accurate")] Accurate
    }
    public enum Units
    {
        [Description("ug/L")] ugl,
        [Description("mg/L")] mgl,

    }


    public class ChlorophyllSample
    {
        [Key]
        public int SampleId { get; set; }
        [Required]
        [Display(Name = "Great Lake")]
        public GreatLakes Lake { get; set; }
        [Required]
        [Display(Name = "Site Observed")]
        public Sites Site { get; set; }
        [Required]
        [Display(Name = "Time Entered" )]
        public DateTime TimeEntered { get; set; }
        [Required]
        [Display(Name = "Parameter Observed")]
        public Parameters Parameter { get; set; }
        [Required]
        [Display(Name = "Entry Code")]
        public Codes EntryCodes { get; set; }
        [Required]
        [Display(Name = "Results of Measurement")]
        public double  Result { get; set; }
        [Required]
        [Display(Name = "Units of Measurement")]
        public Units Unit { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }


}