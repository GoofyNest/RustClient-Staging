internal class PendingBuffer // TypeDefIndex: 5663
{	// Fields
	protected byte[] buf; // 0x10
	private int start; // 0x18
	private int end; // 0x1C
	private uint bits; // 0x20
	private int bitCount; // 0x24

	// Properties
	public int BitCount { get; }
	public bool IsFlushed { get; }

	// Methods

	// RVA: 0x23038B0 Offset: 0x2301EB0 VA: 0x1823038B0
	public void .ctor(int bufsize) { }

	// RVA: 0x2303480 Offset: 0x2301A80 VA: 0x182303480
	public void Reset() { }

	// RVA: 0x23037B0 Offset: 0x2301DB0 VA: 0x1823037B0
	public void WriteShort(int s) { }

	// RVA: 0x23035D0 Offset: 0x2301BD0 VA: 0x1823035D0
	public void WriteBlock(byte[] block, int offset, int len) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_BitCount() { }

	// RVA: 0x23032B0 Offset: 0x23018B0 VA: 0x1823032B0
	public void AlignToByte() { }

	// RVA: 0x2303490 Offset: 0x2301A90 VA: 0x182303490
	public void WriteBits(int b, int count) { }

	// RVA: 0x23036B0 Offset: 0x2301CB0 VA: 0x1823036B0
	public void WriteShortMSB(int s) { }

	// RVA: 0x2303910 Offset: 0x2301F10 VA: 0x182303910
	public bool get_IsFlushed() { }

	// RVA: 0x23033C0 Offset: 0x23019C0 VA: 0x1823033C0
	public int Flush(byte[] output, int offset, int length) { }

}

