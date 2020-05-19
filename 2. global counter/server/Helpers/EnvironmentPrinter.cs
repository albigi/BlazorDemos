using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace server
{
    public class EnvironmentPrinter : IEnvironmentPrinter
    {
        public IDictionary<string, string> PrintEnvironmentInfo()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("OS", RuntimeInformation.OSDescription);
            dict.Add("Process", BuildProcessDescription());
            dict.Add("Runtime", RuntimeInformation.FrameworkDescription);
            dict.Add("Time", DateTime.Now.ToShortTimeString());

            return dict;
        }

        private string BuildProcessDescription()
        {
            Process proc = null;
            try
            {
                proc = Process.GetCurrentProcess();
                return $"{proc.ProcessName}({proc.Id}) ({RuntimeInformation.ProcessArchitecture.ToString()}) on {Environment.MachineName}";
            }
            catch
            {
                return $"{Environment.CommandLine.Split(' ')[0]} ({RuntimeInformation.ProcessArchitecture.ToString()}) on {Environment.MachineName}";
            }
        }
    }
}
