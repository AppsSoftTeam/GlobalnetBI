using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Management.IntegrationServices;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pkgLocation;
            Package pkg;
            Application app;
            DTSExecResult pkgResults;

            pkgLocation = @"C:\Program Files (x86)\Microsoft SQL Server\120\DTS\Binn\DTExec.exe \File " + "\\WIN-DK4BGMJ2CD2.globalnet.tn\\Users\\ichaabane\\Documents\\Visual Studio 2013\\Projects\\AverroesETL2\\AverroesETL2\\GNET_FULL_IMPORT_Aver.dtsx";
            app = new Application();
            pkg = app.LoadPackage(pkgLocation, null);
            pkgResults = pkg.Execute();

            Console.WriteLine(pkgResults.ToString());
            Console.ReadKey();
        }
    }
}
