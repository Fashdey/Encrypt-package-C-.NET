using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for md5
/// </summary>
public class md5
{
	public md5()
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
        MD5 md5;

        //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
        md5 = new MD5CryptoServiceProvider();
        originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
        encodedBytes = md5.ComputeHash(originalBytes);

        //Convert encoded bytes back to a 'readable' string
        return BitConverter.ToString(encodedBytes);
    }

    /*Use this to get a md5 hash - edit "" at test.Text = md5.EncodePassword("1234");
     * Place that on ex. Masterpage to get info in bottom.
     * ---
     * protected void Page_Load(object sender, EventArgs e)
    {
        Label test = new Label();
        test.Text = md5.EncodePassword("1234");
        this.Controls.Add(test);
    }
    */
}