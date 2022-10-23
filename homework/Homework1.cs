namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            //string strEnd;
            int iEnd, iSum, iCounter, strEnd;
            strEnd = Convert.ToInt32(n1.Text);
            iEnd = Convert.ToInt32(n2.Text);
            iCounter = strEnd;
            iSum = 0;
            while (iCounter <= iEnd)
            {
                iSum = iSum + iCounter;
                iCounter = iCounter + 1; // alternatively you can write iCounter ++
               // lblOutput_loop.Text = iCounter.ToString();
            }
                 
            lblOutput.Text = iSum.ToString();
        }
    }
}