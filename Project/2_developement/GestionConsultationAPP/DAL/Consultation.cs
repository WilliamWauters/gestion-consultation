//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consultation
    {
        public int Consultation_ID { get; set; }
        public int Patient_ID { get; set; }
        public int MedecinSpecialiteMaisonMedicale_ID { get; set; }
        public int Local_ID { get; set; }
        public System.DateTime Starting { get; set; }
        public System.DateTime Ending { get; set; }
        public bool IsConfirmed { get; set; }
    
        public virtual Local Local { get; set; }
        public virtual MedecinSpecialiteMaisonMedicale MedecinSpecialiteMaisonMedicale { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
