namespace CarLotApp
{
    partial class NewShopper
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
            newNameLabel = new Label();
            moneyText = new TextBox();
            newShopperMoney = new Label();
            newShopperOkBtn = new Button();
            nameText = new TextBox();
            SuspendLayout();
            // 
            // newNameLabel
            // 
            newNameLabel.AutoSize = true;
            newNameLabel.Location = new Point(12, 16);
            newNameLabel.Name = "newNameLabel";
            newNameLabel.Size = new Size(89, 15);
            newNameLabel.TabIndex = 4;
            newNameLabel.Text = "Shopper Name:";
            // 
            // moneyText
            // 
            moneyText.Location = new Point(105, 51);
            moneyText.Name = "moneyText";
            moneyText.Size = new Size(100, 23);
            moneyText.TabIndex = 1;
            // 
            // newShopperMoney
            // 
            newShopperMoney.AutoSize = true;
            newShopperMoney.Location = new Point(5, 54);
            newShopperMoney.Name = "newShopperMoney";
            newShopperMoney.Size = new Size(94, 15);
            newShopperMoney.TabIndex = 1;
            newShopperMoney.Text = "Shopper Money:";
            // 
            // newShopperOkBtn
            // 
            newShopperOkBtn.Location = new Point(70, 101);
            newShopperOkBtn.Name = "newShopperOkBtn";
            newShopperOkBtn.Size = new Size(75, 23);
            newShopperOkBtn.TabIndex = 2;
            newShopperOkBtn.Text = "OK";
            newShopperOkBtn.UseVisualStyleBackColor = true;
            newShopperOkBtn.Click += newShopperOkBtn_Click;
            // 
            // nameText
            // 
            nameText.Location = new Point(107, 13);
            nameText.Name = "nameText";
            nameText.Size = new Size(100, 23);
            nameText.TabIndex = 0;
            // 
            // NewShopper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 151);
            Controls.Add(nameText);
            Controls.Add(newShopperOkBtn);
            Controls.Add(newShopperMoney);
            Controls.Add(moneyText);
            Controls.Add(newNameLabel);
            Name = "NewShopper";
            Text = "NewShopper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newNameLabel;
        private TextBox textBox1;
        private TextBox moneyText;
        private Label newShopperMoney;
        private Button newShopperOkBtn;
        private TextBox nameText;
    }
}