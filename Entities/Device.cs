/*
Copyright (c) 2012, 2013, 2014 Countly

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using CountlySDK.Helpers;
using System;
using System.Linq;
using System.Windows;
using System.Management;
using System.Reflection;

namespace CountlySDK.Entitites
{
    /// <summary>
    /// This class provides several static methods to retrieve information about the current device and operating environment.
    /// </summary>
    internal static class Device
    {
        /// <summary>
        /// Returns the unique device identificator
        /// </summary>
        public static string DeviceId
        {
            get
            {
                var name = (from x in new ManagementObjectSearcher("SELECT * FROM Win32_Processor").Get().OfType<ManagementObject>()
                            select x.GetPropertyValue("ProcessorID")).FirstOrDefault();
                return name != null ? name.ToString() : "Unknown";
            }
        }

        /// <summary>
        /// Returns the display name of the current operating system
        /// </summary>
        public static string OS
        {
            get
            {
                var name = (from x in new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>()
                            select x.GetPropertyValue("Caption")).FirstOrDefault();
                return name != null ? name.ToString() : "Unknown";
            }
        }

        /// <summary>
        /// Returns the current operating system version as a displayable string
        /// </summary>
        public static string OsVersion
        {
            get
            {
                return Environment.OSVersion.Version.ToString();
            }
        }

        /// <summary>
        /// Returns the current device model
        /// </summary>
        public static string DeviceName
        {
            get { return Environment.MachineName; }
        }

        /// <summary>
        /// Returns application version
        /// </summary>
        public static string AppVersion
        {
            get { return Assembly.GetExecutingAssembly().FullName; }
        }

        /// <summary>
        /// Returns device resolution in <width_px>x<height_px> format
        /// </summary>
        public static string Resolution
        {
            get { return "N/A"; }
        }

        /// <summary>
        /// Returns local domain name
        /// </summary>
        public static string Carrier
        {
            get { return Environment.UserDomainName; }
        }
    }
}
