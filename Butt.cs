using System;
using System.Drawing;
using System.Windows.Forms;

public class MyForm : Form
{
    private Button myButton;

    public MyForm()
    {
        // Налаштування форми
        this.Text = "Наведи курсор на кнопку";
        this.Size = new Size(300, 200);

        // Створення кнопки
        myButton = new Button();
        myButton.Text = "Наведи на мене";
        myButton.Size = new Size(120, 40);
        myButton.Location = new Point(80, 60);
        myButton.BackColor = Color.LightGray;

        // Обробники подій миші
        myButton.MouseEnter += MyButton_MouseEnter;
        myButton.MouseLeave += MyButton_MouseLeave;

        // Додати кнопку на форму
        this.Controls.Add(myButton);
    }

    private void MyButton_MouseEnter(object sender, EventArgs e)
    {
        myButton.BackColor = Color.LightGreen; // Зміна кольору при наведенні
    }

    private void MyButton_MouseLeave(object sender, EventArgs e)
    {
        myButton.BackColor = Color.LightGray; // Повернення початкового кольору
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MyForm());
    }
}
