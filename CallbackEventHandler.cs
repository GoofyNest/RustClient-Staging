public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 4650
{	// Fields
	private EventCallbackRegistry m_CallbackRegistry; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendEvent(EventBase e);

	// RVA: 0xEA9300 Offset: 0xEA7900 VA: 0x180EA9300
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0xEA9360 Offset: 0xEA7960 VA: 0x180EA9360 Slot: 7
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0xEA9610 Offset: 0xEA7C10 VA: 0x180EA9610 Slot: 8
	public bool HasTrickleDownHandlers() { }

	// RVA: 0xEA95F0 Offset: 0xEA7BF0 VA: 0x180EA95F0 Slot: 9
	public bool HasBubbleUpHandlers() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

}

