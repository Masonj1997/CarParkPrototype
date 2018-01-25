using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp27
{
    public partial class CarParkPrototype : Form
    {
        // Attributes ///        
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private ActivePrePaid activePrePaidTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;
        /////////////////

        // Constructor //
        public CarParkPrototype()
        {
            InitializeComponent();
        }

        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            // STUDENTS:
            ///// Class contructors are not defined so there will be errors
            ///// This code is correct for the basic version though
            activeTickets = new ActiveTickets();
            activePrePaidTickets = new ActivePrePaid();
            ticketMachine = new TicketMachine(activeTickets, activePrePaidTickets);
            ticketValidator = new TicketValidator(activeTickets, activePrePaidTickets);
            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnVehicleArrivesEntrance.Visible = true;
            btnNormalEntrance.Visible = false;
            btnPrePaidEntrance.Visible = false;
            btnEmergencyEntrance.Visible = false;
            btnPrePaidEnters.Visible = false;
            btnVehicleEnters.Visible = false;

            btnVehicleArrivesExit.Visible = false;
            btnNormalExit.Visible = false;
            btnPrePaidExit.Visible = false;
            btnEmergencyExit.Visible = false;
            btnVehicleExits.Visible = false;
            btnPrePaidExits.Visible = false;

            lblTicketMachine.Text = "";
            lblTicketValidator.Text = "";
            lstActiveTickets.Items.Clear();
            lstPrePaidTickets.Items.Clear();

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.CarDetected();
            UpdateDisplay();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket();
            UpdateDisplay();
        }

        private void DriverPrePaid(object sender, EventArgs e)
        {
            bool ticketChecked = false;
            do
            {
                int ticketNo = Convert.ToInt32(Interaction.InputBox("Please enter the ticket number of the ticket you wish to use: ", "Pay Ticket", "0"));
                //Ticket is valid if the entered ticket number matches an existing ticket and said ticket hasn't already been paid for
                if (ticketValidator.EnterPrePaidCode(ticketNo) && activePrePaidTickets.InCarPark(ticketNo))
                {
                    MessageBox.Show("Ticket has been successfully checked!");
                    ticketChecked = true;
                }
                else
                    MessageBox.Show("ERROR: Ticket number invalid!");

            } while (ticketChecked == false);

            ticketMachine.PrePaidChecked();
            UpdateDisplay();
        }
        private void EmergencyDriverEnter(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket();
            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor();
            UpdateDisplay();
        }

        private void PrePaidCarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.PrePaidCarLeftSensor();
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.CarDetected();
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {
            if (ticketValidator.TicketEntered())
            {
                carPark.TicketValidated();
            }

            UpdateDisplay();
        }

        private void PrePaidEnteredToken(object sender, EventArgs e)
        {
            bool ticketChecked = false;
            do
            {
                int ticketNo = Convert.ToInt32(Interaction.InputBox("Please enter the ticket number of the ticket you wish to use: ", "Pay Ticket", "0"));
                //Ticket is valid if the entered ticket number matches an existing ticket and said ticket hasn't already been paid for
                if (!activePrePaidTickets.InCarPark(ticketNo))
                {
                    MessageBox.Show("Ticket has been successfully checked!");
                    ticketChecked = true;
                    ticketValidator.PrePaidCodeEntered(ticketNo);

                }
                else
                    MessageBox.Show("ERROR: Ticket number invalid!");

            } while (ticketChecked == false);

            carPark.TicketValidated();
            UpdateDisplay();
        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor();
            UpdateDisplay();
        }

        private void PrePaidCarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.PrePaidCarLeftSensor();
            UpdateDisplay();
        }

        private void btnPayTicket_Click(object sender, EventArgs e)
        {
            int ticketNo = Convert.ToInt32(Interaction.InputBox("Please enter the ticket number of the ticket you wish to pay: ", "Pay Ticket", "0"));
            //Ticket is valid if the entered ticket number matches an existing ticket and said ticket hasn't already been paid for
            if (ticketValidator.PayTicket(ticketNo))
                MessageBox.Show("Ticket has been successfully paid for!");
            else
                MessageBox.Show("ERROR: Ticket number invalid!");

            UpdateDisplay();
        }
        private void btnSecureAdvancePayment_Click(object sender, EventArgs e)
        {
            if (carPark.GetCurrentPrePaidTickets() < carPark.GetMaxPrePaidSpaces())
            {
                ticketMachine.PrintPrePaidTicket();
                UpdateDisplay();

            }

            else
            {
                MessageBox.Show("There are no more avaliable advance bookings");
            }
        }


        ///////////////////////////////////////////////////////////////////////////
        private void btnToggleEmergency_Click(object sender, EventArgs e)
        {
            carPark.IsEmergency();
            UpdateDisplay();
        }

        private void btnEmergencyEntrance_Click(object sender, EventArgs e)
        {

            if (carPark.emergency == false)
            {
                ticketMachine.SpacesMessage();
                ticketMachine.PrintTicket();
            }
            else
            {
                ticketMachine.ClearMessage();
                entryBarrier.Raise();
                UpdateDisplay();
            }
            UpdateDisplay();
        }


        private void btnEmergencyPay_Click(object sender, EventArgs e)
        {

            int ticketNo = Convert.ToInt32(Interaction.InputBox("Please enter the ticket number of the ticket you wish to pay: ", "Pay Ticket", "0"));
            //Ticket is valid if the entered ticket number matches an existing ticket and said ticket hasn't already been paid for
            if (ticketValidator.PayTicket(ticketNo))
                MessageBox.Show("Ticket has been successfully paid for!");
            else
                MessageBox.Show("ERROR: Ticket number invalid!");

            UpdateDisplay();
        }

        private void btnEmergencyExit_Click(object sender, EventArgs e)
        {
            ticketValidator.ClearMessage();
            exitBarrier.Raise();
            UpdateDisplay();
        }



        private void UpdateDisplay()
        {
            lblEmergencyVehicles.Text = Convert.ToString(carPark.GetNoEmergVehicles());
            lblEmergencySign.Text = Convert.ToString(value: carPark.emergency);
            lblEntrySensor.Text = Convert.ToString(entrySensor.isCarOnSensor());
            lblEntryBarrier.Text = Convert.ToString(entryBarrier.IsLifted());
            lblExitSensor.Text = Convert.ToString(exitSensor.isCarOnSensor());
            lblExitBarrier.Text = Convert.ToString(exitBarrier.IsLifted());
            lblFullSign.Text = Convert.ToString(fullSign.IsLit());
            lblFloor2Spaces.Text = Convert.ToString(carPark.GetCurrentPrePaidSpaces());
            lblFloor0Spaces.Text = Convert.ToString(carPark.GetCurrentSpaces());
            lblTicketMachine.Text = Convert.ToString(ticketMachine.GetMessage());
            lblTicketValidator.Text = Convert.ToString(ticketValidator.GetMessage());
            lstActiveTickets.Items.Clear();
            lstPrePaidTickets.Items.Clear();

            if (!carPark.IsFull())
            {
                if (entrySensor.isCarOnSensor() && entryBarrier.IsLifted())
                {
                    btnVehicleEnters.Visible = true;
                    btnPrePaidEnters.Visible = true;
                    btnNormalEntrance.Visible = false;
                    btnPrePaidEntrance.Visible = false;
                    btnEmergencyEntrance.Visible = false;
                }
                else if (entrySensor.isCarOnSensor())
                {
                    btnNormalEntrance.Visible = true;
                    btnPrePaidEntrance.Visible = true;
                    btnEmergencyEntrance.Visible = true;
                    btnVehicleArrivesEntrance.Visible = false;
                }
                else
                {
                    btnVehicleArrivesEntrance.Visible = true;
                    btnVehicleEnters.Visible = false;
                    btnPrePaidEnters.Visible = false;
                }
            }
            else
            {
                btnVehicleEnters.Visible = false;
                btnPrePaidEnters.Visible = false;
            }                  
            

            if (!carPark.IsEmpty())
            {
                if (exitSensor.isCarOnSensor() && exitBarrier.IsLifted())
                {
                    btnVehicleExits.Visible = true;
                    btnPrePaidExits.Visible = true;
                    btnNormalExit.Visible = false;
                    btnPrePaidExit.Visible = false;
                    btnEmergencyExit.Visible = false;
                }
                else if (exitSensor.isCarOnSensor())
                {
                    btnNormalExit.Visible = true;
                    btnPrePaidExit.Visible = true;
                    btnEmergencyExit.Visible = true;
                    btnVehicleArrivesExit.Visible = false;
                }
                else
                {
                    btnVehicleArrivesExit.Visible = true;
                    btnVehicleExits.Visible = false;
                    btnPrePaidExits.Visible = false;
                }
            }
            else
            {
                btnVehicleExits.Visible = false;
                btnPrePaidExits.Visible = false;
            }
                

            foreach (var ticket in activeTickets.GetTickets())
            {
                lstActiveTickets.Items.Add("#" + ticket.GetHashCode() + ": " + ticket.IsPaid());
            }

            foreach (var ticket in activePrePaidTickets.GetTickets())
            {
                lstPrePaidTickets.Items.Add("#" + ticket.GetHashCode() + ": " + ticket.InCarPark());
            }
        }
    }
}
