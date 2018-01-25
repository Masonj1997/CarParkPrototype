namespace WindowsFormsApp27
{
    partial class CarParkPrototype
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
            this.btnPayCash = new System.Windows.Forms.Button();
            this.btnPayCard = new System.Windows.Forms.Button();
            this.btnPayBitCoin = new System.Windows.Forms.Button();
            this.btnSecureAdvancePayment = new System.Windows.Forms.Button();
            this.btnToggleEmergency = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstPrePaidTickets = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstActiveTickets = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblEmergencyVehicles = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblEmergencySign = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblFloor0Spaces = new System.Windows.Forms.Label();
            this.lblFloor2Spaces = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFloor1Spaces = new System.Windows.Forms.Label();
            this.lblFullSign = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnExitOverride = new System.Windows.Forms.Button();
            this.lblExitBarrier = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblExitSensor = new System.Windows.Forms.Label();
            this.Entry = new System.Windows.Forms.GroupBox();
            this.btnBarrierOverride = new System.Windows.Forms.Button();
            this.lblEntryBarrier = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEntrySensor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrePaidExits = new System.Windows.Forms.Button();
            this.btnVehicleExits = new System.Windows.Forms.Button();
            this.lblTicketValidator = new System.Windows.Forms.Label();
            this.btnEmergencyExit = new System.Windows.Forms.Button();
            this.btnVehicleArrivesExit = new System.Windows.Forms.Button();
            this.btnPrePaidExit = new System.Windows.Forms.Button();
            this.btnNormalExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrePaidEnters = new System.Windows.Forms.Button();
            this.btnVehicleEnters = new System.Windows.Forms.Button();
            this.btnEmergencyEntrance = new System.Windows.Forms.Button();
            this.btnPrePaidEntrance = new System.Windows.Forms.Button();
            this.btnNormalEntrance = new System.Windows.Forms.Button();
            this.btnVehicleArrivesEntrance = new System.Windows.Forms.Button();
            this.lblTicketMachine = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.Entry.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPayCash
            // 
            this.btnPayCash.Location = new System.Drawing.Point(641, 15);
            this.btnPayCash.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(249, 39);
            this.btnPayCash.TabIndex = 22;
            this.btnPayCash.Text = "Pay Cash";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayTicket_Click);
            // 
            // btnPayCard
            // 
            this.btnPayCard.Location = new System.Drawing.Point(641, 60);
            this.btnPayCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(249, 39);
            this.btnPayCard.TabIndex = 21;
            this.btnPayCard.Text = "Pay Card";
            this.btnPayCard.UseVisualStyleBackColor = true;
            this.btnPayCard.Click += new System.EventHandler(this.btnPayTicket_Click);
            // 
            // btnPayBitCoin
            // 
            this.btnPayBitCoin.Location = new System.Drawing.Point(641, 107);
            this.btnPayBitCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayBitCoin.Name = "btnPayBitCoin";
            this.btnPayBitCoin.Size = new System.Drawing.Size(249, 39);
            this.btnPayBitCoin.TabIndex = 20;
            this.btnPayBitCoin.Text = "Pay Bit Coin";
            this.btnPayBitCoin.UseVisualStyleBackColor = true;
            this.btnPayBitCoin.Click += new System.EventHandler(this.btnPayTicket_Click);
            // 
            // btnSecureAdvancePayment
            // 
            this.btnSecureAdvancePayment.Location = new System.Drawing.Point(899, 94);
            this.btnSecureAdvancePayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecureAdvancePayment.Name = "btnSecureAdvancePayment";
            this.btnSecureAdvancePayment.Size = new System.Drawing.Size(276, 50);
            this.btnSecureAdvancePayment.TabIndex = 19;
            this.btnSecureAdvancePayment.Text = "Secure parking advance payment";
            this.btnSecureAdvancePayment.UseVisualStyleBackColor = true;
            this.btnSecureAdvancePayment.Click += new System.EventHandler(this.btnSecureAdvancePayment_Click);
            // 
            // btnToggleEmergency
            // 
            this.btnToggleEmergency.Location = new System.Drawing.Point(899, 36);
            this.btnToggleEmergency.Margin = new System.Windows.Forms.Padding(4);
            this.btnToggleEmergency.Name = "btnToggleEmergency";
            this.btnToggleEmergency.Size = new System.Drawing.Size(277, 50);
            this.btnToggleEmergency.TabIndex = 18;
            this.btnToggleEmergency.Text = "Emergency";
            this.btnToggleEmergency.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstPrePaidTickets);
            this.groupBox5.Location = new System.Drawing.Point(960, 178);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(225, 581);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prepaid tickets";
            // 
            // lstPrePaidTickets
            // 
            this.lstPrePaidTickets.FormattingEnabled = true;
            this.lstPrePaidTickets.ItemHeight = 16;
            this.lstPrePaidTickets.Location = new System.Drawing.Point(9, 23);
            this.lstPrePaidTickets.Margin = new System.Windows.Forms.Padding(4);
            this.lstPrePaidTickets.Name = "lstPrePaidTickets";
            this.lstPrePaidTickets.Size = new System.Drawing.Size(207, 532);
            this.lstPrePaidTickets.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstActiveTickets);
            this.groupBox4.Location = new System.Drawing.Point(727, 178);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(225, 581);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active tickets";
            // 
            // lstActiveTickets
            // 
            this.lstActiveTickets.FormattingEnabled = true;
            this.lstActiveTickets.ItemHeight = 16;
            this.lstActiveTickets.Location = new System.Drawing.Point(8, 23);
            this.lstActiveTickets.Margin = new System.Windows.Forms.Padding(4);
            this.lstActiveTickets.Name = "lstActiveTickets";
            this.lstActiveTickets.Size = new System.Drawing.Size(207, 532);
            this.lstActiveTickets.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.Entry);
            this.groupBox3.Location = new System.Drawing.Point(493, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(709, 615);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblEmergencyVehicles);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.lblEmergencySign);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Location = new System.Drawing.Point(8, 502);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(209, 103);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Emergency";
            // 
            // lblEmergencyVehicles
            // 
            this.lblEmergencyVehicles.BackColor = System.Drawing.Color.White;
            this.lblEmergencyVehicles.Location = new System.Drawing.Point(100, 62);
            this.lblEmergencyVehicles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmergencyVehicles.Name = "lblEmergencyVehicles";
            this.lblEmergencyVehicles.Size = new System.Drawing.Size(101, 28);
            this.lblEmergencyVehicles.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 27);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "Emergecy";
            // 
            // lblEmergencySign
            // 
            this.lblEmergencySign.BackColor = System.Drawing.Color.White;
            this.lblEmergencySign.Location = new System.Drawing.Point(100, 23);
            this.lblEmergencySign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmergencySign.Name = "lblEmergencySign";
            this.lblEmergencySign.Size = new System.Drawing.Size(101, 28);
            this.lblEmergencySign.TabIndex = 12;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1, 66);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(99, 17);
            this.label25.TabIndex = 13;
            this.label25.Text = "No of Vehicles";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblFloor0Spaces);
            this.groupBox8.Controls.Add(this.lblFloor2Spaces);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.lblFloor1Spaces);
            this.groupBox8.Controls.Add(this.lblFullSign);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(8, 315);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(209, 180);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Spaces";
            // 
            // lblFloor0Spaces
            // 
            this.lblFloor0Spaces.BackColor = System.Drawing.Color.White;
            this.lblFloor0Spaces.Location = new System.Drawing.Point(100, 138);
            this.lblFloor0Spaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloor0Spaces.Name = "lblFloor0Spaces";
            this.lblFloor0Spaces.Size = new System.Drawing.Size(101, 28);
            this.lblFloor0Spaces.TabIndex = 14;
            // 
            // lblFloor2Spaces
            // 
            this.lblFloor2Spaces.BackColor = System.Drawing.Color.White;
            this.lblFloor2Spaces.Location = new System.Drawing.Point(100, 62);
            this.lblFloor2Spaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloor2Spaces.Name = "lblFloor2Spaces";
            this.lblFloor2Spaces.Size = new System.Drawing.Size(101, 28);
            this.lblFloor2Spaces.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 103);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Floor 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 142);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Floor 0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Full sign";
            // 
            // lblFloor1Spaces
            // 
            this.lblFloor1Spaces.BackColor = System.Drawing.Color.White;
            this.lblFloor1Spaces.Location = new System.Drawing.Point(100, 100);
            this.lblFloor1Spaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloor1Spaces.Name = "lblFloor1Spaces";
            this.lblFloor1Spaces.Size = new System.Drawing.Size(101, 28);
            this.lblFloor1Spaces.TabIndex = 12;
            // 
            // lblFullSign
            // 
            this.lblFullSign.BackColor = System.Drawing.Color.White;
            this.lblFullSign.Location = new System.Drawing.Point(100, 23);
            this.lblFullSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(101, 28);
            this.lblFullSign.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 65);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Floor 2";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnExitOverride);
            this.groupBox7.Controls.Add(this.lblExitBarrier);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.lblExitSensor);
            this.groupBox7.Location = new System.Drawing.Point(8, 170);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(209, 138);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Exit";
            // 
            // btnExitOverride
            // 
            this.btnExitOverride.Location = new System.Drawing.Point(8, 95);
            this.btnExitOverride.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitOverride.Name = "btnExitOverride";
            this.btnExitOverride.Size = new System.Drawing.Size(193, 32);
            this.btnExitOverride.TabIndex = 10;
            this.btnExitOverride.Text = "Override";
            this.btnExitOverride.UseVisualStyleBackColor = true;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(100, 57);
            this.lblExitBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(101, 28);
            this.lblExitBarrier.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sensor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Barrier";
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(100, 18);
            this.lblExitSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(101, 28);
            this.lblExitSensor.TabIndex = 7;
            // 
            // Entry
            // 
            this.Entry.Controls.Add(this.btnBarrierOverride);
            this.Entry.Controls.Add(this.lblEntryBarrier);
            this.Entry.Controls.Add(this.label6);
            this.Entry.Controls.Add(this.lblEntrySensor);
            this.Entry.Controls.Add(this.label2);
            this.Entry.Location = new System.Drawing.Point(8, 25);
            this.Entry.Margin = new System.Windows.Forms.Padding(4);
            this.Entry.Name = "Entry";
            this.Entry.Padding = new System.Windows.Forms.Padding(4);
            this.Entry.Size = new System.Drawing.Size(209, 138);
            this.Entry.TabIndex = 4;
            this.Entry.TabStop = false;
            this.Entry.Text = "Entry";
            // 
            // btnBarrierOverride
            // 
            this.btnBarrierOverride.Location = new System.Drawing.Point(8, 96);
            this.btnBarrierOverride.Margin = new System.Windows.Forms.Padding(4);
            this.btnBarrierOverride.Name = "btnBarrierOverride";
            this.btnBarrierOverride.Size = new System.Drawing.Size(193, 32);
            this.btnBarrierOverride.TabIndex = 5;
            this.btnBarrierOverride.Text = "Override";
            this.btnBarrierOverride.UseVisualStyleBackColor = true;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(100, 58);
            this.lblEntryBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(101, 28);
            this.lblEntryBarrier.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Barrier";
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(100, 20);
            this.lblEntrySensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(101, 28);
            this.lblEntrySensor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrePaidExits);
            this.groupBox2.Controls.Add(this.btnVehicleExits);
            this.groupBox2.Controls.Add(this.lblTicketValidator);
            this.groupBox2.Controls.Add(this.btnEmergencyExit);
            this.groupBox2.Controls.Add(this.btnVehicleArrivesExit);
            this.groupBox2.Controls.Add(this.btnPrePaidExit);
            this.groupBox2.Controls.Add(this.btnNormalExit);
            this.groupBox2.Location = new System.Drawing.Point(260, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(225, 615);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
            // 
            // btnPrePaidExits
            // 
            this.btnPrePaidExits.Location = new System.Drawing.Point(8, 366);
            this.btnPrePaidExits.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrePaidExits.Name = "btnPrePaidExits";
            this.btnPrePaidExits.Size = new System.Drawing.Size(209, 53);
            this.btnPrePaidExits.TabIndex = 11;
            this.btnPrePaidExits.Text = "Pre paid vehicle exits car park";
            this.btnPrePaidExits.UseVisualStyleBackColor = true;
            this.btnPrePaidExits.Click += new System.EventHandler(this.PrePaidCarExitsCarPark);
            // 
            // btnVehicleExits
            // 
            this.btnVehicleExits.Location = new System.Drawing.Point(8, 305);
            this.btnVehicleExits.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicleExits.Name = "btnVehicleExits";
            this.btnVehicleExits.Size = new System.Drawing.Size(209, 53);
            this.btnVehicleExits.TabIndex = 10;
            this.btnVehicleExits.Text = "Vehicle exits car park";
            this.btnVehicleExits.UseVisualStyleBackColor = true;
            this.btnVehicleExits.Click += new System.EventHandler(this.CarExitsCarPark);
            // 
            // lblTicketValidator
            // 
            this.lblTicketValidator.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketValidator.Location = new System.Drawing.Point(8, 20);
            this.lblTicketValidator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketValidator.Name = "lblTicketValidator";
            this.lblTicketValidator.Size = new System.Drawing.Size(209, 41);
            this.lblTicketValidator.TabIndex = 1;
            // 
            // btnEmergencyExit
            // 
            this.btnEmergencyExit.Location = new System.Drawing.Point(8, 245);
            this.btnEmergencyExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencyExit.Name = "btnEmergencyExit";
            this.btnEmergencyExit.Size = new System.Drawing.Size(209, 53);
            this.btnEmergencyExit.TabIndex = 9;
            this.btnEmergencyExit.Text = "Emergency vehicle";
            this.btnEmergencyExit.UseVisualStyleBackColor = true;
            // 
            // btnVehicleArrivesExit
            // 
            this.btnVehicleArrivesExit.Location = new System.Drawing.Point(8, 64);
            this.btnVehicleArrivesExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicleArrivesExit.Name = "btnVehicleArrivesExit";
            this.btnVehicleArrivesExit.Size = new System.Drawing.Size(209, 53);
            this.btnVehicleArrivesExit.TabIndex = 6;
            this.btnVehicleArrivesExit.Text = "Vehicle arrives at exit";
            this.btnVehicleArrivesExit.UseVisualStyleBackColor = true;
            this.btnVehicleArrivesExit.Click += new System.EventHandler(this.CarArrivesAtExit);
            // 
            // btnPrePaidExit
            // 
            this.btnPrePaidExit.Location = new System.Drawing.Point(8, 185);
            this.btnPrePaidExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrePaidExit.Name = "btnPrePaidExit";
            this.btnPrePaidExit.Size = new System.Drawing.Size(209, 53);
            this.btnPrePaidExit.TabIndex = 8;
            this.btnPrePaidExit.Text = "Prepaid car enters their code to exit";
            this.btnPrePaidExit.UseVisualStyleBackColor = true;
            this.btnPrePaidExit.Click += new System.EventHandler(this.PrePaidEnteredToken);
            // 
            // btnNormalExit
            // 
            this.btnNormalExit.Location = new System.Drawing.Point(8, 124);
            this.btnNormalExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnNormalExit.Name = "btnNormalExit";
            this.btnNormalExit.Size = new System.Drawing.Size(209, 53);
            this.btnNormalExit.TabIndex = 7;
            this.btnNormalExit.Text = "Normal vehicle enters their paid chip coin";
            this.btnNormalExit.UseVisualStyleBackColor = true;
            this.btnNormalExit.Click += new System.EventHandler(this.DriverEntersTicket);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrePaidEnters);
            this.groupBox1.Controls.Add(this.btnVehicleEnters);
            this.groupBox1.Controls.Add(this.btnEmergencyEntrance);
            this.groupBox1.Controls.Add(this.btnPrePaidEntrance);
            this.groupBox1.Controls.Add(this.btnNormalEntrance);
            this.groupBox1.Controls.Add(this.btnVehicleArrivesEntrance);
            this.groupBox1.Controls.Add(this.lblTicketMachine);
            this.groupBox1.Location = new System.Drawing.Point(27, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(225, 615);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
            // 
            // btnPrePaidEnters
            // 
            this.btnPrePaidEnters.Location = new System.Drawing.Point(8, 366);
            this.btnPrePaidEnters.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrePaidEnters.Name = "btnPrePaidEnters";
            this.btnPrePaidEnters.Size = new System.Drawing.Size(209, 53);
            this.btnPrePaidEnters.TabIndex = 6;
            this.btnPrePaidEnters.Text = "Pre paid vehicle enters car park";
            this.btnPrePaidEnters.UseVisualStyleBackColor = true;
            this.btnPrePaidEnters.Click += new System.EventHandler(this.PrePaidCarEntersCarPark);
            // 
            // btnVehicleEnters
            // 
            this.btnVehicleEnters.Location = new System.Drawing.Point(8, 305);
            this.btnVehicleEnters.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicleEnters.Name = "btnVehicleEnters";
            this.btnVehicleEnters.Size = new System.Drawing.Size(209, 53);
            this.btnVehicleEnters.TabIndex = 5;
            this.btnVehicleEnters.Text = "Vehicle enters car park";
            this.btnVehicleEnters.UseVisualStyleBackColor = true;
            this.btnVehicleEnters.Click += new System.EventHandler(this.CarEntersCarPark);
            // 
            // btnEmergencyEntrance
            // 
            this.btnEmergencyEntrance.Location = new System.Drawing.Point(8, 245);
            this.btnEmergencyEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencyEntrance.Name = "btnEmergencyEntrance";
            this.btnEmergencyEntrance.Size = new System.Drawing.Size(209, 53);
            this.btnEmergencyEntrance.TabIndex = 4;
            this.btnEmergencyEntrance.Text = "Emergency vehicle";
            this.btnEmergencyEntrance.UseVisualStyleBackColor = true;
            // 
            // btnPrePaidEntrance
            // 
            this.btnPrePaidEntrance.Location = new System.Drawing.Point(8, 185);
            this.btnPrePaidEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrePaidEntrance.Name = "btnPrePaidEntrance";
            this.btnPrePaidEntrance.Size = new System.Drawing.Size(209, 53);
            this.btnPrePaidEntrance.TabIndex = 3;
            this.btnPrePaidEntrance.Text = "Prepaid vehicle enters their code";
            this.btnPrePaidEntrance.UseVisualStyleBackColor = true;
            this.btnPrePaidEntrance.Click += new System.EventHandler(this.DriverPrePaid);
            // 
            // btnNormalEntrance
            // 
            this.btnNormalEntrance.Location = new System.Drawing.Point(8, 124);
            this.btnNormalEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnNormalEntrance.Name = "btnNormalEntrance";
            this.btnNormalEntrance.Size = new System.Drawing.Size(209, 53);
            this.btnNormalEntrance.TabIndex = 2;
            this.btnNormalEntrance.Text = "Normal vehicle gets chip coin";
            this.btnNormalEntrance.UseVisualStyleBackColor = true;
            this.btnNormalEntrance.Click += new System.EventHandler(this.DriverPressesForTicket);
            // 
            // btnVehicleArrivesEntrance
            // 
            this.btnVehicleArrivesEntrance.Location = new System.Drawing.Point(8, 64);
            this.btnVehicleArrivesEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehicleArrivesEntrance.Name = "btnVehicleArrivesEntrance";
            this.btnVehicleArrivesEntrance.Size = new System.Drawing.Size(209, 53);
            this.btnVehicleArrivesEntrance.TabIndex = 1;
            this.btnVehicleArrivesEntrance.Text = "Vehicle arrives at entrance";
            this.btnVehicleArrivesEntrance.UseVisualStyleBackColor = true;
            this.btnVehicleArrivesEntrance.Click += new System.EventHandler(this.CarArrivesAtEntrance);
            // 
            // lblTicketMachine
            // 
            this.lblTicketMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketMachine.Location = new System.Drawing.Point(8, 20);
            this.lblTicketMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketMachine.Name = "lblTicketMachine";
            this.lblTicketMachine.Size = new System.Drawing.Size(209, 41);
            this.lblTicketMachine.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(27, 71);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(577, 74);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSystem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "Car park - Arundel Gate";
            // 
            // CarParkPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 795);
            this.Controls.Add(this.btnPayCash);
            this.Controls.Add(this.btnPayCard);
            this.Controls.Add(this.btnPayBitCoin);
            this.Controls.Add(this.btnSecureAdvancePayment);
            this.Controls.Add(this.btnToggleEmergency);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarParkPrototype";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.Entry.ResumeLayout(false);
            this.Entry.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnPayCard;
        private System.Windows.Forms.Button btnPayBitCoin;
        private System.Windows.Forms.Button btnSecureAdvancePayment;
        private System.Windows.Forms.Button btnToggleEmergency;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstPrePaidTickets;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstActiveTickets;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblFloor0Spaces;
        private System.Windows.Forms.Label lblFloor2Spaces;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFloor1Spaces;
        private System.Windows.Forms.Label lblFullSign;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnExitOverride;
        private System.Windows.Forms.Label lblExitBarrier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblExitSensor;
        private System.Windows.Forms.GroupBox Entry;
        private System.Windows.Forms.Button btnBarrierOverride;
        private System.Windows.Forms.Label lblEntryBarrier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEntrySensor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVehicleExits;
        private System.Windows.Forms.Label lblTicketValidator;
        private System.Windows.Forms.Button btnEmergencyExit;
        private System.Windows.Forms.Button btnVehicleArrivesExit;
        private System.Windows.Forms.Button btnPrePaidExit;
        private System.Windows.Forms.Button btnNormalExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVehicleEnters;
        private System.Windows.Forms.Button btnEmergencyEntrance;
        private System.Windows.Forms.Button btnPrePaidEntrance;
        private System.Windows.Forms.Button btnNormalEntrance;
        private System.Windows.Forms.Button btnVehicleArrivesEntrance;
        private System.Windows.Forms.Label lblTicketMachine;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblEmergencyVehicles;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblEmergencySign;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnPrePaidEnters;
        private System.Windows.Forms.Button btnPrePaidExits;
    }
}

