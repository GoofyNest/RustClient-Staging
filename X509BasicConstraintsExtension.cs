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

	// RVA: 0x1191010 Offset: 0x118F610 VA: 0x181191010
	public void .ctor() { }

	// RVA: 0x11913A0 Offset: 0x118F9A0 VA: 0x1811913A0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x11910C0 Offset: 0x118F6C0 VA: 0x1811910C0
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x1191490 Offset: 0x118FA90 VA: 0x181191490
	public bool get_CertificateAuthority() { }

	// RVA: 0x1191500 Offset: 0x118FB00 VA: 0x181191500
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x1191570 Offset: 0x118FB70 VA: 0x181191570
	public int get_PathLengthConstraint() { }

	// RVA: 0x1190940 Offset: 0x118EF40 VA: 0x181190940 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1190B30 Offset: 0x118F130 VA: 0x181190B30
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1190CC0 Offset: 0x118F2C0 VA: 0x181190CC0
	internal byte[] Encode() { }

	// RVA: 0x1190E20 Offset: 0x118F420 VA: 0x181190E20 Slot: 6
	internal override string ToString(bool multiLine) { }

}

