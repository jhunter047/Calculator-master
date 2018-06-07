using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Main : Form
    {
        /// <summary>
        /// Declare Variables
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        float number, answer;
        int count; 

        //Main function
        public Main()
        {
            InitializeComponent();
        }

        //Equals button code
        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = ""; 
        }

        //Formula to calculate the equation
        public void Calculate()
        {
            switch (count)
            {
                //case for addition
                case 1: 
                    answer = number + float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                //case for subtraction
                case 2:
                    answer = number - float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                //case for multiplication
                case 3:
                    answer = number * float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                //Case for division
                case 4:
                    answer = number / float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
                 //Default case
                default:
                    break; 
            }
        }

        //Backspace button code
        private void BackSpaceBtn_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        //Dot "." button 
        private void DotBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Black; 
        }

        //Zero button code
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Black;
        }

        //One button code
        private void OneBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Black;
        }

        //Two button code
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Black;
        }

        //Three button code
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Black;
        }

        //Four button code
        private void FourBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Black;
        }

        //Five button code
        private void FiveBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Black;
        }

        //Six button code
        private void SixBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Black;
        }

        //Seven button code
        private void SevenBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Black;
        }

        //Eight button code
        private void EightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Black;
        }

        //Nine button code
        private void NineBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Black;
        }

        //Addition button code
        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = number.ToString() + "+";
        }

        //Subtraction button code
        private void SubtractionBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = number.ToString() + "-";
        }

        //Times button code
        private void TimesBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = number.ToString() + "X";
        }

        //Division button code
        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = number.ToString() + "/ ";
        }

        //Clear button code
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Code for the Exit button 
        /// </summary>  
        //When the button is clicked maximize the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        //When the mouse (over) enters the button
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Red
            ExitButton.BackColor = Color.Red;
        }

        //When the mouse (over) exits the button
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            ExitButton.BackColor = Color.Black;
        }

        /// <summary>
        /// Code for the Maximise button
        /// </summary>
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                //if windows state is maximized set the windows state to normal
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                //if windows state is not maximized, maximize the window
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //When the mouse (over) enters the button
        private void MaximizeButton_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            MaximizeButton.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void MaximizeButton_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            MaximizeButton.BackColor = Color.Black;
        }

        /// <summary>
        /// Code for the Minimize button
        /// </summary>
        ///         
        //When the button is clicked minimize the application
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            //if windows state is maximized set the windows state to normal
            this.WindowState = FormWindowState.Minimized;
        }

        //When the mouse (over) enters the button
        private void MinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            MinimizeButton.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void MinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            MinimizeButton.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void DivisionBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            DivisionBtn.BackColor = Color.DimGray;
        }

        private void DivisionBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            DivisionBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void ClearBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            ClearBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void ClearBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            ClearBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void BackSpaceBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            BackSpaceBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void BackSpaceBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            BackSpaceBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void TimesBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            TimesBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void TimesBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            TimesBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void NineBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            NineBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void NineBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            NineBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void EightBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            EightBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void EightBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            EightBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void SevenBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            SevenBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void SevenBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            SevenBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void SubtractionBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            SubtractionBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void SubtractionBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            SubtractionBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void SixBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            SixBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void SixBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            SixBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void FiveBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            FiveBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void FiveBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            FiveBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void FourBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            FourBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void FourBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            FourBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void AdditionBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            AdditionBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void AdditionBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            AdditionBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void ThreeBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            ThreeBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void ThreeBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            ThreeBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void TwoBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            TwoBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void TwoBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            TwoBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void OneBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            OneBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void OneBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            OneBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void EqualsBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            EqualsBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void EqualsBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            EqualsBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void DotBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            DotBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void DotBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            DotBtn.BackColor = Color.Black;
        }

        //When the mouse (over) enters the button
        private void ZeroBtn_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            ZeroBtn.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void ZeroBtn_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            ZeroBtn.BackColor = Color.Black;
        }

        //While the mouse is over the top panel & clicked move the app
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
