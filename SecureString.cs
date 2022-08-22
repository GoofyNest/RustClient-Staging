public sealed class SecureString : IDisposable // TypeDefIndex: 903
{	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x17C0570 Offset: 0x17BEB70 VA: 0x1817C0570
	public void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17C05D0 Offset: 0x17BEBD0 VA: 0x1817C05D0
	public void .ctor(char* value, int length) { }

	// RVA: 0x17C0780 Offset: 0x17BED80 VA: 0x1817C0780
	public int get_Length() { }

	// RVA: 0x17C0440 Offset: 0x17BEA40 VA: 0x1817C0440 Slot: 4
	public void Dispose() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void Encrypt() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void Decrypt() { }

	// RVA: 0x17C02E0 Offset: 0x17BE8E0 VA: 0x1817C02E0
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x17C0490 Offset: 0x17BEA90 VA: 0x1817C0490
	internal byte[] GetBuffer() { }

}

