internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 21
{	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F5670 Offset: 0x1F4A70 VA: 0x1801F5670
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F5970 Offset: 0x1F4D70 VA: 0x1801F5970 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F57C0 Offset: 0x1F4BC0 VA: 0x1801F57C0
	internal int get_Length() { }

	// RVA: 0x1F57B0 Offset: 0x1F4BB0 VA: 0x1801F57B0
	internal IntPtr get_Item(int i) { }

}

