namespace VehicleAppTestReview
{
    public partial class AddVehicleForm : Form
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int DoorCount { get; private set; }
        public bool HasSideCar { get; private set; }
        // public double Value { get; private set; }

        public bool IsCar { get; private set; }

        public AddVehicleForm()
        {
            InitializeComponent();
            InitGUI();
        }

        public void InitGUI()
        {
            txt_Make.Text = "Honda";
            txt_Model.Text = "Civic";
            num_Year.Value = DateTime.Now.Year;

            num_Door.Minimum = 2;
            num_Door.Maximum = 6;
            num_Door.Value = 4;

            chk_Sidecar.Enabled = false;

            rbtn_Car.Checked = true;
            rbtn_Motorcycle.Checked = false;
        }

        private void rbtn_Motorcycle_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radioButton = sender as RadioButton;
            //if (radioButton.Text == "Car")
            //{
            //    IsCar = true;
            //}

            if (rbtn_Motorcycle.Checked)
            {
                chk_Sidecar.Enabled = true;
                num_Door.Enabled = false;
                IsCar = false;
            }
            else
            {
                chk_Sidecar.Enabled = false;
                num_Door.Enabled = true;
                IsCar = true;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Make = txt_Make.Text;
            Model = txt_Model.Text;
            Year = Convert.ToInt32(num_Year.Value);
            DoorCount = Convert.ToInt32(num_Door.Value);
            HasSideCar = chk_Sidecar.Checked;
            IsCar = rbtn_Car.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}