using System;

namespace LootProfiler
{
    partial class frmLootProfiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLootProfiler));
            this.txtBoxDiD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCreatureDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxLootQualityMod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxUnknownChance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxItemMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxItemMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxItemChance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxMagicItemMax = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxMagicItemMin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxMagicItemChance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxMundaneItemMax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoxMundaneItemMin = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBoxMundaneItemChance = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cBoxItemChances = new System.Windows.Forms.ComboBox();
            this.cBoxMagicItemChances = new System.Windows.Forms.ComboBox();
            this.cBoxMundaneItemChances = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblItemTreasureChances = new System.Windows.Forms.Label();
            this.lblMagicItemTreasureChance = new System.Windows.Forms.Label();
            this.lblMundaneItemTreasureChance = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxDiD
            // 
            this.txtBoxDiD.Location = new System.Drawing.Point(25, 25);
            this.txtBoxDiD.Name = "txtBoxDiD";
            this.txtBoxDiD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDiD.TabIndex = 0;
            this.txtBoxDiD.Leave += new System.EventHandler(this.txtBoxDiD_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DeathTreasure DID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID (same for new profiles)";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(173, 25);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CreatureClass";
            // 
            // txtBoxCreatureDescription
            // 
            this.txtBoxCreatureDescription.Location = new System.Drawing.Point(327, 25);
            this.txtBoxCreatureDescription.Name = "txtBoxCreatureDescription";
            this.txtBoxCreatureDescription.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCreatureDescription.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tier";
            // 
            // txtBoxTier
            // 
            this.txtBoxTier.Location = new System.Drawing.Point(238, 85);
            this.txtBoxTier.Name = "txtBoxTier";
            this.txtBoxTier.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTier.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loot Quality Mod";
            // 
            // txtBoxLootQualityMod
            // 
            this.txtBoxLootQualityMod.Location = new System.Drawing.Point(238, 111);
            this.txtBoxLootQualityMod.Name = "txtBoxLootQualityMod";
            this.txtBoxLootQualityMod.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLootQualityMod.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unknown Chances";
            // 
            // txtBoxUnknownChance
            // 
            this.txtBoxUnknownChance.Location = new System.Drawing.Point(238, 137);
            this.txtBoxUnknownChance.Name = "txtBoxUnknownChance";
            this.txtBoxUnknownChance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUnknownChance.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Item Max Amount";
            // 
            // txtBoxItemMax
            // 
            this.txtBoxItemMax.Location = new System.Drawing.Point(238, 231);
            this.txtBoxItemMax.Name = "txtBoxItemMax";
            this.txtBoxItemMax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxItemMax.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Item Min Amount";
            // 
            // txtBoxItemMin
            // 
            this.txtBoxItemMin.Location = new System.Drawing.Point(238, 205);
            this.txtBoxItemMin.Name = "txtBoxItemMin";
            this.txtBoxItemMin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxItemMin.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Item Chance";
            // 
            // txtBoxItemChance
            // 
            this.txtBoxItemChance.Location = new System.Drawing.Point(238, 179);
            this.txtBoxItemChance.Name = "txtBoxItemChance";
            this.txtBoxItemChance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxItemChance.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Item Treasure Type Chances";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Magic Item Treasure Type Chances";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Magic Item Max Amount";
            // 
            // txtBoxMagicItemMax
            // 
            this.txtBoxMagicItemMax.Location = new System.Drawing.Point(238, 349);
            this.txtBoxMagicItemMax.Name = "txtBoxMagicItemMax";
            this.txtBoxMagicItemMax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMagicItemMax.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Magic Item Min Amount";
            // 
            // txtBoxMagicItemMin
            // 
            this.txtBoxMagicItemMin.Location = new System.Drawing.Point(238, 323);
            this.txtBoxMagicItemMin.Name = "txtBoxMagicItemMin";
            this.txtBoxMagicItemMin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMagicItemMin.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Magic Item Chance";
            // 
            // txtBoxMagicItemChance
            // 
            this.txtBoxMagicItemChance.Location = new System.Drawing.Point(238, 297);
            this.txtBoxMagicItemChance.Name = "txtBoxMagicItemChance";
            this.txtBoxMagicItemChance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMagicItemChance.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 502);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Mundane Item Treasure Type Chances";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 476);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Mundane Item Max Amount";
            // 
            // txtBoxMundaneItemMax
            // 
            this.txtBoxMundaneItemMax.Location = new System.Drawing.Point(238, 469);
            this.txtBoxMundaneItemMax.Name = "txtBoxMundaneItemMax";
            this.txtBoxMundaneItemMax.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMundaneItemMax.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 450);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Mundane Item Min Amount";
            // 
            // txtBoxMundaneItemMin
            // 
            this.txtBoxMundaneItemMin.Location = new System.Drawing.Point(238, 443);
            this.txtBoxMundaneItemMin.Name = "txtBoxMundaneItemMin";
            this.txtBoxMundaneItemMin.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMundaneItemMin.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 424);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Mundane Item Chance";
            // 
            // txtBoxMundaneItemChance
            // 
            this.txtBoxMundaneItemChance.Location = new System.Drawing.Point(238, 417);
            this.txtBoxMundaneItemChance.Name = "txtBoxMundaneItemChance";
            this.txtBoxMundaneItemChance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMundaneItemChance.TabIndex = 28;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(640, 257);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 36;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(640, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(640, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(640, 372);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cBoxItemChances
            // 
            this.cBoxItemChances.FormattingEnabled = true;
            this.cBoxItemChances.Location = new System.Drawing.Point(238, 257);
            this.cBoxItemChances.Name = "cBoxItemChances";
            this.cBoxItemChances.Size = new System.Drawing.Size(208, 21);
            this.cBoxItemChances.TabIndex = 40;
            this.cBoxItemChances.SelectedIndexChanged += new System.EventHandler(this.cBoxItemChances_SelectedIndexChanged);
            // 
            // cBoxMagicItemChances
            // 
            this.cBoxMagicItemChances.FormattingEnabled = true;
            this.cBoxMagicItemChances.Location = new System.Drawing.Point(238, 375);
            this.cBoxMagicItemChances.Name = "cBoxMagicItemChances";
            this.cBoxMagicItemChances.Size = new System.Drawing.Size(208, 21);
            this.cBoxMagicItemChances.TabIndex = 41;
            this.cBoxMagicItemChances.SelectedIndexChanged += new System.EventHandler(this.cBoxMagicItemChances_SelectedIndexChanged);
            // 
            // cBoxMundaneItemChances
            // 
            this.cBoxMundaneItemChances.FormattingEnabled = true;
            this.cBoxMundaneItemChances.Location = new System.Drawing.Point(238, 495);
            this.cBoxMundaneItemChances.Name = "cBoxMundaneItemChances";
            this.cBoxMundaneItemChances.Size = new System.Drawing.Size(208, 21);
            this.cBoxMundaneItemChances.TabIndex = 42;
            this.cBoxMundaneItemChances.SelectedIndexChanged += new System.EventHandler(this.cBoxMundaneItemChances_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblItemTreasureChances
            // 
            this.lblItemTreasureChances.AutoSize = true;
            this.lblItemTreasureChances.Location = new System.Drawing.Point(219, 262);
            this.lblItemTreasureChances.Name = "lblItemTreasureChances";
            this.lblItemTreasureChances.Size = new System.Drawing.Size(13, 13);
            this.lblItemTreasureChances.TabIndex = 43;
            this.lblItemTreasureChances.Text = "0";
            // 
            // lblMagicItemTreasureChance
            // 
            this.lblMagicItemTreasureChance.AutoSize = true;
            this.lblMagicItemTreasureChance.Location = new System.Drawing.Point(219, 379);
            this.lblMagicItemTreasureChance.Name = "lblMagicItemTreasureChance";
            this.lblMagicItemTreasureChance.Size = new System.Drawing.Size(13, 13);
            this.lblMagicItemTreasureChance.TabIndex = 44;
            this.lblMagicItemTreasureChance.Text = "0";
            // 
            // lblMundaneItemTreasureChance
            // 
            this.lblMundaneItemTreasureChance.AutoSize = true;
            this.lblMundaneItemTreasureChance.Location = new System.Drawing.Point(219, 500);
            this.lblMundaneItemTreasureChance.Name = "lblMundaneItemTreasureChance";
            this.lblMundaneItemTreasureChance.Size = new System.Drawing.Size(13, 13);
            this.lblMundaneItemTreasureChance.TabIndex = 45;
            this.lblMundaneItemTreasureChance.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 535);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Last Modified:";
            // 
            // lblLastModified
            // 
            this.lblLastModified.AutoSize = true;
            this.lblLastModified.Location = new System.Drawing.Point(107, 535);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(0, 13);
            this.lblLastModified.TabIndex = 47;
            // 
            // frmLootProfiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.lblLastModified);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblMundaneItemTreasureChance);
            this.Controls.Add(this.lblMagicItemTreasureChance);
            this.Controls.Add(this.lblItemTreasureChances);
            this.Controls.Add(this.cBoxMundaneItemChances);
            this.Controls.Add(this.cBoxMagicItemChances);
            this.Controls.Add(this.cBoxItemChances);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBoxMundaneItemMax);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBoxMundaneItemMin);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBoxMundaneItemChance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxMagicItemMax);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxMagicItemMin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxMagicItemChance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxItemMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxItemMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxItemChance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxUnknownChance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxLootQualityMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxTier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxCreatureDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDiD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLootProfiler";
            this.Text = "ACE Death Treasure - Loot Profiler";
            this.Load += new System.EventHandler(this.frmLootProfiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox txtBoxDiD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxCreatureDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxLootQualityMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxUnknownChance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxItemMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxItemMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxItemChance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxMagicItemMax;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxMagicItemMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxMagicItemChance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxMundaneItemMax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBoxMundaneItemMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBoxMundaneItemChance;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cBoxItemChances;
        private System.Windows.Forms.ComboBox cBoxMagicItemChances;
        private System.Windows.Forms.ComboBox cBoxMundaneItemChances;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblItemTreasureChances;
        private System.Windows.Forms.Label lblMagicItemTreasureChance;
        private System.Windows.Forms.Label lblMundaneItemTreasureChance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLastModified;
    }
}

