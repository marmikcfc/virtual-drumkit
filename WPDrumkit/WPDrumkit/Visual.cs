
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WPDrumkit
{
    /// <summary>
    /// Class which contains the visual information for example about UI colors and fonts
    /// </summary>
    class Visual
    {
        public static SpriteFont defaultFont;
        public static Color defaultFontColor = Color.White;
        public static Color defaultBackgroundColor = Color.Black;
        public static Texture2D defaultTexture;

        public static void LoadContent(ContentManager content, GraphicsDevice graphics)
        {
            defaultFont = content.Load<SpriteFont>("NokiaPureText");
            defaultTexture = new Texture2D(graphics, 1, 1);
            defaultTexture.SetData(new Color[] { defaultBackgroundColor });
        }
    }
}
