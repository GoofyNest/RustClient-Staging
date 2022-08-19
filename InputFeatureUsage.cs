public struct InputFeatureUsage : IEquatable<InputFeatureUsage> // TypeDefIndex: 4144
{	// Fields
	internal string m_Name; // 0x0
	[NativeNameAttribute] // RVA: 0x95A30 Offset: 0x94E30 VA: 0x180095A30
	internal InputFeatureType m_InternalType; // 0x8

	// Properties
	public string name { get; }
	internal InputFeatureType internalType { get; }

	// Methods

	// RVA: 0x1FBB30 Offset: 0x1FAF30 VA: 0x1801FBB30
	public string get_name() { }

	// RVA: 0x13ACA0 Offset: 0x13A0A0 VA: 0x18013ACA0
	internal InputFeatureType get_internalType() { }

	// RVA: 0x23E750 Offset: 0x23DB50 VA: 0x18023E750 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E810 Offset: 0x23DC10 VA: 0x18023E810 Slot: 4
	public bool Equals(InputFeatureUsage other) { }

	// RVA: 0x23E860 Offset: 0x23DC60 VA: 0x18023E860 Slot: 2
	public override int GetHashCode() { }

}

