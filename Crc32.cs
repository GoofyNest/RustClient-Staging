internal sealed class Crc32 // TypeDefIndex: 5666
{	// Fields
	private static readonly uint CrcSeed; // 0x0
	private static readonly uint[] CrcTable; // 0x8
	private uint crc; // 0x10

	// Properties
	public long Value { get; }

	// Methods

	// RVA: 0x13ABA40 Offset: 0x13AA040 VA: 0x1813ABA40
	internal static uint ComputeCrc32(uint oldCrc, byte bval) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 4
	public long get_Value() { }

	// RVA: 0x13ABAE0 Offset: 0x13AA0E0 VA: 0x1813ABAE0 Slot: 5
	public void Update(byte[] buf, int off, int len) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13ABCE0 Offset: 0x13AA2E0 VA: 0x1813ABCE0
	private static void .cctor() { }

}

public class CRC32 // TypeDefIndex: 6967
{	// Fields
	private uint dwPolynomial; // 0x10
	private long _TotalBytesRead; // 0x18
	private bool reverseBits; // 0x20
	private uint[] crc32Table; // 0x28
	private uint _register; // 0x30

	// Properties
	public long TotalBytesRead { get; }
	public int Crc32Result { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public long get_TotalBytesRead() { }

	// RVA: 0x21C7810 Offset: 0x21C5E10 VA: 0x1821C7810
	public int get_Crc32Result() { }

	// RVA: 0x21C7550 Offset: 0x21C5B50 VA: 0x1821C7550
	public void SlurpBlock(byte[] block, int offset, int count) { }

	// RVA: 0x21C76A0 Offset: 0x21C5CA0 VA: 0x1821C76A0
	public void UpdateCRC(byte b) { }

	// RVA: 0x21C74F0 Offset: 0x21C5AF0 VA: 0x1821C74F0
	private static uint ReverseBits(uint data) { }

	// RVA: 0x21C74C0 Offset: 0x21C5AC0 VA: 0x1821C74C0
	private static byte ReverseBits(byte data) { }

	// RVA: 0x21C7350 Offset: 0x21C5950 VA: 0x1821C7350
	private void GenerateLookupTable() { }

	// RVA: 0x21C77D0 Offset: 0x21C5DD0 VA: 0x1821C77D0
	public void .ctor() { }

	// RVA: 0x21C7740 Offset: 0x21C5D40 VA: 0x1821C7740
	public void .ctor(bool reverseBits) { }

	// RVA: 0x21C7780 Offset: 0x21C5D80 VA: 0x1821C7780
	public void .ctor(int polynomial, bool reverseBits) { }

	// RVA: 0x21C74B0 Offset: 0x21C5AB0 VA: 0x1821C74B0
	public void Reset() { }

}

