namespace LearningWinForms
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
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.LabelNumberOne = new System.Windows.Forms.Label();
            this.LabelNumberTwo = new System.Windows.Forms.Label();
            this.TextBoxNumberOne = new System.Windows.Forms.TextBox();
            this.TextBoxNumberTwo = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(23, 30);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(92, 30);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(161, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(92, 56);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 2;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // LabelNumberOne
            // 
            this.LabelNumberOne.AutoSize = true;
            this.LabelNumberOne.Location = new System.Drawing.Point(26, 128);
            this.LabelNumberOne.Name = "LabelNumberOne";
            this.LabelNumberOne.Size = new System.Drawing.Size(66, 13);
            this.LabelNumberOne.TabIndex = 3;
            this.LabelNumberOne.Text = "First Number";
            // 
            // LabelNumberTwo
            // 
            this.LabelNumberTwo.AutoSize = true;
            this.LabelNumberTwo.Location = new System.Drawing.Point(26, 175);
            this.LabelNumberTwo.Name = "LabelNumberTwo";
            this.LabelNumberTwo.Size = new System.Drawing.Size(84, 13);
            this.LabelNumberTwo.TabIndex = 4;
            this.LabelNumberTwo.Text = "Second Number";
            // 
            // TextBoxNumberOne
            // 
            this.TextBoxNumberOne.Location = new System.Drawing.Point(98, 128);
            this.TextBoxNumberOne.Name = "TextBoxNumberOne";
            this.TextBoxNumberOne.Size = new System.Drawing.Size(155, 20);
            this.TextBoxNumberOne.TabIndex = 5;
            this.TextBoxNumberOne.TextChanged += new System.EventHandler(this.TextBoxNumberOne_TextChanged);
            // 
            // TextBoxNumberTwo
            // 
            this.TextBoxNumberTwo.Location = new System.Drawing.Point(116, 175);
            this.TextBoxNumberTwo.Name = "TextBoxNumberTwo";
            this.TextBoxNumberTwo.Size = new System.Drawing.Size(137, 20);
            this.TextBoxNumberTwo.TabIndex = 6;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(92, 215);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.Location = new System.Drawing.Point(92, 263);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubtract.TabIndex = 8;
            this.ButtonSubtract.Text = "Subtract";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.ButtonSubtract);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxNumberTwo);
            this.Controls.Add(this.TextBoxNumberOne);
            this.Controls.Add(this.LabelNumberTwo);
            this.Controls.Add(this.LabelNumberOne);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label LabelNumberOne;
        private System.Windows.Forms.Label LabelNumberTwo;
        private System.Windows.Forms.TextBox TextBoxNumberOne;
        private System.Windows.Forms.TextBox TextBoxNumberTwo;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSubtract;
    }
}

