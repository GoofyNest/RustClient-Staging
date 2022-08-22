internal sealed class Crc32 // TypeDefIndex: 5666
{	// Fields
	private static readonly uint CrcSeed; // 0x0
	private static readonly uint[] CrcTable; // 0x8
	private uint crc; // 0x10

	// Properties
	public long Value { get; }

	// Methods

	// RVA: 0x13AAE00 Offset: 0x13A9400 VA: 0x1813AAE00
	internal static uint ComputeCrc32(uint oldCrc, byte bval) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 4
	public long get_Value() { }

	// RVA: 0x13AAEA0 Offset: 0x13A94A0 VA: 0x1813AAEA0 Slot: 5
	public void Update(byte[] buf, int off, int len) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13AB0A0 Offset: 0x13A96A0 VA: 0x1813AB0A0
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

	// RVA: 0x21C8130 Offset: 0x21C6730 VA: 0x1821C8130
	public int get_Crc32Result() { }

	// RVA: 0x21C7E70 Offset: 0x21C6470 VA: 0x1821C7E70
	public void SlurpBlock(byte[] block, int offset, int count) { }

	// RVA: 0x21C7FC0 Offset: 0x21C65C0 VA: 0x1821C7FC0
	public void UpdateCRC(byte b) { }

	// RVA: 0x21C7E10 Offset: 0x21C6410 VA: 0x1821C7E10
	private static uint ReverseBits(uint data) { }

	// RVA: 0x21C7DE0 Offset: 0x21C63E0 VA: 0x1821C7DE0
	private static byte ReverseBits(byte data) { }

	// RVA: 0x21C7C70 Offset: 0x21C6270 VA: 0x1821C7C70
	private void GenerateLookupTable() { }

	// RVA: 0x21C80F0 Offset: 0x21C66F0 VA: 0x1821C80F0
	public void .ctor() { }

	// RVA: 0x21C8060 Offset: 0x21C6660 VA: 0x1821C8060
	public void .ctor(bool reverseBits) { }

	// RVA: 0x21C80A0 Offset: 0x21C66A0 VA: 0x1821C80A0
	public void .ctor(int polynomial, bool reverseBits) { }

	// RVA: 0x21C7DD0 Offset: 0x21C63D0 VA: 0x1821C7DD0
	public void Reset() { }

}

