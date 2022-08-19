public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 3542
{	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x2186B40 Offset: 0x2185140 VA: 0x182186B40 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(Func<bool> predicate) { }

}

