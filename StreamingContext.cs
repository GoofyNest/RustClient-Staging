public struct StreamingContext // TypeDefIndex: 1062
{	// Fields
	internal object m_additionalContext; // 0x0
	internal StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x1DFCA0 Offset: 0x1DF0A0 VA: 0x1801DFCA0
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x14C890 Offset: 0x14BC90 VA: 0x18014C890
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public object get_Context() { }

	// RVA: 0x1DFBF0 Offset: 0x1DEFF0 VA: 0x1801DFBF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	public StreamingContextStates get_State() { }

}

