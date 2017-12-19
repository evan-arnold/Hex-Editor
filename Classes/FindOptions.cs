using System;
using System.Collections.Generic;
using System.Text;

namespace SHex
{

	public enum FindType 
	{ 
		Text, 
		Hex 
	}

	public class FindOptions
	{
		public bool IsValid { get; set; }
		internal byte[] FindBuffer { get; private set; }
		internal byte[] FindBufferLowerCase { get; private set; }
		internal byte[] FindBufferUpperCase { get; private set; }
		bool _matchCase;

		public bool MatchCase
		{
			get { return _matchCase; }
			set
			{
				_matchCase = value;
				UpdateFindBuffer();
			}
		}

		string _text;
		public string Text
		{
			get { return _text; }
			set
			{
				_text = value;
				UpdateFindBuffer();
			}
		}

		public byte[] Hex { get; set; }
		public FindType Type { get; set; }
		void UpdateFindBuffer()
		{
			string text = this.Text != null ? this.Text : string.Empty;
			FindBuffer = ASCIIEncoding.ASCII.GetBytes(text);
			FindBufferLowerCase = ASCIIEncoding.ASCII.GetBytes(text.ToLower());
			FindBufferUpperCase = ASCIIEncoding.ASCII.GetBytes(text.ToUpper());
		}
    }
}
