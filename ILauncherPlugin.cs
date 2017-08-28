using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherPlugin
{
    public interface ILauncherPlugin
    {
        string Name { get; }
        string Version { get; }
        int MajorVersion { get; }
        int MinorVersion { get; }

        UserControl Init();
    }
}
