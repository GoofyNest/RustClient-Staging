public struct TransactionOptions // TypeDefIndex: 3988
{	// Fields
	private IsolationLevel level; // 0x0
	private TimeSpan timeout; // 0x8

	// Methods

	// RVA: 0x14B630 Offset: 0x14AA30 VA: 0x18014B630
	internal void .ctor(IsolationLevel level, TimeSpan timeout) { }

	// RVA: 0x230CEB0 Offset: 0x230B4B0 VA: 0x18230CEB0
	public static bool op_Equality(TransactionOptions x, TransactionOptions y) { }

	// RVA: 0x23FC40 Offset: 0x23F040 VA: 0x18023FC40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23FD30 Offset: 0x23F130 VA: 0x18023FD30 Slot: 2
	public override int GetHashCode() { }

}

