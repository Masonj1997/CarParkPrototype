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
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);
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
            btnVehicleEnters.Visible = false;
            btnVehicleArrivesExit.Visible = false;
            btnNormalExit.Visible = false;
            btnVehicleExits.Visible = false;

            lblTicketMachine.Text = "";
            lblTicketValidator.Text = "";
            lstActiveTickets.Items.Clear();

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

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor();
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

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor();
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

        private void UpdateDisplay()
        {
            lblEntrySensor.Text = Convert.ToString(entrySensor.isCarOnSensor());
            lblEntryBarrier.Text = Convert.ToString(entryBarrier.IsLifted());
            lblExitSensor.Text = Convert.ToString(exitSensor.isCarOnSensor());
            lblExitBarrier.Text = Convert.ToString(exitBarrier.IsLifted());
            lblFullSign.Text = Convert.ToString(fullSign.IsLit());
            lblFloor0Spaces.Text = Convert.ToString(carPark.GetCurrentSpaces());
            lblTicketMachine.Text = Convert.ToString(ticketMachine.GetMessage());
            lblTicketValidator.Text = Convert.ToString(ticketValidator.GetMessage());
            lstActiveTickets.Items.Clear();

            if (!carPark.IsFull())
            {
                if (entrySensor.isCarOnSensor() && entryBarrier.IsLifted())
                {
                    btnVehicleEnters.Visible = true;
                    btnNormalEntrance.Visible = false;
                }
                else if (entrySensor.isCarOnSensor())
                {
                    btnNormalEntrance.Visible = true;
                    btnVehicleArrivesEntrance.Visible = false;
                }
                else
                {
                    btnVehicleArrivesEntrance.Visible = true;
                    btnVehicleEnters.Visible = false;
                }
            }
            else
                btnVehicleEnters.Visible = false;

            if (!carPark.IsEmpty())
            {
                if (exitSensor.isCarOnSensor() && exitBarrier.IsLifted())
                {
                    btnVehicleExits.Visible = true;
                    btnNormalExit.Visible = false;
                }
                else if (exitSensor.isCarOnSensor())
                {
                    btnNormalExit.Visible = true;
                    btnVehicleArrivesExit.Visible = false;
                }
                else
                {
                    btnVehicleArrivesExit.Visible = true;
                    btnVehicleExits.Visible = false;
                }
            }
            else
                btnVehicleExits.Visible = false;

            foreach (var ticket in activeTickets.GetTickets())
            {
                lstActiveTickets.Items.Add("#" + ticket.GetHashCode() + ": " + ticket.IsPaid());
            }
        }
    }
}
