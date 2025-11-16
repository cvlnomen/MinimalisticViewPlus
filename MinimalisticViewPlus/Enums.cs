using System.ComponentModel;

namespace MinimalisticViewPlus
{
    public static class Enums
    {
        public enum TabVisibilityMode
        {
            [Description("Show tabs")]
            Show = 0,
            [Description("Always hide tabs")]
            AlwaysHide = 1
        }

        public enum ToolbarVisibilityMode
        {
            [Description("Show toolbar")]
            Show = 0,
            [Description("Always hide toolbar")]
            AlwaysHide = 1,
            [Description("Show toolbar on hover")]
            ShowOnHover = 2
        }

        public enum TitleBarVisibilityMode
        {
            [Description("Show title bar")]
            Show = 0,
            [Description("Show title bar on hover")]
            ShowOnHover = 2
        }

    }
}
