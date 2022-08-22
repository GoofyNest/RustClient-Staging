public struct TransactionOptions // TypeDefIndex: 3988
{	// Fields
	private IsolationLevel level; // 0x0
	private TimeSpan timeout; // 0x8

	// Methods

	// RVA: 0x14B3D0 Offset: 0x14A7D0 VA: 0x18014B3D0
	internal void .ctor(IsolationLevel level, TimeSpan timeout) { }

	// RVA: 0x230D7D0 Offset: 0x230BDD0 VA: 0x18230D7D0
	public static bool op_Equality(TransactionOptions x, TransactionOptions y) { }

	// RVA: 0x23FBC0 Offset: 0x23EFC0 VA: 0x18023FBC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23FCB0 Offset: 0x23F0B0 VA: 0x18023FCB0 Slot: 2
	public override int GetHashCode() { }

}

