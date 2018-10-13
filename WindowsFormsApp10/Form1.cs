using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        WindowsMicrophoneMuteLibrary.WindowsMicMute micMute = new WindowsMicrophoneMuteLibrary.WindowsMicMute();
        bool setKey = false;
        string keyBind = "A"; //A = default keybind
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (setKey == true)
            {
                keyBind = e.KeyCode.ToString();
                keyBind_Label.Text = "Current Key: " + keyBind;
                setKey = false;
            }
            if (e.KeyCode.ToString() == keyBind)
            {
                micMute.MuteMic();
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == keyBind)
            {
                micMute.UnMuteMic();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setKey = true;
        }
    }
}
