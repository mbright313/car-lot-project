namespace CarLotApp
{
    partial class AddCarForm
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
            makeLbl = new Label();
            modelLbl = new Label();
            mpgLbl = new Label();
            priceLbl = new Label();
            makeBox = new TextBox();
            modelBox = new TextBox();
            mpgBox = new TextBox();
            priceBox = new TextBox();
            addCarOKBtn = new Button();
            SuspendLayout();
            // 
            // makeLbl
            // 
            makeLbl.AutoSize = true;
            makeLbl.Location = new Point(36, 12);
            makeLbl.Name = "makeLbl";
            makeLbl.Size = new Size(42, 15);
            makeLbl.TabIndex = 0;
            makeLbl.Text = "Make: ";
            // 
            // modelLbl
            // 
            modelLbl.AutoSize = true;
            modelLbl.Location = new Point(36, 48);
            modelLbl.Name = "modelLbl";
            modelLbl.Size = new Size(47, 15);
            modelLbl.TabIndex = 1;
            modelLbl.Text = "Model: ";
            // 
            // mpgLbl
            // 
            mpgLbl.AutoSize = true;
            mpgLbl.Location = new Point(36, 84);
            mpgLbl.Name = "mpgLbl";
            mpgLbl.Size = new Size(39, 15);
            mpgLbl.TabIndex = 2;
            mpgLbl.Text = "MPG: ";
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(36, 120);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(36, 15);
            priceLbl.TabIndex = 3;
            priceLbl.Text = "Price:";
            // 
            // textBox1
            // 
            makeBox.Location = new Point(80, 9);
            makeBox.Name = "textBox1";
            makeBox.Size = new Size(100, 23);
            makeBox.TabIndex = 4;
            // 
            // textBox2
            // 
            modelBox.Location = new Point(80, 45);
            modelBox.Name = "textBox2";
            modelBox.Size = new Size(100, 23);
            modelBox.TabIndex = 5;
            // 
            // textBox3
            // 
            mpgBox.Location = new Point(80, 81);
            mpgBox.Name = "textBox3";
            mpgBox.Size = new Size(100, 23);
            mpgBox.TabIndex = 6;
            // 
            // textBox4
            // 
            priceBox.Location = new Point(80, 117);
            priceBox.Name = "textBox4";
            priceBox.Size = new Size(100, 23);
            priceBox.TabIndex = 7;
            // 
            // addCarOKBtn
            // 
            addCarOKBtn.Location = new Point(71, 166);
            addCarOKBtn.Name = "addCarOKBtn";
            addCarOKBtn.Size = new Size(75, 23);
            addCarOKBtn.TabIndex = 8;
            addCarOKBtn.Text = "OK";
            addCarOKBtn.UseVisualStyleBackColor = true;
            addCarOKBtn.Click += addCarOKBtn_Click;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 215);
            Controls.Add(addCarOKBtn);
            Controls.Add(priceBox);
            Controls.Add(mpgBox);
            Controls.Add(modelBox);
            Controls.Add(makeBox);
            Controls.Add(priceLbl);
            Controls.Add(mpgLbl);
            Controls.Add(modelLbl);
            Controls.Add(makeLbl);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeLbl;
        private Label modelLbl;
        private Label mpgLbl;
        private Label priceLbl;
        private TextBox makeBox;
        private TextBox modelBox;
        private TextBox mpgBox;
        private TextBox priceBox;
        private Button addCarOKBtn;
    }
}