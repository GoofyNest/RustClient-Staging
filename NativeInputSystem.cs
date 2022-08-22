internal class NativeInputSystem // TypeDefIndex: 4523
{	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x2322990 Offset: 0x2320F90 VA: 0x182322990
	private static void .cctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2322760 Offset: 0x2320D60 VA: 0x182322760
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2322860 Offset: 0x2320E60 VA: 0x182322860
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23227E0 Offset: 0x2320DE0 VA: 0x1823227E0
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2322900 Offset: 0x2320F00 VA: 0x182322900
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x23229C0 Offset: 0x2320FC0 VA: 0x1823229C0
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

}

