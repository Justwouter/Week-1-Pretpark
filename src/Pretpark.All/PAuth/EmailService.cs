namespace Pretpark.Auth;

public class EmailService : IEmail{
    public bool Email(String text, String naarAdres){
        if(naarAdres.Contains("@")){
            Console.WriteLine("To "+naarAdres + ": " + text);
            return true;
        }
        return false;
    }
}