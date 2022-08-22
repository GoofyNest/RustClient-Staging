public struct ProfilerMarker // TypeDefIndex: 3296
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x213990 Offset: 0x212D90 VA: 0x180213990
	public void .ctor(string name) { }

	// RVA: 0x213950 Offset: 0x212D50 VA: 0x180213950
	public ProfilerMarker.AutoScope Auto() { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	// RVA: 0x1832970 Offset: 0x1830F70 VA: 0x181832970
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	// RVA: 0x1832930 Offset: 0x1830F30 VA: 0x181832930
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	// RVA: 0x18329C0 Offset: 0x1830FC0 VA: 0x1818329C0
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x2120D0 Offset: 0x2114D0 VA: 0x1802120D0
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x212090 Offset: 0x211490 VA: 0x180212090 Slot: 4
	public void Dispose() { }

}

