public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 4650
{	// Fields
	private EventCallbackRegistry m_CallbackRegistry; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendEvent(EventBase e);

	// RVA: 0xEAA070 Offset: 0xEA8670 VA: 0x180EAA070
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0xEAA0D0 Offset: 0xEA86D0 VA: 0x180EAA0D0 Slot: 7
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0xEAA380 Offset: 0xEA8980 VA: 0x180EAA380 Slot: 8
	public bool HasTrickleDownHandlers() { }

	// RVA: 0xEAA360 Offset: 0xEA8960 VA: 0x180EAA360 Slot: 9
	public bool HasBubbleUpHandlers() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

}

