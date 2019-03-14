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
    
    public partial class Task : ISupportsLongId, ISupportsAuthorFields
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.Schedules = new HashSet<Schedule>();
            this.Alerts = new HashSet<TaskAlert>();
        }
    
    	/// <summary>
    	/// Gets or sets the Id of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public long Id { get; set; }
    	/// <summary>
    	/// Gets or sets the Active of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public bool Active { get; set; }
    	/// <summary>
    	/// Gets or sets the TaskTypeId of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public int TaskTypeId { get; set; }
    	/// <summary>
    	/// Gets or sets the TaskCategoryId of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public int TaskCategoryId { get; set; }
    	/// <summary>
    	/// Gets or sets the FormId of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public Nullable<int> FormId { get; set; }
    	/// <summary>
    	/// Gets or sets the Name of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public string Name { get; set; }
    	/// <summary>
    	/// Gets or sets the Description of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public string Description { get; set; }
    	/// <summary>
    	/// Gets or sets the IdleTimeout of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public int IdleTimeout { get; set; }
    	/// <summary>
    	/// Gets or sets the Metadata of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public string Metadata { get; set; }
    	/// <summary>
    	/// Gets or sets the CreatedBy of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public string CreatedBy { get; set; }
    	/// <summary>
    	/// Gets or sets the CreatedOn of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public System.DateTime CreatedOn { get; set; }
    	/// <summary>
    	/// Gets or sets the UpdatedBy of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public string UpdatedBy { get; set; }
    	/// <summary>
    	/// Gets or sets the UpdatedOn of this <see cref='Altask.Data.Model.Task'/>.
    	/// </summary>
        public System.DateTime UpdatedOn { get; set; }
    
        public virtual Form Form { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual TaskCategory Category { get; set; }
        public virtual TaskType Type { get; set; }
        public virtual ICollection<TaskAlert> Alerts { get; set; }
    }
    
    public static partial class Mapper {
    	/// <summary>
    	/// Maps a <see cref='Altask.Data.Model.Task'/> object to a <see cref='Altask.Data.Dto.Task'/> object.
    	/// </summary>
    	/// <param name="includeLogs">Indicates whether to load any logs associated with the object when mapping.</param>
    	public static Altask.Data.Dto.Task ToDto(this Altask.Data.Model.Task entity, bool includeLogs = false) {
    		var dto = new Altask.Data.Dto.Task();
    		dto.Id = entity.Id;
    		dto.Active = entity.Active;
    		dto.TaskTypeId = entity.TaskTypeId;
    		dto.TaskCategoryId = entity.TaskCategoryId;
    		dto.FormId = entity.FormId;
    		dto.Name = entity.Name;
    		dto.Description = entity.Description;
    		dto.IdleTimeout = entity.IdleTimeout;
    		dto.Metadata = JsonConvert.DeserializeObject("{Properties: []}");
    
    		if (!string.IsNullOrEmpty(entity.Metadata)) {
    			try {
    				XmlDocument doc = new XmlDocument();
    				doc.LoadXml(entity.Metadata);
    				string json = Json.SerizlieXmlDocument(doc);
    				dto.Metadata = JsonConvert.DeserializeObject(json);
    			} catch(Exception) {}
    		}
    
    		dto.CreatedBy = entity.CreatedBy;
    		dto.CreatedOn = entity.CreatedOn;
    		dto.UpdatedBy = entity.UpdatedBy;
    		dto.UpdatedOn = entity.UpdatedOn;
    
    		if (entity.Form != null) {
    			dto.Form = entity.Form.ToDto();
    		}
    
    		dto.Schedules = new List<Altask.Data.Dto.Schedule>();
    		
    		if (entity.Schedules != null) {
    			foreach(var item in entity.Schedules) {
    				dto.Schedules.Add(item.ToDto());
    			}
    		}
    
    		if (entity.Category != null) {
    			dto.Category = entity.Category.ToDto();
    		}
    
    		if (entity.Type != null) {
    			dto.Type = entity.Type.ToDto();
    		}
    
    		dto.Alerts = new List<Altask.Data.Dto.TaskAlert>();
    		
    		if (entity.Alerts != null) {
    			foreach(var item in entity.Alerts) {
    				dto.Alerts.Add(item.ToDto());
    			}
    		}
    
    		return dto;
    	}
    
    	/// <summary>
    	/// Maps all the non-primary key and tracking properties of a <see cref='Altask.Data.Dto.Task'/> object to a <see cref='Altask.Data.Model.Task'/> object.
    	/// </summary>
    	public static Altask.Data.Model.Task FromDto(this Altask.Data.Model.Task model, Altask.Data.Dto.Task entity) {
    		model.Active = entity.Active;
    		model.TaskTypeId = entity.TaskTypeId;
    		model.TaskCategoryId = entity.TaskCategoryId;
    		model.FormId = entity.FormId;
    		model.Name = entity.Name;
    		model.Description = entity.Description;
    		model.IdleTimeout = entity.IdleTimeout;
    		model.Metadata = string.Empty;
    
    		try {
    			model.Metadata = ((XmlDocument)JsonConvert.DeserializeXmlNode(entity.Metadata.ToString(), "Properties")).OuterXml;
    		} catch(Exception) {}
    
    		return model;
    	}
    }
}