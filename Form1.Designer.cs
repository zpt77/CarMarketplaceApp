
namespace CarMarketplaceApp
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
            this.carsGrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.MakeAddText = new System.Windows.Forms.TextBox();
            this.ModelAddText = new System.Windows.Forms.TextBox();
            this.EngAddText = new System.Windows.Forms.TextBox();
            this.YearAddText = new System.Windows.Forms.TextBox();
            this.PriceAddText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinEngSearchText = new System.Windows.Forms.TextBox();
            this.ModelSearchText = new System.Windows.Forms.TextBox();
            this.MakeSearchText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.MaxEngSearchText = new System.Windows.Forms.TextBox();
            this.MinYearSearchText = new System.Windows.Forms.TextBox();
            this.MaxYearSearchText = new System.Windows.Forms.TextBox();
            this.MinPriceSearchText = new System.Windows.Forms.TextBox();
            this.MaxPriceSearchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // carsGrid
            // 
            this.carsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsGrid.Location = new System.Drawing.Point(12, 12);
            this.carsGrid.Name = "carsGrid";
            this.carsGrid.Size = new System.Drawing.Size(544, 426);
            this.carsGrid.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(667, 398);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Dodaj";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MakeAddText
            // 
            this.MakeAddText.Location = new System.Drawing.Point(645, 267);
            this.MakeAddText.Name = "MakeAddText";
            this.MakeAddText.Size = new System.Drawing.Size(118, 20);
            this.MakeAddText.TabIndex = 2;
            // 
            // ModelAddText
            // 
            this.ModelAddText.Location = new System.Drawing.Point(645, 294);
            this.ModelAddText.Name = "ModelAddText";
            this.ModelAddText.Size = new System.Drawing.Size(118, 20);
            this.ModelAddText.TabIndex = 3;
            // 
            // EngAddText
            // 
            this.EngAddText.Location = new System.Drawing.Point(645, 320);
            this.EngAddText.Name = "EngAddText";
            this.EngAddText.Size = new System.Drawing.Size(118, 20);
            this.EngAddText.TabIndex = 4;
            // 
            // YearAddText
            // 
            this.YearAddText.Location = new System.Drawing.Point(645, 346);
            this.YearAddText.Name = "YearAddText";
            this.YearAddText.Size = new System.Drawing.Size(118, 20);
            this.YearAddText.TabIndex = 5;
            // 
            // PriceAddText
            // 
            this.PriceAddText.Location = new System.Drawing.Point(645, 372);
            this.PriceAddText.Name = "PriceAddText";
            this.PriceAddText.Size = new System.Drawing.Size(118, 20);
            this.PriceAddText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Poj. silnika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rok produkcji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cena";
            // 
            // MinEngSearchText
            // 
            this.MinEngSearchText.Location = new System.Drawing.Point(658, 131);
            this.MinEngSearchText.Name = "MinEngSearchText";
            this.MinEngSearchText.Size = new System.Drawing.Size(56, 20);
            this.MinEngSearchText.TabIndex = 14;
            // 
            // ModelSearchText
            // 
            this.ModelSearchText.Location = new System.Drawing.Point(658, 102);
            this.ModelSearchText.Name = "ModelSearchText";
            this.ModelSearchText.Size = new System.Drawing.Size(118, 20);
            this.ModelSearchText.TabIndex = 13;
            // 
            // MakeSearchText
            // 
            this.MakeSearchText.Location = new System.Drawing.Point(658, 75);
            this.MakeSearchText.Name = "MakeSearchText";
            this.MakeSearchText.Size = new System.Drawing.Size(118, 20);
            this.MakeSearchText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Marka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(720, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Max. Poj. silnika";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Min. Poj. silnika";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(720, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Max. Rok produkcji";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Min. Rok produkcji";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(720, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Max. Cena";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(585, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Min. Cena";
            // 
            // MaxEngSearchText
            // 
            this.MaxEngSearchText.Location = new System.Drawing.Point(819, 131);
            this.MaxEngSearchText.Name = "MaxEngSearchText";
            this.MaxEngSearchText.Size = new System.Drawing.Size(56, 20);
            this.MaxEngSearchText.TabIndex = 25;
            // 
            // MinYearSearchText
            // 
            this.MinYearSearchText.Location = new System.Drawing.Point(658, 157);
            this.MinYearSearchText.Name = "MinYearSearchText";
            this.MinYearSearchText.Size = new System.Drawing.Size(56, 20);
            this.MinYearSearchText.TabIndex = 26;
            // 
            // MaxYearSearchText
            // 
            this.MaxYearSearchText.Location = new System.Drawing.Point(819, 157);
            this.MaxYearSearchText.Name = "MaxYearSearchText";
            this.MaxYearSearchText.Size = new System.Drawing.Size(56, 20);
            this.MaxYearSearchText.TabIndex = 27;
            // 
            // MinPriceSearchText
            // 
            this.MinPriceSearchText.Location = new System.Drawing.Point(658, 183);
            this.MinPriceSearchText.Name = "MinPriceSearchText";
            this.MinPriceSearchText.Size = new System.Drawing.Size(56, 20);
            this.MinPriceSearchText.TabIndex = 28;
            // 
            // MaxPriceSearchText
            // 
            this.MaxPriceSearchText.Location = new System.Drawing.Point(819, 183);
            this.MaxPriceSearchText.Name = "MaxPriceSearchText";
            this.MaxPriceSearchText.Size = new System.Drawing.Size(56, 20);
            this.MaxPriceSearchText.TabIndex = 29;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(668, 222);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 30;
            this.Search.Text = "Szukaj";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(613, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(215, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Komis samochodowy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.MaxPriceSearchText);
            this.Controls.Add(this.MinPriceSearchText);
            this.Controls.Add(this.MaxYearSearchText);
            this.Controls.Add(this.MinYearSearchText);
            this.Controls.Add(this.MaxEngSearchText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinEngSearchText);
            this.Controls.Add(this.ModelSearchText);
            this.Controls.Add(this.MakeSearchText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceAddText);
            this.Controls.Add(this.YearAddText);
            this.Controls.Add(this.EngAddText);
            this.Controls.Add(this.ModelAddText);
            this.Controls.Add(this.MakeAddText);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.carsGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.carsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsGrid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox MakeAddText;
        private System.Windows.Forms.TextBox ModelAddText;
        private System.Windows.Forms.TextBox EngAddText;
        private System.Windows.Forms.TextBox YearAddText;
        private System.Windows.Forms.TextBox PriceAddText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinEngSearchText;
        private System.Windows.Forms.TextBox ModelSearchText;
        private System.Windows.Forms.TextBox MakeSearchText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MaxEngSearchText;
        private System.Windows.Forms.TextBox MinYearSearchText;
        private System.Windows.Forms.TextBox MaxYearSearchText;
        private System.Windows.Forms.TextBox MinPriceSearchText;
        private System.Windows.Forms.TextBox MaxPriceSearchText;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label14;
    }
}

