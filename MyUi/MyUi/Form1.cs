using MyLibrary;

namespace MyUi
{
    public partial class Form1 : Form
    {
        //MyLibrary oLBR = new MyLibrary();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e, double input)
        {
            double Input = Convert.ToDouble(input);
            textBox1.Text = MyMath(Input);

            //create oject from MyMath class
            MyMath myMath = new MyMath();
            int sum1 = myMath.getSummation(3, 4);
            int sum2 = myMath.getSummation(3, 3);
            this.textBox1.Text = sum1.ToString();
            this.textBox2.Text = sum2.ToString();

            //string grade = MyGPA.calculateGrade(70);
            //this.textBox1.Text = grade;
            //string grade = MyGPA.calculateGrade(50);
            //this.textBox2.Text = grade;


        }

        private string MyMath(double input)
        {
            throw new NotImplementedException();
        }
    }
}