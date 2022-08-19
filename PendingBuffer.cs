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

	// RVA: 0x2303A70 Offset: 0x2302070 VA: 0x182303A70
	public void .ctor(int bufsize) { }

	// RVA: 0x2303640 Offset: 0x2301C40 VA: 0x182303640
	public void Reset() { }

	// RVA: 0x2303970 Offset: 0x2301F70 VA: 0x182303970
	public void WriteShort(int s) { }

	// RVA: 0x2303790 Offset: 0x2301D90 VA: 0x182303790
	public void WriteBlock(byte[] block, int offset, int len) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_BitCount() { }

	// RVA: 0x2303470 Offset: 0x2301A70 VA: 0x182303470
	public void AlignToByte() { }

	// RVA: 0x2303650 Offset: 0x2301C50 VA: 0x182303650
	public void WriteBits(int b, int count) { }

	// RVA: 0x2303870 Offset: 0x2301E70 VA: 0x182303870
	public void WriteShortMSB(int s) { }

	// RVA: 0x2303AD0 Offset: 0x23020D0 VA: 0x182303AD0
	public bool get_IsFlushed() { }

	// RVA: 0x2303580 Offset: 0x2301B80 VA: 0x182303580
	public int Flush(byte[] output, int offset, int length) { }

}

