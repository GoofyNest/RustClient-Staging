public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 2813
{	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x28
	private bool _hasPathLengthConstraint; // 0x29
	private int _pathLengthConstraint; // 0x2C
	private AsnDecodeStatus _status; // 0x30

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1190D50 Offset: 0x118F350 VA: 0x181190D50
	public void .ctor() { }

	// RVA: 0x11910E0 Offset: 0x118F6E0 VA: 0x1811910E0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1190E00 Offset: 0x118F400 VA: 0x181190E00
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x11911D0 Offset: 0x118F7D0 VA: 0x1811911D0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1191240 Offset: 0x118F840 VA: 0x181191240
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x11912B0 Offset: 0x118F8B0 VA: 0x1811912B0
	public int get_PathLengthConstraint() { }

	// RVA: 0x1190680 Offset: 0x118EC80 VA: 0x181190680 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1190870 Offset: 0x118EE70 VA: 0x181190870
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1190A00 Offset: 0x118F000 VA: 0x181190A00
	internal byte[] Encode() { }

	// RVA: 0x1190B60 Offset: 0x118F160 VA: 0x181190B60 Slot: 6
	internal override string ToString(bool multiLine) { }

}

