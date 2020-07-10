using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Form2 newForm = new Form2();
      newForm.Show();
      var text = textBox1.Text;
     
      newForm.label1.Text = ClassLibrary1.Library.GetName(text);
    }
  }
}
