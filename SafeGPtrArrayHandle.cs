internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 21
{	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F68A0 Offset: 0x1F5CA0 VA: 0x1801F68A0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F6BA0 Offset: 0x1F5FA0 VA: 0x1801F6BA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F69F0 Offset: 0x1F5DF0 VA: 0x1801F69F0
	internal int get_Length() { }

	// RVA: 0x1F69E0 Offset: 0x1F5DE0 VA: 0x1801F69E0
	internal IntPtr get_Item(int i) { }

}

