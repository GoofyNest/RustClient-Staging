public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 4144
{	// Fields
	internal string m_Name; // 0x0
	[NativeNameAttribute] // RVA: 0x95AB0 Offset: 0x94EB0 VA: 0x180095AB0
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x1FBAB0 Offset: 0x1FAEB0 VA: 0x1801FBAB0
	public string get_name() { }

	// RVA: 0x13AC20 Offset: 0x13A020 VA: 0x18013AC20
	internal InputFeatureType get_internalType() { }

	// RVA: 0x23E6D0 Offset: 0x23DAD0 VA: 0x18023E6D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E790 Offset: 0x23DB90 VA: 0x18023E790 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x23E7E0 Offset: 0x23DBE0 VA: 0x18023E7E0 Slot: 2
	public override int GetHashCode() { }

}

