namespace Common.DataEncryption;

public class AESEncryptionHelper
{
    private string EncryptString(string plainText)
    {
        using Aes aes = Aes.Create();
        aes.Key = _key;
        aes.IV = _iv;
        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

        using MemoryStream ms = new();
        using CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write);
        using StreamWriter sw = new(cs, Encoding.UTF8);
        sw.Write(plainText);
        sw.Flush();
        cs.FlushFinalBlock();
        return Convert.ToBase64String(ms.ToArray());
    }

    private string DecryptString(string cipherText)
    {
        byte[] buffer = Convert.FromBase64String(cipherText);
        using Aes aes = Aes.Create();
        aes.Key = _key;
        aes.IV = _iv;
        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
        using MemoryStream ms = new(buffer);
        using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);
        using StreamReader sr = new(cs, Encoding.UTF8);
        return sr.ReadToEnd();
    }
}
