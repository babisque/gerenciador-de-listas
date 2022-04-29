namespace Aula33_Exercicios
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
            this.lbListas = new System.Windows.Forms.ListBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.rbLists = new System.Windows.Forms.RadioButton();
            this.rbListB = new System.Windows.Forms.RadioButton();
            this.rbListA = new System.Windows.Forms.RadioButton();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbListas
            // 
            this.lbListas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListas.FormattingEnabled = true;
            this.lbListas.ItemHeight = 16;
            this.lbListas.Location = new System.Drawing.Point(12, 123);
            this.lbListas.Name = "lbListas";
            this.lbListas.Size = new System.Drawing.Size(190, 308);
            this.lbListas.TabIndex = 0;
            this.lbListas.SelectedIndexChanged += new System.EventHandler(this.lbListas_SelectedIndexChanged);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(13, 13);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(189, 22);
            this.txtItem.TabIndex = 1;
            // 
            // rbLists
            // 
            this.rbLists.AutoSize = true;
            this.rbLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLists.Location = new System.Drawing.Point(13, 100);
            this.rbLists.Name = "rbLists";
            this.rbLists.Size = new System.Drawing.Size(68, 20);
            this.rbLists.TabIndex = 3;
            this.rbLists.TabStop = true;
            this.rbLists.Text = "Ambas";
            this.rbLists.UseVisualStyleBackColor = true;
            this.rbLists.CheckedChanged += new System.EventHandler(this.rbLists_CheckedChanged);
            // 
            // rbListB
            // 
            this.rbListB.AutoSize = true;
            this.rbListB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbListB.Location = new System.Drawing.Point(13, 77);
            this.rbListB.Name = "rbListB";
            this.rbListB.Size = new System.Drawing.Size(70, 20);
            this.rbListB.TabIndex = 4;
            this.rbListB.TabStop = true;
            this.rbListB.Text = "Lista 02";
            this.rbListB.UseVisualStyleBackColor = true;
            this.rbListB.CheckedChanged += new System.EventHandler(this.rbListB_CheckedChanged);
            // 
            // rbListA
            // 
            this.rbListA.AutoSize = true;
            this.rbListA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbListA.Location = new System.Drawing.Point(13, 54);
            this.rbListA.Name = "rbListA";
            this.rbListA.Size = new System.Drawing.Size(70, 20);
            this.rbListA.TabIndex = 5;
            this.rbListA.TabStop = true;
            this.rbListA.Text = "Lista 01";
            this.rbListA.UseVisualStyleBackColor = true;
            this.rbListA.CheckedChanged += new System.EventHandler(this.rbListA_CheckedChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(208, 13);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 26);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(12, 38);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.rbListA);
            this.Controls.Add(this.rbListB);
            this.Controls.Add(this.rbLists);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lbListas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListas;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.RadioButton rbLists;
        private System.Windows.Forms.RadioButton rbListB;
        private System.Windows.Forms.RadioButton rbListA;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblErro;
    }
}

