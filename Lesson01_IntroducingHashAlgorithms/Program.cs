﻿//********** ********** ********** ********** ********** 
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
// Learn 02 - Introduction to available hash algorithms
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

//System.Security.Cryptography.HashAlgorithm oHashAlgorithm =
//    System.Security.Cryptography.MD5.Create();
//byte[] bytGeneratedMD5Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

//oHashAlgorithm = System.Security.Cryptography.SHA1.Create();
//byte[] bytGeneratedSHA1Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

//oHashAlgorithm = System.Security.Cryptography.SHA256.Create();
//byte[] bytGeneratedSHA256Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

//oHashAlgorithm = System.Security.Cryptography.SHA384.Create();
//byte[] bytGeneratedSHA384Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

//oHashAlgorithm = System.Security.Cryptography.SHA512.Create();
//byte[] bytGeneratedSHA512Hash = oHashAlgorithm.ComputeHash(bytOriginalData);

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
//string strOriginalData = "Hello, my name is Hamed Banaei, you can call me Mr. Tech Lead. Glad to share this information with you.";

//// Now, you should convert your Original Data to array of bytes
//byte[] bytOriginalData=System.Text.Encoding.UTF8.GetBytes(strOriginalData);

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

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 05 - How hash function can help for integrity
//********** ********** ********** ********** ********** 
// Just notice:
//          1) Hash algorithms has no reverse algorithms!!!
//          2) When two Hashes are exactly the same, The Original Data are definitly the same!!!

// Lets Try:

using System;
using System.Linq;

string strOriginalData = "Hello, my name is Hamed Banaei, you can call me Mr. Tech Lead. Glad to share this information with you.";

System.Collections.Generic.List<string> hashCollections =
    new System.Collections.Generic.List<string>();

// Lemme give it a try and compute hash for 100,000 times for the same Original Data
for (int intIndex = 0; intIndex < 100_000; intIndex++)
{
    // Now, you should convert your Original Data to array of bytes
    byte[] bytOriginalData = System.Text.Encoding.UTF8.GetBytes(strOriginalData);
    byte[] bytGeneratedHash = System.Security.Cryptography.SHA256.HashData(bytOriginalData);
    string strHashInBase64Format = System.Convert.ToBase64String(bytGeneratedHash);
    hashCollections.Add(strHashInBase64Format);
}

// Now, lets see if there is any computed hash from the same original data with diffrent HASH???
var uniqueResult = hashCollections.Distinct().ToList();

System.Console.WriteLine("Distinct result is:");
foreach (var hash in uniqueResult)
{
    Console.WriteLine(hash);
}
System.Console.WriteLine(Environment.NewLine);
// As you can see it the console, there is only one unique hash generated
// with 100,000 times of iteration and the same Original data as input!!! :D

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 