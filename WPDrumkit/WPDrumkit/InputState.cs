

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input.Touch;

namespace WPDrumkit
{
    public class InputState
    {
        public TouchCollection touchState;
        public readonly List<GestureSample> Gestures = new List<GestureSample>();

        public void Update()
        {
            touchState = TouchPanel.GetState();
            Gestures.Clear();
            while (TouchPanel.IsGestureAvailable)
                Gestures.Add(TouchPanel.ReadGesture());
        }
    }
}
