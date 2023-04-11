namespace PartyOrganizerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newEventBox = new System.Windows.Forms.GroupBox();
            this.createListBtn = new System.Windows.Forms.Button();
            this.feeLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.guestNumberLabel = new System.Windows.Forms.Label();
            this.feeIn = new System.Windows.Forms.TextBox();
            this.costIn = new System.Windows.Forms.TextBox();
            this.maxGuestsIn = new System.Windows.Forms.TextBox();
            this.guestListBox = new System.Windows.Forms.ListBox();
            this.GuestListTitle = new System.Windows.Forms.Label();
            this.inviteGuestBox = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.lastNameIn = new System.Windows.Forms.TextBox();
            this.firstNameIn = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.numberGuestsOut = new System.Windows.Forms.Label();
            this.totalCostOut = new System.Windows.Forms.Label();
            this.totalFeesOut = new System.Windows.Forms.Label();
            this.surplusOut = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalFeesLabel = new System.Windows.Forms.Label();
            this.surplusLabel = new System.Windows.Forms.Label();
            this.numberGuestLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newEventBox.SuspendLayout();
            this.inviteGuestBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newEventBox
            // 
            this.newEventBox.Controls.Add(this.createListBtn);
            this.newEventBox.Controls.Add(this.feeLabel);
            this.newEventBox.Controls.Add(this.costLabel);
            this.newEventBox.Controls.Add(this.guestNumberLabel);
            this.newEventBox.Controls.Add(this.feeIn);
            this.newEventBox.Controls.Add(this.costIn);
            this.newEventBox.Controls.Add(this.maxGuestsIn);
            this.newEventBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newEventBox.ForeColor = System.Drawing.Color.Olive;
            this.newEventBox.Location = new System.Drawing.Point(33, 37);
            this.newEventBox.Name = "newEventBox";
            this.newEventBox.Size = new System.Drawing.Size(656, 324);
            this.newEventBox.TabIndex = 0;
            this.newEventBox.TabStop = false;
            this.newEventBox.Text = "New Event";
            // 
            // createListBtn
            // 
            this.createListBtn.BackColor = System.Drawing.SystemColors.Window;
            this.createListBtn.ForeColor = System.Drawing.Color.Olive;
            this.createListBtn.Location = new System.Drawing.Point(179, 262);
            this.createListBtn.Name = "createListBtn";
            this.createListBtn.Size = new System.Drawing.Size(297, 46);
            this.createListBtn.TabIndex = 6;
            this.createListBtn.Text = "Create List";
            this.createListBtn.UseVisualStyleBackColor = false;
            this.createListBtn.Click += new System.EventHandler(this.createListClck);
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feeLabel.ForeColor = System.Drawing.Color.Olive;
            this.feeLabel.Location = new System.Drawing.Point(17, 187);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(174, 32);
            this.feeLabel.TabIndex = 5;
            this.feeLabel.Text = "Fee per person";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costLabel.ForeColor = System.Drawing.Color.Olive;
            this.costLabel.Location = new System.Drawing.Point(17, 124);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(183, 32);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Cost per person";
            // 
            // guestNumberLabel
            // 
            this.guestNumberLabel.AutoSize = true;
            this.guestNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guestNumberLabel.ForeColor = System.Drawing.Color.Olive;
            this.guestNumberLabel.Location = new System.Drawing.Point(17, 57);
            this.guestNumberLabel.Name = "guestNumberLabel";
            this.guestNumberLabel.Size = new System.Drawing.Size(255, 32);
            this.guestNumberLabel.TabIndex = 3;
            this.guestNumberLabel.Text = "Max number of guests";
            // 
            // feeIn
            // 
            this.feeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feeIn.Location = new System.Drawing.Point(424, 185);
            this.feeIn.Name = "feeIn";
            this.feeIn.Size = new System.Drawing.Size(200, 39);
            this.feeIn.TabIndex = 2;
            // 
            // costIn
            // 
            this.costIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costIn.Location = new System.Drawing.Point(424, 122);
            this.costIn.Name = "costIn";
            this.costIn.Size = new System.Drawing.Size(200, 39);
            this.costIn.TabIndex = 1;
            // 
            // maxGuestsIn
            // 
            this.maxGuestsIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxGuestsIn.Location = new System.Drawing.Point(424, 55);
            this.maxGuestsIn.Name = "maxGuestsIn";
            this.maxGuestsIn.Size = new System.Drawing.Size(200, 39);
            this.maxGuestsIn.TabIndex = 0;
            // 
            // guestListBox
            // 
            this.guestListBox.FormattingEnabled = true;
            this.guestListBox.ItemHeight = 32;
            this.guestListBox.Location = new System.Drawing.Point(745, 92);
            this.guestListBox.Name = "guestListBox";
            this.guestListBox.Size = new System.Drawing.Size(565, 708);
            this.guestListBox.TabIndex = 1;
            // 
            // GuestListTitle
            // 
            this.GuestListTitle.AutoSize = true;
            this.GuestListTitle.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuestListTitle.Location = new System.Drawing.Point(917, 37);
            this.GuestListTitle.Name = "GuestListTitle";
            this.GuestListTitle.Size = new System.Drawing.Size(184, 39);
            this.GuestListTitle.TabIndex = 2;
            this.GuestListTitle.Text = "Guest List";
            // 
            // inviteGuestBox
            // 
            this.inviteGuestBox.Controls.Add(this.addBtn);
            this.inviteGuestBox.Controls.Add(this.lastNameIn);
            this.inviteGuestBox.Controls.Add(this.firstNameIn);
            this.inviteGuestBox.Controls.Add(this.lastNameLabel);
            this.inviteGuestBox.Controls.Add(this.firstNameLabel);
            this.inviteGuestBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inviteGuestBox.ForeColor = System.Drawing.Color.Olive;
            this.inviteGuestBox.Location = new System.Drawing.Point(33, 383);
            this.inviteGuestBox.Name = "inviteGuestBox";
            this.inviteGuestBox.Size = new System.Drawing.Size(656, 226);
            this.inviteGuestBox.TabIndex = 3;
            this.inviteGuestBox.TabStop = false;
            this.inviteGuestBox.Text = "Invite Guest";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.Window;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.Color.Olive;
            this.addBtn.Location = new System.Drawing.Point(179, 174);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(297, 46);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addGuestClick);
            // 
            // lastNameIn
            // 
            this.lastNameIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameIn.Location = new System.Drawing.Point(220, 112);
            this.lastNameIn.Name = "lastNameIn";
            this.lastNameIn.Size = new System.Drawing.Size(404, 39);
            this.lastNameIn.TabIndex = 3;
            // 
            // firstNameIn
            // 
            this.firstNameIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameIn.Location = new System.Drawing.Point(220, 60);
            this.firstNameIn.Name = "firstNameIn";
            this.firstNameIn.Size = new System.Drawing.Size(404, 39);
            this.firstNameIn.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(29, 115);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(126, 32);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(29, 63);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(129, 32);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // numberGuestsOut
            // 
            this.numberGuestsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberGuestsOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberGuestsOut.Location = new System.Drawing.Point(457, 678);
            this.numberGuestsOut.Name = "numberGuestsOut";
            this.numberGuestsOut.Size = new System.Drawing.Size(212, 43);
            this.numberGuestsOut.TabIndex = 4;
            this.numberGuestsOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCostOut
            // 
            this.totalCostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalCostOut.Location = new System.Drawing.Point(457, 735);
            this.totalCostOut.Name = "totalCostOut";
            this.totalCostOut.Size = new System.Drawing.Size(212, 45);
            this.totalCostOut.TabIndex = 5;
            this.totalCostOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalFeesOut
            // 
            this.totalFeesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalFeesOut.Location = new System.Drawing.Point(457, 789);
            this.totalFeesOut.Name = "totalFeesOut";
            this.totalFeesOut.Size = new System.Drawing.Size(212, 45);
            this.totalFeesOut.TabIndex = 6;
            this.totalFeesOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surplusOut
            // 
            this.surplusOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surplusOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surplusOut.Location = new System.Drawing.Point(456, 841);
            this.surplusOut.Name = "surplusOut";
            this.surplusOut.Size = new System.Drawing.Size(213, 48);
            this.surplusOut.TabIndex = 7;
            this.surplusOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalCostLabel.Location = new System.Drawing.Point(38, 736);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(129, 37);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Total cost";
            // 
            // totalFeesLabel
            // 
            this.totalFeesLabel.AutoSize = true;
            this.totalFeesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalFeesLabel.Location = new System.Drawing.Point(38, 790);
            this.totalFeesLabel.Name = "totalFeesLabel";
            this.totalFeesLabel.Size = new System.Drawing.Size(128, 37);
            this.totalFeesLabel.TabIndex = 9;
            this.totalFeesLabel.Text = "Total fees";
            // 
            // surplusLabel
            // 
            this.surplusLabel.AutoSize = true;
            this.surplusLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surplusLabel.Location = new System.Drawing.Point(38, 842);
            this.surplusLabel.Name = "surplusLabel";
            this.surplusLabel.Size = new System.Drawing.Size(188, 37);
            this.surplusLabel.TabIndex = 10;
            this.surplusLabel.Text = "Surplus/deficit";
            // 
            // numberGuestLabel
            // 
            this.numberGuestLabel.AutoSize = true;
            this.numberGuestLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberGuestLabel.Location = new System.Drawing.Point(38, 679);
            this.numberGuestLabel.Name = "numberGuestLabel";
            this.numberGuestLabel.Size = new System.Drawing.Size(228, 37);
            this.numberGuestLabel.TabIndex = 11;
            this.numberGuestLabel.Text = "Number of guests";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(917, 837);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(238, 61);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 939);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.numberGuestLabel);
            this.Controls.Add(this.surplusLabel);
            this.Controls.Add(this.totalFeesLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.surplusOut);
            this.Controls.Add(this.totalFeesOut);
            this.Controls.Add(this.totalCostOut);
            this.Controls.Add(this.numberGuestsOut);
            this.Controls.Add(this.inviteGuestBox);
            this.Controls.Add(this.GuestListTitle);
            this.Controls.Add(this.guestListBox);
            this.Controls.Add(this.newEventBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.newEventBox.ResumeLayout(false);
            this.newEventBox.PerformLayout();
            this.inviteGuestBox.ResumeLayout(false);
            this.inviteGuestBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox newEventBox;
        private ListBox guestListBox;
        private Label GuestListTitle;
        private Button createListBtn;
        private Label feeLabel;
        private Label costLabel;
        private Label guestNumberLabel;
        private TextBox feeIn;
        private TextBox costIn;
        private TextBox maxGuestsIn;
        private GroupBox inviteGuestBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Button addBtn;
        private TextBox lastNameIn;
        private TextBox firstNameIn;
        private Label numberGuestsOut;
        private Label totalCostLabel;
        private Label totalFeesLabel;
        private Label surplusLabel;
        private Label numberGuestLabel;
        private Button deleteBtn;
        private Label totalCostOut;
        private Label totalFeesOut;
        private Label surplusOut;
    }
}