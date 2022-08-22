internal sealed class BitReserve // TypeDefIndex: 7383
{	// Fields
	private const int BUFSIZE = 32768;
	private const int BUFSIZE_MASK = 32767;
	private int[] _Buffer; // 0x10
	private int _Offset; // 0x18
	private int _Totbit; // 0x1C
	private int _BufByteIdx; // 0x20

	// Methods

	// RVA: 0x5DAA00 Offset: 0x5D9000 VA: 0x1805DAA00
	internal void .ctor() { }

	// RVA: 0x5DA670 Offset: 0x5D8C70 VA: 0x1805DA670
	private void InitBlock() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	internal int HssTell() { }

	// RVA: 0x5DA890 Offset: 0x5D8E90 VA: 0x1805DA890
	internal int ReadBits(int n) { }

	// RVA: 0x5DA980 Offset: 0x5D8F80 VA: 0x1805DA980
	internal int ReadOneBit() { }

	// RVA: 0x5DA6C0 Offset: 0x5D8CC0 VA: 0x1805DA6C0
	internal void PutBuffer(int val) { }

	// RVA: 0x5DA9D0 Offset: 0x5D8FD0 VA: 0x1805DA9D0
	internal void RewindStreamBits(int bitCount) { }

	// RVA: 0x5DA9E0 Offset: 0x5D8FE0 VA: 0x1805DA9E0
	internal void RewindStreamBytes(int byteCount) { }

}

