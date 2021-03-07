public class BankAccountSimulator : IBankAccount
{
    public BankAccountSimulator(string titular, string agencyNumber, string accountNumber, string cpf, decimal depositValue)
    {
        Titular = titular;
        AgencyNumber = agencyNumber;
        AccountNumber = accountNumber;
        Cpf = cpf;
        DepositValue = depositValue;
    }

    public string Titular { get; init; }
    public string AgencyNumber { get; init; }
    public string AccountNumber { get; init; }
    public string Cpf { get; init; }
    public decimal DepositValue { get; init; }

    public void DepositInCheckingAccount()
    {           
        throw new System.NotImplementedException();
    }

    public void DepositInSavingsAccount()
    {
        throw new System.NotImplementedException();
    }
    
}