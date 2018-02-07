﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace com.leadingsoft.DingChat
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    [Export(typeof(LoginWindow))]
    public partial class LoginWindow : BaseWindow
    {
        public LoginWindow()
        {          
            InitializeComponent();
        }
    }
}
