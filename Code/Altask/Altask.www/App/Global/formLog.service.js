//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

export class FormLogService {
	constructor(AppConfig, CrudService, Logger) {
        this.AppConfig = AppConfig;
        this.CrudService = CrudService;
        this.Logger = Logger
    }

	create(formLog) {
		this.Logger.debug('FormLogService.create');
		return this.CrudService.create('FormLog', formLog);
    }

	list(filter) {
		this.Logger.debug('FormLogService.list');
        return this.CrudService.list('FormLog', filter);
    }

	update(formLog) {
		this.Logger.debug('FormLogService.update');
        return this.CrudService.update('FormLog', formLog);
    }
}

FormLogService.$inject = ['AppConfig', 'CrudService', 'Logger'];
