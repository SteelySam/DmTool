
namespace DmTool
{
    partial class Form1
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtRandoChecker = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.radWeather = new System.Windows.Forms.RadioButton();
            this.radEncounter = new System.Windows.Forms.RadioButton();
            this.radLoot = new System.Windows.Forms.RadioButton();
            this.radNpc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(436, 218);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(77, 40);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Arctic",
            "Coastal",
            "Desert",
            "Forest",
            "Grassland",
            "Hill",
            "Mountain",
            "Swamp",
            "Underdark",
            "Underwater",
            "Urban"});
            this.cmbLocation.Location = new System.Drawing.Point(36, 105);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbLocation.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(36, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(477, 87);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "Result text will display here bitch...";
            // 
            // txtRandoChecker
            // 
            this.txtRandoChecker.Location = new System.Drawing.Point(413, 105);
            this.txtRandoChecker.Name = "txtRandoChecker";
            this.txtRandoChecker.Size = new System.Drawing.Size(100, 20);
            this.txtRandoChecker.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(336, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radWeather
            // 
            this.radWeather.AutoSize = true;
            this.radWeather.Location = new System.Drawing.Point(36, 144);
            this.radWeather.Name = "radWeather";
            this.radWeather.Size = new System.Drawing.Size(66, 17);
            this.radWeather.TabIndex = 9;
            this.radWeather.TabStop = true;
            this.radWeather.Text = "Weather";
            this.radWeather.UseVisualStyleBackColor = true;
            // 
            // radEncounter
            // 
            this.radEncounter.AutoSize = true;
            this.radEncounter.Location = new System.Drawing.Point(36, 167);
            this.radEncounter.Name = "radEncounter";
            this.radEncounter.Size = new System.Drawing.Size(74, 17);
            this.radEncounter.TabIndex = 10;
            this.radEncounter.TabStop = true;
            this.radEncounter.Text = "Encounter";
            this.radEncounter.UseVisualStyleBackColor = true;
            // 
            // radLoot
            // 
            this.radLoot.AutoSize = true;
            this.radLoot.Location = new System.Drawing.Point(36, 190);
            this.radLoot.Name = "radLoot";
            this.radLoot.Size = new System.Drawing.Size(46, 17);
            this.radLoot.TabIndex = 11;
            this.radLoot.TabStop = true;
            this.radLoot.Text = "Loot";
            this.radLoot.UseVisualStyleBackColor = true;
            // 
            // radNpc
            // 
            this.radNpc.AutoSize = true;
            this.radNpc.Location = new System.Drawing.Point(36, 213);
            this.radNpc.Name = "radNpc";
            this.radNpc.Size = new System.Drawing.Size(47, 17);
            this.radNpc.TabIndex = 12;
            this.radNpc.TabStop = true;
            this.radNpc.Text = "NPC";
            this.radNpc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 285);
            this.Controls.Add(this.radNpc);
            this.Controls.Add(this.radLoot);
            this.Controls.Add(this.radEncounter);
            this.Controls.Add(this.radWeather);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtRandoChecker);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtRandoChecker;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radWeather;
        private System.Windows.Forms.RadioButton radEncounter;
        private System.Windows.Forms.RadioButton radLoot;
        private System.Windows.Forms.RadioButton radNpc;
    }
}

