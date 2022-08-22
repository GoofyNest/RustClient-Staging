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

	// RVA: 0x117A5B0 Offset: 0x1178BB0 VA: 0x18117A5B0
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x117A700 Offset: 0x1178D00 VA: 0x18117A700
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Oid get_Oid() { }

	// RVA: 0x117A7E0 Offset: 0x1178DE0 VA: 0x18117A7E0
	public void set_Oid(Oid value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public byte[] get_RawData() { }

	// RVA: 0x117A8A0 Offset: 0x1178EA0 VA: 0x18117A8A0
	public void set_RawData(byte[] value) { }

	// RVA: 0x1179900 Offset: 0x1177F00 VA: 0x181179900 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1179CA0 Offset: 0x11782A0 VA: 0x181179CA0 Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x117A420 Offset: 0x1178A20 VA: 0x18117A420 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x1179AD0 Offset: 0x11780D0 VA: 0x181179AD0
	internal string Default(bool multiLine) { }

	// RVA: 0x11797B0 Offset: 0x1177DB0 VA: 0x1811797B0
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x1179BF0 Offset: 0x11781F0 VA: 0x181179BF0
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x1179D30 Offset: 0x1178330 VA: 0x181179D30
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x117A370 Offset: 0x1178970 VA: 0x18117A370
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x117A100 Offset: 0x1178700 VA: 0x18117A100
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x1179DE0 Offset: 0x11783E0 VA: 0x181179DE0
	internal string NetscapeCertType(bool multiLine) { }

}

