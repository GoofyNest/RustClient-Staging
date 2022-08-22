internal sealed class Crc32 // TypeDefIndex: 5666
{	// Fields
	private static readonly uint CrcSeed; // 0x0
	private static readonly uint[] CrcTable; // 0x8
	private uint crc; // 0x10

	// Properties
	public long Value { get; }

	// Methods

	// RVA: 0x13ABD00 Offset: 0x13AA300 VA: 0x1813ABD00
	internal static uint ComputeCrc32(uint oldCrc, byte bval) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 4
	public long get_Value() { }

	// RVA: 0x13ABDA0 Offset: 0x13AA3A0 VA: 0x1813ABDA0 Slot: 5
	public void Update(byte[] buf, int off, int len) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13ABFA0 Offset: 0x13AA5A0 VA: 0x1813ABFA0
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

	// RVA: 0x21C7910 Offset: 0x21C5F10 VA: 0x1821C7910
	public int get_Crc32Result() { }

	// RVA: 0x21C7650 Offset: 0x21C5C50 VA: 0x1821C7650
	public void SlurpBlock(byte[] block, int offset, int count) { }

	// RVA: 0x21C77A0 Offset: 0x21C5DA0 VA: 0x1821C77A0
	public void UpdateCRC(byte b) { }

	// RVA: 0x21C75F0 Offset: 0x21C5BF0 VA: 0x1821C75F0
	private static uint ReverseBits(uint data) { }

	// RVA: 0x21C75C0 Offset: 0x21C5BC0 VA: 0x1821C75C0
	private static byte ReverseBits(byte data) { }

	// RVA: 0x21C7450 Offset: 0x21C5A50 VA: 0x1821C7450
	private void GenerateLookupTable() { }

	// RVA: 0x21C78D0 Offset: 0x21C5ED0 VA: 0x1821C78D0
	public void .ctor() { }

	// RVA: 0x21C7840 Offset: 0x21C5E40 VA: 0x1821C7840
	public void .ctor(bool reverseBits) { }

	// RVA: 0x21C7880 Offset: 0x21C5E80 VA: 0x1821C7880
	public void .ctor(int polynomial, bool reverseBits) { }

	// RVA: 0x21C75B0 Offset: 0x21C5BB0 VA: 0x1821C75B0
	public void Reset() { }

}

