using My.Core;
using My.Core.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) return;

            var dir = args[0];

            if (!Directory.Exists(dir)) return;

            CoreUtil.CreateZipFromDirectory(dir, $"{dir}.zip");
        }
    }
}
