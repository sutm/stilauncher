using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace WPFUserControl
{
    public static class WpfExtensions
    {
        // Helper class to wrap the HWND of WPF window
        // for passing to modal Windows Form dialog
        public class OwnerWindow : IWin32Window
        {
            private readonly IntPtr _handle;

            public OwnerWindow(IntPtr handle)
            {
                _handle = handle;
            }

            public IntPtr Handle
            {
                get { return _handle; }
            }
        }

        public static IWin32Window GetIWin32Window(Window parent)
        {
            var helper = new System.Windows.Interop.WindowInteropHelper(parent);
            var owner = new OwnerWindow(helper.Handle);
            return owner;
        }
    }
}
