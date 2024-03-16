

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Org.BouncyCastle.Crypto.Generators;
using static BCrypt.Net.BCrypt;
using System.Security.Cryptography;
using Konscious.Security.Cryptography;
using System.Text;

public class HashingBenchmark
{
    private const string Password = "SuaSenha123";
    private const int Iterations = 10000;

    [Benchmark]
    public string PBKDF2()
    {
        using(var rng = new RNGCryptoServiceProvider())
        {
            byte[] salt = new byte[16];
            rng.GetBytes(salt);

            using (var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                return Convert.ToBase64String(pbkdf2.GetBytes(32));
            }
        }
    }

    [Benchmark]
    public string BCryptHash()
    {

        string passwordHash = BCrypt.Net.BCrypt.HashPassword(Password);
        
        return passwordHash;

    }

    [Benchmark]
    public string Argon2Hash()
    {
        byte[] bytes = Encoding.ASCII.GetBytes(Password);

        using var argon2 = new Argon2id(bytes);

        argon2.Salt = new byte[16];
        argon2.DegreeOfParallelism = 8;
        argon2.Iterations = 4;
        argon2.MemorySize = 1024 * 128;
        var hash = argon2.GetBytes(32);

        string pwd = Encoding.ASCII.GetString(hash);
        return pwd;
    }


}

public static class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<HashingBenchmark>();
    }
}