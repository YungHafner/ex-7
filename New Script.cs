using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

class Script
{
    [STAThread]
    static public void Main(string[] args)
    {
        {
			{
		      bool fw = false;
			  Console.WriteLine("vvedi text");
			  string words= Console.ReadLine();
			  char [] Splitchars = new char [] {' ',' ','.'};
			  string[] word =words.Split(Splitchars,StringSplitOptions.RemoveEmptyEntries);
			  for(int i= 0; i<word.Length; i++)
			  {
				  if(word[i].Length==3)
					  Console.WriteLine(word[i]);
				  
			  }

			  Console.ReadLine();
			}		
		}
	}
}