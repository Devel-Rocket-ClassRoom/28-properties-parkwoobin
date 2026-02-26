using System;

// README.md를 읽고 아래에 코드를 작성하세요

BankAccount account = new BankAccount();

Console.WriteLine($"계좌번호: {account.AccountNumber}");
Console.WriteLine($"예금주: {account.OwnerName}");
Console.WriteLine($"잔액: {account.Balance}원");
account.Deposit(50000);
account.Withdraw(20000);
account.Withdraw(100000);


class BankAccount
{
    public string AccountNumber { get; private set; } = "123-456";
    public string OwnerName { get; set; } = "홍길동";
    public int Balance { get; private set; } = 0;

    public void Deposit(int amount)
    {
        Console.WriteLine($"--- {amount}원 입금 ---");
        // 입금 로직 구현 
        if (amount >= 0)
        {
            Balance += amount;
            Console.WriteLine($"잔액: {Balance}원");
        }
        else
        {
            Console.WriteLine("입금 금액은 0 이상이어야 합니다.");
        }
    }
    public void Withdraw(int amount)
    {
        Console.WriteLine($"--- {amount}원 출금 ---");
        // 출금 로직 구현 
        if (amount >= 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("출금 성공: True");
            Console.WriteLine($"잔액: {Balance}원");
        }
        else
        {
            Console.WriteLine("출금 성공: False");
            Console.WriteLine($"잔액: {Balance}원");
        }
    }

}
