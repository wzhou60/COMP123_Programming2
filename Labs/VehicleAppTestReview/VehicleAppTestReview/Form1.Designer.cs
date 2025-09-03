namespace VehicleAppTestReview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbx_Output = new ListBox();
            btn_StartEngine = new Button();
            btn_AddVehicle = new Button();
            SuspendLayout();
            // 
            // lbx_Output
            // 
            lbx_Output.FormattingEnabled = true;
            lbx_Output.Location = new Point(204, 54);
            lbx_Output.Name = "lbx_Output";
            lbx_Output.Size = new Size(460, 104);
            lbx_Output.TabIndex = 0;
            // 
            // btn_StartEngine
            // 
            btn_StartEngine.Location = new Point(44, 54);
            btn_StartEngine.Name = "btn_StartEngine";
            btn_StartEngine.Size = new Size(120, 42);
            btn_StartEngine.TabIndex = 1;
            btn_StartEngine.Text = "Start Engine";
            btn_StartEngine.UseVisualStyleBackColor = true;
            btn_StartEngine.Click += btn_StartEngine_Click;
            // 
            // btn_AddVehicle
            // 
            btn_AddVehicle.Location = new Point(44, 119);
            btn_AddVehicle.Name = "btn_AddVehicle";
            btn_AddVehicle.Size = new Size(120, 39);
            btn_AddVehicle.TabIndex = 2;
            btn_AddVehicle.Text = "Add Vehicle";
            btn_AddVehicle.UseVisualStyleBackColor = true;
            btn_AddVehicle.Click += btn_AddVehicle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 428);
            Controls.Add(btn_AddVehicle);
            Controls.Add(btn_StartEngine);
            Controls.Add(lbx_Output);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbx_Output;
        private Button btn_StartEngine;
        private Button btn_AddVehicle;
    }
}
