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
            this.lstPrepaidTickets = new System.Windows.Forms.ListBox();
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
            this.btnVehicleExits = new System.Windows.Forms.Button();
            this.lblTicketValidator = new System.Windows.Forms.Label();
            this.btnEmergencyExit = new System.Windows.Forms.Button();
            this.btnVehicleArrivesExit = new System.Windows.Forms.Button();
            this.btnPrepaidExit = new System.Windows.Forms.Button();
            this.btnNormalExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVehicleEnters = new System.Windows.Forms.Button();
            this.btnEmergencyEntrance = new System.Windows.Forms.Button();
            this.btnPrepaidEntrance = new System.Windows.Forms.Button();
            this.btnNormalEntrance = new System.Windows.Forms.Button();
            this.btnVehicleArrivesEntrance = new System.Windows.Forms.Button();
            this.lblTicketMachine = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEmergencyPay = new System.Windows.Forms.Button();
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
            this.btnPayCash.Location = new System.Drawing.Point(481, 12);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(187, 32);
            this.btnPayCash.TabIndex = 22;
            this.btnPayCash.Text = "Pay cash";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayTicket_Click);
            // 
            // btnPayCard
            // 
            this.btnPayCard.Location = new System.Drawing.Point(481, 49);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(187, 32);
            this.btnPayCard.TabIndex = 21;
            this.btnPayCard.Text = "Pay Card";
            this.btnPayCard.UseVisualStyleBackColor = true;
            this.btnPayCard.Click += new System.EventHandler(this.btnPayTicket_Click);
            // 
            // btnPayBitCoin
            // 
            this.btnPayBitCoin.Location = new System.Drawing.Point(481, 87);
            this.btnPayBitCoin.Name = "btnPayBitCoin";
            this.btnPayBitCoin.Size = new System.Drawing.Size(187, 32);
            this.btnPayBitCoin.TabIndex = 20;
            this.btnPayBitCoin.Text = "Pay Bit Coin";
            this.btnPayBitCoin.UseVisualStyleBackColor = true;
            this.btnPayBitCoin.Click += new System.EventHandler(this.btnPayTicket_Click);
            // 
            // btnSecureAdvancePayment
            // 
            this.btnSecureAdvancePayment.Location = new System.Drawing.Point(674, 50);
            this.btnSecureAdvancePayment.Name = "btnSecureAdvancePayment";
            this.btnSecureAdvancePayment.Size = new System.Drawing.Size(207, 31);
            this.btnSecureAdvancePayment.TabIndex = 19;
            this.btnSecureAdvancePayment.Text = "Secure parking advance payment";
            this.btnSecureAdvancePayment.UseVisualStyleBackColor = true;
            // 
            // btnToggleEmergency
            // 
            this.btnToggleEmergency.BackColor = System.Drawing.Color.Red;
            this.btnToggleEmergency.Location = new System.Drawing.Point(674, 12);
            this.btnToggleEmergency.Name = "btnToggleEmergency";
            this.btnToggleEmergency.Size = new System.Drawing.Size(208, 32);
            this.btnToggleEmergency.TabIndex = 18;
            this.btnToggleEmergency.Text = "Emergency";
            this.btnToggleEmergency.UseVisualStyleBackColor = false;
            this.btnToggleEmergency.Click += new System.EventHandler(this.btnToggleEmergency_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstPrepaidTickets);
            this.groupBox5.Location = new System.Drawing.Point(720, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 472);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prepaid tickets";
            // 
            // lstPrepaidTickets
            // 
            this.lstPrepaidTickets.FormattingEnabled = true;
            this.lstPrepaidTickets.Location = new System.Drawing.Point(7, 19);
            this.lstPrepaidTickets.Name = "lstPrepaidTickets";
            this.lstPrepaidTickets.Size = new System.Drawing.Size(156, 433);
            this.lstPrepaidTickets.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstActiveTickets);
            this.groupBox4.Location = new System.Drawing.Point(545, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 472);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active tickets";
            // 
            // lstActiveTickets
            // 
            this.lstActiveTickets.FormattingEnabled = true;
            this.lstActiveTickets.Location = new System.Drawing.Point(6, 19);
            this.lstActiveTickets.Name = "lstActiveTickets";
            this.lstActiveTickets.Size = new System.Drawing.Size(156, 433);
            this.lstActiveTickets.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.Entry);
            this.groupBox3.Location = new System.Drawing.Point(370, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 500);
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
            this.groupBox6.Location = new System.Drawing.Point(6, 408);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 84);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Emergency";
            // 
            // lblEmergencyVehicles
            // 
            this.lblEmergencyVehicles.BackColor = System.Drawing.Color.White;
            this.lblEmergencyVehicles.Location = new System.Drawing.Point(75, 50);
            this.lblEmergencyVehicles.Name = "lblEmergencyVehicles";
            this.lblEmergencyVehicles.Size = new System.Drawing.Size(76, 23);
            this.lblEmergencyVehicles.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "Emergency";
            // 
            // lblEmergencySign
            // 
            this.lblEmergencySign.BackColor = System.Drawing.Color.White;
            this.lblEmergencySign.Location = new System.Drawing.Point(75, 19);
            this.lblEmergencySign.Name = "lblEmergencySign";
            this.lblEmergencySign.Size = new System.Drawing.Size(76, 23);
            this.lblEmergencySign.TabIndex = 12;
            this.lblEmergencySign.Click += new System.EventHandler(this.lblEmergencySign_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 13);
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
            this.groupBox8.Location = new System.Drawing.Point(6, 256);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(157, 146);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Spaces";
            // 
            // lblFloor0Spaces
            // 
            this.lblFloor0Spaces.BackColor = System.Drawing.Color.White;
            this.lblFloor0Spaces.Location = new System.Drawing.Point(75, 112);
            this.lblFloor0Spaces.Name = "lblFloor0Spaces";
            this.lblFloor0Spaces.Size = new System.Drawing.Size(76, 23);
            this.lblFloor0Spaces.TabIndex = 14;
            // 
            // lblFloor2Spaces
            // 
            this.lblFloor2Spaces.BackColor = System.Drawing.Color.White;
            this.lblFloor2Spaces.Location = new System.Drawing.Point(75, 50);
            this.lblFloor2Spaces.Name = "lblFloor2Spaces";
            this.lblFloor2Spaces.Size = new System.Drawing.Size(76, 23);
            this.lblFloor2Spaces.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Floor 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Floor 0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Full sign";
            // 
            // lblFloor1Spaces
            // 
            this.lblFloor1Spaces.BackColor = System.Drawing.Color.White;
            this.lblFloor1Spaces.Location = new System.Drawing.Point(75, 81);
            this.lblFloor1Spaces.Name = "lblFloor1Spaces";
            this.lblFloor1Spaces.Size = new System.Drawing.Size(76, 23);
            this.lblFloor1Spaces.TabIndex = 12;
            // 
            // lblFullSign
            // 
            this.lblFullSign.BackColor = System.Drawing.Color.White;
            this.lblFullSign.Location = new System.Drawing.Point(75, 19);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(76, 23);
            this.lblFullSign.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
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
            this.groupBox7.Location = new System.Drawing.Point(6, 138);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(157, 112);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Exit";
            // 
            // btnExitOverride
            // 
            this.btnExitOverride.Location = new System.Drawing.Point(6, 77);
            this.btnExitOverride.Name = "btnExitOverride";
            this.btnExitOverride.Size = new System.Drawing.Size(145, 26);
            this.btnExitOverride.TabIndex = 10;
            this.btnExitOverride.Text = "Override";
            this.btnExitOverride.UseVisualStyleBackColor = true;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(75, 46);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(76, 23);
            this.lblExitBarrier.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sensor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Barrier";
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(75, 15);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(76, 23);
            this.lblExitSensor.TabIndex = 7;
            // 
            // Entry
            // 
            this.Entry.Controls.Add(this.btnBarrierOverride);
            this.Entry.Controls.Add(this.lblEntryBarrier);
            this.Entry.Controls.Add(this.label6);
            this.Entry.Controls.Add(this.lblEntrySensor);
            this.Entry.Controls.Add(this.label2);
            this.Entry.Location = new System.Drawing.Point(6, 20);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(157, 112);
            this.Entry.TabIndex = 4;
            this.Entry.TabStop = false;
            this.Entry.Text = "Entry";
            // 
            // btnBarrierOverride
            // 
            this.btnBarrierOverride.Location = new System.Drawing.Point(6, 78);
            this.btnBarrierOverride.Name = "btnBarrierOverride";
            this.btnBarrierOverride.Size = new System.Drawing.Size(145, 26);
            this.btnBarrierOverride.TabIndex = 5;
            this.btnBarrierOverride.Text = "Override";
            this.btnBarrierOverride.UseVisualStyleBackColor = true;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(75, 47);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(76, 23);
            this.lblEntryBarrier.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Barrier";
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(75, 16);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(76, 23);
            this.lblEntrySensor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVehicleExits);
            this.groupBox2.Controls.Add(this.lblTicketValidator);
            this.groupBox2.Controls.Add(this.btnEmergencyExit);
            this.groupBox2.Controls.Add(this.btnVehicleArrivesExit);
            this.groupBox2.Controls.Add(this.btnPrepaidExit);
            this.groupBox2.Controls.Add(this.btnNormalExit);
            this.groupBox2.Location = new System.Drawing.Point(195, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 500);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
            // 
            // btnVehicleExits
            // 
            this.btnVehicleExits.Location = new System.Drawing.Point(6, 248);
            this.btnVehicleExits.Name = "btnVehicleExits";
            this.btnVehicleExits.Size = new System.Drawing.Size(157, 43);
            this.btnVehicleExits.TabIndex = 10;
            this.btnVehicleExits.Text = "Vehicle exits car park";
            this.btnVehicleExits.UseVisualStyleBackColor = true;
            this.btnVehicleExits.Click += new System.EventHandler(this.CarExitsCarPark);
            // 
            // lblTicketValidator
            // 
            this.lblTicketValidator.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketValidator.Location = new System.Drawing.Point(6, 16);
            this.lblTicketValidator.Name = "lblTicketValidator";
            this.lblTicketValidator.Size = new System.Drawing.Size(157, 33);
            this.lblTicketValidator.TabIndex = 1;
            // 
            // btnEmergencyExit
            // 
            this.btnEmergencyExit.Location = new System.Drawing.Point(6, 199);
            this.btnEmergencyExit.Name = "btnEmergencyExit";
            this.btnEmergencyExit.Size = new System.Drawing.Size(157, 43);
            this.btnEmergencyExit.TabIndex = 9;
            this.btnEmergencyExit.Text = "Emergency vehicle";
            this.btnEmergencyExit.UseVisualStyleBackColor = true;
            this.btnEmergencyExit.Click += new System.EventHandler(this.btnEmergencyExit_Click);
            // 
            // btnVehicleArrivesExit
            // 
            this.btnVehicleArrivesExit.Location = new System.Drawing.Point(6, 52);
            this.btnVehicleArrivesExit.Name = "btnVehicleArrivesExit";
            this.btnVehicleArrivesExit.Size = new System.Drawing.Size(157, 43);
            this.btnVehicleArrivesExit.TabIndex = 6;
            this.btnVehicleArrivesExit.Text = "Vehicle arrives at exit";
            this.btnVehicleArrivesExit.UseVisualStyleBackColor = true;
            this.btnVehicleArrivesExit.Click += new System.EventHandler(this.CarArrivesAtExit);
            // 
            // btnPrepaidExit
            // 
            this.btnPrepaidExit.Location = new System.Drawing.Point(6, 150);
            this.btnPrepaidExit.Name = "btnPrepaidExit";
            this.btnPrepaidExit.Size = new System.Drawing.Size(157, 43);
            this.btnPrepaidExit.TabIndex = 8;
            this.btnPrepaidExit.Text = "Prepaid car enters their code to exit";
            this.btnPrepaidExit.UseVisualStyleBackColor = true;
            // 
            // btnNormalExit
            // 
            this.btnNormalExit.Location = new System.Drawing.Point(6, 101);
            this.btnNormalExit.Name = "btnNormalExit";
            this.btnNormalExit.Size = new System.Drawing.Size(157, 43);
            this.btnNormalExit.TabIndex = 7;
            this.btnNormalExit.Text = "Normal vehicle enters their paid chip coin";
            this.btnNormalExit.UseVisualStyleBackColor = true;
            this.btnNormalExit.Click += new System.EventHandler(this.DriverEntersTicket);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVehicleEnters);
            this.groupBox1.Controls.Add(this.btnEmergencyEntrance);
            this.groupBox1.Controls.Add(this.btnPrepaidEntrance);
            this.groupBox1.Controls.Add(this.btnNormalEntrance);
            this.groupBox1.Controls.Add(this.btnVehicleArrivesEntrance);
            this.groupBox1.Controls.Add(this.lblTicketMachine);
            this.groupBox1.Location = new System.Drawing.Point(20, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 500);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
            // 
            // btnVehicleEnters
            // 
            this.btnVehicleEnters.Location = new System.Drawing.Point(6, 248);
            this.btnVehicleEnters.Name = "btnVehicleEnters";
            this.btnVehicleEnters.Size = new System.Drawing.Size(157, 43);
            this.btnVehicleEnters.TabIndex = 5;
            this.btnVehicleEnters.Text = "Vehicle enters car park";
            this.btnVehicleEnters.UseVisualStyleBackColor = true;
            this.btnVehicleEnters.Click += new System.EventHandler(this.CarEntersCarPark);
            // 
            // btnEmergencyEntrance
            // 
            this.btnEmergencyEntrance.Location = new System.Drawing.Point(6, 199);
            this.btnEmergencyEntrance.Name = "btnEmergencyEntrance";
            this.btnEmergencyEntrance.Size = new System.Drawing.Size(157, 43);
            this.btnEmergencyEntrance.TabIndex = 4;
            this.btnEmergencyEntrance.Text = "Emergency vehicle";
            this.btnEmergencyEntrance.UseVisualStyleBackColor = true;
            this.btnEmergencyEntrance.Click += new System.EventHandler(this.btnEmergencyEntrance_Click);
            // 
            // btnPrepaidEntrance
            // 
            this.btnPrepaidEntrance.Location = new System.Drawing.Point(6, 150);
            this.btnPrepaidEntrance.Name = "btnPrepaidEntrance";
            this.btnPrepaidEntrance.Size = new System.Drawing.Size(157, 43);
            this.btnPrepaidEntrance.TabIndex = 3;
            this.btnPrepaidEntrance.Text = "Prepaid vehicle enters their code";
            this.btnPrepaidEntrance.UseVisualStyleBackColor = true;
            // 
            // btnNormalEntrance
            // 
            this.btnNormalEntrance.Location = new System.Drawing.Point(6, 101);
            this.btnNormalEntrance.Name = "btnNormalEntrance";
            this.btnNormalEntrance.Size = new System.Drawing.Size(157, 43);
            this.btnNormalEntrance.TabIndex = 2;
            this.btnNormalEntrance.Text = "Normal vehicle gets chip coin";
            this.btnNormalEntrance.UseVisualStyleBackColor = true;
            this.btnNormalEntrance.Click += new System.EventHandler(this.DriverPressesForTicket);
            // 
            // btnVehicleArrivesEntrance
            // 
            this.btnVehicleArrivesEntrance.Location = new System.Drawing.Point(6, 52);
            this.btnVehicleArrivesEntrance.Name = "btnVehicleArrivesEntrance";
            this.btnVehicleArrivesEntrance.Size = new System.Drawing.Size(157, 43);
            this.btnVehicleArrivesEntrance.TabIndex = 1;
            this.btnVehicleArrivesEntrance.Text = "Vehicle arrives at entrance";
            this.btnVehicleArrivesEntrance.UseVisualStyleBackColor = true;
            this.btnVehicleArrivesEntrance.Click += new System.EventHandler(this.CarArrivesAtEntrance);
            // 
            // lblTicketMachine
            // 
            this.lblTicketMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblTicketMachine.Location = new System.Drawing.Point(6, 16);
            this.lblTicketMachine.Name = "lblTicketMachine";
            this.lblTicketMachine.Size = new System.Drawing.Size(157, 33);
            this.lblTicketMachine.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(20, 58);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(433, 60);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSystem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Car park - Arundel Gate";
            // 
            // btnEmergencyPay
            // 
            this.btnEmergencyPay.Location = new System.Drawing.Point(674, 86);
            this.btnEmergencyPay.Name = "btnEmergencyPay";
            this.btnEmergencyPay.Size = new System.Drawing.Size(207, 32);
            this.btnEmergencyPay.TabIndex = 23;
            this.btnEmergencyPay.Text = "Pay Emergency Vehicle";
            this.btnEmergencyPay.UseVisualStyleBackColor = true;
            this.btnEmergencyPay.Click += new System.EventHandler(this.btnEmergencyPay_Click);
            // 
            // CarParkPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 646);
            this.Controls.Add(this.btnEmergencyPay);
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
        private System.Windows.Forms.ListBox lstPrepaidTickets;
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
        private System.Windows.Forms.Button btnPrepaidExit;
        private System.Windows.Forms.Button btnNormalExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVehicleEnters;
        private System.Windows.Forms.Button btnPrepaidEntrance;
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
        private System.Windows.Forms.Button btnEmergencyPay;
        private System.Windows.Forms.Button btnEmergencyEntrance;
    }
}

