using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace com.leadingsoft.DingChat
{
    public class BaseWindow : Window
    {
        public BaseWindow()
        {
            DefaultStyleKey = typeof(BaseWindow);
            CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand,Close_Window));
        }

        private void Close_Window(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
    }
}
