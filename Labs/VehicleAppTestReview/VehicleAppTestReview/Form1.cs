namespace VehicleAppTestReview
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

        private Vehicle selectedVehicle = null;

        public Form1()
        {
            InitializeComponent();
            InitGUI();
            UpdateVehicleList();
        }

        public void InitGUI()
        {
            Car car1 = new Car("Honda", "Civic", 2019, 4);
            Car car2 = new Car("Ford", "Beetle", 2019, 4);
            Motorcycle motorcycle1 = new Motorcycle("Honda", "Cycle", 2019, true);
            vehicles["CAR001"] = car1;
            string key = "CAR002";
            vehicles.Add(key, car2);
            //vehicles.Add("CAR002", car2);
            //vehicles["CAR002"] = car2;
            vehicles["MOTOR003"] = motorcycle1;

            //vehicles.Add(car1.FullDescription, car1);
            //vehicles.Add(car2.FullDescription, car2);
            //vehicles.Add(motorcycle1.FullDescription, motorcycle1);
        }

        void UpdateVehicleList()
        {
            //foreach (var pair in vehicles)
            lbx_Output.Items.Clear();
            foreach (KeyValuePair<string, Vehicle> pair in vehicles)
            {
                lbx_Output.Items.Add($"{pair.Key}: {pair.Value.FullDescription}");
            }
        }

        private void btn_AddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            int count = lbx_Output.Items.Count;
            if (addVehicleForm.ShowDialog() == DialogResult.OK)
            {
                if (addVehicleForm.IsCar)
                {
                    Car car = new Car(addVehicleForm.Make, addVehicleForm.Model, addVehicleForm.Year, addVehicleForm.DoorCount);
                    vehicles[$"CAR00{count}"] = car;
                }
                else
                {
                    Motorcycle motorcycle = new Motorcycle(addVehicleForm.Make, addVehicleForm.Model, addVehicleForm.Year, addVehicleForm.HasSideCar);
                    vehicles[$"MOTOR00{count}"] = motorcycle;
                }
                UpdateVehicleList();
            }
        }

        private void btn_StartEngine_Click(object sender, EventArgs e)
        {
            if (lbx_Output.SelectedIndex == null || lbx_Output.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a vehicle first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  else {
            string key = lbx_Output.SelectedItem.ToString().Split(":")[0];

            selectedVehicle = vehicles[key];
            lbx_Output.Items.Add(selectedVehicle.StartEngine());
            selectedVehicle.StartEngine();
            //}
        }
    }
}