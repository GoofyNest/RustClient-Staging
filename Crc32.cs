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

	// RVA: 0x21C7650 Offset: 0x21C5C50 VA: 0x1821C7650
	public int get_Crc32Result() { }

	// RVA: 0x21C7390 Offset: 0x21C5990 VA: 0x1821C7390
	public void SlurpBlock(byte[] block, int offset, int count) { }

	// RVA: 0x21C74E0 Offset: 0x21C5AE0 VA: 0x1821C74E0
	public void UpdateCRC(byte b) { }

	// RVA: 0x21C7330 Offset: 0x21C5930 VA: 0x1821C7330
	private static uint ReverseBits(uint data) { }

	// RVA: 0x21C7300 Offset: 0x21C5900 VA: 0x1821C7300
	private static byte ReverseBits(byte data) { }

	// RVA: 0x21C7190 Offset: 0x21C5790 VA: 0x1821C7190
	private void GenerateLookupTable() { }

	// RVA: 0x21C7610 Offset: 0x21C5C10 VA: 0x1821C7610
	public void .ctor() { }

	// RVA: 0x21C7580 Offset: 0x21C5B80 VA: 0x1821C7580
	public void .ctor(bool reverseBits) { }

	// RVA: 0x21C75C0 Offset: 0x21C5BC0 VA: 0x1821C75C0
	public void .ctor(int polynomial, bool reverseBits) { }

	// RVA: 0x21C72F0 Offset: 0x21C58F0 VA: 0x1821C72F0
	public void Reset() { }

}

