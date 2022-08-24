public static class InputTracking // TypeDefIndex: 4137
{
[RequiredByNativeCodeAttribute] // RVA: 0x95360 Offset: 0x94760 VA: 0x180095360
[NativeHeaderAttribute] // RVA: 0x95360 Offset: 0x94760 VA: 0x180095360
[NativeConditionalAttribute] // RVA: 0x95360 Offset: 0x94760 VA: 0x180095360
[StaticAccessorAttribute] // RVA: 0x95360 Offset: 0x94760 VA: 0x180095360
public static class InputTracking // TypeDefIndex: 4137
	[DebuggerBrowsableAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	[CompilerGeneratedAttribute] // RVA: 0x70810 Offset: 0x6FC10 VA: 0x180070810
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<XRNodeState> trackingLost; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	[DebuggerBrowsableAttribute] // RVA: 0x70900 Offset: 0x6FD00 VA: 0x180070900
	private static Action<XRNodeState> nodeRemoved; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

	private static void .cctor() { }

}

private enum InputTracking.TrackingStateEventType // TypeDefIndex: 4138
{	public int value__; // 0x0
	public const InputTracking.TrackingStateEventType NodeAdded = 0;
	public const InputTracking.TrackingStateEventType NodeRemoved = 1;
	public const InputTracking.TrackingStateEventType TrackingAcquired = 2;
	public const InputTracking.TrackingStateEventType TrackingLost = 3;

}

