public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 4147
{	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x1FBB30 Offset: 0x1FAF30 VA: 0x1801FBB30
	internal ulong get_deviceId() { }

	// RVA: 0x13ACA0 Offset: 0x13A0A0 VA: 0x18013ACA0
	internal uint get_featureIndex() { }

	// RVA: 0x23E470 Offset: 0x23D870 VA: 0x18023E470 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E3E0 Offset: 0x23D7E0 VA: 0x18023E3E0 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x23E420 Offset: 0x23D820 VA: 0x18023E420 Slot: 2
	public override int GetHashCode() { }

}

