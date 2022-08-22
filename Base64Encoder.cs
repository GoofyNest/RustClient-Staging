internal abstract class Base64Encoder // TypeDefIndex: 1813
{	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x12DDE70 Offset: 0x12DC470 VA: 0x1812DDE70
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x12DDA20 Offset: 0x12DC020 VA: 0x1812DDA20
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x12DDDA0 Offset: 0x12DC3A0 VA: 0x1812DDDA0
	internal void Flush() { }

}

internal class Base64Encoder // TypeDefIndex: 5917
{	// Fields
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x17FE4B0 Offset: 0x17FCAB0 VA: 0x1817FE4B0
	public void .ctor(TextWriter writer) { }

	// RVA: 0x17FE020 Offset: 0x17FC620 VA: 0x1817FE020
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x17FE3B0 Offset: 0x17FC9B0 VA: 0x1817FE3B0
	public void Flush() { }

	// RVA: 0x17FE480 Offset: 0x17FCA80 VA: 0x1817FE480
	private void WriteChars(char[] chars, int index, int count) { }

}

