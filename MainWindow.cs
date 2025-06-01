using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace TestSavePdf
{
    public partial class MainWindow : Form
    {
        private Models.TicketCounterAndLog ticketCounterAndLog = new Models.TicketCounterAndLog(); // Declare the ticket counter and log variable

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = ticketCounterAndLog.Log; // Bind the log to the ListBox
            // Set the StatusStrip to update with the current ticket counter
            ticketCounterAndLog.Log.ListChanged += (s, args) =>
            {
                toolStripStatusLabel1.Text = $"Ticket Counter: {ticketCounterAndLog.TicketCounter}"; // Update the status strip with the current ticket counter
            };

        }

        private void Button1_Click(object sender, EventArgs e) // Renamed to follow PascalCase naming convention
        {
            var ticketWindow = new TicketWindow();
            this.ticketCounterAndLog.AddLogEntry("Showing Visible Window");
            this.ticketCounterAndLog.IncrementCounter(); // Increment the ticket counter            
            ticketWindow.Show();

        }
        /// <summary>
        /// This function will create a new ticket window, increment the ticket counter and add a log entry to the ticket counter and log model.
        /// It will NOT make the ticket visible. 
        /// It will draw the ticket window instead to a Pdf files called ticket<TicketCounter>.pdf in the current directory.
        /// It will then close the ticket window and log the action.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e) // Renamed to follow PascalCase naming convention
        {


            var ticketWindow = new TicketWindow();
            this.ticketCounterAndLog.AddLogEntry("Showing Hidden Window and Saving to PDF");
            this.ticketCounterAndLog.IncrementCounter(); // Increment the ticket counter

            // Compute an appropriate filename
            string pdfFileName = $"ticket{ticketCounterAndLog.TicketCounter}.pdf";

            // Find a location that is offscreen 
            Point loc = GetOffScreenLocation();

            //Set location for the window to offscreen 
            this.StartPosition = FormStartPosition.Manual;

            ticketWindow.Location = loc;
            ticketWindow.ShowInTaskbar = false; // Hide the window from the taskbar.
            ticketWindow.Opacity = 0; // Make the window invisible
            ticketWindow.Show();
            Application.DoEvents();

            SaveTicketToPdf(ticketWindow, pdfFileName); // Save the ticket window to a PDF file

            ticketWindow.Close(); // Close the ticket window

            this.ticketCounterAndLog.AddLogEntry($"File :{Environment.CurrentDirectory}\\{pdfFileName} saved to PDF and window closed."); // Log the action

        }

        private void SaveTicketToPdf(TicketWindow ticketWindow, string path)
        {
            using (Bitmap bmp = new Bitmap(ticketWindow.Width, ticketWindow.Height)) // Create a bitmap to draw the ticket window
            {
                ticketWindow.DrawToBitmap(bitmap: bmp, new Rectangle(Point.Empty, ticketWindow.Size)); // Draw the ticket window to the bitmap
                PdfDocument pdfDocument = new PdfDocument(); // Create a new PDF document
                pdfDocument.Info.Title = $"Ticket {ticketCounterAndLog.TicketCounter}"; // Set the title of the PDF document
                PdfPage page = pdfDocument.AddPage(); // Add a new page to the PDF document
                page.Width = bmp.Width; // Set the width of the page to the width of the bitmap
                page.Height = bmp.Height; // Set the height of the page to the height of the bitmap
                using (XGraphics gfx = XGraphics.FromPdfPage(page)) // Create a graphics object to draw on the PDF page
                {
                    using (XImage image = XImage.FromGdiPlusImage(bmp)) // Create an image from the bitmap
                    {
                        gfx.DrawImage(image, 0, 0, bmp.Width, bmp.Height); // Draw the image on the PDF page
                    }
                }
                string pdfFileName = $"ticket{ticketCounterAndLog.TicketCounter}.pdf"; // Create a file name for the PDF document
                pdfDocument.Save(pdfFileName);
            }
        }
        /// <summary>
        /// This function will find a location to display the ticket that is defintely offscreen. 
        /// </summary>
        /// <returns></returns>
        private static Point GetOffScreenLocation()
        {
            // Get the bounds of all screens
            var allScreens = Screen.AllScreens.Select(s => s.Bounds).ToList();

            // Find the rightmost and bottommost edges
            int maxRight = allScreens.Max(b => b.Right);
            int maxBottom = allScreens.Max(b => b.Bottom);

            // Place the form just outside the right and bottom edge
            int x = maxRight + 1000;  // 1000 pixels beyond right edge
            int y = maxBottom + 1000; // 1000 pixels beyond bottom edge

            return new Point(x, y);

        }

        private void openExplorer_Click(object sender, EventArgs e)
        {
            string currentDirectory = Environment.CurrentDirectory; // Get the current directory
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = currentDirectory,
                UseShellExecute = true // Use the shell to open the directory
            });
        }
    }
}
