//********** ********** ********** ********** ********** 
// Learn 01 - How to use hash algorithms
//********** ********** ********** ********** ********** 

// This is our Original Data which we want to compute hash for
using HashAlgorithms;

byte[] bytOriginalData = new byte[100];

// We randomely generate an array of bytes to use as Original Data
// Don't worry! We'll learn how to compute hash of everything latter.
System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytOriginalData);
Utilities.ShowByteArray(bytOriginalData, "Generated Original Data");

System.Console.WriteLine(System.Environment.NewLine);

// Bingo! we successfully generate our Original Data's Hash.
byte[] bytGeneratedHash = System.Security.Cryptography.MD5.HashData(bytOriginalData);
Utilities.ShowByteArray(bytGeneratedHash, "Generated Hash");

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 02 - Introduction to available hash algorithms
//********** ********** ********** ********** ********** 

//// This is our Original Data which we want to compute hash for
//byte[] bytOriginalData = new byte[100];

//// We randomely generate an array of bytes to use as Original Data
//// Don't worry! We'll learn how to compute hash of everything latter.
//System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytOriginalData, "Generated Original Data");

//// Here is a list of well-know widly used hash algorithms:
//byte[] bytGeneratedMD5Hash = System.Security.Cryptography.MD5.HashData(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedMD5Hash, "Generated MD5 Hash");

//byte[] bytGeneratedSHA1Hash = System.Security.Cryptography.SHA1.HashData(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA1Hash, "Generated SHA1 Hash");

//byte[] bytGeneratedSHA256Hash = System.Security.Cryptography.SHA256.HashData(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA256Hash, "Generated SHA256 Hash");

//byte[] bytGeneratedSHA384Hash = System.Security.Cryptography.SHA384.HashData(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA384Hash, "Generated SHA384 Hash");

//byte[] bytGeneratedSHA512Hash = System.Security.Cryptography.SHA512.HashData(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA512Hash, "Generated SHA512 Hash");


//// All the preceding hash classes are children of the class: System.Security.Cryptography.HashAlgorithm
//// Consider that System.Security.Cryptography.HashAlgorithm is an abstract class and you can't make object of it.
////var test = new System.Security.Cryptography.HashAlgorithm();

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 03 - So, Why System.Security.Cryptography.HashAlgorithm exists?
//********** ********** ********** ********** ********** 

//// Simply:
////          1) Dependency Injection (DI)
////          2) Using of Strategy Patterns
////          3) ...

//// This is our Original Data which we want to compute hash for
//byte[] bytOriginalData = new byte[100];

//// We randomely generate an array of bytes to use as Original Data
//// Don't worry! We'll learn how to compute hash of everything latter.
//System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytOriginalData);

//HashAlgorithms.Utilities
//    .ShowByteArray(bytOriginalData, "Generated Original Data");

//System.Security.Cryptography.HashAlgorithm oHashAlgorithm = null;

//oHashAlgorithm = System.Security.Cryptography.MD5.Create();
//byte[] bytGeneratedMD5Hash = oHashAlgorithm.ComputeHash(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedMD5Hash, "Generated MD5 Hash");

//oHashAlgorithm = System.Security.Cryptography.SHA1.Create();
//byte[] bytGeneratedSHA1Hash = oHashAlgorithm.ComputeHash(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA1Hash, "Generated SHA1 Hash");

//oHashAlgorithm = System.Security.Cryptography.SHA256.Create();
//byte[] bytGeneratedSHA256Hash = oHashAlgorithm.ComputeHash(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA256Hash, "Generated SHA256 Hash");

//oHashAlgorithm = System.Security.Cryptography.SHA384.Create();
//byte[] bytGeneratedSHA384Hash = oHashAlgorithm.ComputeHash(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA384Hash, "Generated SHA384 Hash");

