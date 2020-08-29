﻿using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.EventService.Models;

namespace Xc.HiKVisionSdk.Isc.Managers.EventService
{

    /// <summary>
    /// 事件服务api
    /// </summary>
    public class HikEventServiceApiManager : IHikEventServiceApiManager
    {
        private readonly IHikVisionApiManager _hikVisionApiManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hikVisionApiManager"></param>
        public HikEventServiceApiManager(IHikVisionApiManager hikVisionApiManager)
        {
            _hikVisionApiManager = hikVisionApiManager;
        }

        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public EventsSearchResponse EventsSearch(EventsSearchRequest model)
        {
            return _hikVisionApiManager.PostAndGet<EventsSearchRequest, EventsSearchResponse>("/api/eventService/v1/events/search", model, Const.V1_3);
        }

        /// <summary>
        /// 获取联动事件列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<EventsSearchResponse> EventsSearchAsync(EventsSearchRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<EventsSearchRequest, EventsSearchResponse>("/api/eventService/v1/events/search", model, Const.V1_3);
        }

        /// <summary>
        /// 按事件类型订阅事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public EventSubscriptionByEventTypesResponse EventSubscriptionByEventTypes(EventSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGet<EventSubscriptionByEventTypesRequest, EventSubscriptionByEventTypesResponse>("/api/eventService/v1/eventSubscriptionByEventTypes", model, Const.V1_3);
        }

        /// <summary>
        /// 按事件类型订阅事件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<EventSubscriptionByEventTypesResponse> EventSubscriptionByEventTypesAsync(EventSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<EventSubscriptionByEventTypesRequest, EventSubscriptionByEventTypesResponse>("/api/eventService/v1/eventSubscriptionByEventTypes", model, Const.V1_3);
        }

        /// <summary>
        /// 查询事件订阅信息
        /// </summary>
        /// <returns></returns>
        public EventSubscriptionViewResponse EventSubscriptionView()
        {
            return _hikVisionApiManager.PostAndGet<EventSubscriptionViewRequest, EventSubscriptionViewResponse>("/api/eventService/v1/eventSubscriptionView", null, Const.V1_0);
        }

        /// <summary>
        /// 查询事件订阅信息
        /// </summary>
        /// <returns></returns>
        public Task<EventSubscriptionViewResponse> EventSubscriptionViewAsync()
        {
            return _hikVisionApiManager.PostAndGetAsync<EventSubscriptionViewRequest, EventSubscriptionViewResponse>("/api/eventService/v1/eventSubscriptionView", null, Const.V1_0);
        }

        /// <summary>
        /// 按事件类型取消订阅
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public EventUnSubscriptionByEventTypesResponse EventUnSubscriptionByEventTypes(EventUnSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGet<EventUnSubscriptionByEventTypesRequest, EventUnSubscriptionByEventTypesResponse>("/api/eventService/v1/eventUnSubscriptionByEventTypes", model, Const.V1_0);
        }

        /// <summary>
        /// 按事件类型取消订阅
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<EventUnSubscriptionByEventTypesResponse> EventUnSubscriptionByEventTypesAsync(EventUnSubscriptionByEventTypesRequest model)
        {
            return _hikVisionApiManager.PostAndGetAsync<EventUnSubscriptionByEventTypesRequest, EventUnSubscriptionByEventTypesResponse>("/api/eventService/v1/eventUnSubscriptionByEventTypes", model, Const.V1_0);
        }
    }
}
