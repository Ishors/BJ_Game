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
            this.flowLayoutPanel_dealer = new System.Windows.Forms.FlowLayoutPanel();
            this.button_hit = new System.Windows.Forms.Button();
            this.button_stand = new System.Windows.Forms.Button();
            this.label_bet = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_player = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_go = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel_bank = new System.Windows.Forms.FlowLayoutPanel();
            this.label_cash = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ptotal = new System.Windows.Forms.Label();
            this.label_dtotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_dealer
            // 
            this.flowLayoutPanel_dealer.Location = new System.Drawing.Point(313, 3);
            this.flowLayoutPanel_dealer.Name = "flowLayoutPanel_dealer";
            this.flowLayoutPanel_dealer.Size = new System.Drawing.Size(614, 321);
            this.flowLayoutPanel_dealer.TabIndex = 3;
            // 
            // button_hit
            // 
            this.button_hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_hit.Location = new System.Drawing.Point(3, 194);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(80, 50);
            this.button_hit.TabIndex = 4;
            this.button_hit.Text = "Hit";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Visible = false;
            this.button_hit.Click += new System.EventHandler(this.button_hit_Click);
            // 
            // button_stand
            // 
            this.button_stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_stand.Location = new System.Drawing.Point(151, 194);
            this.button_stand.Name = "button_stand";
            this.button_stand.Size = new System.Drawing.Size(80, 50);
            this.button_stand.TabIndex = 5;
            this.button_stand.Text = "Stand";
            this.button_stand.UseVisualStyleBackColor = true;
            this.button_stand.Visible = false;
            this.button_stand.Click += new System.EventHandler(this.button_stand_Click);
            // 
            // label_bet
            // 
            this.label_bet.AutoSize = true;
            this.label_bet.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_bet.Location = new System.Drawing.Point(3, 0);
            this.label_bet.Name = "label_bet";
            this.label_bet.Size = new System.Drawing.Size(602, 17);
            this.label_bet.TabIndex = 9;
            this.label_bet.Text = "Bet: ";
            this.label_bet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 741);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(930, 402);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel_player, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(313, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(614, 396);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // flowLayoutPanel_player
            // 
            this.flowLayoutPanel_player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_player.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_player.Name = "flowLayoutPanel_player";
            this.flowLayoutPanel_player.Size = new System.Drawing.Size(608, 291);
            this.flowLayoutPanel_player.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.button_go, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label_bet, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 300);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(608, 93);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // button_go
            // 
            this.button_go.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_go.Location = new System.Drawing.Point(3, 49);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(602, 27);
            this.button_go.TabIndex = 11;
            this.button_go.Text = "New game";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Visible = false;
            this.button_go.Click += new System.EventHandler(this.button_go_Click_1);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel_bank, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label_cash, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(304, 396);
            this.tableLayoutPanel7.TabIndex = 10;
            // 
            // flowLayoutPanel_bank
            // 
            this.flowLayoutPanel_bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_bank.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_bank.Name = "flowLayoutPanel_bank";
            this.flowLayoutPanel_bank.Size = new System.Drawing.Size(298, 291);
            this.flowLayoutPanel_bank.TabIndex = 10;
            // 
            // label_cash
            // 
            this.label_cash.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_cash.Location = new System.Drawing.Point(3, 297);
            this.label_cash.Name = "label_cash";
            this.label_cash.Size = new System.Drawing.Size(298, 29);
            this.label_cash.TabIndex = 9;
            this.label_cash.Text = "Remaining: ";
            this.label_cash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel_dealer, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(930, 327);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel4.Controls.Add(this.button_hit, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.button_stand, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label_ptotal, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_dtotal, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(939, 336);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(306, 402);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // label_ptotal
            // 
            this.label_ptotal.AutoSize = true;
            this.label_ptotal.Location = new System.Drawing.Point(3, 0);
            this.label_ptotal.Name = "label_ptotal";
            this.label_ptotal.Size = new System.Drawing.Size(87, 17);
            this.label_ptotal.TabIndex = 6;
            this.label_ptotal.Text = "Player total: ";
            this.label_ptotal.Visible = false;
            // 
            // label_dtotal
            // 
            this.label_dtotal.AutoSize = true;
            this.label_dtotal.Location = new System.Drawing.Point(151, 0);
            this.label_dtotal.Name = "label_dtotal";
            this.label_dtotal.Size = new System.Drawing.Size(85, 17);
            this.label_dtotal.TabIndex = 7;
            this.label_dtotal.Text = "Dealer total:";
            this.label_dtotal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1267, 789);
            this.MinimumSize = new System.Drawing.Size(1266, 788);
            this.Name = "Form1";
            this.Text = "Best BlackJack Game Ever";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_dealer;
        private System.Windows.Forms.Button button_hit;
        private System.Windows.Forms.Button button_stand;
        private System.Windows.Forms.Label label_bet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_player;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label_cash;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_bank;
        private System.Windows.Forms.Label label_ptotal;
        private System.Windows.Forms.Label label_dtotal;
    }
}

