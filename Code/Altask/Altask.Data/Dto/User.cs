//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Altask.Data.Dto
{
    using Altask.Data;
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Logs = new HashSet<UserLog>();
            this.Roles = new HashSet<UserRole>();
        }
    
    	/// <summary>
    	/// Gets or sets the Id of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public int Id { get; set; }
    	/// <summary>
    	/// Gets or sets the Active of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public bool Active { get; set; }
    	/// <summary>
    	/// Gets or sets the UserName of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string UserName { get; set; }
    	/// <summary>
    	/// Gets or sets the FullName of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string FullName { get; set; }
    	/// <summary>
    	/// Gets or sets the EmailAddress of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string EmailAddress { get; set; }
    	/// <summary>
    	/// Gets or sets the SmsAddress of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string SmsAddress { get; set; }
    	/// <summary>
    	/// Gets or sets the Metadata of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public object Metadata { get; set; }
    	/// <summary>
    	/// Gets or sets the Settings of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string Settings { get; set; }
    	/// <summary>
    	/// Gets or sets the MobilePhone of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string MobilePhone { get; set; }
    	/// <summary>
    	/// Gets or sets the ReceiveEmail of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public bool ReceiveEmail { get; set; }
    	/// <summary>
    	/// Gets or sets the ReceiveText of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public bool ReceiveText { get; set; }
    	/// <summary>
    	/// Gets or sets the PasswordHash of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string PasswordHash { get; set; }
    	/// <summary>
    	/// Gets or sets the SecurityStamp of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string SecurityStamp { get; set; }
    	/// <summary>
    	/// Gets or sets the CreatedBy of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string CreatedBy { get; set; }
    	/// <summary>
    	/// Gets or sets the CreatedOn of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public System.DateTime CreatedOn { get; set; }
    	/// <summary>
    	/// Gets or sets the UpdatedBy of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public string UpdatedBy { get; set; }
    	/// <summary>
    	/// Gets or sets the UpdatedOn of this <see cref='Altask.Data.Dto.User'/>.
    	/// </summary>
        public System.DateTime UpdatedOn { get; set; }
    
        public virtual ICollection<UserLog> Logs { get; set; }
        public virtual ICollection<UserRole> Roles { get; set; }
    }
}
