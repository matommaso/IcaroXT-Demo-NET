//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OracleSQL
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class ABILITAZIONE
    {
        public string SIGLA { get; set; }
        public string MATR_UTENTE { get; set; }
        public System.DateTime DATA_INS { get; set; }
        public System.DateTime DATA_VAR { get; set; }
        public string RICH_EQUIP_CONDOTTA { get; set; }
        public string RICH_EQUIP_CABINA { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(SIGLA).Append(",");
            builder.Append(MATR_UTENTE).Append(",");
            builder.Append(DATA_INS).Append(",");
            builder.Append(DATA_VAR).Append(",");
            builder.Append(RICH_EQUIP_CONDOTTA).Append(",");
            builder.Append(RICH_EQUIP_CABINA);
            return builder.ToString();
        }
    }
}
