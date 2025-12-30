using System.Linq;

namespace HashAlgorithms.Learn08;

public static class DbContext
{
    static DbContext()
    {
        Transactions = new();

        #region Seed Transactions
        Transaction t1 =
            new Transaction(1, "6037708090807010", "6037708090807011", "106.10.10.2", 1000);

        Transaction t2 =
            new Transaction(2, "6007708090807010", "6037708090807011", "106.10.25.2", 25000);

        Transaction t3 =
            new Transaction(3, "6037998090807010", "6037701090807011", "106.65.20.2", 650);

        InsertTransation(t1);
        InsertTransation(t2);
        InsertTransation(t3);
        #endregion /Seed Transactions
    }

    public static System.Collections.Generic.List<Transaction> Transactions { get; }

    public static void InsertTransation(Transaction transaction)
    {
        Transactions.Add(transaction);
    }

    public static Transaction? FindTransactionById(long id)
    {
        return Transactions.SingleOrDefault(t => t.Id == id);
    }
}
