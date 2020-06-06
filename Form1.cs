using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Button> list = new List<Button>();
            for (int i = 0; i < 200; i++)
            {
                Button b = new Button();
                b.Location = new Point(50 * i + 2, 0);//位置自bai己确定du一下zhi
                b.Size = new Size(40, 30);//按钮大小dao
                b.Text = i.ToString();
                list.Add(b);
            }
            this.panel1.Controls.AddRange(list.ToArray());
        }
    }
}
