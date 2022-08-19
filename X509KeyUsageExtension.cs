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

	// RVA: 0x14DC0E0 Offset: 0x14DA6E0 VA: 0x1814DC0E0
	public void .ctor() { }

	// RVA: 0x14DBF50 Offset: 0x14DA550 VA: 0x1814DBF50
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x14DC020 Offset: 0x14DA620 VA: 0x1814DC020
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x14DC160 Offset: 0x14DA760 VA: 0x1814DC160
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x14DB650 Offset: 0x14D9C50 VA: 0x1814DB650 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DBB10 Offset: 0x14DA110 VA: 0x1814DBB10
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x14DB7D0 Offset: 0x14D9DD0 VA: 0x1814DB7D0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DB950 Offset: 0x14D9F50 VA: 0x1814DB950
	internal byte[] Encode() { }

	// RVA: 0x14DBB20 Offset: 0x14DA120 VA: 0x1814DBB20 Slot: 6
	internal override string ToString(bool multiLine) { }

}

