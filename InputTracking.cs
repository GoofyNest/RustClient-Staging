public static class InputTracking // TypeDefIndex: 4137
{
// Namespace: UnityEngine.XR
[RequiredByNativeCodeAttribute] // RVA: 0x951B0 Offset: 0x945B0 VA: 0x1800951B0
[NativeHeaderAttribute] // RVA: 0x951B0 Offset: 0x945B0 VA: 0x1800951B0
[NativeConditionalAttribute] // RVA: 0x951B0 Offset: 0x945B0 VA: 0x1800951B0
[StaticAccessorAttribute] // RVA: 0x951B0 Offset: 0x945B0 VA: 0x1800951B0
public static class InputTracking // TypeDefIndex: 4137
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<XRNodeState> trackingLost; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<XRNodeState> nodeAdded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22FB360 Offset: 0x22F9960 VA: 0x1822FB360
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

	// RVA: 0x22FB5A0 Offset: 0x22F9BA0 VA: 0x1822FB5A0
	private static void .cctor() { }

}

private enum InputTracking.TrackingStateEventType // TypeDefIndex: 4138
{	// Fields
	public int value__; // 0x0
	public const InputTracking.TrackingStateEventType NodeAdded = 0;
	public const InputTracking.TrackingStateEventType NodeRemoved = 1;
	public const InputTracking.TrackingStateEventType TrackingAcquired = 2;
	public const InputTracking.TrackingStateEventType TrackingLost = 3;

}

