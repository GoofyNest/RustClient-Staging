public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 2836
{	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x28
	private AsnDecodeStatus _status; // 0x2C

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x14DB470 Offset: 0x14D9A70 VA: 0x1814DB470
	public void .ctor() { }

	// RVA: 0x14DB2E0 Offset: 0x14D98E0 VA: 0x1814DB2E0
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x14DB3B0 Offset: 0x14D99B0 VA: 0x1814DB3B0
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x14DB4F0 Offset: 0x14D9AF0 VA: 0x1814DB4F0
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x14DA9E0 Offset: 0x14D8FE0 VA: 0x1814DA9E0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DAEA0 Offset: 0x14D94A0 VA: 0x1814DAEA0
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x14DAB60 Offset: 0x14D9160 VA: 0x1814DAB60
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DACE0 Offset: 0x14D92E0 VA: 0x1814DACE0
	internal byte[] Encode() { }

	// RVA: 0x14DAEB0 Offset: 0x14D94B0 VA: 0x1814DAEB0 Slot: 6
	internal override string ToString(bool multiLine) { }

}

