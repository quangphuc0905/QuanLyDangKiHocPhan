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
    
    public partial class Diem
    {
        public string ID_SinhVien { get; set; }
        public string ID_LopHocPhan { get; set; }
        public Nullable<double> TK1 { get; set; }
        public Nullable<double> TK2 { get; set; }
        public Nullable<double> TK3 { get; set; }
        public Nullable<double> GK { get; set; }
        public Nullable<double> CK { get; set; }
    
        public virtual LopHocPhan LopHocPhan { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}