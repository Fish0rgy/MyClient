using MyClient.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient.Modules.Example
{
     class ToggleButtonExample : BaseModule
    {
        //again if you want a custom icon or set icon already made by VRChat repalce "null" with "SDK.ButtonAPI.QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.example)"

        //format of button "public ClassName() : base("name of button","discription of toggle button",main.Instance.NestedButton,icon,toggle true or false) {}
        public ToggleButtonExample() : base("Toggle Button", "Discription", Main.Instance.ExampleButton, null, true) { }

        //OnEnable() is for executing code when toggle is enabled
        public override void OnEnable()
        {
            LogHandler.Log(LogHandler.Colors.Green, "on", false, false);
        }

        //OnDisable() is for executing code when toggle is Disabled
        public override void OnDisable()
        {
            LogHandler.Log(LogHandler.Colors.Green, "off", false, false);
        }
    }
}
