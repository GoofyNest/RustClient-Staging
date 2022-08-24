public struct ProfilerMarker // TypeDefIndex: 3296
{	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal readonly IntPtr m_Ptr; // 0x0


	public void .ctor(string name) { }

	public ProfilerMarker.AutoScope Auto() { }

	[ThreadSafeAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	[NativeConditionalAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	internal static IntPtr Internal_Create(string name, ushort flags) { }

	[ThreadSafeAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	[NativeConditionalAttribute] // RVA: 0xE9640 Offset: 0xE8A40 VA: 0x1800E9640
	internal static void Internal_Begin(IntPtr markerPtr) { }

	[NativeConditionalAttribute] // RVA: 0xE9900 Offset: 0xE8D00 VA: 0x1800E9900
	[ThreadSafeAttribute] // RVA: 0xE9900 Offset: 0xE8D00 VA: 0x1800E9900
	internal static void Internal_End(IntPtr markerPtr) { }

}

public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 3297
{	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal readonly IntPtr m_Ptr; // 0x0


	internal void .ctor(IntPtr markerPtr) { }

	public void Dispose() { }

}

