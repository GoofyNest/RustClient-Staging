public struct StreamingContext // TypeDefIndex: 1062
{	// Fields
	internal object m_additionalContext; // 0x0
	internal StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x1DFD20 Offset: 0x1DF120 VA: 0x1801DFD20
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x14C910 Offset: 0x14BD10 VA: 0x18014C910
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public object get_Context() { }

	// RVA: 0x1DFC70 Offset: 0x1DF070 VA: 0x1801DFC70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public StreamingContextStates get_State() { }

}