//oHashAlgorithm = System.Security.Cryptography.SHA512.Create();
//byte[] bytGeneratedSHA512Hash = oHashAlgorithm.ComputeHash(bytOriginalData);
//HashAlgorithms.Utilities
//    .ShowByteArray(bytGeneratedSHA512Hash, "Generated SHA512 Hash");

//// With DI and/or mix of Strategy Pattern (in some cases) your solution could be
//// compeletly indipendant from the type of hash algorithm you choose

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 04 - How to hash everything?
//********** ********** ********** ********** ********** 

//// Simply:
////          1) Convert what you want compute hash from to array of bytes
////          2) Compute hash of your Original Data which you just converted to array of bytes
////          3) You may saved computed hash as an array of bytes or convert it to string and save the result

//// This is our Original Data which we want to compute hash for and consider that its type is string
//string strOriginalData = "Hello, my name is Hamed Banaei, you can call me Kourosh, that's my nickname. Glad to share this information with you.";

//// Now, you should convert your Original Data to array of bytes
//byte[] bytOriginalData = System.Text.Encoding.UTF8.GetBytes(strOriginalData);

//// Compute Hash
//byte[] bytGeneratedHash = System.Security.Cryptography.SHA256.HashData(bytOriginalData);

//// Consider that is enough and you've computed the hash.
//// But for easy observing, saving, retrieving, etc it's much better to convert it to string and use it
//string strHash = System.Text.Encoding.UTF8.GetString(bytGeneratedHash);
//// This conversion may cause countless problems like:
//// It may possible to generate new line character code and while saving you encounter problems
//// Here is the tricky part that Base64String gives us a hand to prevent any problem:
//string strHashInBase64Format = System.Convert.ToBase64String(bytGeneratedHash);
//// It's safe and generate just visible characters, not anything else!

//System.Console.WriteLine($"Original Data: {strOriginalData}");
//System.Console.WriteLine($"Generated Hash: {strHashInBase64Format}");

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 05 - How hash algorithms can help for integrity
//********** ********** ********** ********** ********** 

//// Just notice:
////	1) Hash algorithms has no reverse algorithms!!!
////	2) When two Hashes are exactly the same, The Original Data are definitly the same!!!

//// Lets Try:

//using System.Linq;

//string strOriginalData = "Hello, my name is Hamed Banaei, you can call me Kourosh, that's my nickname. Glad to share this information with you.";

//System.Collections.Generic.List<string> hashCollections =
//    new System.Collections.Generic.List<string>();

//// Lemme give it a try and compute hash for 1,000,000 times for the same Original Data
//for (int intIndex = 0; intIndex < 1_000_000; intIndex++)
//{
//    // Now, you should convert your Original Data to array of bytes
//    byte[] bytOriginalData = System.Text.Encoding.UTF8.GetBytes(strOriginalData);
//    byte[] bytGeneratedHash = System.Security.Cryptography.SHA256.HashData(bytOriginalData);
//    string strHashInBase64Format = System.Convert.ToBase64String(bytGeneratedHash);
//    hashCollections.Add(strHashInBase64Format);
//}

//// Now, lets see if there is any computed hash from the same original data with diffrent HASH???
//var uniqueResult = hashCollections.Distinct().ToList();

//System.Console.WriteLine("Distinct result is:");
//foreach (var hash in uniqueResult)
//{
//    System.Console.WriteLine(hash);
//}
//System.Console.WriteLine(System.Environment.NewLine);
//// As you can see it the console, there is only one unique hash generated
//// with 1,000,000 times of iteration and the same Original data as input!!! :D

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 06 - How hash algorithms can help for Privacy (Not Security)
//////********** ********** ********** ********** ********** 

//// Just notice:
////  1) Hash algorithms has no reverse algorithms!!!
////  2) When two Hashes are exactly the same, The Original Data are definitly the same!!!

//// Lets Try:

//using System.Linq;
//using HashAlgorithms.Learn06; // Lets use it for simply focus to user learning

//if (DbContext.Login("Hamed", "123"))
//{
//    System.Console.WriteLine("Hamed login with his password!");
//}

