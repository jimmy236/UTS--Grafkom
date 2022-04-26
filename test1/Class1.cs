using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Windowing.Desktop;

namespace test1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            var nativewindowsetting = new NativeWindowSettings() {Size=new OpenTK.Mathematics.Vector2i(1200,1200),Title="Hi" };
            using (var window = new Window(GameWindowSettings.Default, nativewindowsetting)) { window.Run(); };
        }
    }
}
