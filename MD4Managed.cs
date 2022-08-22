internal class MD4Managed : MD4 // TypeDefIndex: 69
{	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x174A220 Offset: 0x1748820 VA: 0x18174A220
	public void .ctor() { }

	// RVA: 0x1749580 Offset: 0x1747B80 VA: 0x181749580 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1749240 Offset: 0x1747840 VA: 0x181749240 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1749400 Offset: 0x1747A00 VA: 0x181749400 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x174A190 Offset: 0x1748790 VA: 0x18174A190
	private byte[] Padding(int nLength) { }

	// RVA: 0x1749170 Offset: 0x1747770 VA: 0x181749170
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x17491D0 Offset: 0x17477D0 VA: 0x1817491D0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x1749230 Offset: 0x1747830 VA: 0x181749230
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x174A200 Offset: 0x1748800 VA: 0x18174A200
	private uint ROL(uint x, byte n) { }

	// RVA: 0x1749130 Offset: 0x1747730 VA: 0x181749130
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1749180 Offset: 0x1747780 VA: 0x181749180
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x17491E0 Offset: 0x17477E0 VA: 0x1817491E0
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1748FE0 Offset: 0x17475E0 VA: 0x181748FE0
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x1748ED0 Offset: 0x17474D0 VA: 0x181748ED0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x17496C0 Offset: 0x1747CC0 VA: 0x1817496C0
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

	// RVA: 0x1AB87E0 Offset: 0x1AB6DE0 VA: 0x181AB87E0
	public void .ctor() { }

	// RVA: 0x1749580 Offset: 0x1747B80 VA: 0x181749580 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1749240 Offset: 0x1747840 VA: 0x181749240 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1AB85F0 Offset: 0x1AB6BF0 VA: 0x181AB85F0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1AB8770 Offset: 0x1AB6D70 VA: 0x181AB8770
	private byte[] Padding(int nLength) { }

	// RVA: 0x1749170 Offset: 0x1747770 VA: 0x181749170
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x17491D0 Offset: 0x17477D0 VA: 0x1817491D0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x1749230 Offset: 0x1747830 VA: 0x181749230
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x174A200 Offset: 0x1748800 VA: 0x18174A200
	private uint ROL(uint x, byte n) { }

	// RVA: 0x1749130 Offset: 0x1747730 VA: 0x181749130
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1749180 Offset: 0x1747780 VA: 0x181749180
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x17491E0 Offset: 0x17477E0 VA: 0x1817491E0
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1748FE0 Offset: 0x17475E0 VA: 0x181748FE0
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x1748ED0 Offset: 0x17474D0 VA: 0x181748ED0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x17496C0 Offset: 0x1747CC0 VA: 0x1817496C0
	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

