public static class PointerCaptureHelper // TypeDefIndex: 4603
{	// Methods

	// RVA: 0xEB7310 Offset: 0xEB5910 VA: 0x180EB7310
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB73B0 Offset: 0xEB59B0 VA: 0x180EB73B0
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB7080 Offset: 0xEB5680 VA: 0x180EB7080
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB7630 Offset: 0xEB5C30 VA: 0x180EB7630
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB7270 Offset: 0xEB5870 VA: 0x180EB7270
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB7590 Offset: 0xEB5B90 VA: 0x180EB7590
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6FF0 Offset: 0xEB55F0 VA: 0x180EB6FF0
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB7490 Offset: 0xEB5A90 VA: 0x180EB7490
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB7720 Offset: 0xEB5D20 VA: 0x180EB7720
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB7520 Offset: 0xEB5B20 VA: 0x180EB7520
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

}

