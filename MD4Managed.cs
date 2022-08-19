internal class MD4Managed : MD4 // TypeDefIndex: 69
{	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x174C3A0 Offset: 0x174A9A0 VA: 0x18174C3A0
	public void .ctor() { }

	// RVA: 0x174B700 Offset: 0x1749D00 VA: 0x18174B700 Slot: 16
	public override void Initialize() { }

	// RVA: 0x174B3C0 Offset: 0x17499C0 VA: 0x18174B3C0 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x174B580 Offset: 0x1749B80 VA: 0x18174B580 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x174C310 Offset: 0x174A910 VA: 0x18174C310
	private byte[] Padding(int nLength) { }

	// RVA: 0x174B2F0 Offset: 0x17498F0 VA: 0x18174B2F0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x174B350 Offset: 0x1749950 VA: 0x18174B350
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x174B3B0 Offset: 0x17499B0 VA: 0x18174B3B0
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x174C380 Offset: 0x174A980 VA: 0x18174C380
	private uint ROL(uint x, byte n) { }

	// RVA: 0x174B2B0 Offset: 0x17498B0 VA: 0x18174B2B0
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B300 Offset: 0x1749900 VA: 0x18174B300
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B360 Offset: 0x1749960 VA: 0x18174B360
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B160 Offset: 0x1749760 VA: 0x18174B160
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x174B050 Offset: 0x1749650 VA: 0x18174B050
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x174B840 Offset: 0x1749E40 VA: 0x18174B840
	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

public class MD4Managed : MD4 // TypeDefIndex: 1756
{	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1AB7EF0 Offset: 0x1AB64F0 VA: 0x181AB7EF0
	public void .ctor() { }

	// RVA: 0x174B700 Offset: 0x1749D00 VA: 0x18174B700 Slot: 16
	public override void Initialize() { }

	// RVA: 0x174B3C0 Offset: 0x17499C0 VA: 0x18174B3C0 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1AB7D00 Offset: 0x1AB6300 VA: 0x181AB7D00 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1AB7E80 Offset: 0x1AB6480 VA: 0x181AB7E80
	private byte[] Padding(int nLength) { }

	// RVA: 0x174B2F0 Offset: 0x17498F0 VA: 0x18174B2F0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x174B350 Offset: 0x1749950 VA: 0x18174B350
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x174B3B0 Offset: 0x17499B0 VA: 0x18174B3B0
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x174C380 Offset: 0x174A980 VA: 0x18174C380
	private uint ROL(uint x, byte n) { }

	// RVA: 0x174B2B0 Offset: 0x17498B0 VA: 0x18174B2B0
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B300 Offset: 0x1749900 VA: 0x18174B300
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B360 Offset: 0x1749960 VA: 0x18174B360
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B160 Offset: 0x1749760 VA: 0x18174B160
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x174B050 Offset: 0x1749650 VA: 0x18174B050
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x174B840 Offset: 0x1749E40 VA: 0x18174B840
	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

