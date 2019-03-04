using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("OtpremnicaStatusLog")]
    public class OtpremnicaStatusLog
    {
        public int ID { get; set; }

        public int Otpremnica { get; set; }

        public int Status { get; set; }

        public DateTime VremePromene { get; set; }

        public int Promenio { get; set; }

        public bool ExportFlag { get; set; }

        public virtual Otpremnica Otpremnica1 { get; set; }
    }
}