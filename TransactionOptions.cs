public struct TransactionOptions // TypeDefIndex: 3988
{	// Fields
	private IsolationLevel level; // 0x0
	private TimeSpan timeout; // 0x8

	// Methods

	// RVA: 0x14B5B0 Offset: 0x14A9B0 VA: 0x18014B5B0
	internal void .ctor(IsolationLevel level, TimeSpan timeout) { }

	// RVA: 0x230CFB0 Offset: 0x230B5B0 VA: 0x18230CFB0
	public static bool op_Equality(TransactionOptions x, TransactionOptions y) { }

	// RVA: 0x23FBC0 Offset: 0x23EFC0 VA: 0x18023FBC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23FCB0 Offset: 0x23F0B0 VA: 0x18023FCB0 Slot: 2
	public override int GetHashCode() { }

}

