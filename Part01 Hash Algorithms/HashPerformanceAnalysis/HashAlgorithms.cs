namespace HashPerformanceAnalysis;

[BenchmarkDotNet.Attributes.MemoryDiagnoser]
[BenchmarkDotNet.Attributes.Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[BenchmarkDotNet.Attributes.GroupBenchmarksBy(BenchmarkDotNet.Configs.BenchmarkLogicalGroupRule.ByParams)]
public class HashAlgorithms : object
{
    byte[] bytRawData = null;

    [BenchmarkDotNet.Attributes.Params(1_000, 2_000, 5_000, 10_000)]
    public int RawDataSize = 0;

    [BenchmarkDotNet.Attributes.GlobalSetup]
    public void GlobalSetup()
    {
        bytRawData = System.Security.Cryptography.RandomNumberGenerator.GetBytes(RawDataSize);
    }

    [BenchmarkDotNet.Attributes.Benchmark(Description = "MD5")]
    public void MD5HashAlgorithm() => System.Security.Cryptography.MD5.HashData(bytRawData);

    [BenchmarkDotNet.Attributes.Benchmark(Description = "SHA1")]
    public void SHA1HashAlgorithm() => System.Security.Cryptography.SHA1.HashData(bytRawData);

    [BenchmarkDotNet.Attributes.Benchmark(Description = "SHA256")]
    public void SHA256HashAlgorithm() => System.Security.Cryptography.SHA256.HashData(bytRawData);

    [BenchmarkDotNet.Attributes.Benchmark(Description = "SHA384")]
    public void SHA384HashAlgorithm() => System.Security.Cryptography.SHA384.HashData(bytRawData);

    [BenchmarkDotNet.Attributes.Benchmark(Description = "SHA512")]
    public void SHA512HashAlgorithm() => System.Security.Cryptography.SHA512.HashData(bytRawData);
}
