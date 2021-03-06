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
		internal static void NotifyAssetCreate(Guid? clientId, Altask.Data.Dto.Asset asset) {
			if (!clientId.HasValue) {
				_context.Clients.All.notifyAssetCreate(new { asset = asset });
			} else {
				SignalRConnection connection;

				if (_connections.TryGetValue(clientId.Value, out connection)) {
					_context.Clients.AllExcept(connection.ConnectionId).notifyAssetCreate(new { connection = connection, asset = asset });
				} else {
					_context.Clients.All.notifyAssetCreate(new { asset = asset });
				}
			}
		}

        internal static void NotifyAssetUpdate(Guid? clientId, Altask.Data.Dto.Asset asset) {
            if (!clientId.HasValue) {
				_context.Clients.All.notifyAssetUpdate(new { asset = asset });
			} else {
				SignalRConnection connection;

				if (_connections.TryGetValue(clientId.Value, out connection)) {
					_context.Clients.AllExcept(connection.ConnectionId).notifyAssetUpdate(new { connection = connection, asset = asset });
				} else {
					_context.Clients.All.notifyAssetCreate(new { asset = asset });
				}
			}
		}
	}
}
