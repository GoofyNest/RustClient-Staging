internal abstract class Base64Encoder // TypeDefIndex: 1813
{	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x12E4320 Offset: 0x12E2920 VA: 0x1812E4320
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x12E3ED0 Offset: 0x12E24D0 VA: 0x1812E3ED0
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x12E4250 Offset: 0x12E2850 VA: 0x1812E4250
	internal void Flush() { }

}

internal class Base64Encoder // TypeDefIndex: 5917
{	// Fields
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x17EB8F0 Offset: 0x17E9EF0 VA: 0x1817EB8F0
	public void .ctor(TextWriter writer) { }

	// RVA: 0x17EB460 Offset: 0x17E9A60 VA: 0x1817EB460
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x17EB7F0 Offset: 0x17E9DF0 VA: 0x1817EB7F0
	public void Flush() { }

	// RVA: 0x17EB8C0 Offset: 0x17E9EC0 VA: 0x1817EB8C0
	private void WriteChars(char[] chars, int index, int count) { }

}

