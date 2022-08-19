internal class NativeInputSystem // TypeDefIndex: 4523
{	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x2322070 Offset: 0x2320670 VA: 0x182322070
	private static void .cctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2321E40 Offset: 0x2320440 VA: 0x182321E40
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2321F40 Offset: 0x2320540 VA: 0x182321F40
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2321EC0 Offset: 0x23204C0 VA: 0x182321EC0
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2321FE0 Offset: 0x23205E0 VA: 0x182321FE0
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x23220A0 Offset: 0x23206A0 VA: 0x1823220A0
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

}
