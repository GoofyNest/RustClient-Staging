public sealed class SecureString : IDisposable // TypeDefIndex: 903
{	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x17C2A20 Offset: 0x17C1020 VA: 0x1817C2A20
	public void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x17C2A80 Offset: 0x17C1080 VA: 0x1817C2A80
	public void .ctor(char* value, int length) { }

	// RVA: 0x17C2C30 Offset: 0x17C1230 VA: 0x1817C2C30
	public int get_Length() { }

	// RVA: 0x17C28F0 Offset: 0x17C0EF0 VA: 0x1817C28F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void Encrypt() { }

	// RVA: 0x48BD30 Offset: 0x48A330 VA: 0x18048BD30
	private void Decrypt() { }

	// RVA: 0x17C2790 Offset: 0x17C0D90 VA: 0x1817C2790
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x17C2940 Offset: 0x17C0F40 VA: 0x1817C2940
	internal byte[] GetBuffer() { }

}

