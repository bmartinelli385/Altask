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
		internal static void NotifyTaskAlertCreate(Guid? clientId, Altask.Data.Dto.TaskAlert taskAlert) {
			if (!clientId.HasValue) {
				_context.Clients.All.notifyTaskAlertCreate(new { taskAlert = taskAlert });
			} else {
				SignalRConnection connection;

				if (_connections.TryGetValue(clientId.Value, out connection)) {
					_context.Clients.AllExcept(connection.ConnectionId).notifyTaskAlertCreate(new { connection = connection, taskAlert = taskAlert });
				} else {
					_context.Clients.All.notifyTaskAlertCreate(new { taskAlert = taskAlert });
				}
			}
		}

        internal static void NotifyTaskAlertUpdate(Guid? clientId, Altask.Data.Dto.TaskAlert taskAlert) {
            if (!clientId.HasValue) {
				_context.Clients.All.notifyTaskAlertUpdate(new { taskAlert = taskAlert });
			} else {
				SignalRConnection connection;

				if (_connections.TryGetValue(clientId.Value, out connection)) {
					_context.Clients.AllExcept(connection.ConnectionId).notifyTaskAlertUpdate(new { connection = connection, taskAlert = taskAlert });
				} else {
					_context.Clients.All.notifyTaskAlertCreate(new { taskAlert = taskAlert });
				}
			}
		}
	}
}
