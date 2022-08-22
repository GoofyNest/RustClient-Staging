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

	// RVA: 0x14DC3A0 Offset: 0x14DA9A0 VA: 0x1814DC3A0
	public void .ctor() { }

	// RVA: 0x14DC210 Offset: 0x14DA810 VA: 0x1814DC210
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x14DC2E0 Offset: 0x14DA8E0 VA: 0x1814DC2E0
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x14DC420 Offset: 0x14DAA20 VA: 0x1814DC420
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x14DB910 Offset: 0x14D9F10 VA: 0x1814DB910 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DBDD0 Offset: 0x14DA3D0 VA: 0x1814DBDD0
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x14DBA90 Offset: 0x14DA090 VA: 0x1814DBA90
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DBC10 Offset: 0x14DA210 VA: 0x1814DBC10
	internal byte[] Encode() { }

	// RVA: 0x14DBDE0 Offset: 0x14DA3E0 VA: 0x1814DBDE0 Slot: 6
	internal override string ToString(bool multiLine) { }

}

