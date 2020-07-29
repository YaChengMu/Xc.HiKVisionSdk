﻿using Stylet;
using StyletIoC;
using System;
using System.Threading.Tasks;
using Xc.HiKVisionSdk.Isc.Managers.Pms;
using Xc.HiKVisionSdk.Isc.Managers.Pms.Models;

namespace Xc.HiKVisionSdk.Isc.Wpf.Pages.Vehicle
{
    public class CarParkViewModel : BaseScreenViewModel
    {
        public CarParkViewModel(IWindowManager windowManager, IContainer container) : base(windowManager, container)
        {
            DisplayName = "停车场功能";
        }




        public async Task AlarmCar()
        {

            try
            {

                IHikPmsApiManager pmsApiManagerV1 = Container.Get<IHikPmsApiManager>();

                var result = await pmsApiManagerV1.AlarmCarPageAsync(new AlarmCarPageRequest());


                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }


                WindowManager.ShowMessageBox($"查询成功，共有{result.Data.Total}个布控车辆");
            }
            catch (Exception ex)
            {
                WindowManager.ShowMessageBox($"查询失败\r\n" + ex);

            }
            finally
            {

            }

        }


        public async Task ParkRemainSpaceNum()
        {

            try
            {

                IHikPmsApiManager pmsApiManagerV1 = Container.Get<IHikPmsApiManager>();

                var result = await pmsApiManagerV1.ParkRemainSpaceNumAsync(new ParkRemainSpaceNumRequest());

                int total = 0;
                if (result.Data == null)
                {
                    WindowManager.ShowMessageBox($"查询结果为空\r\n状态:{result.Code}\r\n消息:${result.Msg}");
                    return;
                }
                foreach (var xx in result.Data)
                {
                    total += xx.TotalPlace;
                }

                WindowManager.ShowMessageBox($"查询成功，共有{total}个车位");
            }
            catch (Exception ex)
            {
                WindowManager.ShowMessageBox($"查询失败\r\n" + ex);

            }
            finally
            {

            }

        }

    }
}
