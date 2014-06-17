using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for sha256
/// </summary>
public class sha512
{
	public sha512()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string EncodePassword(string originalPassword)
    {
        //Declarations
        Byte[] originalBytes;
        Byte[] encodedBytes;
        SHA512 sha512;

        //Instantiate sha512CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
        sha512 = new SHA512CryptoServiceProvider();
        originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
        encodedBytes = sha512.ComputeHash(originalBytes);

        //Convert encoded bytes back to a 'readable' string
        return BitConverter.ToString(encodedBytes);
    }

    /*Use this to get a sha256 hash - edit "" at test.Text = sha256.EncodePassword("1234");
     * Place that on ex. Masterpage to get info in bottom.
     * ---
     * protected void Page_Load(object sender, EventArgs e)
    {
        Label test = new Label();
        test.Text = sha512.EncodePassword("1234kage");
        this.Controls.Add(test);
    }
    */
}