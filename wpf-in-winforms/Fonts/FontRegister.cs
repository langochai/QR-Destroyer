using System;
using System.Drawing.Text;

namespace wpf_in_winforms.Fonts
{
    internal class FontRegister
    {
        public static PrivateFontCollection JoystickFont = new PrivateFontCollection();
        public static PrivateFontCollection MonoFont = new PrivateFontCollection();

        public static bool Register()
        {
            try
            {
                JoystickFont.AddFontFile("./Fonts/joystix_monospace.otf");
                MonoFont.AddFontFile("./Fonts/LCDM2N__.TTF");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}