namespace lab1._1_3sem
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
            txtBoxLengthBar = new TextBox();
            txtBoxEdgeBarA = new TextBox();
            txtBoxEdgeBarB = new TextBox();
            txtBoxLengthCylinder = new TextBox();
            txtBoxRadiusCylinder = new TextBox();
            lblLengthBar = new Label();
            lblEdgeBarB = new Label();
            lblEdgeBarA = new Label();
            lblLengthCylinder = new Label();
            lblRadiusCylinder = new Label();
            lblVolumeBar = new Label();
            lblVolumeCylinder = new Label();
            lblWastePercentage = new Label();
            txtBoxVolumeBar = new TextBox();
            txtBoxVolumeCylinder = new TextBox();
            txtBoxWastePercentage = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtBoxLengthBar
            // 
            txtBoxLengthBar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxLengthBar.Location = new Point(25, 43);
            txtBoxLengthBar.Name = "txtBoxLengthBar";
            txtBoxLengthBar.Size = new Size(100, 22);
            txtBoxLengthBar.TabIndex = 0;
            // 
            // txtBoxEdgeBarA
            // 
            txtBoxEdgeBarA.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxEdgeBarA.Location = new Point(25, 98);
            txtBoxEdgeBarA.Name = "txtBoxEdgeBarA";
            txtBoxEdgeBarA.Size = new Size(100, 22);
            txtBoxEdgeBarA.TabIndex = 1;
            // 
            // txtBoxEdgeBarB
            // 
            txtBoxEdgeBarB.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxEdgeBarB.Location = new Point(25, 151);
            txtBoxEdgeBarB.Name = "txtBoxEdgeBarB";
            txtBoxEdgeBarB.Size = new Size(100, 22);
            txtBoxEdgeBarB.TabIndex = 2;
            // 
            // txtBoxLengthCylinder
            // 
            txtBoxLengthCylinder.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxLengthCylinder.Location = new Point(25, 207);
            txtBoxLengthCylinder.Name = "txtBoxLengthCylinder";
            txtBoxLengthCylinder.Size = new Size(100, 22);
            txtBoxLengthCylinder.TabIndex = 3;
            // 
            // txtBoxRadiusCylinder
            // 
            txtBoxRadiusCylinder.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxRadiusCylinder.Location = new Point(25, 263);
            txtBoxRadiusCylinder.Name = "txtBoxRadiusCylinder";
            txtBoxRadiusCylinder.Size = new Size(100, 22);
            txtBoxRadiusCylinder.TabIndex = 4;
            // 
            // lblLengthBar
            // 
            lblLengthBar.AutoSize = true;
            lblLengthBar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLengthBar.Location = new Point(25, 24);
            lblLengthBar.Name = "lblLengthBar";
            lblLengthBar.Size = new Size(161, 16);
            lblLengthBar.TabIndex = 5;
            lblLengthBar.Text = "Введите длину бруска (L)";
            // 
            // lblEdgeBarB
            // 
            lblEdgeBarB.AutoSize = true;
            lblEdgeBarB.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEdgeBarB.Location = new Point(25, 132);
            lblEdgeBarB.Name = "lblEdgeBarB";
            lblEdgeBarB.Size = new Size(200, 16);
            lblEdgeBarB.TabIndex = 6;
            lblEdgeBarB.Text = "Введите длину ребра бруска (b)";
            // 
            // lblEdgeBarA
            // 
            lblEdgeBarA.AutoSize = true;
            lblEdgeBarA.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEdgeBarA.Location = new Point(25, 79);
            lblEdgeBarA.Name = "lblEdgeBarA";
            lblEdgeBarA.Size = new Size(194, 16);
            lblEdgeBarA.TabIndex = 7;
            lblEdgeBarA.Text = "Введите длину ребра бруса (a)";
            // 
            // lblLengthCylinder
            // 
            lblLengthCylinder.AutoSize = true;
            lblLengthCylinder.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLengthCylinder.Location = new Point(25, 188);
            lblLengthCylinder.Name = "lblLengthCylinder";
            lblLengthCylinder.Size = new Size(173, 16);
            lblLengthCylinder.TabIndex = 8;
            lblLengthCylinder.Text = "Введите длину цилиндра (l)";
            // 
            // lblRadiusCylinder
            // 
            lblRadiusCylinder.AutoSize = true;
            lblRadiusCylinder.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRadiusCylinder.Location = new Point(25, 244);
            lblRadiusCylinder.Name = "lblRadiusCylinder";
            lblRadiusCylinder.Size = new Size(181, 16);
            lblRadiusCylinder.TabIndex = 9;
            lblRadiusCylinder.Text = "Введите радиус цилиндра (r)";
            // 
            // lblVolumeBar
            // 
            lblVolumeBar.AutoSize = true;
            lblVolumeBar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblVolumeBar.Location = new Point(406, 66);
            lblVolumeBar.Name = "lblVolumeBar";
            lblVolumeBar.Size = new Size(93, 16);
            lblVolumeBar.TabIndex = 10;
            lblVolumeBar.Text = "Объем бруска";
            // 
            // lblVolumeCylinder
            // 
            lblVolumeCylinder.AutoSize = true;
            lblVolumeCylinder.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblVolumeCylinder.Location = new Point(406, 121);
            lblVolumeCylinder.Name = "lblVolumeCylinder";
            lblVolumeCylinder.Size = new Size(109, 16);
            lblVolumeCylinder.TabIndex = 11;
            lblVolumeCylinder.Text = "Объем цилиндра";
            // 
            // lblWastePercentage
            // 
            lblWastePercentage.AutoSize = true;
            lblWastePercentage.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblWastePercentage.Location = new Point(406, 174);
            lblWastePercentage.Name = "lblWastePercentage";
            lblWastePercentage.Size = new Size(252, 16);
            lblWastePercentage.TabIndex = 12;
            lblWastePercentage.Text = "Процент материала, ушедшего в отходы";
            // 
            // txtBoxVolumeBar
            // 
            txtBoxVolumeBar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxVolumeBar.Location = new Point(406, 85);
            txtBoxVolumeBar.Name = "txtBoxVolumeBar";
            txtBoxVolumeBar.Size = new Size(100, 22);
            txtBoxVolumeBar.TabIndex = 13;
            // 
            // txtBoxVolumeCylinder
            // 
            txtBoxVolumeCylinder.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxVolumeCylinder.Location = new Point(406, 140);
            txtBoxVolumeCylinder.Name = "txtBoxVolumeCylinder";
            txtBoxVolumeCylinder.Size = new Size(100, 22);
            txtBoxVolumeCylinder.TabIndex = 14;
            // 
            // txtBoxWastePercentage
            // 
            txtBoxWastePercentage.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBoxWastePercentage.Location = new Point(406, 193);
            txtBoxWastePercentage.Name = "txtBoxWastePercentage";
            txtBoxWastePercentage.Size = new Size(100, 22);
            txtBoxWastePercentage.TabIndex = 15;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCalculate.Location = new Point(275, 121);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(87, 41);
            btnCalculate.TabIndex = 16;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 303);
            Controls.Add(btnCalculate);
            Controls.Add(txtBoxWastePercentage);
            Controls.Add(txtBoxVolumeCylinder);
            Controls.Add(txtBoxVolumeBar);
            Controls.Add(lblWastePercentage);
            Controls.Add(lblVolumeCylinder);
            Controls.Add(lblVolumeBar);
            Controls.Add(lblRadiusCylinder);
            Controls.Add(lblLengthCylinder);
            Controls.Add(lblEdgeBarA);
            Controls.Add(lblEdgeBarB);
            Controls.Add(lblLengthBar);
            Controls.Add(txtBoxRadiusCylinder);
            Controls.Add(txtBoxLengthCylinder);
            Controls.Add(txtBoxEdgeBarB);
            Controls.Add(txtBoxEdgeBarA);
            Controls.Add(txtBoxLengthBar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxLengthBar;
        private TextBox txtBoxEdgeBarA;
        private TextBox txtBoxEdgeBarB;
        private TextBox txtBoxLengthCylinder;
        private TextBox txtBoxRadiusCylinder;
        private Label lblLengthBar;
        private Label lblEdgeBarB;
        private Label lblEdgeBarA;
        private Label lblLengthCylinder;
        private Label lblRadiusCylinder;
        private Label lblVolumeBar;
        private Label lblVolumeCylinder;
        private Label lblWastePercentage;
        private TextBox txtBoxVolumeBar;
        private TextBox txtBoxVolumeCylinder;
        private TextBox txtBoxWastePercentage;
        private Button btnCalculate;
    }
}
