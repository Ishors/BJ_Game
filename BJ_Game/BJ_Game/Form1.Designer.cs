namespace BJ_Game
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel_player = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_dealer = new System.Windows.Forms.FlowLayoutPanel();
            this.button_hit = new System.Windows.Forms.Button();
            this.button_stand = new System.Windows.Forms.Button();
            this.button_go = new System.Windows.Forms.Button();
            this.groupBox_bank = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_player
            // 
            this.flowLayoutPanel_player.Location = new System.Drawing.Point(240, 235);
            this.flowLayoutPanel_player.Name = "flowLayoutPanel_player";
            this.flowLayoutPanel_player.Size = new System.Drawing.Size(354, 239);
            this.flowLayoutPanel_player.TabIndex = 2;
            // 
            // flowLayoutPanel_dealer
            // 
            this.flowLayoutPanel_dealer.Location = new System.Drawing.Point(237, 12);
            this.flowLayoutPanel_dealer.Name = "flowLayoutPanel_dealer";
            this.flowLayoutPanel_dealer.Size = new System.Drawing.Size(357, 217);
            this.flowLayoutPanel_dealer.TabIndex = 3;
            // 
            // button_hit
            // 
            this.button_hit.Enabled = false;
            this.button_hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_hit.Location = new System.Drawing.Point(661, 235);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(120, 78);
            this.button_hit.TabIndex = 4;
            this.button_hit.Text = "Hit";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Visible = false;
            // 
            // button_stand
            // 
            this.button_stand.Enabled = false;
            this.button_stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_stand.Location = new System.Drawing.Point(661, 336);
            this.button_stand.Name = "button_stand";
            this.button_stand.Size = new System.Drawing.Size(120, 78);
            this.button_stand.TabIndex = 5;
            this.button_stand.Text = "Stand";
            this.button_stand.UseVisualStyleBackColor = true;
            this.button_stand.Visible = false;
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(286, 480);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(241, 28);
            this.button_go.TabIndex = 6;
            this.button_go.Text = "Let\'s go !";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // groupBox_bank
            // 
            this.groupBox_bank.Location = new System.Drawing.Point(12, 246);
            this.groupBox_bank.Name = "groupBox_bank";
            this.groupBox_bank.Size = new System.Drawing.Size(216, 158);
            this.groupBox_bank.TabIndex = 8;
            this.groupBox_bank.TabStop = false;
            this.groupBox_bank.Text = "Banque";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 542);
            this.Controls.Add(this.groupBox_bank);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.button_stand);
            this.Controls.Add(this.button_hit);
            this.Controls.Add(this.flowLayoutPanel_dealer);
            this.Controls.Add(this.flowLayoutPanel_player);
            this.Name = "Form1";
            this.Text = "Best BlackJack Game Ever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_player;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_dealer;
        private System.Windows.Forms.Button button_hit;
        private System.Windows.Forms.Button button_stand;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.GroupBox groupBox_bank;
    }
}

