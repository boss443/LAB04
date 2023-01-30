namespace LAB4Encapsulation
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.textName.Text;
            string input_Year = this.textBirthYear.Text;
            string input_GPA = this.textGPA.Text;
            int iYear = Int32.Parse(input_Year);
            double iGPA = Double.Parse(input_GPA);

            //
            Person person = new Person(input_name, iYear, iGPA);
            this.classroom.addPerson2Classs(person);
            // display person
            this.textPerson.Text = this.classroom.showAllPersoninClass();
            // show sumAge
            this.textSumAge.Text = this.classroom.showSumAgeinClass().ToString();
            //show max min GPA
            this.textMax.Text = this.classroom.showMaxGPAinClass().ToString();
            this.textMin.Text = this.classroom.showMinGPAinClass().ToString();
            // show avg
            this.textAvg.Text = this.classroom.showAvgGPAinClass().ToString();
            //show Name max min GPA
            this.textGPA_personMax.Text = this.classroom.showNameMaxGPAinClass().ToString();
            this.textGPA_personMin.Text = this.classroom.showNameMinGPAinClass().ToString();

            // clear old data_input
            this.textName.Text = "";
            this.textBirthYear.Text = "";
            this.textGPA.Text = "";

        }

        
    }
}