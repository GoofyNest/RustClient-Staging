internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 4665
{	// Methods

	// RVA: 0xEB4150 Offset: 0xEB2750 VA: 0x180EB4150 Slot: 4
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0xEB41D0 Offset: 0xEB27D0 VA: 0x180EB41D0 Slot: 5
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private enum MouseCaptureDispatchingStrategy.EventBehavior // TypeDefIndex: 4666
{	// Fields
	public int value__; // 0x0
	public const MouseCaptureDispatchingStrategy.EventBehavior None = 0;
	public const MouseCaptureDispatchingStrategy.EventBehavior IsCapturable = 1;
	public const MouseCaptureDispatchingStrategy.EventBehavior IsSentExclusivelyToCapturingElement = 2;

}

