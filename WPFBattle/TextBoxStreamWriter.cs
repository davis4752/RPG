using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFBattle
{
    class TextBoxStreamWriter : System.IO.TextWriter
    {
        private TextBox textbox;


        public TextBoxStreamWriter(TextBox textbox)
        {
            this.textbox = textbox;
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }

        public override void Write(char value)
        {
            base.Write(value);
            textbox.Dispatcher.BeginInvoke(new Action(() =>
                {
                    textbox.AppendText(value.ToString());
                    textbox.ScrollToEnd();
              })
            ); // When character data is written, append it to the text box.
        }


    }
}
