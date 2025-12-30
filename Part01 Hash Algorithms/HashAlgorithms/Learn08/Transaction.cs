namespace HashAlgorithms.Learn08;

public class Transaction
{
    private Transaction()
    {
        DateTime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
    }

    public Transaction(long id, string sourceCard, string destinationCard, string issuerIp, long amount)
        : this()
    {
        Id = id;
        SourceCard = sourceCard;
        DestinationCard = destinationCard;
        IssuerIp = issuerIp;
        Amount = amount;
    }

    public long Id { get; set; }

    public string SourceCard { get; set; }

    public string DestinationCard { get; set; }

    public string IssuerIp { get; set; }

    public long Amount { get; set; }

    public string DateTime { get; set; }
}
