using System.Globalization;

namespace Vurma_Cedveli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int reqem = 0;
            int saycag = 10;
            for (int j = 0; j < saycag / 2; j++) {
                for (int i = 0; i < saycag / 2; i++ )
                {
                    reqem++;
                    Button btn = new Button();
                    int cavab = 1 * reqem;
                    btn.Text = $"1*" + reqem + "=" + cavab;
                    btn.BackColor = Color.White;
                    btn.Location = new System.Drawing.Point(j*450, i * 80);
                    btn.Size = new System.Drawing.Size(332, 62);
                    btn.Name = $"txtbtn{i}";
                    this.Controls.Add(btn);
                    panel1.Controls.Add(btn);

                }

            }
        }
    }
}