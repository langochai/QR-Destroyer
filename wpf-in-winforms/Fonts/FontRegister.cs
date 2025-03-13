using System.Drawing.Text;

namespace wpf_in_winforms.Fonts
{
    internal class FontRegister
    {
        public static PrivateFontCollection Font = new PrivateFontCollection();

        public static bool Register()
        {
            try
            {
                Font.AddFontFile("./Fonts/joystix_monospace.otf");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}