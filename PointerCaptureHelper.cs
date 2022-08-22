public static class PointerCaptureHelper // TypeDefIndex: 4603
{	// Methods

	// RVA: 0xEB65A0 Offset: 0xEB4BA0 VA: 0x180EB65A0
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6640 Offset: 0xEB4C40 VA: 0x180EB6640
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6310 Offset: 0xEB4910 VA: 0x180EB6310
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB68C0 Offset: 0xEB4EC0 VA: 0x180EB68C0
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6500 Offset: 0xEB4B00 VA: 0x180EB6500
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6820 Offset: 0xEB4E20 VA: 0x180EB6820
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6280 Offset: 0xEB4880 VA: 0x180EB6280
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB6720 Offset: 0xEB4D20 VA: 0x180EB6720
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB69B0 Offset: 0xEB4FB0 VA: 0x180EB69B0
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEB67B0 Offset: 0xEB4DB0 VA: 0x180EB67B0
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

}

