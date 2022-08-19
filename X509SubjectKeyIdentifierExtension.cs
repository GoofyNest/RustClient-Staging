public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 2838
{	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x14DD3B0 Offset: 0x14DB9B0 VA: 0x1814DD3B0
	public void .ctor() { }

	// RVA: 0x14DD050 Offset: 0x14DB650 VA: 0x1814DD050
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DCEE0 Offset: 0x14DB4E0 VA: 0x1814DCEE0
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DD120 Offset: 0x14DB720 VA: 0x1814DD120
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DD390 Offset: 0x14DB990 VA: 0x1814DD390
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x14DD430 Offset: 0x14DBA30 VA: 0x1814DD430
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x14DD7D0 Offset: 0x14DBDD0 VA: 0x1814DD7D0
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x14DC730 Offset: 0x14DAD30 VA: 0x1814DC730 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DCA90 Offset: 0x14DB090 VA: 0x1814DCA90
	internal static byte FromHexChar(char c) { }

	// RVA: 0x14DCAC0 Offset: 0x14DB0C0 VA: 0x1814DCAC0
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x14DCB40 Offset: 0x14DB140 VA: 0x1814DCB40
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x14DC8B0 Offset: 0x14DAEB0 VA: 0x1814DC8B0
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DCA10 Offset: 0x14DB010 VA: 0x1814DCA10
	internal byte[] Encode() { }

	// RVA: 0x14DCCC0 Offset: 0x14DB2C0 VA: 0x1814DCCC0 Slot: 6
	internal override string ToString(bool multiLine) { }

}

