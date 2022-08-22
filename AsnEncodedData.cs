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

	// RVA: 0x117EED0 Offset: 0x117D4D0 VA: 0x18117EED0
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x117F020 Offset: 0x117D620 VA: 0x18117F020
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Oid get_Oid() { }

	// RVA: 0x117F100 Offset: 0x117D700 VA: 0x18117F100
	public void set_Oid(Oid value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public byte[] get_RawData() { }

	// RVA: 0x117F1C0 Offset: 0x117D7C0 VA: 0x18117F1C0
	public void set_RawData(byte[] value) { }

	// RVA: 0x117E220 Offset: 0x117C820 VA: 0x18117E220 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x117E5C0 Offset: 0x117CBC0 VA: 0x18117E5C0 Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x117ED40 Offset: 0x117D340 VA: 0x18117ED40 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x117E3F0 Offset: 0x117C9F0 VA: 0x18117E3F0
	internal string Default(bool multiLine) { }

	// RVA: 0x117E0D0 Offset: 0x117C6D0 VA: 0x18117E0D0
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x117E510 Offset: 0x117CB10 VA: 0x18117E510
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x117E650 Offset: 0x117CC50 VA: 0x18117E650
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x117EC90 Offset: 0x117D290 VA: 0x18117EC90
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x117EA20 Offset: 0x117D020 VA: 0x18117EA20
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x117E700 Offset: 0x117CD00 VA: 0x18117E700
	internal string NetscapeCertType(bool multiLine) { }

}

