public struct ProfilerMarker // TypeDefIndex: 3296
{	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal readonly IntPtr m_Ptr; // 0x0


	public void .ctor(string name) { }

	public ProfilerMarker.AutoScope Auto() { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[NativeConditionalAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	[ThreadSafeAttribute] // RVA: 0xE9560 Offset: 0xE8960 VA: 0x1800E9560
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal readonly IntPtr m_Ptr; // 0x0


	internal void .ctor(IntPtr markerPtr) { }

	public void Dispose() { }

}

