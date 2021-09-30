
namespace Uncle_Petes_Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopTitle = new System.Windows.Forms.TextBox();
            this.PizzaCountTitle = new System.Windows.Forms.Label();
            this.WingCountTitle = new System.Windows.Forms.Label();
            this.GarlicCountTitle = new System.Windows.Forms.Label();
            this.PizzaBox = new System.Windows.Forms.TextBox();
            this.WingBox = new System.Windows.Forms.TextBox();
            this.BreadBox = new System.Windows.Forms.TextBox();
            this.CalcTotalButton = new System.Windows.Forms.Button();
            this.SubTotalTitle = new System.Windows.Forms.Label();
            this.SubTotBox = new System.Windows.Forms.Label();
            this.TaxTitle = new System.Windows.Forms.Label();
            this.TaxBox = new System.Windows.Forms.Label();
            this.TotalTitle = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.Label();
            this.TenderedTitle = new System.Windows.Forms.Label();
            this.PayBox = new System.Windows.Forms.TextBox();
            this.CalcChangeButton = new System.Windows.Forms.Button();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.ReceiptTextBox = new System.Windows.Forms.Label();
            this.CostOfPizza = new System.Windows.Forms.Label();
            this.CostOfWings = new System.Windows.Forms.Label();
            this.CostOfGarlic = new System.Windows.Forms.Label();
            this.AmountChangeTitle = new System.Windows.Forms.Label();
            this.ChangeTitle = new System.Windows.Forms.Label();
            this.Receipt = new System.Windows.Forms.Label();
            this.ReceiptPizza = new System.Windows.Forms.Label();
            this.ReceiptWings = new System.Windows.Forms.Label();
            this.ReceiptGarlic = new System.Windows.Forms.Label();
            this.ReceiptSub = new System.Windows.Forms.Label();
            this.ReceiptTax = new System.Windows.Forms.Label();
            this.ReceiptTotal = new System.Windows.Forms.Label();
            this.ReceiptTend = new System.Windows.Forms.Label();
            this.ReceiptChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopTitle
            // 
            this.TopTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTitle.Location = new System.Drawing.Point(-5, 0);
            this.TopTitle.Name = "TopTitle";
            this.TopTitle.Size = new System.Drawing.Size(388, 40);
            this.TopTitle.TabIndex = 0;
            this.TopTitle.Text = "Uncle Pete\'s Pizza Pit";
            // 
            // PizzaCountTitle
            // 
            this.PizzaCountTitle.AutoSize = true;
            this.PizzaCountTitle.ForeColor = System.Drawing.Color.Yellow;
            this.PizzaCountTitle.Location = new System.Drawing.Point(1, 58);
            this.PizzaCountTitle.Name = "PizzaCountTitle";
            this.PizzaCountTitle.Size = new System.Drawing.Size(96, 13);
            this.PizzaCountTitle.TabIndex = 2;
            this.PizzaCountTitle.Text = "Amount Of Pizzas :";
            // 
            // WingCountTitle
            // 
            this.WingCountTitle.AutoSize = true;
            this.WingCountTitle.ForeColor = System.Drawing.Color.Yellow;
            this.WingCountTitle.Location = new System.Drawing.Point(1, 86);
            this.WingCountTitle.Name = "WingCountTitle";
            this.WingCountTitle.Size = new System.Drawing.Size(134, 13);
            this.WingCountTitle.TabIndex = 3;
            this.WingCountTitle.Text = "Amount Of Wings(1lb per) :";
            // 
            // GarlicCountTitle
            // 
            this.GarlicCountTitle.AutoSize = true;
            this.GarlicCountTitle.ForeColor = System.Drawing.Color.Yellow;
            this.GarlicCountTitle.Location = new System.Drawing.Point(1, 116);
            this.GarlicCountTitle.Name = "GarlicCountTitle";
            this.GarlicCountTitle.Size = new System.Drawing.Size(124, 13);
            this.GarlicCountTitle.TabIndex = 4;
            this.GarlicCountTitle.Text = "Amount Of Garlic Bread :";
            // 
            // PizzaBox
            // 
            this.PizzaBox.Location = new System.Drawing.Point(99, 55);
            this.PizzaBox.Name = "PizzaBox";
            this.PizzaBox.Size = new System.Drawing.Size(36, 20);
            this.PizzaBox.TabIndex = 5;
            // 
            // WingBox
            // 
            this.WingBox.Location = new System.Drawing.Point(141, 86);
            this.WingBox.Name = "WingBox";
            this.WingBox.Size = new System.Drawing.Size(36, 20);
            this.WingBox.TabIndex = 6;
            // 
            // BreadBox
            // 
            this.BreadBox.Location = new System.Drawing.Point(131, 116);
            this.BreadBox.Name = "BreadBox";
            this.BreadBox.Size = new System.Drawing.Size(36, 20);
            this.BreadBox.TabIndex = 7;
            // 
            // CalcTotalButton
            // 
            this.CalcTotalButton.BackColor = System.Drawing.Color.White;
            this.CalcTotalButton.ForeColor = System.Drawing.Color.Black;
            this.CalcTotalButton.Location = new System.Drawing.Point(12, 142);
            this.CalcTotalButton.Name = "CalcTotalButton";
            this.CalcTotalButton.Size = new System.Drawing.Size(154, 18);
            this.CalcTotalButton.TabIndex = 8;
            this.CalcTotalButton.Text = "Calculate Total";
            this.CalcTotalButton.UseVisualStyleBackColor = false;
            this.CalcTotalButton.Click += new System.EventHandler(this.CalcTotalButton_Click);
            // 
            // SubTotalTitle
            // 
            this.SubTotalTitle.AutoSize = true;
            this.SubTotalTitle.ForeColor = System.Drawing.Color.Yellow;
            this.SubTotalTitle.Location = new System.Drawing.Point(12, 173);
            this.SubTotalTitle.Name = "SubTotalTitle";
            this.SubTotalTitle.Size = new System.Drawing.Size(53, 13);
            this.SubTotalTitle.TabIndex = 9;
            this.SubTotalTitle.Text = "Sub Total";
            // 
            // SubTotBox
            // 
            this.SubTotBox.AutoSize = true;
            this.SubTotBox.ForeColor = System.Drawing.Color.Yellow;
            this.SubTotBox.Location = new System.Drawing.Point(128, 173);
            this.SubTotBox.Name = "SubTotBox";
            this.SubTotBox.Size = new System.Drawing.Size(19, 13);
            this.SubTotBox.TabIndex = 10;
            this.SubTotBox.Text = "    ";
            // 
            // TaxTitle
            // 
            this.TaxTitle.AutoSize = true;
            this.TaxTitle.ForeColor = System.Drawing.Color.Yellow;
            this.TaxTitle.Location = new System.Drawing.Point(12, 213);
            this.TaxTitle.Name = "TaxTitle";
            this.TaxTitle.Size = new System.Drawing.Size(25, 13);
            this.TaxTitle.TabIndex = 11;
            this.TaxTitle.Text = "Tax";
            // 
            // TaxBox
            // 
            this.TaxBox.AutoSize = true;
            this.TaxBox.ForeColor = System.Drawing.Color.Yellow;
            this.TaxBox.Location = new System.Drawing.Point(128, 213);
            this.TaxBox.Name = "TaxBox";
            this.TaxBox.Size = new System.Drawing.Size(19, 13);
            this.TaxBox.TabIndex = 12;
            this.TaxBox.Text = "    ";
            // 
            // TotalTitle
            // 
            this.TotalTitle.AutoSize = true;
            this.TotalTitle.ForeColor = System.Drawing.Color.Yellow;
            this.TotalTitle.Location = new System.Drawing.Point(12, 260);
            this.TotalTitle.Name = "TotalTitle";
            this.TotalTitle.Size = new System.Drawing.Size(31, 13);
            this.TotalTitle.TabIndex = 13;
            this.TotalTitle.Text = "Total";
            // 
            // TotalBox
            // 
            this.TotalBox.AutoSize = true;
            this.TotalBox.ForeColor = System.Drawing.Color.Yellow;
            this.TotalBox.Location = new System.Drawing.Point(128, 260);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(19, 13);
            this.TotalBox.TabIndex = 14;
            this.TotalBox.Text = "    ";
            // 
            // TenderedTitle
            // 
            this.TenderedTitle.AutoSize = true;
            this.TenderedTitle.ForeColor = System.Drawing.Color.Red;
            this.TenderedTitle.Location = new System.Drawing.Point(212, 58);
            this.TenderedTitle.Name = "TenderedTitle";
            this.TenderedTitle.Size = new System.Drawing.Size(53, 13);
            this.TenderedTitle.TabIndex = 15;
            this.TenderedTitle.Text = "Tendered";
            // 
            // PayBox
            // 
            this.PayBox.Location = new System.Drawing.Point(271, 55);
            this.PayBox.Name = "PayBox";
            this.PayBox.Size = new System.Drawing.Size(36, 20);
            this.PayBox.TabIndex = 16;
            // 
            // CalcChangeButton
            // 
            this.CalcChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcChangeButton.Location = new System.Drawing.Point(215, 81);
            this.CalcChangeButton.Name = "CalcChangeButton";
            this.CalcChangeButton.Size = new System.Drawing.Size(93, 23);
            this.CalcChangeButton.TabIndex = 17;
            this.CalcChangeButton.Text = "Calculate Change";
            this.CalcChangeButton.UseVisualStyleBackColor = true;
            this.CalcChangeButton.Click += new System.EventHandler(this.CalcChangeButton_Click);
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.Location = new System.Drawing.Point(191, 129);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(144, 30);
            this.ReceiptButton.TabIndex = 18;
            this.ReceiptButton.Text = "Print Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = true;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // ReceiptTextBox
            // 
            this.ReceiptTextBox.AutoSize = true;
            this.ReceiptTextBox.ForeColor = System.Drawing.Color.White;
            this.ReceiptTextBox.Location = new System.Drawing.Point(397, 15);
            this.ReceiptTextBox.Name = "ReceiptTextBox";
            this.ReceiptTextBox.Size = new System.Drawing.Size(13, 13);
            this.ReceiptTextBox.TabIndex = 19;
            this.ReceiptTextBox.Text = "  ";
            // 
            // CostOfPizza
            // 
            this.CostOfPizza.AutoSize = true;
            this.CostOfPizza.Location = new System.Drawing.Point(640, 24);
            this.CostOfPizza.Name = "CostOfPizza";
            this.CostOfPizza.Size = new System.Drawing.Size(118, 13);
            this.CostOfPizza.TabIndex = 20;
            this.CostOfPizza.Text = "The Cost Of Pizza Is $7";
            // 
            // CostOfWings
            // 
            this.CostOfWings.AutoSize = true;
            this.CostOfWings.Location = new System.Drawing.Point(658, 100);
            this.CostOfWings.Name = "CostOfWings";
            this.CostOfWings.Size = new System.Drawing.Size(124, 13);
            this.CostOfWings.TabIndex = 21;
            this.CostOfWings.Text = "The cost of wings are $5";
            // 
            // CostOfGarlic
            // 
            this.CostOfGarlic.AutoSize = true;
            this.CostOfGarlic.Location = new System.Drawing.Point(674, 149);
            this.CostOfGarlic.Name = "CostOfGarlic";
            this.CostOfGarlic.Size = new System.Drawing.Size(144, 13);
            this.CostOfGarlic.TabIndex = 22;
            this.CostOfGarlic.Text = "The cost of garlic bread is $5";
            // 
            // AmountChangeTitle
            // 
            this.AmountChangeTitle.AutoSize = true;
            this.AmountChangeTitle.ForeColor = System.Drawing.Color.Yellow;
            this.AmountChangeTitle.Location = new System.Drawing.Point(244, 113);
            this.AmountChangeTitle.Name = "AmountChangeTitle";
            this.AmountChangeTitle.Size = new System.Drawing.Size(0, 13);
            this.AmountChangeTitle.TabIndex = 23;
            // 
            // ChangeTitle
            // 
            this.ChangeTitle.AutoSize = true;
            this.ChangeTitle.ForeColor = System.Drawing.Color.Red;
            this.ChangeTitle.Location = new System.Drawing.Point(228, 113);
            this.ChangeTitle.Name = "ChangeTitle";
            this.ChangeTitle.Size = new System.Drawing.Size(0, 13);
            this.ChangeTitle.TabIndex = 24;
            // 
            // Receipt
            // 
            this.Receipt.AutoSize = true;
            this.Receipt.BackColor = System.Drawing.Color.White;
            this.Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receipt.Location = new System.Drawing.Point(391, 17);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(180, 300);
            this.Receipt.TabIndex = 25;
            this.Receipt.Text = resources.GetString("Receipt.Text");
            this.Receipt.Visible = false;
            // 
            // ReceiptPizza
            // 
            this.ReceiptPizza.AutoSize = true;
            this.ReceiptPizza.BackColor = System.Drawing.Color.White;
            this.ReceiptPizza.Location = new System.Drawing.Point(536, 93);
            this.ReceiptPizza.Name = "ReceiptPizza";
            this.ReceiptPizza.Size = new System.Drawing.Size(0, 13);
            this.ReceiptPizza.TabIndex = 26;
            // 
            // ReceiptWings
            // 
            this.ReceiptWings.AutoSize = true;
            this.ReceiptWings.BackColor = System.Drawing.Color.White;
            this.ReceiptWings.Location = new System.Drawing.Point(536, 129);
            this.ReceiptWings.Name = "ReceiptWings";
            this.ReceiptWings.Size = new System.Drawing.Size(0, 13);
            this.ReceiptWings.TabIndex = 27;
            // 
            // ReceiptGarlic
            // 
            this.ReceiptGarlic.AutoSize = true;
            this.ReceiptGarlic.BackColor = System.Drawing.Color.White;
            this.ReceiptGarlic.Location = new System.Drawing.Point(545, 158);
            this.ReceiptGarlic.Name = "ReceiptGarlic";
            this.ReceiptGarlic.Size = new System.Drawing.Size(0, 13);
            this.ReceiptGarlic.TabIndex = 28;
            // 
            // ReceiptSub
            // 
            this.ReceiptSub.AutoSize = true;
            this.ReceiptSub.BackColor = System.Drawing.Color.White;
            this.ReceiptSub.Location = new System.Drawing.Point(536, 198);
            this.ReceiptSub.Name = "ReceiptSub";
            this.ReceiptSub.Size = new System.Drawing.Size(0, 13);
            this.ReceiptSub.TabIndex = 29;
            // 
            // ReceiptTax
            // 
            this.ReceiptTax.AutoSize = true;
            this.ReceiptTax.BackColor = System.Drawing.Color.White;
            this.ReceiptTax.Location = new System.Drawing.Point(536, 213);
            this.ReceiptTax.Name = "ReceiptTax";
            this.ReceiptTax.Size = new System.Drawing.Size(0, 13);
            this.ReceiptTax.TabIndex = 30;
            // 
            // ReceiptTotal
            // 
            this.ReceiptTotal.AutoSize = true;
            this.ReceiptTotal.BackColor = System.Drawing.Color.White;
            this.ReceiptTotal.Location = new System.Drawing.Point(536, 235);
            this.ReceiptTotal.Name = "ReceiptTotal";
            this.ReceiptTotal.Size = new System.Drawing.Size(0, 13);
            this.ReceiptTotal.TabIndex = 31;
            // 
            // ReceiptTend
            // 
            this.ReceiptTend.AutoSize = true;
            this.ReceiptTend.BackColor = System.Drawing.Color.White;
            this.ReceiptTend.Location = new System.Drawing.Point(536, 260);
            this.ReceiptTend.Name = "ReceiptTend";
            this.ReceiptTend.Size = new System.Drawing.Size(0, 13);
            this.ReceiptTend.TabIndex = 32;
            // 
            // ReceiptChange
            // 
            this.ReceiptChange.AutoSize = true;
            this.ReceiptChange.BackColor = System.Drawing.Color.White;
            this.ReceiptChange.Location = new System.Drawing.Point(536, 273);
            this.ReceiptChange.Name = "ReceiptChange";
            this.ReceiptChange.Size = new System.Drawing.Size(0, 13);
            this.ReceiptChange.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.ReceiptChange);
            this.Controls.Add(this.ReceiptTend);
            this.Controls.Add(this.ReceiptTotal);
            this.Controls.Add(this.ReceiptTax);
            this.Controls.Add(this.ReceiptSub);
            this.Controls.Add(this.ReceiptGarlic);
            this.Controls.Add(this.ReceiptWings);
            this.Controls.Add(this.ReceiptPizza);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.ChangeTitle);
            this.Controls.Add(this.AmountChangeTitle);
            this.Controls.Add(this.CostOfGarlic);
            this.Controls.Add(this.CostOfWings);
            this.Controls.Add(this.CostOfPizza);
            this.Controls.Add(this.ReceiptTextBox);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.CalcChangeButton);
            this.Controls.Add(this.PayBox);
            this.Controls.Add(this.TenderedTitle);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.TotalTitle);
            this.Controls.Add(this.TaxBox);
            this.Controls.Add(this.TaxTitle);
            this.Controls.Add(this.SubTotBox);
            this.Controls.Add(this.SubTotalTitle);
            this.Controls.Add(this.CalcTotalButton);
            this.Controls.Add(this.BreadBox);
            this.Controls.Add(this.WingBox);
            this.Controls.Add(this.PizzaBox);
            this.Controls.Add(this.GarlicCountTitle);
            this.Controls.Add(this.WingCountTitle);
            this.Controls.Add(this.PizzaCountTitle);
            this.Controls.Add(this.TopTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopTitle;
        private System.Windows.Forms.Label PizzaCountTitle;
        private System.Windows.Forms.Label WingCountTitle;
        private System.Windows.Forms.Label GarlicCountTitle;
        private System.Windows.Forms.TextBox PizzaBox;
        private System.Windows.Forms.TextBox WingBox;
        private System.Windows.Forms.TextBox BreadBox;
        private System.Windows.Forms.Button CalcTotalButton;
        private System.Windows.Forms.Label SubTotalTitle;
        private System.Windows.Forms.Label SubTotBox;
        private System.Windows.Forms.Label TaxTitle;
        private System.Windows.Forms.Label TaxBox;
        private System.Windows.Forms.Label TotalTitle;
        private System.Windows.Forms.Label TotalBox;
        private System.Windows.Forms.Label TenderedTitle;
        private System.Windows.Forms.TextBox PayBox;
        private System.Windows.Forms.Button CalcChangeButton;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Label ReceiptTextBox;
        private System.Windows.Forms.Label CostOfPizza;
        private System.Windows.Forms.Label CostOfWings;
        private System.Windows.Forms.Label CostOfGarlic;
        private System.Windows.Forms.Label AmountChangeTitle;
        private System.Windows.Forms.Label ChangeTitle;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.Label ReceiptPizza;
        private System.Windows.Forms.Label ReceiptWings;
        private System.Windows.Forms.Label ReceiptGarlic;
        private System.Windows.Forms.Label ReceiptSub;
        private System.Windows.Forms.Label ReceiptTax;
        private System.Windows.Forms.Label ReceiptTotal;
        private System.Windows.Forms.Label ReceiptTend;
        private System.Windows.Forms.Label ReceiptChange;
    }
}

