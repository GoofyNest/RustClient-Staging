public class AsnEncodedData // TypeDefIndex: 2797
{	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x117A2F0 Offset: 0x11788F0 VA: 0x18117A2F0
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x117A440 Offset: 0x1178A40 VA: 0x18117A440
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Oid get_Oid() { }

	// RVA: 0x117A520 Offset: 0x1178B20 VA: 0x18117A520
	public void set_Oid(Oid value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public byte[] get_RawData() { }

	// RVA: 0x117A5E0 Offset: 0x1178BE0 VA: 0x18117A5E0
	public void set_RawData(byte[] value) { }

	// RVA: 0x1179640 Offset: 0x1177C40 VA: 0x181179640 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x11799E0 Offset: 0x1177FE0 VA: 0x1811799E0 Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x117A160 Offset: 0x1178760 VA: 0x18117A160 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x1179810 Offset: 0x1177E10 VA: 0x181179810
	internal string Default(bool multiLine) { }

	// RVA: 0x11794F0 Offset: 0x1177AF0 VA: 0x1811794F0
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x1179930 Offset: 0x1177F30 VA: 0x181179930
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x1179A70 Offset: 0x1178070 VA: 0x181179A70
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x117A0B0 Offset: 0x11786B0 VA: 0x18117A0B0
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x1179E40 Offset: 0x1178440 VA: 0x181179E40
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x1179B20 Offset: 0x1178120 VA: 0x181179B20
	internal string NetscapeCertType(bool multiLine) { }

}

