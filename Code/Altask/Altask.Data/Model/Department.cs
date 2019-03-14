//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Altask.Data.Model
{
    using Altask.Data;
    using Newtonsoft.Json;
    using System;
    using System.Xml;
    using System;
    using System.Collections.Generic;
    
    public partial class Department : ISupportsIntId
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.Assets = new HashSet<Asset>();
        }
    
    	/// <summary>
    	/// Gets or sets the Id of this <see cref='Altask.Data.Model.Department'/>.
    	/// </summary>
        public int Id { get; set; }
    	/// <summary>
    	/// Gets or sets the Active of this <see cref='Altask.Data.Model.Department'/>.
    	/// </summary>
        public bool Active { get; set; }
    	/// <summary>
    	/// Gets or sets the Name of this <see cref='Altask.Data.Model.Department'/>.
    	/// </summary>
        public string Name { get; set; }
    	/// <summary>
    	/// Gets or sets the Description of this <see cref='Altask.Data.Model.Department'/>.
    	/// </summary>
        public string Description { get; set; }
    
        public virtual ICollection<Asset> Assets { get; set; }
    }
    
    public static partial class Mapper {
    	/// <summary>
    	/// Maps a <see cref='Altask.Data.Model.Department'/> object to a <see cref='Altask.Data.Dto.Department'/> object.
    	/// </summary>
    	public static Altask.Data.Dto.Department ToDto(this Altask.Data.Model.Department entity) {
    		var dto = new Altask.Data.Dto.Department();
    		dto.Id = entity.Id;
    		dto.Active = entity.Active;
    		dto.Name = entity.Name;
    		dto.Description = entity.Description;
    
    		return dto;
    	}
    
    	/// <summary>
    	/// Maps all the non-primary key and tracking properties of a <see cref='Altask.Data.Dto.Department'/> object to a <see cref='Altask.Data.Model.Department'/> object.
    	/// </summary>
    	public static Altask.Data.Model.Department FromDto(this Altask.Data.Model.Department model, Altask.Data.Dto.Department entity) {
    		model.Active = entity.Active;
    		model.Name = entity.Name;
    		model.Description = entity.Description;
    		return model;
    	}
    }
}