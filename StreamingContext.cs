public struct StreamingContext // TypeDefIndex: 1062
{	// Fields
	internal object m_additionalContext; // 0x0
	internal StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x1E0310 Offset: 0x1DF710 VA: 0x1801E0310
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x14C6B0 Offset: 0x14BAB0 VA: 0x18014C6B0
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public object get_Context() { }

	// RVA: 0x1E0260 Offset: 0x1DF660 VA: 0x1801E0260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public StreamingContextStates get_State() { }

}

