using Microsoft.VisualStudio.Shell;
using System;
using System.ComponentModel;

namespace MinimalisticViewPlus
{
    public class OptionPage : DialogPage, INotifyPropertyChanged
    {
        Enums.TabVisibilityMode _tabsVisibility = Enums.TabVisibilityMode.Show;
        [DisplayName("Tab visibility")]
        [Description("Controls tab bar visibility: Show (always visible), Always hide (completely hidden).")]
        [TypeConverter(typeof(EnumConverter))]
        public Enums.TabVisibilityMode TabsVisibility
        {
            get
            {
                return _tabsVisibility;
            }
            set
            {
                if (_tabsVisibility == value)
                {
                    return;
                }

                _tabsVisibility = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TabsVisibility)));
            }
        }

        Enums.TitleBarVisibilityMode _titleBarVisibility = Enums.TitleBarVisibilityMode.ShowOnHover;
        [DisplayName("Title bar visibility")]
        [Description("Controls title bar visibility: Show (always visible), or Show on hover (appears when mouse hovers over tab area). " +
            "You can always access title bar using hotkeys such as Alt or Ctrl-Q.")]
        [TypeConverter(typeof(EnumConverter))]
        public Enums.TitleBarVisibilityMode TitleBarVisibility
        {
            get
            {
                return _titleBarVisibility;
            }
            set
            {
                if (_titleBarVisibility == value)
                {
                    return;
                }

                _titleBarVisibility = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TitleBarVisibility)));
            }
        }

        int _collapsedTitleHeight = 4;
        [DisplayName("Collapsed title height")]
        [Description("Height of collapsed title bar. If set to zero removes it completely but menu cannot expand on mouse over.")]
        public int CollapsedTitleHeight
        {
            get
            {
                return _collapsedTitleHeight;
            }
            set
            {
                if (_collapsedTitleHeight == value)
                {
                    return;
                }

                _collapsedTitleHeight = Math.Max(value, 0);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CollapsedTitleHeight)));
            }
        }

        int _mouseEnterDelay = 0;
        [DisplayName("Mouse enter delay")]
        [Description("Delay after mouse enters collapsed menu and before menu pops up, in milliseconds.")]
        public int MouseEnterDelay
        {
            get
            {
                return _mouseEnterDelay;
            }
            set
            {
                if (_mouseEnterDelay == value)
                {
                    return;
                }

                _mouseEnterDelay = Math.Max(value, 0);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MouseEnterDelay)));
            }
        }

        int _mouseLeaveDelay = 0;
        [DisplayName("Mouse leave delay")]
        [Description("Delay after mouse leaves menu and before menu collapses back, in milliseconds.")]
        public int MouseLeaveDelay
        {
            get
            {
                return _mouseLeaveDelay;
            }
            set
            {
                if (_mouseLeaveDelay == value)
                {
                    return;
                }

                _mouseLeaveDelay = Math.Max(value, 0);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MouseLeaveDelay)));
            }
        }

        Enums.ToolbarVisibilityMode _toolbarVisibility = Enums.ToolbarVisibilityMode.ShowOnHover;
        [DisplayName("Toolbar visibility")]
        [Description("Controls toolbar visibility: Show (always visible), Always hide (completely hidden), or Show on hover (appears when mouse hovers over menu area).")]
        [TypeConverter(typeof(EnumConverter))]
        public Enums.ToolbarVisibilityMode ToolbarVisibility
        {
            get
            {
                return _toolbarVisibility;
            }
            set
            {
                if (_toolbarVisibility == value)
                {
                    return;
                }

                _toolbarVisibility = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ToolbarVisibility)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
