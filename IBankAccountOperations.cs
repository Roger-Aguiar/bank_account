interface IBankAccount
{
    string Titular{get; init;}
    string AgencyNumber{get; init;}
    string AccountNumber{get; init;}
    string Cpf{get; init;}
    decimal Value{get; init;}

    void DepositInSavingsAccount();
    void DepositInCheckingAccount();
}