using MyClient.SDK.ButtonAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MyClient.Modules
{
    internal class BaseModule
    {
        public string name;
        public bool toggled;
        public bool save;

        string discription;
        QMNestedButton category;
        bool isToggle;
        Sprite image;

        //format of Buttons 
        public BaseModule(string name, string discription, QMNestedButton category, Sprite image = null, bool isToggle = false)
        {
            this.name = name;
            this.discription = discription;
            this.category = category;
            this.isToggle = isToggle; 
            this.image = image;
        }

        public virtual void OnEnable()
        {

        }

        public virtual void OnDisable()
        {

        }



        public virtual void OnPreferencesSaved()
        {

        }

        public virtual void OnUIInit()
        {
            if (isToggle)
            {
                QMToggleButton qMToggleButton = new QMToggleButton(category.menuTransform, name, discription, new Action<bool>((bool state) =>
                {
                    this.toggled = state;
                    if (state)
                    {
                        OnEnable();
                    }
                    else
                    {
                        OnDisable();
                    }
                    Main.Instance.OnUpdateEventArray = Main.Instance.OnUpdateEvents.ToArray();

                }));
            }
            else
            {
                new QMSingleButton(category.menuTransform, name, discription, image, delegate
                {
                    OnEnable();
                });
            }
        }
    }
}
