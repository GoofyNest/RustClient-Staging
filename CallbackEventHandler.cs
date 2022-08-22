public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 4650
{	// Fields
	private EventCallbackRegistry m_CallbackRegistry; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendEvent(EventBase e);

	// RVA: 0xEA95C0 Offset: 0xEA7BC0 VA: 0x180EA95C0
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0xEA9620 Offset: 0xEA7C20 VA: 0x180EA9620 Slot: 7
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0xEA98D0 Offset: 0xEA7ED0 VA: 0x180EA98D0 Slot: 8
	public bool HasTrickleDownHandlers() { }

	// RVA: 0xEA98B0 Offset: 0xEA7EB0 VA: 0x180EA98B0 Slot: 9
	public bool HasBubbleUpHandlers() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

}

