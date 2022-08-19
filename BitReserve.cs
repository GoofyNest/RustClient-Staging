internal sealed class BitReserve // TypeDefIndex: 7383
{	// Fields
	private const int BUFSIZE = 32768;
	private const int BUFSIZE_MASK = 32767;
	private int[] _Buffer; // 0x10
	private int _Offset; // 0x18
	private int _Totbit; // 0x1C
	private int _BufByteIdx; // 0x20

	// Methods

	// RVA: 0x5DAA70 Offset: 0x5D9070 VA: 0x1805DAA70
	internal void .ctor() { }

	// RVA: 0x5DA6E0 Offset: 0x5D8CE0 VA: 0x1805DA6E0
	private void InitBlock() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	internal int HssTell() { }

	// RVA: 0x5DA900 Offset: 0x5D8F00 VA: 0x1805DA900
	internal int ReadBits(int n) { }

	// RVA: 0x5DA9F0 Offset: 0x5D8FF0 VA: 0x1805DA9F0
	internal int ReadOneBit() { }

	// RVA: 0x5DA730 Offset: 0x5D8D30 VA: 0x1805DA730
	internal void PutBuffer(int val) { }

	// RVA: 0x5DAA40 Offset: 0x5D9040 VA: 0x1805DAA40
	internal void RewindStreamBits(int bitCount) { }

	// RVA: 0x5DAA50 Offset: 0x5D9050 VA: 0x1805DAA50
	internal void RewindStreamBytes(int byteCount) { }

}

