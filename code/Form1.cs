namespace lab1._1_3sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double lengthBar = double.Parse(txtBoxLengthBar.Text);
            double edgeBarA = double.Parse(txtBoxEdgeBarA.Text);
            double edgeBarB = double.Parse(txtBoxEdgeBarB.Text);
            double lengthCylinder = double.Parse(txtBoxLengthCylinder.Text);
            double radiusCylinder = double.Parse(txtBoxRadiusCylinder.Text);

            if (radiusCylinder > edgeBarA / 2 || radiusCylinder > edgeBarB / 2 || lengthCylinder > lengthBar)
            {
                MessageBox.Show("Условия r <= a/2, r <= b/2, l <= L не выполнены!");
                return;
            }

            double volumeBlock = lengthBar * edgeBarA * edgeBarB;
            double volumeCylinder = Math.PI * radiusCylinder * radiusCylinder * lengthCylinder;
            double volumeWaste = volumeBlock - volumeCylinder;
            double wastePercentage = (volumeWaste / volumeBlock) * 100;

            txtBoxVolumeBar.Text = volumeBlock.ToString("F2");
            txtBoxVolumeCylinder.Text = volumeCylinder.ToString("F2");
            txtBoxWastePercentage.Text = wastePercentage.ToString("F2") + "%";
        }
    }
}
