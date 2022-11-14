Console.WriteLine("Welcome to the Bank");

BankAccount account = new BankAccount(11000);

// BankAccount account = new BankAccount("New account namme");
try {
account.makeDeposit(-1);
} catch(Exception ex) {
  Console.WriteLine(ex.Message);
}
// account.balance = 100.97m;

Console.WriteLine($" Your balance is: {account.getBalance()} \n Account Number: {account.accountNumber} \n");
Console.WriteLine($" Account Number: {account.accountNumber}");