public struct ProfilerMarker // TypeDefIndex: 3296
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x213A10 Offset: 0x212E10 VA: 0x180213A10
	public void .ctor(string name) { }

	// RVA: 0x2139D0 Offset: 0x212DD0 VA: 0x1802139D0
	public ProfilerMarker.AutoScope Auto() { }

	[NativeConditionalAttribute] // RVA: 0xE9550 Offset: 0xE8950 VA: 0x1800E9550
	[ThreadSafeAttribute] // RVA: 0xE9550 Offset: 0xE8950 VA: 0x1800E9550
	// RVA: 0x18329B0 Offset: 0x1830FB0 VA: 0x1818329B0
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[ThreadSafeAttribute] // RVA: 0xE97B0 Offset: 0xE8BB0 VA: 0x1800E97B0
	[NativeConditionalAttribute] // RVA: 0xE97B0 Offset: 0xE8BB0 VA: 0x1800E97B0
	// RVA: 0x1832970 Offset: 0x1830F70 VA: 0x181832970
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[ThreadSafeAttribute] // RVA: 0xE97B0 Offset: 0xE8BB0 VA: 0x1800E97B0
	[NativeConditionalAttribute] // RVA: 0xE97B0 Offset: 0xE8BB0 VA: 0x1800E97B0
	// RVA: 0x1832A00 Offset: 0x1831000 VA: 0x181832A00
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x212150 Offset: 0x211550 VA: 0x180212150
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x212110 Offset: 0x211510 VA: 0x180212110 Slot: 4
	public void Dispose() { }

}

