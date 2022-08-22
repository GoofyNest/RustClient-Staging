public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 3542
{	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x2186C40 Offset: 0x2185240 VA: 0x182186C40 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(Func<bool> predicate) { }

}

