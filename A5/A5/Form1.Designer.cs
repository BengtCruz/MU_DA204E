namespace A5
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
            this.feeLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.eventNameLbl = new System.Windows.Forms.Label();
            this.createEventBtn = new System.Windows.Forms.Button();
            this.feePerGuest = new System.Windows.Forms.TextBox();
            this.costPerGuestIn = new System.Windows.Forms.TextBox();
            this.eventNameIn = new System.Windows.Forms.TextBox();
            this.addGuestBox = new System.Windows.Forms.GroupBox();
            this.countryLbl = new System.Windows.Forms.Label();
            this.zipCodeLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.streetLbl = new System.Windows.Forms.Label();
            this.secondNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.addGuestBtn = new System.Windows.Forms.Button();
            this.countryDropDown = new System.Windows.Forms.ComboBox();
            this.zipCodeIn = new System.Windows.Forms.TextBox();
            this.cityIn = new System.Windows.Forms.TextBox();
            this.streetIn = new System.Windows.Forms.TextBox();
            this.secondNameIn = new System.Windows.Forms.TextBox();
            this.firstNameIn = new System.Windows.Forms.TextBox();
            this.guestListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.surplusDeficitLbl = new System.Windows.Forms.Label();
            this.totalFeesLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.numberOfGuestLbl = new System.Windows.Forms.Label();
            this.surplusDeficitOut = new System.Windows.Forms.Label();
            this.totalFeesOut = new System.Windows.Forms.Label();
            this.totalCostOut = new System.Windows.Forms.Label();
            this.numbGuestOut = new System.Windows.Forms.Label();
            this.guestLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newEventBox.SuspendLayout();
            this.addGuestBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newEventBox
            // 
            this.newEventBox.Controls.Add(this.feeLbl);
            this.newEventBox.Controls.Add(this.costLbl);
            this.newEventBox.Controls.Add(this.eventNameLbl);
            this.newEventBox.Controls.Add(this.createEventBtn);
            this.newEventBox.Controls.Add(this.feePerGuest);
            this.newEventBox.Controls.Add(this.costPerGuestIn);
            this.newEventBox.Controls.Add(this.eventNameIn);
            this.newEventBox.Location = new System.Drawing.Point(35, 54);
            this.newEventBox.Name = "newEventBox";
            this.newEventBox.Size = new System.Drawing.Size(661, 289);
            this.newEventBox.TabIndex = 0;
            this.newEventBox.TabStop = false;
            this.newEventBox.Text = "New Event";
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.Location = new System.Drawing.Point(25, 149);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(160, 32);
            this.feeLbl.TabIndex = 6;
            this.feeLbl.Text = "Fee per guest";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(25, 104);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(169, 32);
            this.costLbl.TabIndex = 5;
            this.costLbl.Text = "Cost per guest";
            // 
            // eventNameLbl
            // 
            this.eventNameLbl.AutoSize = true;
            this.eventNameLbl.Location = new System.Drawing.Point(25, 59);
            this.eventNameLbl.Name = "eventNameLbl";
            this.eventNameLbl.Size = new System.Drawing.Size(144, 32);
            this.eventNameLbl.TabIndex = 4;
            this.eventNameLbl.Text = "Event Name";
            // 
            // createEventBtn
            // 
            this.createEventBtn.ForeColor = System.Drawing.Color.Teal;
            this.createEventBtn.Location = new System.Drawing.Point(173, 228);
            this.createEventBtn.Name = "createEventBtn";
            this.createEventBtn.Size = new System.Drawing.Size(304, 46);
            this.createEventBtn.TabIndex = 3;
            this.createEventBtn.Text = "Create Event";
            this.createEventBtn.UseVisualStyleBackColor = true;
            this.createEventBtn.Click += new System.EventHandler(this.clickCreateEvent);
            // 
            // feePerGuest
            // 
            this.feePerGuest.Location = new System.Drawing.Point(446, 142);
            this.feePerGuest.Name = "feePerGuest";
            this.feePerGuest.Size = new System.Drawing.Size(200, 39);
            this.feePerGuest.TabIndex = 2;
            // 
            // costPerGuestIn
            // 
            this.costPerGuestIn.Location = new System.Drawing.Point(446, 97);
            this.costPerGuestIn.Name = "costPerGuestIn";
            this.costPerGuestIn.Size = new System.Drawing.Size(200, 39);
            this.costPerGuestIn.TabIndex = 1;
            // 
            // eventNameIn
            // 
            this.eventNameIn.Location = new System.Drawing.Point(278, 52);
            this.eventNameIn.Name = "eventNameIn";
            this.eventNameIn.Size = new System.Drawing.Size(368, 39);
            this.eventNameIn.TabIndex = 0;
            // 
            // addGuestBox
            // 
            this.addGuestBox.Controls.Add(this.countryLbl);
            this.addGuestBox.Controls.Add(this.zipCodeLbl);
            this.addGuestBox.Controls.Add(this.cityLbl);
            this.addGuestBox.Controls.Add(this.streetLbl);
            this.addGuestBox.Controls.Add(this.secondNameLbl);
            this.addGuestBox.Controls.Add(this.firstNameLbl);
            this.addGuestBox.Controls.Add(this.addGuestBtn);
            this.addGuestBox.Controls.Add(this.countryDropDown);
            this.addGuestBox.Controls.Add(this.zipCodeIn);
            this.addGuestBox.Controls.Add(this.cityIn);
            this.addGuestBox.Controls.Add(this.streetIn);
            this.addGuestBox.Controls.Add(this.secondNameIn);
            this.addGuestBox.Controls.Add(this.firstNameIn);
            this.addGuestBox.Location = new System.Drawing.Point(35, 414);
            this.addGuestBox.Name = "addGuestBox";
            this.addGuestBox.Size = new System.Drawing.Size(661, 586);
            this.addGuestBox.TabIndex = 1;
            this.addGuestBox.TabStop = false;
            this.addGuestBox.Text = "Add Guest";
            // 
            // countryLbl
            // 
            this.countryLbl.AutoSize = true;
            this.countryLbl.Location = new System.Drawing.Point(15, 382);
            this.countryLbl.Name = "countryLbl";
            this.countryLbl.Size = new System.Drawing.Size(99, 32);
            this.countryLbl.TabIndex = 12;
            this.countryLbl.Text = "Country";
            // 
            // zipCodeLbl
            // 
            this.zipCodeLbl.AutoSize = true;
            this.zipCodeLbl.Location = new System.Drawing.Point(15, 309);
            this.zipCodeLbl.Name = "zipCodeLbl";
            this.zipCodeLbl.Size = new System.Drawing.Size(111, 32);
            this.zipCodeLbl.TabIndex = 11;
            this.zipCodeLbl.Text = "Zip Code";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(15, 240);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(55, 32);
            this.cityLbl.TabIndex = 10;
            this.cityLbl.Text = "City";
            // 
            // streetLbl
            // 
            this.streetLbl.AutoSize = true;
            this.streetLbl.Location = new System.Drawing.Point(15, 173);
            this.streetLbl.Name = "streetLbl";
            this.streetLbl.Size = new System.Drawing.Size(76, 32);
            this.streetLbl.TabIndex = 9;
            this.streetLbl.Text = "Street";
            // 
            // secondNameLbl
            // 
            this.secondNameLbl.AutoSize = true;
            this.secondNameLbl.Location = new System.Drawing.Point(15, 106);
            this.secondNameLbl.Name = "secondNameLbl";
            this.secondNameLbl.Size = new System.Drawing.Size(164, 32);
            this.secondNameLbl.TabIndex = 8;
            this.secondNameLbl.Text = "Second Name";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(15, 45);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(129, 32);
            this.firstNameLbl.TabIndex = 7;
            this.firstNameLbl.Text = "First Name";
            // 
            // addGuestBtn
            // 
            this.addGuestBtn.ForeColor = System.Drawing.Color.Teal;
            this.addGuestBtn.Location = new System.Drawing.Point(173, 480);
            this.addGuestBtn.Name = "addGuestBtn";
            this.addGuestBtn.Size = new System.Drawing.Size(304, 48);
            this.addGuestBtn.TabIndex = 6;
            this.addGuestBtn.Text = "Add Guest";
            this.addGuestBtn.UseVisualStyleBackColor = true;
            this.addGuestBtn.Click += new System.EventHandler(this.clickAddGuest);
            // 
            // countryDropDown
            // 
            this.countryDropDown.FormattingEnabled = true;
            this.countryDropDown.Location = new System.Drawing.Point(270, 374);
            this.countryDropDown.Name = "countryDropDown";
            this.countryDropDown.Size = new System.Drawing.Size(376, 40);
            this.countryDropDown.TabIndex = 5;
            // 
            // zipCodeIn
            // 
            this.zipCodeIn.Location = new System.Drawing.Point(270, 302);
            this.zipCodeIn.Name = "zipCodeIn";
            this.zipCodeIn.Size = new System.Drawing.Size(376, 39);
            this.zipCodeIn.TabIndex = 4;
            // 
            // cityIn
            // 
            this.cityIn.Location = new System.Drawing.Point(270, 233);
            this.cityIn.Name = "cityIn";
            this.cityIn.Size = new System.Drawing.Size(376, 39);
            this.cityIn.TabIndex = 3;
            // 
            // streetIn
            // 
            this.streetIn.Location = new System.Drawing.Point(270, 166);
            this.streetIn.Name = "streetIn";
            this.streetIn.Size = new System.Drawing.Size(376, 39);
            this.streetIn.TabIndex = 2;
            // 
            // secondNameIn
            // 
            this.secondNameIn.Location = new System.Drawing.Point(270, 99);
            this.secondNameIn.Name = "secondNameIn";
            this.secondNameIn.Size = new System.Drawing.Size(376, 39);
            this.secondNameIn.TabIndex = 1;
            // 
            // firstNameIn
            // 
            this.firstNameIn.Location = new System.Drawing.Point(270, 38);
            this.firstNameIn.Name = "firstNameIn";
            this.firstNameIn.Size = new System.Drawing.Size(376, 39);
            this.firstNameIn.TabIndex = 0;
            // 
            // guestListBox
            // 
            this.guestListBox.FormattingEnabled = true;
            this.guestListBox.ItemHeight = 32;
            this.guestListBox.Location = new System.Drawing.Point(800, 106);
            this.guestListBox.Name = "guestListBox";
            this.guestListBox.Size = new System.Drawing.Size(817, 452);
            this.guestListBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.surplusDeficitLbl);
            this.groupBox1.Controls.Add(this.totalFeesLbl);
            this.groupBox1.Controls.Add(this.totalCostLbl);
            this.groupBox1.Controls.Add(this.numberOfGuestLbl);
            this.groupBox1.Controls.Add(this.surplusDeficitOut);
            this.groupBox1.Controls.Add(this.totalFeesOut);
            this.groupBox1.Controls.Add(this.totalCostOut);
            this.groupBox1.Controls.Add(this.numbGuestOut);
            this.groupBox1.Location = new System.Drawing.Point(880, 654);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 325);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Economy";
            // 
            // surplusDeficitLbl
            // 
            this.surplusDeficitLbl.AutoSize = true;
            this.surplusDeficitLbl.Location = new System.Drawing.Point(23, 275);
            this.surplusDeficitLbl.Name = "surplusDeficitLbl";
            this.surplusDeficitLbl.Size = new System.Drawing.Size(168, 32);
            this.surplusDeficitLbl.TabIndex = 7;
            this.surplusDeficitLbl.Text = "Surplus/deficit";
            // 
            // totalFeesLbl
            // 
            this.totalFeesLbl.AutoSize = true;
            this.totalFeesLbl.Location = new System.Drawing.Point(23, 201);
            this.totalFeesLbl.Name = "totalFeesLbl";
            this.totalFeesLbl.Size = new System.Drawing.Size(116, 32);
            this.totalFeesLbl.TabIndex = 6;
            this.totalFeesLbl.Text = "Total fees";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(23, 127);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(115, 32);
            this.totalCostLbl.TabIndex = 5;
            this.totalCostLbl.Text = "Total cost";
            // 
            // numberOfGuestLbl
            // 
            this.numberOfGuestLbl.AutoSize = true;
            this.numberOfGuestLbl.Location = new System.Drawing.Point(23, 54);
            this.numberOfGuestLbl.Name = "numberOfGuestLbl";
            this.numberOfGuestLbl.Size = new System.Drawing.Size(207, 32);
            this.numberOfGuestLbl.TabIndex = 4;
            this.numberOfGuestLbl.Text = "Number of guests";
            // 
            // surplusDeficitOut
            // 
            this.surplusDeficitOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.surplusDeficitOut.Location = new System.Drawing.Point(401, 256);
            this.surplusDeficitOut.Name = "surplusDeficitOut";
            this.surplusDeficitOut.Size = new System.Drawing.Size(251, 51);
            this.surplusDeficitOut.TabIndex = 3;
            // 
            // totalFeesOut
            // 
            this.totalFeesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeesOut.Location = new System.Drawing.Point(401, 182);
            this.totalFeesOut.Name = "totalFeesOut";
            this.totalFeesOut.Size = new System.Drawing.Size(251, 51);
            this.totalFeesOut.TabIndex = 2;
            // 
            // totalCostOut
            // 
            this.totalCostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostOut.Location = new System.Drawing.Point(401, 108);
            this.totalCostOut.Name = "totalCostOut";
            this.totalCostOut.Size = new System.Drawing.Size(251, 51);
            this.totalCostOut.TabIndex = 1;
            // 
            // numbGuestOut
            // 
            this.numbGuestOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numbGuestOut.Location = new System.Drawing.Point(401, 35);
            this.numbGuestOut.Name = "numbGuestOut";
            this.numbGuestOut.Size = new System.Drawing.Size(251, 51);
            this.numbGuestOut.TabIndex = 0;
            // 
            // guestLbl
            // 
            this.guestLbl.AutoSize = true;
            this.guestLbl.ForeColor = System.Drawing.Color.Teal;
            this.guestLbl.Location = new System.Drawing.Point(821, 54);
            this.guestLbl.Name = "guestLbl";
            this.guestLbl.Size = new System.Drawing.Size(75, 32);
            this.guestLbl.TabIndex = 4;
            this.guestLbl.Text = "Guest";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.ForeColor = System.Drawing.Color.Teal;
            this.addressLbl.Location = new System.Drawing.Point(1320, 54);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(98, 32);
            this.addressLbl.TabIndex = 5;
            this.addressLbl.Text = "Address";
            // 
            // changeBtn
            // 
            this.changeBtn.ForeColor = System.Drawing.Color.Teal;
            this.changeBtn.Location = new System.Drawing.Point(877, 587);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(233, 46);
            this.changeBtn.TabIndex = 6;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.clickChange);
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteBtn.Location = new System.Drawing.Point(1320, 587);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(233, 46);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.clickDelete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 1038);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.guestLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guestListBox);
            this.Controls.Add(this.addGuestBox);
            this.Controls.Add(this.newEventBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.newEventBox.ResumeLayout(false);
            this.newEventBox.PerformLayout();
            this.addGuestBox.ResumeLayout(false);
            this.addGuestBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox newEventBox;
        private GroupBox addGuestBox;
        private ListBox guestListBox;
        private TextBox feePerGuest;
        private TextBox costPerGuestIn;
        private TextBox eventNameIn;
        private Button createEventBtn;
        private Label eventNameLbl;
        private Label costLbl;
        private Label feeLbl;
        private Button addGuestBtn;
        private ComboBox countryDropDown;
        private TextBox zipCodeIn;
        private TextBox cityIn;
        private TextBox streetIn;
        private TextBox secondNameIn;
        private TextBox firstNameIn;
        private Label secondNameLbl;
        private Label firstNameLbl;
        private Label streetLbl;
        private Label cityLbl;
        private Label zipCodeLbl;
        private Label countryLbl;
        private GroupBox groupBox1;
        private Label numberOfGuestLbl;
        private Label surplusDeficitOut;
        private Label totalFeesOut;
        private Label totalCostOut;
        private Label numbGuestOut;
        private Label totalCostLbl;
        private Label totalFeesLbl;
        private Label surplusDeficitLbl;
        private Label guestLbl;
        private Label addressLbl;
        private Button changeBtn;
        private Button deleteBtn;
    }
}