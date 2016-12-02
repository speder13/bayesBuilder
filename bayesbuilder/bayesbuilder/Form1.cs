using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bayesbuilder
{
    public partial class Form1 : Form
    {
        string[] emptyImages;
        string[] ballImages;
        string[] errorImages;

        public Form1()
        {
            InitializeComponent();
        }
        private void load_files()
        {
            emptyImages = Directory.GetFiles("images/Empty/", "*.*");
            ballImages = Directory.GetFiles("images/Ball/", "*.*");
            errorImages = Directory.GetFiles("images/Error/", "*.*");
        }
        
    }
}
