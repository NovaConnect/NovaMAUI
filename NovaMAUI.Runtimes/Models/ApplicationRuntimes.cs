using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using NovaMAUI.Runtimes.Models;
using NovaMAUI.Runtimes.Models.Enum;

namespace NovaMAUI.Runtimes
{
    public class ApplicationRuntimes
    {

        public static ScreenRatio ScreenRatioType { get; set; }

        public static bool Loaded { get; set; } = false;
        public static object? Theme { get; set; } = "Dark";
        public static bool IsInti { get; set; } = false;
        public static NavItem[] ?NavItems { get; set; } = new NavItem[]{};
    }
}
