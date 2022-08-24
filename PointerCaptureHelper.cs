public static class PointerCaptureHelper // TypeDefIndex: 4603
{
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	[ExtensionAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

}

