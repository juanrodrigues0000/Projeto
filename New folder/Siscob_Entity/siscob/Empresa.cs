//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace siscob
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public Empresa()
        {
            this.Contrato = new HashSet<Contrato>();
        }
    
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
    
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}
