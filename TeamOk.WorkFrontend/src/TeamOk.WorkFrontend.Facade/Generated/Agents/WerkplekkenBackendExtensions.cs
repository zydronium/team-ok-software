// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TeamOk.WorkFrontend.Facade
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for WerkplekkenBackend.
    /// </summary>
    public static partial class WerkplekkenBackendExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            public static IList<Floor> ApiFloorsByLocationIdGet(this IWerkplekkenBackend operations, long locationId)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiFloorsByLocationIdGetAsync(locationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Floor>> ApiFloorsByLocationIdGetAsync(this IWerkplekkenBackend operations, long locationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiFloorsByLocationIdGetWithHttpMessagesAsync(locationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiFloorsByLocationIdPost(this IWerkplekkenBackend operations, long locationId, Floor value = default(Floor))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiFloorsByLocationIdPostAsync(locationId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiFloorsByLocationIdPostAsync(this IWerkplekkenBackend operations, long locationId, Floor value = default(Floor), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiFloorsByLocationIdPostWithHttpMessagesAsync(locationId, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Floor ApiFloorsByLocationIdByIdGet(this IWerkplekkenBackend operations, long locationId, long id)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiFloorsByLocationIdByIdGetAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Floor> ApiFloorsByLocationIdByIdGetAsync(this IWerkplekkenBackend operations, long locationId, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiFloorsByLocationIdByIdGetWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiFloorsByLocationIdByIdPut(this IWerkplekkenBackend operations, long locationId, long id, Floor value = default(Floor))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiFloorsByLocationIdByIdPutAsync(locationId, id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiFloorsByLocationIdByIdPutAsync(this IWerkplekkenBackend operations, long locationId, long id, Floor value = default(Floor), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiFloorsByLocationIdByIdPutWithHttpMessagesAsync(locationId, id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiFloorsByLocationIdByIdDelete(this IWerkplekkenBackend operations, long locationId, long id)
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiFloorsByLocationIdByIdDeleteAsync(locationId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiFloorsByLocationIdByIdDeleteAsync(this IWerkplekkenBackend operations, long locationId, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiFloorsByLocationIdByIdDeleteWithHttpMessagesAsync(locationId, id, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Location> ApiLocationsGet(this IWerkplekkenBackend operations)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiLocationsGetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Location>> ApiLocationsGetAsync(this IWerkplekkenBackend operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLocationsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiLocationsPost(this IWerkplekkenBackend operations, Location value = default(Location))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiLocationsPostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiLocationsPostAsync(this IWerkplekkenBackend operations, Location value = default(Location), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiLocationsPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Location ApiLocationsByIdGet(this IWerkplekkenBackend operations, long id)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiLocationsByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Location> ApiLocationsByIdGetAsync(this IWerkplekkenBackend operations, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiLocationsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiLocationsByIdPut(this IWerkplekkenBackend operations, long id, Location value = default(Location))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiLocationsByIdPutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiLocationsByIdPutAsync(this IWerkplekkenBackend operations, long id, Location value = default(Location), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiLocationsByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiLocationsByIdDelete(this IWerkplekkenBackend operations, long id)
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiLocationsByIdDeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiLocationsByIdDeleteAsync(this IWerkplekkenBackend operations, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiLocationsByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workSpaceId'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiNotificationsByWorkSpaceIdPost(this IWerkplekkenBackend operations, long workSpaceId, Notification value = default(Notification))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiNotificationsByWorkSpaceIdPostAsync(workSpaceId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='workSpaceId'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiNotificationsByWorkSpaceIdPostAsync(this IWerkplekkenBackend operations, long workSpaceId, Notification value = default(Notification), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiNotificationsByWorkSpaceIdPostWithHttpMessagesAsync(workSpaceId, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiValuesGet(this IWerkplekkenBackend operations)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiValuesGetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiValuesGetAsync(this IWerkplekkenBackend operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesPost(this IWerkplekkenBackend operations, string value = default(string))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiValuesPostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesPostAsync(this IWerkplekkenBackend operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiValuesByIdGet(this IWerkplekkenBackend operations, int id)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiValuesByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiValuesByIdGetAsync(this IWerkplekkenBackend operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesByIdPut(this IWerkplekkenBackend operations, int id, string value = default(string))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiValuesByIdPutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdPutAsync(this IWerkplekkenBackend operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiValuesByIdDelete(this IWerkplekkenBackend operations, int id)
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiValuesByIdDeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdDeleteAsync(this IWerkplekkenBackend operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            public static IList<Workspace> ApiWorkspacesByFloorIdGet(this IWerkplekkenBackend operations, long floorId)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiWorkspacesByFloorIdGetAsync(floorId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Workspace>> ApiWorkspacesByFloorIdGetAsync(this IWerkplekkenBackend operations, long floorId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiWorkspacesByFloorIdGetWithHttpMessagesAsync(floorId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiWorkspacesByFloorIdPost(this IWerkplekkenBackend operations, long floorId, Workspace value = default(Workspace))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiWorkspacesByFloorIdPostAsync(floorId, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiWorkspacesByFloorIdPostAsync(this IWerkplekkenBackend operations, long floorId, Workspace value = default(Workspace), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiWorkspacesByFloorIdPostWithHttpMessagesAsync(floorId, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Workspace ApiWorkspacesByFloorIdByIdGet(this IWerkplekkenBackend operations, long floorId, long id)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiWorkspacesByFloorIdByIdGetAsync(floorId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Workspace> ApiWorkspacesByFloorIdByIdGetAsync(this IWerkplekkenBackend operations, long floorId, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiWorkspacesByFloorIdByIdGetWithHttpMessagesAsync(floorId, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiWorkspacesByFloorIdByIdPut(this IWerkplekkenBackend operations, long floorId, long id, Workspace value = default(Workspace))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiWorkspacesByFloorIdByIdPutAsync(floorId, id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiWorkspacesByFloorIdByIdPutAsync(this IWerkplekkenBackend operations, long floorId, long id, Workspace value = default(Workspace), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiWorkspacesByFloorIdByIdPutWithHttpMessagesAsync(floorId, id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiWorkspacesByFloorIdByIdDelete(this IWerkplekkenBackend operations, long floorId, long id)
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiWorkspacesByFloorIdByIdDeleteAsync(floorId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floorId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiWorkspacesByFloorIdByIdDeleteAsync(this IWerkplekkenBackend operations, long floorId, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiWorkspacesByFloorIdByIdDeleteWithHttpMessagesAsync(floorId, id, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='macAddress'>
            /// </param>
            public static Status ApiWorkspaceunitsByMacAddressGet(this IWerkplekkenBackend operations, string macAddress)
            {
                return Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiWorkspaceunitsByMacAddressGetAsync(macAddress), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='macAddress'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Status> ApiWorkspaceunitsByMacAddressGetAsync(this IWerkplekkenBackend operations, string macAddress, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiWorkspaceunitsByMacAddressGetWithHttpMessagesAsync(macAddress, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='macAddress'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiWorkspaceunitsByMacAddressPost(this IWerkplekkenBackend operations, string macAddress, Status value = default(Status))
            {
                Task.Factory.StartNew(s => ((IWerkplekkenBackend)s).ApiWorkspaceunitsByMacAddressPostAsync(macAddress, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='macAddress'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiWorkspaceunitsByMacAddressPostAsync(this IWerkplekkenBackend operations, string macAddress, Status value = default(Status), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiWorkspaceunitsByMacAddressPostWithHttpMessagesAsync(macAddress, value, null, cancellationToken).ConfigureAwait(false);
            }

    }
}