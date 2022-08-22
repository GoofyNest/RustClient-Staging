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

	// RVA: 0x2304390 Offset: 0x2302990 VA: 0x182304390
	public void .ctor(int bufsize) { }

	// RVA: 0x2303F60 Offset: 0x2302560 VA: 0x182303F60
	public void Reset() { }

	// RVA: 0x2304290 Offset: 0x2302890 VA: 0x182304290
	public void WriteShort(int s) { }

	// RVA: 0x23040B0 Offset: 0x23026B0 VA: 0x1823040B0
	public void WriteBlock(byte[] block, int offset, int len) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_BitCount() { }

	// RVA: 0x2303D90 Offset: 0x2302390 VA: 0x182303D90
	public void AlignToByte() { }

	// RVA: 0x2303F70 Offset: 0x2302570 VA: 0x182303F70
	public void WriteBits(int b, int count) { }

	// RVA: 0x2304190 Offset: 0x2302790 VA: 0x182304190
	public void WriteShortMSB(int s) { }

	// RVA: 0x23043F0 Offset: 0x23029F0 VA: 0x1823043F0
	public bool get_IsFlushed() { }

	// RVA: 0x2303EA0 Offset: 0x23024A0 VA: 0x182303EA0
	public int Flush(byte[] output, int offset, int length) { }

}

