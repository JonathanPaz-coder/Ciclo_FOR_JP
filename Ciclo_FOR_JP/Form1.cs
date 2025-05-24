namespace Ciclo_FOR_JP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(txtC1V1.Text, out int corredor1_vuelta1);
            int.TryParse(txtC1V2.Text, out int corredor1_vuelta2);
            int.TryParse(txtC2V1.Text, out int corredor2_vuelta1);
            int.TryParse(txtC2V2.Text, out int corredor2_vuelta2);

            int total1 = 0;
            int total2 = 0;

            for (int i = 1; i <= 2; i++)
            {
                if (i == 1)
                {
                    total1 = corredor1_vuelta1 + corredor1_vuelta2;
                }
                else
                {
                    total2 = corredor2_vuelta1 + corredor2_vuelta2;
                }
            }

            MessageBox.Show("Corredor 1 recorrió " + total1 + " kms en total.");
            MessageBox.Show("Corredor 2 recorrió " + total2 + " kms en total.");
        }
    }
}