//if (DbContext.Login("Kourosh", "123"))
//{
//    System.Console.WriteLine("Hamed login with Kourosh username but his password!");
//}
//else
//{
//    System.Console.WriteLine("Hamed can't login with Kourosh username but his password!");
//}

//// So good so far, how can hamed login as Kourosh with his password????!!!!!!!!!
//// Just imagine Hamed illegally accessed to database and replace Kourosh Pass (Hashed Pass) with his one:
//DbContext.Users[2].Password = DbContext.Users[0].Password; // This is called: Hash Replacement Attack
//// And now guess what:
//if (DbContext.Login("Kourosh", "123"))
//{
//    System.Console.WriteLine("Hamed login with Kourosh username but his password!");
//}
//else
//{
//    System.Console.WriteLine("Hamed can't login with Kourosh username but his password!");
//}
//// This is one of many reasons that Hashing Users Password is just for Privacy

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 07 - How to Securely prevent Hash Replacement Attack?
//********** ********** ********** ********** ********** 

//// Just notice:
////  1) Hash algorithms has no reverse algorithms!!!
////  2) When two Hashes are exactly the same, The Original Data are definitly the same!!!
////  3) We can prevent Hash Replacement Attacks with combination of some other fields, in this case, username

//// Lets Try:

//using System.Linq;
//using HashAlgorithms.Learn07; // Lets use it for simply focus to user learning

//if (DbContext.Login("Hamed", "123"))
//{
//    System.Console.WriteLine("Hamed login with his password!");
//}

//if (DbContext.Login("Kourosh", "123"))
//{
//    System.Console.WriteLine("Hamed login with Kourosh username but his password!");
//}
//else
//{
//    System.Console.WriteLine("Hamed can't login with Kourosh username but his password!");
//}

//// So good so far, how can hamed login as Kourosh with his password????!!!!!!!!!
//// Just imagine Hamed illegally accessed to database and replace Kourosh Pass (Hashed Pass) with his one:
//DbContext.Users[2].Password = DbContext.Users[0].Password;
//// And now guess what:
//if (DbContext.Login("Kourosh", "123"))
//{
//    System.Console.WriteLine("Hamed login with Kourosh username but his password!");
//}
//else
//{
//    System.Console.WriteLine("Hamed can't login with Kourosh username but his password!");
//}
//// This is exactly the code we seen in Learn06 - What's happened? -> See Learn07.DbContext.HashPassword :D

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 08 - How to Validate Data? What if it Tampered Illegally
//********** ********** ********** ********** ********** 

//// Consider This Scenario:
////	1) Somebody do transaction 2!!!
////	2) He don't want to be arrested cause transfering money without it's owner permission
////	3) What if he somehow access the data base and tamper IssuerIp?

//// Lets Try:

//using HashAlgorithms.Learn08; // Lets use it for simply focus to user learning

//var transaction = DbContext.FindTransactionById(2);
//transaction.IssuerIp = "26.123.241.65"; // He TAMPERED transaction data, Set  IssuerIp to the card owner Ip

//// Is here any kind of validation available that we can find out
//// If the data is valid and nobody tampered it?
// Lets see in the following Learn09

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 09 - How to Validate Data?
//********** ********** ********** ********** ********** 

//// Consider This Scenario:
////	1) Somebody do transaction 2!!!
////	2) He don't want to be arrested cause transfering money without it's owner permission
////	3) What if he somehow access the data base and tamper IssuerIp?
////	4) And we want to Validate the data to find out Tampering...

//// Lets Try:

//using HashAlgorithms.Learn09; // Lets use it for simply focus to user learning

//var transaction = DbContext.FindTransactionById(2);
//// Before Tampering data we could validate it
//transaction.ValidateData();


//transaction.IssuerIp = "26.123.241.65"; // He TAMPERED transaction data, Set  IssuerIp to the card owner Ip

//// But after tampering we couldn't
//transaction.ValidateData();

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 