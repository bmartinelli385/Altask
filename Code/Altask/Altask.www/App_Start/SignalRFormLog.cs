//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace Altask.www {
    public partial class SignalRHub {
		internal static void NotifyFormLogCreate(Guid? clientId, Altask.Data.Dto.FormLog formLog) {
			if (!clientId.HasValue) {
				_context.Clients.All.notifyFormLogCreate(new { formLog = formLog });
			} else {
				SignalRConnection connection;

				if (_connections.TryGetValue(clientId.Value, out connection)) {
					_context.Clients.AllExcept(connection.ConnectionId).notifyFormLogCreate(new { connection = connection, formLog = formLog });
				} else {
					_context.Clients.All.notifyFormLogCreate(new { formLog = formLog });
				}
			}
		}

        internal static void NotifyFormLogUpdate(Guid? clientId, Altask.Data.Dto.FormLog formLog) {
            if (!clientId.HasValue) {
				_context.Clients.All.notifyFormLogUpdate(new { formLog = formLog });
			} else {
				SignalRConnection connection;

				if (_connections.TryGetValue(clientId.Value, out connection)) {
					_context.Clients.AllExcept(connection.ConnectionId).notifyFormLogUpdate(new { connection = connection, formLog = formLog });
				} else {
					_context.Clients.All.notifyFormLogCreate(new { formLog = formLog });
				}
			}
		}
	}
}