using MyClient.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClient.Modules.Example
{
    class SingleButtonExample : BaseModule
    {
        //if you want a custom icon or set icon already made by VRChat repalce "null" with "SDK.ButtonAPI.QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.example)"
        //format of button "public ClassName() : base("name of button","discription of toggle button",main.Instance.NestedButton,icon,toggle true or false) {}
        public SingleButtonExample() : base("Single Button", "discription", Main.Instance.ExampleButton, null, false) { }
        //OnEnable is for when you click the button it executes the code you put inside of it and for single buttons you only need OnEnable and not OnDisable
        public override void OnEnable()
        {
            LogHandler.Log(LogHandler.Colors.Green, "pressed", false, false);
        }
    }
}
