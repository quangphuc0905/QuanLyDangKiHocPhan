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
    
    public partial class LichHoc_LopHocPhan
    {
        public int ID_LichHoc_LopHP { get; set; }
        public string ID_LopHocPhan { get; set; }
        public string NgayHoc { get; set; }
        public string TietHoc { get; set; }
        public string ID_PhongHoc { get; set; }
    
        public virtual LopHocPhan LopHocPhan { get; set; }
        public virtual PhongHoc PhongHoc { get; set; }
    }
}