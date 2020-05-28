﻿using RGBFusionCli;
using RGBFusionCli.Device;
using RGBFusionCli.Device.Aorus2080;
using RGBFusionCli.Device.DledPinHeader;
using RGBFusionCli.Device.KingstonFury;
using RGBFusionCli.Device.RGBFusion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBFusionWrapper
{
    class Example
    {
        private void DoInit()
        {
            RGBFusionLoader _RGBFusionLoader = new RGBFusionLoader();
            _RGBFusionLoader.Load();

            DeviceController.Devices.Add(new RGBFusionDevice(_RGBFusionLoader, true));
            DeviceController.Devices.Add(new KingstonFuryDevice());
            DeviceController.Devices.Add(new Aorus2080Device());
            DeviceController.Devices.Add(new Z390DledPinHeaderDevice(_RGBFusionLoader));

            DeviceController.InitAll();

            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 1);
            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 2);
            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 3);
            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 5);
            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 6);
            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 7);
            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 8);
            DeviceController.GetDeviceByType(DeviceType.RGBFusion).SetLed(System.Drawing.Color.FromArgb(255, 0, 0, 255), 9);

            DeviceController.ApplyAll();
        }
    }
}
