using System;

namespace HashAlgorithms.Learn09;

public class Transaction
{
    private Transaction()
    {
        DateTime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        Signature = string.Empty;
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

    public string Signature { get; private set; }

    public void SignTransaction()
    {
        Signature = ComputeSignature();
    }

    public bool ValidateData()
    {
        string strSign = ComputeSignature();

        bool blnResult = string.Equals(this.Signature, strSign, System.StringComparison.Ordinal);

        if (blnResult)
        {
            System.Console.WriteLine("Hooray!!! Good News!");
            System.Console.WriteLine("Data is Valid and not Tampered");
            System.Console.WriteLine($"Valid data signature is: {Signature}");
            System.Console.WriteLine(System.Environment.NewLine);
        }
        else
        {
            System.Console.WriteLine("OMG!!! We got BAD News Boss!");
            System.Console.WriteLine("Data is not Valid and has been Tampered");
            System.Console.WriteLine($"Valid data signature in data base is: {Signature}");
            System.Console.WriteLine($"Data signature already computed is: {strSign}");
            System.Console.WriteLine(System.Environment.NewLine);
        }

        return (blnResult);
    }

    private string ComputeSignature()
    {
        string strOriginalValues = $"{Id}{SourceCard}{DestinationCard}{IssuerIp}{Amount}{DateTime}";

        byte[] bytOriginalValues = System.Text.Encoding.UTF8.GetBytes(strOriginalValues);
        byte[] bytGeneratedHash = System.Security.Cryptography.SHA256.HashData(bytOriginalValues);
        string strHashInBase64Format = System.Convert.ToBase64String(bytGeneratedHash);

        return (strHashInBase64Format);
    }
}
