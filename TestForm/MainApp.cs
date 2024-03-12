using System;
using System.Windows.Forms;

namespace TestForm
{
    class MyForm : System.Windows.Forms.Form
    {

    }
    internal class MainApp : System.Windows.Forms.Form


    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Application.Exit();
                });
            Application.Run(form);

        }
    }
}
