namespace PartyPlanning
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberPeopleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberPeopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FantazyDecorationCheckBox = new System.Windows.Forms.CheckBox();
            this.HealthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPeopleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberPeopleLabel
            // 
            this.NumberPeopleLabel.AutoSize = true;
            this.NumberPeopleLabel.Location = new System.Drawing.Point(12, 9);
            this.NumberPeopleLabel.Name = "NumberPeopleLabel";
            this.NumberPeopleLabel.Size = new System.Drawing.Size(64, 13);
            this.NumberPeopleLabel.TabIndex = 0;
            this.NumberPeopleLabel.Text = "Liczba osób";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koszt:";
            // 
            // NumberPeopleNumericUpDown
            // 
            this.NumberPeopleNumericUpDown.Location = new System.Drawing.Point(15, 25);
            this.NumberPeopleNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberPeopleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberPeopleNumericUpDown.Name = "NumberPeopleNumericUpDown";
            this.NumberPeopleNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.NumberPeopleNumericUpDown.TabIndex = 2;
            this.NumberPeopleNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberPeopleNumericUpDown.ValueChanged += new System.EventHandler(this.NumberPeopleNumericUpDown_ValueChanged);
            // 
            // FantazyDecorationCheckBox
            // 
            this.FantazyDecorationCheckBox.AutoSize = true;
            this.FantazyDecorationCheckBox.Location = new System.Drawing.Point(15, 51);
            this.FantazyDecorationCheckBox.Name = "FantazyDecorationCheckBox";
            this.FantazyDecorationCheckBox.Size = new System.Drawing.Size(126, 17);
            this.FantazyDecorationCheckBox.TabIndex = 3;
            this.FantazyDecorationCheckBox.Text = "Dekoracje fantazyjne";
            this.FantazyDecorationCheckBox.UseVisualStyleBackColor = true;
            this.FantazyDecorationCheckBox.CheckedChanged += new System.EventHandler(this.FantazyDecorationCheckBox_CheckedChanged);
            // 
            // HealthyOptionCheckBox
            // 
            this.HealthyOptionCheckBox.AutoSize = true;
            this.HealthyOptionCheckBox.Location = new System.Drawing.Point(15, 74);
            this.HealthyOptionCheckBox.Name = "HealthyOptionCheckBox";
            this.HealthyOptionCheckBox.Size = new System.Drawing.Size(91, 17);
            this.HealthyOptionCheckBox.TabIndex = 4;
            this.HealthyOptionCheckBox.Text = "Opcja zdrowa";
            this.HealthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.HealthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.HealthyOptionCheckBox_CheckedChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(53, 101);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 136);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.HealthyOptionCheckBox);
            this.Controls.Add(this.FantazyDecorationCheckBox);
            this.Controls.Add(this.NumberPeopleNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberPeopleLabel);
            this.Name = "Form1";
            this.Text = "Planista Przyjęć";
            ((System.ComponentModel.ISupportInitialize)(this.NumberPeopleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberPeopleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberPeopleNumericUpDown;
        private System.Windows.Forms.CheckBox FantazyDecorationCheckBox;
        private System.Windows.Forms.CheckBox HealthyOptionCheckBox;
        private System.Windows.Forms.TextBox CostTextBox;
    }
}

