using SWENG421_Lab6.UI;

ApplicationConfiguration.Initialize();

var user1 = new UserForm("User A");
var user2 = new UserForm("User B");

user1.StartPosition = FormStartPosition.Manual;
user1.Location = new Point(0, 50);

user2.StartPosition = FormStartPosition.Manual;
user2.Location = new Point(user1.Width + 10, 50);

int openForms = 2;
void OnFormClosed(object? s, EventArgs e)
{
    if (--openForms == 0)
        Application.Exit();
}

user1.FormClosed += OnFormClosed;
user2.FormClosed += OnFormClosed;

user1.Show();
user2.Show();

Application.Run();