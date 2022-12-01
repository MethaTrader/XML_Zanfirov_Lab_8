using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_Zanfirov_Lab_8
{
    public partial class Interaction : Form
    {
        public Interaction(string question)
        {
            InitializeComponent();

            this.TitleInteractionLabel.Text = question ?? "Помилка";
        }
    }
}
