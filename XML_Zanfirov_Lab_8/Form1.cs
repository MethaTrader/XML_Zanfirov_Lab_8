using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace XML_Zanfirov_Lab_8
{
    public partial class Form1 : Form
    {
        public List<Subject>? subjects;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("subjects.xml", FileMode.OpenOrCreate))
            {
                var formatter = new XmlSerializer(typeof(List<Subject>));
                subjects = formatter.Deserialize(fs) as List<Subject>;

                if (subjects != null)
                {
                    SubjectsListBox.DataSource = subjects;
                    SubjectsListBox.DisplayMember = "Name";
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Name = ShowInteractDialog("������ ����� ��������");
            string Teacher = ShowInteractDialog("������ ��'� ���������");
            string Department = ShowInteractDialog("������ �������");
            string Course = ShowInteractDialog("������ ����");
            string Semester = ShowInteractDialog("������ �������");
            string Hours = ShowInteractDialog("������ ������� �����");

            if (Name == String.Empty)
            {
                MessageBox.Show("���� ����� �������� �� ���������!");
                return;
            }

            if (Teacher == String.Empty)
            {
                MessageBox.Show("���� �������� �� ���������!");
                return;
            }

            if (Department == String.Empty)
            {
                MessageBox.Show("���� ������� �� ���������!");
                return;
            }

            if (Course == String.Empty)
            {
                MessageBox.Show("���� ���� �� ���������!");
                return;
            }

            if (Hours == String.Empty)
            {
                MessageBox.Show("���� ������ �� ���������!");
                return;
            }

            subjects.Add(
                new Subject(
                    Name, 
                    Teacher, 
                    Department, 
                    int.Parse(Course), 
                    int.Parse(Semester), 
                    int.Parse(Hours))
                );


            WriteToXML();
            MessageBox.Show("����� ������ ������! �������� ������ Read ��� �������");
        }

        //����� �������� � ���� XML
        private void WriteToXML()
        {
            File.WriteAllText("subjects.xml", String.Empty);
            var formatter = new XmlSerializer(typeof(List<Subject>));
            using (FileStream fs = new FileStream("subjects.xml", FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {

                formatter.Serialize(fs, subjects);
            }
        }

        private string ShowInteractDialog(string question)
        {
            Interaction interactionDialog = new Interaction(question);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (interactionDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                return interactionDialog.InputInteractionTextbox.Text;
            }
            else
            {
                return "";
            }
        }

        private void SubjectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectsListBox.SelectedItem != null)
            {
                Subject? subject = SubjectsListBox.SelectedItem as Subject;
                InfoRichTextBox.Text = subject.ToString();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SubjectsListBox.SelectedItem != null)
            {
                Subject? subject = SubjectsListBox.SelectedItem as Subject;
                subjects.Remove(subject);
                WriteToXML();
                MessageBox.Show("������� ������ ��������! �������� ������ Read ��� �������");
            }
        }
    }
}