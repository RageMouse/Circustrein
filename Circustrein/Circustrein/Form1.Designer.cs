namespace Circustrein
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
            this.lvWagon = new System.Windows.Forms.ListView();
            this.chPointsBenut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnimals = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbSpecies = new System.Windows.Forms.GroupBox();
            this.gbCount = new System.Windows.Forms.GroupBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.numAmountOfAnimals = new System.Windows.Forms.NumericUpDown();
            this.btnAddAnimals = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.chFormaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEetSoort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSize.SuspendLayout();
            this.gbSpecies.SuspendLayout();
            this.gbCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOfAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // lvWagon
            // 
            this.lvWagon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPointsBenut,
            this.chAnimals});
            this.lvWagon.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvWagon.Location = new System.Drawing.Point(452, 0);
            this.lvWagon.Name = "lvWagon";
            this.lvWagon.Size = new System.Drawing.Size(406, 420);
            this.lvWagon.TabIndex = 0;
            this.lvWagon.UseCompatibleStateImageBehavior = false;
            this.lvWagon.View = System.Windows.Forms.View.Details;
            // 
            // chPointsBenut
            // 
            this.chPointsBenut.Text = "Points";
            // 
            // chAnimals
            // 
            this.chAnimals.Text = "Animals";
            this.chAnimals.Width = 200;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.cbSize);
            this.gbSize.Location = new System.Drawing.Point(13, 246);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 80);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Formaat";
            // 
            // gbSpecies
            // 
            this.gbSpecies.Controls.Add(this.cbFood);
            this.gbSpecies.Location = new System.Drawing.Point(219, 246);
            this.gbSpecies.Name = "gbSpecies";
            this.gbSpecies.Size = new System.Drawing.Size(200, 80);
            this.gbSpecies.TabIndex = 2;
            this.gbSpecies.TabStop = false;
            this.gbSpecies.Text = "Soort";
            // 
            // gbCount
            // 
            this.gbCount.Controls.Add(this.numAmountOfAnimals);
            this.gbCount.Location = new System.Drawing.Point(13, 332);
            this.gbCount.Name = "gbCount";
            this.gbCount.Size = new System.Drawing.Size(200, 74);
            this.gbCount.TabIndex = 2;
            this.gbCount.TabStop = false;
            this.gbCount.Text = "Aantal";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(39, 32);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 0;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(42, 32);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 21);
            this.cbFood.TabIndex = 1;
            // 
            // numAmountOfAnimals
            // 
            this.numAmountOfAnimals.Location = new System.Drawing.Point(40, 28);
            this.numAmountOfAnimals.Name = "numAmountOfAnimals";
            this.numAmountOfAnimals.Size = new System.Drawing.Size(120, 20);
            this.numAmountOfAnimals.TabIndex = 0;
            // 
            // btnAddAnimals
            // 
            this.btnAddAnimals.Location = new System.Drawing.Point(238, 360);
            this.btnAddAnimals.Name = "btnAddAnimals";
            this.btnAddAnimals.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnimals.TabIndex = 3;
            this.btnAddAnimals.Text = "Toevoegen";
            this.btnAddAnimals.UseVisualStyleBackColor = true;
            this.btnAddAnimals.Click += new System.EventHandler(this.btnAddAnimals_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(332, 360);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Berekenen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lvAnimals
            // 
            this.lvAnimals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFormaat,
            this.chEetSoort,
            this.chPoints});
            this.lvAnimals.Location = new System.Drawing.Point(12, 12);
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(407, 227);
            this.lvAnimals.TabIndex = 5;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.View = System.Windows.Forms.View.Details;
            // 
            // chFormaat
            // 
            this.chFormaat.Text = "Formaat";
            this.chFormaat.Width = 121;
            // 
            // chEetSoort
            // 
            this.chEetSoort.Text = "Eet Soort";
            this.chEetSoort.Width = 92;
            // 
            // chPoints
            // 
            this.chPoints.Text = "Punten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 420);
            this.Controls.Add(this.lvAnimals);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddAnimals);
            this.Controls.Add(this.gbCount);
            this.Controls.Add(this.gbSpecies);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lvWagon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSpecies.ResumeLayout(false);
            this.gbCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOfAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvWagon;
        private System.Windows.Forms.ColumnHeader chPointsBenut;
        private System.Windows.Forms.ColumnHeader chAnimals;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbSpecies;
        private System.Windows.Forms.GroupBox gbCount;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.NumericUpDown numAmountOfAnimals;
        private System.Windows.Forms.Button btnAddAnimals;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListView lvAnimals;
        private System.Windows.Forms.ColumnHeader chFormaat;
        private System.Windows.Forms.ColumnHeader chEetSoort;
        private System.Windows.Forms.ColumnHeader chPoints;
    }
}

