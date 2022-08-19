public sealed class SecureString : IDisposable // TypeDefIndex: 903
{	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x17C2760 Offset: 0x17C0D60 VA: 0x1817C2760
	public void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x17C27C0 Offset: 0x17C0DC0 VA: 0x1817C27C0
	public void .ctor(char* value, int length) { }

	// RVA: 0x17C2970 Offset: 0x17C0F70 VA: 0x1817C2970
	public int get_Length() { }

	// RVA: 0x17C2630 Offset: 0x17C0C30 VA: 0x1817C2630 Slot: 4
	public void Dispose() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void Encrypt() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void Decrypt() { }

	// RVA: 0x17C24D0 Offset: 0x17C0AD0 VA: 0x1817C24D0
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x17C2680 Offset: 0x17C0C80 VA: 0x1817C2680
	internal byte[] GetBuffer() { }

}

