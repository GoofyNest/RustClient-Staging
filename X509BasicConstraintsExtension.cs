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

	// RVA: 0x1195930 Offset: 0x1193F30 VA: 0x181195930
	public void .ctor() { }

	// RVA: 0x1195CC0 Offset: 0x11942C0 VA: 0x181195CC0
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x11959E0 Offset: 0x1193FE0 VA: 0x1811959E0
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x1195DB0 Offset: 0x11943B0 VA: 0x181195DB0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1195E20 Offset: 0x1194420 VA: 0x181195E20
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x1195E90 Offset: 0x1194490 VA: 0x181195E90
	public int get_PathLengthConstraint() { }

	// RVA: 0x1195260 Offset: 0x1193860 VA: 0x181195260 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1195450 Offset: 0x1193A50 VA: 0x181195450
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x11955E0 Offset: 0x1193BE0 VA: 0x1811955E0
	internal byte[] Encode() { }

	// RVA: 0x1195740 Offset: 0x1193D40 VA: 0x181195740 Slot: 6
	internal override string ToString(bool multiLine) { }

}

