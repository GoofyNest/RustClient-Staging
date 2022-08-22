internal class NativeInputSystem // TypeDefIndex: 4523
{	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x2321EB0 Offset: 0x23204B0 VA: 0x182321EB0
	private static void .cctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2321C80 Offset: 0x2320280 VA: 0x182321C80
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2321D80 Offset: 0x2320380 VA: 0x182321D80
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2321D00 Offset: 0x2320300 VA: 0x182321D00
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2321E20 Offset: 0x2320420 VA: 0x182321E20
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x2321EE0 Offset: 0x23204E0 VA: 0x182321EE0
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

}

