using System.CodeDom;

namespace SimpleGUI;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
        Button myButton = new Button();
        myButton.Text = "Click me";
        myButton.Location = new Point(50, 50);
        myButton.Click += MyButton_Click();
        this.Controls.Add(myButton);
    }

    private void MyButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Button clicked!");
    }
}
