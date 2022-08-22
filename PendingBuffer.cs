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

	// RVA: 0x2303B70 Offset: 0x2302170 VA: 0x182303B70
	public void .ctor(int bufsize) { }

	// RVA: 0x2303740 Offset: 0x2301D40 VA: 0x182303740
	public void Reset() { }

	// RVA: 0x2303A70 Offset: 0x2302070 VA: 0x182303A70
	public void WriteShort(int s) { }

	// RVA: 0x2303890 Offset: 0x2301E90 VA: 0x182303890
	public void WriteBlock(byte[] block, int offset, int len) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_BitCount() { }

	// RVA: 0x2303570 Offset: 0x2301B70 VA: 0x182303570
	public void AlignToByte() { }

	// RVA: 0x2303750 Offset: 0x2301D50 VA: 0x182303750
	public void WriteBits(int b, int count) { }

	// RVA: 0x2303970 Offset: 0x2301F70 VA: 0x182303970
	public void WriteShortMSB(int s) { }

	// RVA: 0x2303BD0 Offset: 0x23021D0 VA: 0x182303BD0
	public bool get_IsFlushed() { }

	// RVA: 0x2303680 Offset: 0x2301C80 VA: 0x182303680
	public int Flush(byte[] output, int offset, int length) { }

}

