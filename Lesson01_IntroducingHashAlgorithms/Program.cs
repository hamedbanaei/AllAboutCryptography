//********** ********** ********** ********** ********** 
// Learn 01 - How to use hash algorithms
//********** ********** ********** ********** ********** 

//// This is our Original Data which we want to compute hash for
//byte[] bytOriginalData = new byte[100];

//// We randomely generate an array of bytes to use as Original Data
//// Don't worry! We'll learn how to compute hash of everything latter.
//System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytOriginalData);

//// Bingo! we successfully generate our Original Data's Hash.
//byte[] bytGeneratedHash = System.Security.Cryptography.MD5.HashData(bytOriginalData);

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 



//********** ********** ********** ********** ********** 
// Learn 01 - Introduction to available hash algorithms
//********** ********** ********** ********** ********** 

//// This is our Original Data which we want to compute hash for
//byte[] bytOriginalData = new byte[100];

//// We randomely generate an array of bytes to use as Original Data
//// Don't worry! We'll learn how to compute hash of everything latter.
//System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytOriginalData);

//// Here is a list of well-know widly used hash algorithms:
//byte[] bytGeneratedMD5Hash = System.Security.Cryptography.MD5.HashData(bytOriginalData);
//byte[] bytGeneratedSHA1Hash = System.Security.Cryptography.SHA1.HashData(bytOriginalData);
//byte[] bytGeneratedSHA256Hash = System.Security.Cryptography.SHA256.HashData(bytOriginalData);
//byte[] bytGeneratedSHA384Hash = System.Security.Cryptography.SHA384.HashData(bytOriginalData);
//byte[] bytGeneratedSHA512Hash = System.Security.Cryptography.SHA512.HashData(bytOriginalData);


//// All the preceding hash classes are children of the class: System.Security.Cryptography.HashAlgorithm
//// Consider that System.Security.Cryptography.HashAlgorithm is an abstract class and you can't make object of it.
//var test = new System.Security.Cryptography.HashAlgorithm();

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 





//********** ********** ********** ********** ********** 
// Learn 02 - So, Why System.Security.Cryptography.HashAlgorithm exists?
//********** ********** ********** ********** ********** 
// Simply:
//          1) Dependency Injection (DI)
//          2) Using of Strategy Patterns
//          3) ...

// This is our Original Data which we want to compute hash for
byte[] bytOriginalData = new byte[100];

// We randomely generate an array of bytes to use as Original Data
// Don't worry! We'll learn how to compute hash of everything latter.
System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytOriginalData);

System.Security.Cryptography.HashAlgorithm oHashAlgorithm =
    System.Security.Cryptography.MD5.Create();
byte[] bytGeneratedMD5Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

oHashAlgorithm = System.Security.Cryptography.SHA1.Create();
byte[] bytGeneratedSHA1Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

oHashAlgorithm = System.Security.Cryptography.SHA256.Create();
byte[] bytGeneratedSHA256Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

oHashAlgorithm = System.Security.Cryptography.SHA384.Create();
byte[] bytGeneratedSHA384Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

oHashAlgorithm = System.Security.Cryptography.SHA512.Create();
byte[] bytGeneratedSHA512Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

// With DI and/or mix of Strategy Pattern (in some cases) your solution could be
// compeletly indipendant from the type of hash algorithm you choose

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 