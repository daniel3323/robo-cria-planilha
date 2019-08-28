namespace RoboCriaPlanilha
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transf")]
    public partial class Transf
    {
        public int id { get; set; }

        public decimal Valor { get; set; }

        public int idContaRemetente { get; set; }

        public int idContaDestinatario { get; set; }

        public virtual Conta Conta { get; set; }

        public virtual Conta Conta1 { get; set; }

        public virtual Conta Conta2 { get; set; }
    }
}
