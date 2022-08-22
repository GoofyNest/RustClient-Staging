internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 21
{	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F6820 Offset: 0x1F5C20 VA: 0x1801F6820
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F6B20 Offset: 0x1F5F20 VA: 0x1801F6B20 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F6970 Offset: 0x1F5D70 VA: 0x1801F6970
	internal int get_Length() { }

	// RVA: 0x1F6960 Offset: 0x1F5D60 VA: 0x1801F6960
	internal IntPtr get_Item(int i) { }

}

