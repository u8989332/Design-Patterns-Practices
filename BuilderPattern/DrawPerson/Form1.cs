using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawPerson
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen p = new Pen(Color.Red);
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearGraphics();
            PersonDirector.CreatePerson(new PersonFatBuilder(g, p));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearGraphics();
            PersonDirector.CreatePerson(new PersonThinBuilder(g, p));
        }

        private void ClearGraphics()
        {
            g.Clear(this.BackColor);
        }
    }
}
