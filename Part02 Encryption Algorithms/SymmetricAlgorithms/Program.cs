//********** ********** ********** ********** ********** 
// Learn 01 - How to use Symmetric algorithms
//********** ********** ********** ********** ********** 

using CommonMethods;

// This is our Original Data which we want to encrypt
byte[] bytPlainData = new byte[10];

// We randomely generate an array of bytes to use as Plain Data
// Don't worry! We'll learn how to encrypt everything latter.
System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytPlainData);
Utility.ShowData(bytPlainData, "Plain Data");

var aesAlgorithm = System.Security.Cryptography.Aes.Create();
aesAlgorithm.Mode = System.Security.Cryptography.CipherMode.CBC;
aesAlgorithm.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

byte[] bytIv = aesAlgorithm.IV;
byte[] bytKey = aesAlgorithm.Key;

// Encrypt Plain Data => Cipher Data
using var encryptor = aesAlgorithm.CreateEncryptor();
byte[] bytCipherData = encryptor.TransformFinalBlock(bytPlainData, 0, bytPlainData.Length);

Utility.ShowData(bytCipherData, "Cipher Data");

// Decrypt Cipher Data => Plain Data
using var decryptor = aesAlgorithm.CreateDecryptor();
byte[] bytDecryptedData = decryptor.TransformFinalBlock(bytCipherData, 0, bytCipherData.Length);

Utility.ShowData(bytDecryptedData, "Decrypted Data");

//********** ********** ********** ********** ********** 
// / Learn 01 - How to use Symmetric algorithms
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 02 - So, Why
//  System.Security.Cryptography.SymmetricAlgorithm and
//  System.Security.Cryptography.ICryptoTransform
//  exist?
//********** ********** ********** ********** ********** 

//// Simply:
////  1) Dependency Injection (DI)
////  2) Using of Strategy Patterns
////  3) ...

//using CommonMethods;

//// This is our Plain Data which we want to encrypt
//byte[] bytPainData = new byte[10];

//// We randomely generate an array of bytes to use as Plain Data
//// Don't worry! We'll learn how to encrypt everything latter.
//System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytPainData);

//Utility.ShowData(bytPainData, "Plain Data");

//System.Security.Cryptography.SymmetricAlgorithm oSymmetricAlgorithm = null;
//System.Security.Cryptography.ICryptoTransform oCryptoTransform = null;

//// System.Security.Cryptography.Aes
//oSymmetricAlgorithm = System.Security.Cryptography.Aes.Create();
//oCryptoTransform = oSymmetricAlgorithm.CreateEncryptor();
//byte[] AesEncryptionResult = oCryptoTransform.TransformFinalBlock(bytPainData, 0, bytPainData.Length);
//Utility.ShowData(AesEncryptionResult, "Aes Encryption Result");

//// System.Security.Cryptography.TripleDES
//oSymmetricAlgorithm = System.Security.Cryptography.TripleDES.Create();
//oCryptoTransform = oSymmetricAlgorithm.CreateEncryptor();
//byte[] TripleDESEncryptionResult = oCryptoTransform.TransformFinalBlock(bytPainData, 0, bytPainData.Length);
//Utility.ShowData(TripleDESEncryptionResult, "TripleDES Encryption Result");

//// With DI and/or mix of Strategy Pattern (in some cases) your solution could be
//// compeletly indipendant from the type of encryption algorithm you choose

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 03 - How to encrypt everything?
//********** ********** ********** ********** ********** 

//// Simply:
////	1) Convert what you want to encrypt to array of bytes
////	2) Encrypt your Plain Data which you just converted to array of bytes
////	3) You may save Cipher Data as an array of bytes or convert it to string and save the result

//using CommonMethods;

//// This is our Plain Data which we want to encrypt and consider that its type is string
//string strPlainData = "Hello, my name is Hamed Banaei, you can call me Kourosh, that's my nickname. Glad to share this information with you.";
//Utility.ShowData(strPlainData, "Plain Data");

//// Now, you should convert your Original Data to array of bytes
//byte[] bytPlainData = System.Text.Encoding.UTF8.GetBytes(strPlainData);
//Utility.ShowData(bytPlainData, "Plain Data as Byte Array");


//var aesAlgorithm = System.Security.Cryptography.Aes.Create();
//aesAlgorithm.Mode = System.Security.Cryptography.CipherMode.CBC;
//aesAlgorithm.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

//byte[] bytIv = aesAlgorithm.IV;
//byte[] bytKey = aesAlgorithm.Key;

//// Encrypt Plain Data => Cipher Data
//using var encryptor = aesAlgorithm.CreateEncryptor();
//byte[] bytCipherData = encryptor.TransformFinalBlock(bytPlainData, 0, bytPlainData.Length);
//string strCipherData = System.Convert.ToBase64String(bytCipherData);

//Utility.ShowData(bytCipherData, "Cipher Data as Byte Array");
//Utility.ShowData(strCipherData, "Cipher Data as String (ToBase64String Result)");

//// Decrypt Cipher Data => Plain Data
//byte[] bytCipherDataToDecrypt = System.Convert.FromBase64String(strCipherData);
//using var decryptor = aesAlgorithm.CreateDecryptor();
//byte[] bytDecryptedData = decryptor.TransformFinalBlock(bytCipherDataToDecrypt, 0, bytCipherDataToDecrypt.Length);
//string strDecryptedData = System.Text.Encoding.UTF8.GetString(bytDecryptedData);

//Utility.ShowData(bytCipherDataToDecrypt, "Cipher Data To Decrypt (FromBase64String Result)");
//Utility.ShowData(bytDecryptedData, "Decrypted Data as Byte Array");
//Utility.ShowData(strDecryptedData, "Decrypted Data as String (Plain Data)");

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 