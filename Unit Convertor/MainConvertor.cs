using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Convertor
{
    public partial class MainConvertor : Form
    {
        int mov;
        int movX;
        int movY;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public MainConvertor()
        {
            InitializeComponent();
        }

        private void MainConvertor_Load(object sender, EventArgs e)
        {
            Unit_List_Panel.AutoScroll = true;

            Unit_List_Panel.Location = new Point(438, 137);

            Unit_List_Panel.Size = new Size(1079, 913);

            Unit_List_Panel.TabIndex = 0;

            Unit_List_Panel.VerticalScroll.Enabled = false;
            Unit_List_Panel.VerticalScroll.Visible = false;

            combobox1.SelectedIndex = 0;
            combobox2.SelectedIndex = 0;

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void guna2GradientButton15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
          if (combobox1.Text == "단위를 선택하세요" && combobox2.Text == "단위를 선택하세요")
          {
           MessageBox.Show("단위를 선택하셔야 합니다.", "Error[01]");
           }
        }
    }
}
