namespace Task8_Interface;

public interface IAccount
{
    bool PasswordChecker(string password);
    string ShowInfo();
}

public class User : IAccount
{
    public User(int id, string? fullName, string? email, string? password)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        Password = password;
    }

    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public bool PasswordChecker(string password)
    {
        bool allValidated = false;
        bool lengthValid = false;
        bool upperCaseValid = false;
        bool lowerCaseValid = false;
        bool digitValid = false;

        if(password.Length >= 8)
            lengthValid = true;
        
        foreach(var l in password)
        {
            if(char.IsUpper(l)) upperCaseValid = true;

            else if(char.IsLower(l)) lowerCaseValid = true;

            else if(char.IsDigit(l)) digitValid = true;
        }

        if (lengthValid && upperCaseValid && lowerCaseValid && digitValid)
        {
            allValidated = true;
        }

        return allValidated;
    }

    public string ShowInfo()
    {
        return $"Id: {this.Id}\nFullname: {this.FullName}\nEmail: {this.Email}";
    }
}