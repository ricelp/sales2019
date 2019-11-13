
namespace sales2019.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Equipo
    {
        [Key]
        public int codinfo { get; set; }
        [Key]
        public int codequipo { get; set; }
        [Required]
        public string xnombre { get; set; }
        public string xdescripcion { get; set; }
        public Nullable<int> cmarca { get; set; }
        public string xmarca { get; set; }
        public Nullable<int> cmodelo { get; set; }
        public string xmodelo { get; set; }
        public Nullable<int> cmarcamotor { get; set; }
        public string xmarcamotor { get; set; }
        public string xserialChasis { get; set; }
        public string xserialMotor { get; set; }
        public string xplaca { get; set; }
        public Nullable<int> aa { get; set; }
        public string itipoequipo { get; set; }
        public Nullable<System.DateTime> fpesosydim { get; set; }
        public Nullable<System.DateTime> fseguro { get; set; }
        public Nullable<System.DateTime> ffrenos { get; set; }
        public Nullable<System.DateTime> fplaca { get; set; }
        public string icambioaceite { get; set; }
        public Nullable<System.DateTime> fproximoCA { get; set; }
        public string imantenimiento { get; set; }
        public Nullable<System.DateTime> fproximoMA { get; set; }
        public string iengrasado { get; set; }
        public Nullable<System.DateTime> fproximoEN { get; set; }
        public Nullable<int> cantcombustible { get; set; }
        public Nullable<int> cantcombustiblebarre { get; set; }
        public Nullable<int> consumodiesel_km { get; set; }
        public Nullable<int> consumodiesel_h { get; set; }
        public decimal km { get; set; }
        public decimal odm { get; set; }
        public string xobservacion { get; set; }
        public string iestado { get; set; }
    }
}
