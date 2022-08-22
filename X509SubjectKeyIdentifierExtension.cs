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

	// RVA: 0x14DC740 Offset: 0x14DAD40 VA: 0x1814DC740
	public void .ctor() { }

	// RVA: 0x14DC3E0 Offset: 0x14DA9E0 VA: 0x1814DC3E0
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DC270 Offset: 0x14DA870 VA: 0x1814DC270
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DC4B0 Offset: 0x14DAAB0 VA: 0x1814DC4B0
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x14DC720 Offset: 0x14DAD20 VA: 0x1814DC720
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x14DC7C0 Offset: 0x14DADC0 VA: 0x1814DC7C0
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x14DCB60 Offset: 0x14DB160 VA: 0x1814DCB60
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x14DBAC0 Offset: 0x14DA0C0 VA: 0x1814DBAC0 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DBE20 Offset: 0x14DA420 VA: 0x1814DBE20
	internal static byte FromHexChar(char c) { }

	// RVA: 0x14DBE50 Offset: 0x14DA450 VA: 0x1814DBE50
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x14DBED0 Offset: 0x14DA4D0 VA: 0x1814DBED0
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x14DBC40 Offset: 0x14DA240 VA: 0x1814DBC40
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x14DBDA0 Offset: 0x14DA3A0 VA: 0x1814DBDA0
	internal byte[] Encode() { }

	// RVA: 0x14DC050 Offset: 0x14DA650 VA: 0x1814DC050 Slot: 6
	internal override string ToString(bool multiLine) { }

}

