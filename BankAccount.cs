
public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;
    public string BankAccountId { get; }
    public string PersonName { get; set; }
    public decimal Balance { get; }

    public BankAccount(string name, decimal initialBalance)
    {
        PersonName = name;
        Balance = initialBalance;
        BankAccountId = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
    }
   
    public void MakeWithDrawel(decimal amount, DateTime date, string note)
    {

    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {

    }


}