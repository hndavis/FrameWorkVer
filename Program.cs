using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FrameworkVer
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> versions = new Dictionary<int, string>
            {
                [394254] = ".NET Framework 4.6.1 installed on Windows 10 November Update",
                [394271] = ".NET Framework 4.6.1 installed on all OS versions other than Windows 10 November Update",
                [393295] = ".NET Framework 4.6 installed on Windows 10",
                [393297] = ".NET Framework 4.6 installed on all OS versions other than Windows 10",
                [379893] = ".NET Framework 4.5.2",
                [378675] = ".NET Framework 4.5.1 installed with Windows 8.1 or Windows Server 2012 R2",
                [378758] = ".NET Framework 4.5.1 installed on Windows 8, Windows 7",
                [378389] = ".NET Framework 4.5",
                [-1]="Not Found"
            };
                           
             string key= @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full";
             var installedVer =(int) Registry.GetValue(key, "Release", -1);
            Console.WriteLine("{0}: {1} ", installedVer, versions[installedVer]);
        }
    }
}
