namespace CarLotApp
{
    partial class CarLotForm
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
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            addCarbtn = new Button();
            createShopperbtn = new Button();
            shopperMoney = new Label();
            shopperName = new Label();
            purchaseBtn = new Button();
            invBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 0;
            label1.Text = "Car Lot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 42);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Cars:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(21, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(274, 274);
            listBox1.TabIndex = 2;
            // 
            // addCarbtn
            // 
            addCarbtn.Location = new Point(355, 60);
            addCarbtn.Name = "addCarbtn";
            addCarbtn.Size = new Size(75, 23);
            addCarbtn.TabIndex = 3;
            addCarbtn.Text = "Add Car";
            addCarbtn.UseVisualStyleBackColor = true;
            addCarbtn.Click += addCarbtn_Click;
            // 
            // createShopperbtn
            // 
            createShopperbtn.Location = new Point(462, 60);
            createShopperbtn.Name = "createShopperbtn";
            createShopperbtn.Size = new Size(75, 23);
            createShopperbtn.TabIndex = 4;
            createShopperbtn.Text = "Create Shopper";
            createShopperbtn.UseVisualStyleBackColor = true;
            createShopperbtn.Click += createShopperbtn_Click;
            // 
            // shopperMoney
            // 
            shopperMoney.AutoSize = true;
            shopperMoney.Location = new Point(628, 27);
            shopperMoney.Name = "shopperMoney";
            shopperMoney.Size = new Size(34, 15);
            shopperMoney.TabIndex = 5;
            shopperMoney.Text = "$0.00";
            shopperMoney.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // shopperName
            // 
            shopperName.AutoSize = true;
            shopperName.Location = new Point(533, 27);
            shopperName.Name = "shopperName";
            shopperName.Size = new Size(89, 15);
            shopperName.TabIndex = 6;
            shopperName.Text = "Shopper Name:";
            shopperName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // purchaseBtn
            // 
            purchaseBtn.Location = new Point(569, 60);
            purchaseBtn.Name = "purchaseBtn";
            purchaseBtn.Size = new Size(75, 23);
            purchaseBtn.TabIndex = 7;
            purchaseBtn.Text = "Purchase Car";
            purchaseBtn.UseVisualStyleBackColor = true;
            purchaseBtn.Click += purchaseBtn_Click;
            // 
            // invBtn
            // 
            invBtn.Location = new Point(462, 112);
            invBtn.Name = "invBtn";
            invBtn.Size = new Size(75, 23);
            invBtn.TabIndex = 8;
            invBtn.Text = "Details";
            invBtn.UseVisualStyleBackColor = true;
            invBtn.Click += invBtn_Click;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 372);
            Controls.Add(invBtn);
            Controls.Add(purchaseBtn);
            Controls.Add(shopperName);
            Controls.Add(shopperMoney);
            Controls.Add(createShopperbtn);
            Controls.Add(addCarbtn);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CarLotForm";
            Text = "CarLotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button addCarbtn;
        private Button createShopperbtn;
        public Label shopperMoney;
        public Label shopperName;
        private Button purchaseBtn;
        private Button invBtn;
    }
}