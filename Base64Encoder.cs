internal abstract class Base64Encoder // TypeDefIndex: 1813
{	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x12DDBB0 Offset: 0x12DC1B0 VA: 0x1812DDBB0
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x12DD760 Offset: 0x12DBD60 VA: 0x1812DD760
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x12DDAE0 Offset: 0x12DC0E0 VA: 0x1812DDAE0
	internal void Flush() { }

}

internal class Base64Encoder // TypeDefIndex: 5917
{	// Fields
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x17FE1F0 Offset: 0x17FC7F0 VA: 0x1817FE1F0
	public void .ctor(TextWriter writer) { }

	// RVA: 0x17FDD60 Offset: 0x17FC360 VA: 0x1817FDD60
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x17FE0F0 Offset: 0x17FC6F0 VA: 0x1817FE0F0
	public void Flush() { }

	// RVA: 0x17FE1C0 Offset: 0x17FC7C0 VA: 0x1817FE1C0
	private void WriteChars(char[] chars, int index, int count) { }

}

