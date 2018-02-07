using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.leadingsoft.DingChat.ViewModels
{
    [Export,PartCreationPolicy(CreationPolicy.NonShared)]
    public class LoginViewModel : BindableBase
    {
        public String Username { get; set; } = "dagdsg";
        public String Password { get; set; }
    }
}
