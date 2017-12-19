using System;
using System.Collections.Generic;

namespace SHex
{
	public class DynamicByteProvider : IByteProvider
	{
		bool _hasChanges;
		List<byte> _bytes;

		public DynamicByteProvider(byte[] data) : this(new List<Byte>(data)) 
		{
		}

		public DynamicByteProvider(List<Byte> bytes)
		{
			_bytes = bytes;
		}

		void OnChanged(EventArgs e)
		{
			_hasChanges = true;

			if(Changed != null)
				Changed(this, e);
		}

		void OnLengthChanged(EventArgs e)
		{
			if(LengthChanged != null)
				LengthChanged(this, e);
		}

		public List<Byte> Bytes
		{
			get { return _bytes; }
		}

		#region IByteProvider Members
		public bool HasChanges()
		{
			return _hasChanges;
		}

		public void ApplyChanges()
		{
			_hasChanges = false;
		}

		public event EventHandler Changed;
		public event EventHandler LengthChanged;

		public byte ReadByte(long index)
		{ return _bytes[(int)index]; }

		public void WriteByte(long index, byte value)
		{
			_bytes[(int)index] = value;
			OnChanged(EventArgs.Empty);
		}

		public void DeleteBytes(long index, long length)
		{ 
			int internal_index = (int)Math.Max(0, index);
			int internal_length = (int)Math.Min((int)Length, length);
			_bytes.RemoveRange(internal_index, internal_length); 

			OnLengthChanged(EventArgs.Empty);
			OnChanged(EventArgs.Empty);
		}

		public void InsertBytes(long index, byte[] bs)
		{ 
			_bytes.InsertRange((int)index, bs); 

			OnLengthChanged(EventArgs.Empty);
			OnChanged(EventArgs.Empty);
		}

		public long Length
		{
			get
			{
				return _bytes.Count;
			}
		}

		public bool SupportsWriteByte()
		{
			return true;
		}

		public bool SupportsInsertBytes()
		{
			return true;
		}

		public bool SupportsDeleteBytes()
		{
			return true;
		}
		#endregion

    }
}
