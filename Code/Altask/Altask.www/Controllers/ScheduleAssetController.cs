//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Altask.www.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using System.Xml;
    using Altask.www.Models;
    using Data.Model;
    
    [Authorize]
    public partial class ScheduleAssetController : BaseController<Altask.Data.Model.ScheduleAsset, Altask.Data.Dto.ScheduleAsset>
    {
    	/// <summary>
    	/// Constructor
    	/// </summary>
    	public ScheduleAssetController() : base() {
    	
    	}
    
    	/// <summary>
    	/// Constructor
    	/// </summary>
    	/// <param name="userManager">The application user manager used in this application. UserManager is defined in ASP.NET Identity and is used by the application.</param>
    	/// <param name="signInManager">The application sign-in manager which is used in this application.</param>
    	public ScheduleAssetController(ApplicationUserManager userManager, ApplicationSignInManager signInManager) : base(userManager, signInManager) {
    
    	}
    
    	[HttpPost]
    	[JsonNetFilter]
    	/// <summary>
    	/// Create a <see cref="Altask.Data.Model.ScheduleAsset"/>.
    	/// </summary>
    	/// <param name="scheduleAsset"></param>
    	/// <returns>Returns a <see cref="Altask.Data.EntityResult"/> indicating success or failure.</returns>
    	public virtual async Task<ActionResult> Create(Altask.Data.Dto.ScheduleAsset scheduleAsset) {
    		ThrowIfDisposed();
    
    		if (!ModelState.IsValid) {
    			return BadRequest(ModelState);
    		}
    
    		var newScheduleAsset = new Altask.Data.Model.ScheduleAsset().FromDto(scheduleAsset);
    		Context.ScheduleAssets.Add(newScheduleAsset);
    		BeforeCreate(newScheduleAsset, scheduleAsset);
    		var result = await Context.SaveChangesAsync();
    		Context.Entry(newScheduleAsset).Reference(e => e.Asset).Load();
    		Context.Entry(newScheduleAsset).Reference(e => e.Type).Load();
        
        	if (result.Succeeded) {
    			await AfterCreateAsync(newScheduleAsset);
    			return Ok(new { scheduleAsset = newScheduleAsset.ToDto() });
        	} else {
        		return BadRequest(result);
        	}
    	}
    
    	[HttpGet]
    	[JsonNetFilter]
    	/// <summary>
    	/// Returns a <see cref="Altask.Data.Model.ScheduleAsset"/> having the specified ID.
    	/// </summary>
    	/// <param name="id">The ID of the <see cref="Altask.Data.Model.ScheduleAsset"/>.</param>
    	/// <returns>Returns a <see cref="Altask.Data.EntityResult"/> indicating success or failure.</returns>
    	public virtual async Task<ActionResult> FindById(long id) {
    		ThrowIfDisposed();
    		var scheduleAsset = await Context.ScheduleAssets.FindAsync(id);
    		return Ok(new { scheduleAsset = scheduleAsset.ToDto() }, JsonRequestBehavior.AllowGet);
    	}
    
    	[HttpGet]
    	[JsonNetFilter]
    	/// <summary>
    	/// Returns a collection of <see cref="Altask.Data.Model.ScheduleAsset"/> objects matching the specified filter.
    	/// </summary>
    	/// <param name="filter">A <see cref="Altask.www.Models.ScheduleAssetListOptions"/> object on which to filter.</param>
    	/// <returns>Returns a <see cref="Altask.Data.EntityResult"/> indicating success or failure.</returns>
    	public virtual async Task<ActionResult> List(ScheduleAssetListOptions filter) {
    		ThrowIfDisposed();
    
    		if (filter == null) {
    			filter = new ScheduleAssetListOptions();
    		}
    
    		var dtoScheduleAssets = new List<Altask.Data.Dto.ScheduleAsset>();
    		var scheduleAsset = await Context.ScheduleAssets.AsNoTracking().Where(filter.GetPredicate())
    			.Include(e => e.Asset)
    			.Include(e => e.Type)
    			.ToListAsync();
    
    		foreach(var item in scheduleAsset) {
    			dtoScheduleAssets.Add(item.ToDto());
    		}
    
    		return Ok(new { scheduleAssets = dtoScheduleAssets }, JsonRequestBehavior.AllowGet);
    	}
    
    	[HttpPost]
    	[JsonNetFilter]
    	/// <summary>
    	/// Updates the specified <see cref="Altask.Data.Model.ScheduleAsset"/>.
    	/// </summary>
    	/// <param name="scheduleAsset"></param>
    	/// <returns>Returns a <see cref="Altask.Data.EntityResult"/> indicating success or failure.</returns>
    	public virtual async Task<ActionResult> Update(Altask.Data.Dto.ScheduleAsset scheduleAsset) {
    		ThrowIfDisposed();
    
    		if (!ModelState.IsValid) {
    			return BadRequest(ModelState);
    		}
    
    		var scheduleAssetEntity = await Context.ScheduleAssets.FindAsync(scheduleAsset.Id);
    
    		if (scheduleAssetEntity == null) {
    			return BadRequest(ErrorDescriber.DoesNotExist("ScheduleAsset"));
    		}
    
    		scheduleAssetEntity.FromDto(scheduleAsset);
    		Context.Entry(scheduleAssetEntity).State = EntityState.Modified;
    		BeforeUpdate(scheduleAssetEntity, scheduleAsset);
    		var result = await Context.SaveChangesAsync();
    		Context.Entry(scheduleAssetEntity).Reference(e => e.Asset).Load();
    		Context.Entry(scheduleAssetEntity).Reference(e => e.Type).Load();
        
        	if (result.Succeeded) {
    			await AfterUpdateAsync(scheduleAssetEntity);
    			return Ok(new { scheduleAsset = scheduleAssetEntity.ToDto() });
        	} else {
        		return BadRequest(result);
        	}
    	}
    }
}