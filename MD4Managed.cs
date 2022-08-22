internal class MD4Managed : MD4 // TypeDefIndex: 69
{	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x174C660 Offset: 0x174AC60 VA: 0x18174C660
	public void .ctor() { }

	// RVA: 0x174B9C0 Offset: 0x1749FC0 VA: 0x18174B9C0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x174B680 Offset: 0x1749C80 VA: 0x18174B680 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x174B840 Offset: 0x1749E40 VA: 0x18174B840 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x174C5D0 Offset: 0x174ABD0 VA: 0x18174C5D0
	private byte[] Padding(int nLength) { }

	// RVA: 0x174B5B0 Offset: 0x1749BB0 VA: 0x18174B5B0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x174B610 Offset: 0x1749C10 VA: 0x18174B610
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x174B670 Offset: 0x1749C70 VA: 0x18174B670
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x174C640 Offset: 0x174AC40 VA: 0x18174C640
	private uint ROL(uint x, byte n) { }

	// RVA: 0x174B570 Offset: 0x1749B70 VA: 0x18174B570
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B5C0 Offset: 0x1749BC0 VA: 0x18174B5C0
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B620 Offset: 0x1749C20 VA: 0x18174B620
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B420 Offset: 0x1749A20 VA: 0x18174B420
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x174B310 Offset: 0x1749910 VA: 0x18174B310
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x174BB00 Offset: 0x174A100 VA: 0x18174BB00
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

	// RVA: 0x1AB7FF0 Offset: 0x1AB65F0 VA: 0x181AB7FF0
	public void .ctor() { }

	// RVA: 0x174B9C0 Offset: 0x1749FC0 VA: 0x18174B9C0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x174B680 Offset: 0x1749C80 VA: 0x18174B680 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1AB7E00 Offset: 0x1AB6400 VA: 0x181AB7E00 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1AB7F80 Offset: 0x1AB6580 VA: 0x181AB7F80
	private byte[] Padding(int nLength) { }

	// RVA: 0x174B5B0 Offset: 0x1749BB0 VA: 0x18174B5B0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x174B610 Offset: 0x1749C10 VA: 0x18174B610
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x174B670 Offset: 0x1749C70 VA: 0x18174B670
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x174C640 Offset: 0x174AC40 VA: 0x18174C640
	private uint ROL(uint x, byte n) { }

	// RVA: 0x174B570 Offset: 0x1749B70 VA: 0x18174B570
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B5C0 Offset: 0x1749BC0 VA: 0x18174B5C0
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B620 Offset: 0x1749C20 VA: 0x18174B620
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x174B420 Offset: 0x1749A20 VA: 0x18174B420
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x174B310 Offset: 0x1749910 VA: 0x18174B310
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x174BB00 Offset: 0x174A100 VA: 0x18174BB00
	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

