//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InspectionPractice
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.VehicleAccident = new HashSet<VehicleAccident>();
        }
    
        public string VIN { get; set; }
        public int VehicleModelId { get; set; }
        public int Year { get; set; }
        public int Weight { get; set; }
        public Nullable<int> VehicleColorId { get; set; }
        public int EngineTypeId { get; set; }
        public int TypeOfDriverId { get; set; }
        public int DriverId { get; set; }
    
        public virtual Driver Driver { get; set; }
        public virtual EngineType EngineType { get; set; }
        public virtual TypeOfDrive TypeOfDrive { get; set; }
        public virtual VehicleColor VehicleColor { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleAccident> VehicleAccident { get; set; }
    }
}
