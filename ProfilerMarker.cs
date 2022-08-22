public struct ProfilerMarker // TypeDefIndex: 3296
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x212DC0 Offset: 0x2121C0 VA: 0x180212DC0
	public void .ctor(string name) { }

	// RVA: 0x212D80 Offset: 0x212180 VA: 0x180212D80
	public ProfilerMarker.AutoScope Auto() { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	// RVA: 0x1820570 Offset: 0x181EB70 VA: 0x181820570
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	// RVA: 0x1820530 Offset: 0x181EB30 VA: 0x181820530
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	// RVA: 0x18205C0 Offset: 0x181EBC0 VA: 0x1818205C0
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x211500 Offset: 0x210900 VA: 0x180211500
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x2114C0 Offset: 0x2108C0 VA: 0x1802114C0 Slot: 4
	public void Dispose() { }

}

