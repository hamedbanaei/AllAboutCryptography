//********** ********** ********** ********** ********** 
// Learn 01 - How to use Asymmetric algorithms
//********** ********** ********** ********** ********** 

using CommonMethods;

// This is our Original Data which we want to encrypt
byte[] bytPlainData = new byte[10];

// We randomely generate an array of bytes to use as Plain Data
// Don't worry! We'll learn how to encrypt everything latter.
System.Security.Cryptography.RandomNumberGenerator.Create().GetBytes(bytPlainData);
Utility.ShowData(bytPlainData, "Plain Data");

var rsaAlgorithm = System.Security.Cryptography.RSA.Create();
rsaAlgorithm.KeySize = 512;

byte[] bytPublicKey = rsaAlgorithm.ExportRSAPublicKey();
byte[] bytPrivateKey = rsaAlgorithm.ExportRSAPrivateKey();

string strPublicKey = System.Convert.ToBase64String(bytPublicKey);
string strPrivateKey = System.Convert.ToBase64String(bytPrivateKey);

Utility.ShowData(bytPublicKey, "PublicKey as Byte Array");
Utility.ShowData(strPublicKey, "PublicKey as String (ToBase64String Result)");

Utility.ShowData(bytPrivateKey, "PrivateKey as Byte Array");
Utility.ShowData(strPrivateKey, "PrivateKey as String (ToBase64String Result)");

// Encrypt Plain Data => Cipher Data
byte[] bytCipherData = rsaAlgorithm.Encrypt(bytPlainData, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);

Utility.ShowData(bytCipherData, "Cipher Data");

// Decrypt Cipher Data => Plain Data
byte[] bytDecryptedData = rsaAlgorithm.Decrypt(bytCipherData, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);

Utility.ShowData(bytDecryptedData, "Decrypted Data");

//********** ********** ********** ********** ********** 
// / Learn 01 - How to use Asymmetric algorithms
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 02 - How to encrypt everything?
//********** ********** ********** ********** ********** 

// Simply:
//	1) Convert what you want to encrypt to array of bytes
//	2) Encrypt your Plain Data which you just converted to array of bytes
//	3) You may save Cipher Data as an array of bytes or convert it to string and save the result

//using CommonMethods;

//// This is our Plain Data which we want to encrypt and consider that its type is string
//string strPlainData = "Hello, my name is Hamed Banaei.";
//Utility.ShowData(strPlainData, "Plain Data");

//// Now, you should convert your Original Data to array of bytes
//byte[] bytPlainData = System.Text.Encoding.UTF8.GetBytes(strPlainData);
//Utility.ShowData(bytPlainData, "Plain Data as Byte Array");


//var rsaAlgorithm = System.Security.Cryptography.RSA.Create();
//rsaAlgorithm.KeySize = 512;

//// Encrypt Plain Data => Cipher Data
//byte[] bytCipherData = rsaAlgorithm.Encrypt(bytPlainData, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);
//string strCipherData = System.Convert.ToBase64String(bytCipherData);

//Utility.ShowData(bytCipherData, "Cipher Data as Byte Array");
//Utility.ShowData(strCipherData, "Cipher Data as String (ToBase64String Result)");

//// Decrypt Cipher Data => Plain Data
//byte[] bytCipherDataToDecrypt = System.Convert.FromBase64String(strCipherData);
//byte[] bytDecryptedData = rsaAlgorithm.Decrypt(bytCipherDataToDecrypt, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);
//string strDecryptedData = System.Text.Encoding.UTF8.GetString(bytDecryptedData);

//Utility.ShowData(bytCipherDataToDecrypt, "Cipher Data To Decrypt (FromBase64String Result)");
//Utility.ShowData(bytDecryptedData, "Decrypted Data as Byte Array");
//Utility.ShowData(strDecryptedData, "Decrypted Data as String (Plain Data)");

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 






//********** ********** ********** ********** ********** 
// Learn 03 - But Asymmetric algorithms have limitation on size of data. So what to do?
//********** ********** ********** ********** ********** 

//// Simply:
////	1) They exist to prevent repudation!
////	2) They are not designed to encrypt large data!
////	3) Best use of them is to encrypt a Symmetric Key!

//using Learn02;
//using CommonMethods;

//// This is our Plain Data which we want to encrypt and consider that its type is string
//string strPlainData = "Hello, my name is Hamed Banaei, you can call me Kourosh, that's my nickname. Glad to share this information with you.";
//Utility.ShowData(strPlainData, "Plain Data");

//// Now, you should convert your Original Data to array of bytes
//byte[] bytPlainData = System.Text.Encoding.UTF8.GetBytes(strPlainData);
//Utility.ShowData(bytPlainData, "Plain Data as Byte Array");

//var aesAlgorithm = System.Security.Cryptography.Aes.Create();
//aesAlgorithm.GenerateIV();
//aesAlgorithm.GenerateKey();
//var aesEncryptor = aesAlgorithm.CreateEncryptor();

//var rsaAlgorithm = System.Security.Cryptography.RSA.Create();
//rsaAlgorithm.KeySize = 4096;

//Message message = new Message();

//// Encrypt Plain Data => Cipher Data
//byte[] bytCipherData = aesEncryptor.TransformFinalBlock(bytPlainData, 0, bytPlainData.Length);
//string strCipherData = System.Convert.ToBase64String(bytCipherData);

//message.Content = strCipherData;

//Utility.ShowData(bytCipherData, "Cipher Data as Byte Array");
//Utility.ShowData(strCipherData, "Cipher Data as String (ToBase64String Result)");

//message.SecretV = rsaAlgorithm.Encrypt(aesAlgorithm.IV, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);
//message.SecretK = rsaAlgorithm.Encrypt(aesAlgorithm.Key, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);

//// Decrypt Cipher Data => Plain Data
//message.SecretV = rsaAlgorithm.Decrypt(message.SecretV, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);
//message.SecretK = rsaAlgorithm.Decrypt(message.SecretK, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);

//aesAlgorithm.Key = message.SecretK;
//aesAlgorithm.IV = message.SecretV;

//byte[] bytCipherDataToDecrypt = System.Convert.FromBase64String(strCipherData);
//var aesDecryptor = aesAlgorithm.CreateDecryptor();
//byte[] bytDecryptedData = aesDecryptor.TransformFinalBlock(bytCipherDataToDecrypt, 0, bytCipherDataToDecrypt.Length);
//message.Content = System.Text.Encoding.UTF8.GetString(bytDecryptedData);

//Utility.ShowData(bytCipherDataToDecrypt, "Cipher Data To Decrypt (FromBase64String Result)");
//Utility.ShowData(bytDecryptedData, "Decrypted Data as Byte Array");
//Utility.ShowData(message.Content, "Decrypted Data as String (Plain Data)");

//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 
//********** ********** ********** ********** ********** 