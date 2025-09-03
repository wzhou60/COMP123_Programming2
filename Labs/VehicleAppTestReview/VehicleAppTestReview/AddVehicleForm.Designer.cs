namespace VehicleAppTestReview
{
    partial class AddVehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rbtn_Car = new RadioButton();
            grp_VehicleType = new GroupBox();
            rbtn_Motorcycle = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_Make = new TextBox();
            txt_Model = new TextBox();
            num_Year = new NumericUpDown();
            num_Door = new NumericUpDown();
            chk_Sidecar = new CheckBox();
            btn_OK = new Button();
            btn_Cancel = new Button();
            grp_VehicleType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_Year).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Door).BeginInit();
            SuspendLayout();
            // 
            // rbtn_Car
            // 
            rbtn_Car.AutoSize = true;
            rbtn_Car.Location = new Point(22, 30);
            rbtn_Car.Name = "rbtn_Car";
            rbtn_Car.Size = new Size(52, 24);
            rbtn_Car.TabIndex = 0;
            rbtn_Car.TabStop = true;
            rbtn_Car.Text = "Car";
            rbtn_Car.UseVisualStyleBackColor = true;
            // 
            // grp_VehicleType
            // 
            grp_VehicleType.Controls.Add(rbtn_Motorcycle);
            grp_VehicleType.Controls.Add(rbtn_Car);
            grp_VehicleType.Location = new Point(46, 26);
            grp_VehicleType.Name = "grp_VehicleType";
            grp_VehicleType.Size = new Size(221, 72);
            grp_VehicleType.TabIndex = 1;
            grp_VehicleType.TabStop = false;
            grp_VehicleType.Text = "Vehicle Type";
            // 
            // rbtn_Motorcycle
            // 
            rbtn_Motorcycle.AutoSize = true;
            rbtn_Motorcycle.Location = new Point(99, 30);
            rbtn_Motorcycle.Name = "rbtn_Motorcycle";
            rbtn_Motorcycle.Size = new Size(104, 24);
            rbtn_Motorcycle.TabIndex = 1;
            rbtn_Motorcycle.TabStop = true;
            rbtn_Motorcycle.Text = "Motorcycle";
            rbtn_Motorcycle.UseVisualStyleBackColor = true;
            rbtn_Motorcycle.CheckedChanged += rbtn_Motorcycle_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 126);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 2;
            label1.Text = "Make";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 167);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 207);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 247);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 5;
            label4.Text = "DoorCount";
            // 
            // txt_Make
            // 
            txt_Make.Location = new Point(117, 123);
            txt_Make.Name = "txt_Make";
            txt_Make.Size = new Size(150, 27);
            txt_Make.TabIndex = 6;
            // 
            // txt_Model
            // 
            txt_Model.Location = new Point(117, 163);
            txt_Model.Name = "txt_Model";
            txt_Model.Size = new Size(150, 27);
            txt_Model.TabIndex = 7;
            // 
            // num_Year
            // 
            num_Year.Location = new Point(117, 202);
            num_Year.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            num_Year.Minimum = new decimal(new int[] { 1940, 0, 0, 0 });
            num_Year.Name = "num_Year";
            num_Year.Size = new Size(150, 27);
            num_Year.TabIndex = 8;
            num_Year.Value = new decimal(new int[] { 1940, 0, 0, 0 });
            // 
            // num_Door
            // 
            num_Door.Location = new Point(117, 244);
            num_Door.Name = "num_Door";
            num_Door.Size = new Size(150, 27);
            num_Door.TabIndex = 9;
            // 
            // chk_Sidecar
            // 
            chk_Sidecar.AutoSize = true;
            chk_Sidecar.Location = new Point(92, 294);
            chk_Sidecar.Name = "chk_Sidecar";
            chk_Sidecar.Size = new Size(130, 24);
            chk_Sidecar.TabIndex = 10;
            chk_Sidecar.Text = "Sidecar Option";
            chk_Sidecar.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(46, 348);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(94, 29);
            btn_OK.TabIndex = 11;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(173, 348);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 12;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // AddVehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 406);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(chk_Sidecar);
            Controls.Add(num_Door);
            Controls.Add(num_Year);
            Controls.Add(txt_Model);
            Controls.Add(txt_Make);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grp_VehicleType);
            Name = "AddVehicleForm";
            Text = "AddVehicleForm";
            grp_VehicleType.ResumeLayout(false);
            grp_VehicleType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_Year).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Door).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtn_Car;
        private GroupBox grp_VehicleType;
        private RadioButton rbtn_Motorcycle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Make;
        private TextBox txt_Model;
        private NumericUpDown num_Year;
        private NumericUpDown num_Door;
        private CheckBox chk_Sidecar;
        private Button btn_OK;
        private Button btn_Cancel;
    }
}