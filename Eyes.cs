public struct Eyes : IEquatable<Eyes> // TypeDefIndex: 4147
{	// Fields
	private ulong m_DeviceId; // 0x0
	private uint m_FeatureIndex; // 0x8

	// Properties
	internal ulong deviceId { get; }
	internal uint featureIndex { get; }

	// Methods

	// RVA: 0x1FB6E0 Offset: 0x1FAAE0 VA: 0x1801FB6E0
	internal ulong get_deviceId() { }

	// RVA: 0x13AA40 Offset: 0x139E40 VA: 0x18013AA40
	internal uint get_featureIndex() { }

	// RVA: 0x23E3F0 Offset: 0x23D7F0 VA: 0x18023E3F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E360 Offset: 0x23D760 VA: 0x18023E360 Slot: 4
	public bool Equals(Eyes other) { }

	// RVA: 0x23E3A0 Offset: 0x23D7A0 VA: 0x18023E3A0 Slot: 2
	public override int GetHashCode() { }

}

