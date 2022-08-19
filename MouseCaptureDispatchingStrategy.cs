internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 4665
{	// Methods

	// RVA: 0xEB33E0 Offset: 0xEB19E0 VA: 0x180EB33E0 Slot: 4
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0xEB3460 Offset: 0xEB1A60 VA: 0x180EB3460 Slot: 5
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

