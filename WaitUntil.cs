public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 3542
{	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x2187460 Offset: 0x2185A60 VA: 0x182187460 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(Func<bool> predicate) { }

}

