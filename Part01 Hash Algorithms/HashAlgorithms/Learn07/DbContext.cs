namespace HashAlgorithms.Learn07;

public static class DbContext
{
    static DbContext()
    {
        Users = new();

        RegisterUser("Hamed", "123");
        RegisterUser("Dariush", "145");
        RegisterUser("Kourosh", "Mr@123");
    }

    public static System.Collections.Generic.List<User> Users { get; }

    private static string HashPassword(string username, string password)
    {
        string strHash = string.Empty;
        string strUserPasswordConbination = username + ":" + password; // Consider character ':' as Salt and follow my voice

        byte[] bytPassword = System.Text.Encoding.UTF8.GetBytes(strUserPasswordConbination);
        byte[] bytPasswordHash = System.Security.Cryptography.SHA256.HashData(bytPassword);
        strHash = System.Convert.ToBase64String(bytPassword);

        return (strHash);
    }

    public static void RegisterUser(string username, string password)
    {
        string strPasswordHash = HashPassword(username, password);

        User oUser = new User();
        oUser.Username = username;
        oUser.Password = strPasswordHash;

        Users.Add(oUser);
    }

    public static bool Login(string username, string password)
    {
        string strPasswordHash = HashPassword(username, password);
        return Users.Exists(u => u.Username == username && u.Password == strPasswordHash);
    }
}
