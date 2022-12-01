using System;
using System.Xml.Serialization;
namespace XML_Zanfirov_Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XmlSerializer formatter = new XmlSerializer(typeof(Subject[]));

            // восстановление массива из файла
            using (FileStream fs = new FileStream("subjects.xml", FileMode.OpenOrCreate))
            {
                Subject[]? newpeople = formatter.Deserialize(fs) as Subject[];

                if (newpeople != null)
                {
                    foreach (Subject person in newpeople)
                    {
                        MessageBox.Show(person.ToString());
                    }
                }
            }

        }
    }
}