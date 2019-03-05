namespace RGN_Computerladen
{
    partial class frmMainWindow
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
            this.lblShopItems = new System.Windows.Forms.Label();
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.lvwShopItems = new System.Windows.Forms.ListView();
            this.clmHdrArtikel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrPreis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHdrAnzahl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btBuy = new System.Windows.Forms.Button();
            this.cbSelfConfig = new System.Windows.Forms.CheckBox();
            this.lblShopBeschreibung = new System.Windows.Forms.Label();
            this.lblAioGamingPC = new System.Windows.Forms.Label();
            this.btAioGamingPC = new System.Windows.Forms.Button();
            this.lblAioDescription = new System.Windows.Forms.Label();
            this.btAioExpertPC = new System.Windows.Forms.Button();
            this.lblAioExpertPC = new System.Windows.Forms.Label();
            this.tbFullPrice = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShopItems
            // 
            this.lblShopItems.AutoSize = true;
            this.lblShopItems.Location = new System.Drawing.Point(12, 80);
            this.lblShopItems.Name = "lblShopItems";
            this.lblShopItems.Size = new System.Drawing.Size(60, 13);
            this.lblShopItems.TabIndex = 0;
            this.lblShopItems.Text = "Shop Items";
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.Location = new System.Drawing.Point(12, 9);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(415, 31);
            this.lblWelcomeText.TabIndex = 3;
            this.lblWelcomeText.Text = "Willkommen in Rastla\'s PC Shop!";
            // 
            // lvwShopItems
            // 
            this.lvwShopItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHdrArtikel,
            this.clmHdrPreis,
            this.clmHdrAnzahl});
            this.lvwShopItems.FullRowSelect = true;
            this.lvwShopItems.Location = new System.Drawing.Point(15, 96);
            this.lvwShopItems.MultiSelect = false;
            this.lvwShopItems.Name = "lvwShopItems";
            this.lvwShopItems.Size = new System.Drawing.Size(259, 290);
            this.lvwShopItems.TabIndex = 10;
            this.lvwShopItems.UseCompatibleStateImageBehavior = false;
            this.lvwShopItems.View = System.Windows.Forms.View.Details;
            this.lvwShopItems.DoubleClick += new System.EventHandler(this.lvwShopItems_DoubleClick);
            // 
            // clmHdrArtikel
            // 
            this.clmHdrArtikel.Text = "Artikel";
            this.clmHdrArtikel.Width = 170;
            // 
            // clmHdrPreis
            // 
            this.clmHdrPreis.Text = "Preis";
            this.clmHdrPreis.Width = 50;
            // 
            // clmHdrAnzahl
            // 
            this.clmHdrAnzahl.Text = "Anz.";
            this.clmHdrAnzahl.Width = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gesamtpreis:";
            // 
            // btBuy
            // 
            this.btBuy.Location = new System.Drawing.Point(151, 392);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(49, 23);
            this.btBuy.TabIndex = 12;
            this.btBuy.Text = "Kaufen";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // cbSelfConfig
            // 
            this.cbSelfConfig.AutoSize = true;
            this.cbSelfConfig.Location = new System.Drawing.Point(151, 79);
            this.cbSelfConfig.Name = "cbSelfConfig";
            this.cbSelfConfig.Size = new System.Drawing.Size(123, 17);
            this.cbSelfConfig.TabIndex = 13;
            this.cbSelfConfig.Text = "selbst konfigurieren?";
            this.cbSelfConfig.UseVisualStyleBackColor = true;
            this.cbSelfConfig.CheckedChanged += new System.EventHandler(this.cbSelfConfig_CheckedChanged);
            // 
            // lblShopBeschreibung
            // 
            this.lblShopBeschreibung.AutoSize = true;
            this.lblShopBeschreibung.Location = new System.Drawing.Point(18, 44);
            this.lblShopBeschreibung.Name = "lblShopBeschreibung";
            this.lblShopBeschreibung.Size = new System.Drawing.Size(458, 13);
            this.lblShopBeschreibung.TabIndex = 14;
            this.lblShopBeschreibung.Text = "Sie können wählen ob Sie den PC selbst konfigurieren wollen oder ein All-In-One P" +
    "aket nehmen";
            // 
            // lblAioGamingPC
            // 
            this.lblAioGamingPC.AutoSize = true;
            this.lblAioGamingPC.Location = new System.Drawing.Point(299, 173);
            this.lblAioGamingPC.Name = "lblAioGamingPC";
            this.lblAioGamingPC.Size = new System.Drawing.Size(179, 52);
            this.lblAioGamingPC.TabIndex = 15;
            this.lblAioGamingPC.Text = "Ein neuer PC mit allen Komponenten\r\ndie ein Gamer benötigt. Inklusive\r\nZusammenst" +
    "ellung und erstmaliger\r\nEinrichtung!";
            // 
            // btAioGamingPC
            // 
            this.btAioGamingPC.Location = new System.Drawing.Point(302, 147);
            this.btAioGamingPC.Name = "btAioGamingPC";
            this.btAioGamingPC.Size = new System.Drawing.Size(150, 23);
            this.btAioGamingPC.TabIndex = 16;
            this.btAioGamingPC.Text = "Neuer Gaming PC";
            this.btAioGamingPC.UseVisualStyleBackColor = true;
            this.btAioGamingPC.Click += new System.EventHandler(this.btAioGamingPC_Click);
            // 
            // lblAioDescription
            // 
            this.lblAioDescription.AutoSize = true;
            this.lblAioDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAioDescription.Location = new System.Drawing.Point(299, 96);
            this.lblAioDescription.Name = "lblAioDescription";
            this.lblAioDescription.Size = new System.Drawing.Size(152, 26);
            this.lblAioDescription.TabIndex = 17;
            this.lblAioDescription.Text = "Wählen Sie eines unserer\r\nAll-In-One Pakete:";
            // 
            // btAioExpertPC
            // 
            this.btAioExpertPC.Location = new System.Drawing.Point(302, 252);
            this.btAioExpertPC.Name = "btAioExpertPC";
            this.btAioExpertPC.Size = new System.Drawing.Size(150, 23);
            this.btAioExpertPC.TabIndex = 19;
            this.btAioExpertPC.Text = "Experten-PC";
            this.btAioExpertPC.UseVisualStyleBackColor = true;
            this.btAioExpertPC.Click += new System.EventHandler(this.btAioExpertPC_Click);
            // 
            // lblAioExpertPC
            // 
            this.lblAioExpertPC.AutoSize = true;
            this.lblAioExpertPC.Location = new System.Drawing.Point(299, 278);
            this.lblAioExpertPC.Name = "lblAioExpertPC";
            this.lblAioExpertPC.Size = new System.Drawing.Size(183, 26);
            this.lblAioExpertPC.TabIndex = 18;
            this.lblAioExpertPC.Text = "Ein neuer PC mit aktuellster High-End\r\nHardware für echte PC Experten!";
            // 
            // tbFullPrice
            // 
            this.tbFullPrice.Location = new System.Drawing.Point(89, 394);
            this.tbFullPrice.Name = "tbFullPrice";
            this.tbFullPrice.ReadOnly = true;
            this.tbFullPrice.Size = new System.Drawing.Size(52, 20);
            this.tbFullPrice.TabIndex = 20;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(215, 397);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 13);
            this.lblDiscount.TabIndex = 21;
            this.lblDiscount.Text = "Rabatt: 0%";
            // 
            // btReset
            // 
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(109, 78);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(36, 15);
            this.btReset.TabIndex = 22;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 422);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.tbFullPrice);
            this.Controls.Add(this.btAioExpertPC);
            this.Controls.Add(this.lblAioExpertPC);
            this.Controls.Add(this.lblAioDescription);
            this.Controls.Add(this.btAioGamingPC);
            this.Controls.Add(this.lblAioGamingPC);
            this.Controls.Add(this.lblShopBeschreibung);
            this.Controls.Add(this.cbSelfConfig);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwShopItems);
            this.Controls.Add(this.lblWelcomeText);
            this.Controls.Add(this.lblShopItems);
            this.Name = "frmMainWindow";
            this.Text = "Rastla\'s Computerladen";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShopItems;
        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.ListView lvwShopItems;
        private System.Windows.Forms.ColumnHeader clmHdrArtikel;
        private System.Windows.Forms.ColumnHeader clmHdrPreis;
        private System.Windows.Forms.ColumnHeader clmHdrAnzahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.CheckBox cbSelfConfig;
        private System.Windows.Forms.Label lblShopBeschreibung;
        private System.Windows.Forms.Label lblAioGamingPC;
        private System.Windows.Forms.Button btAioGamingPC;
        private System.Windows.Forms.Label lblAioDescription;
        private System.Windows.Forms.Button btAioExpertPC;
        private System.Windows.Forms.Label lblAioExpertPC;
        private System.Windows.Forms.TextBox tbFullPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Button btReset;
    }
}

