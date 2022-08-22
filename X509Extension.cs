internal class X509Extension // TypeDefIndex: 61
{	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Methods

	// RVA: 0x15691E0 Offset: 0x15677E0 VA: 0x1815691E0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x1568D50 Offset: 0x1567350 VA: 0x181568D50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1568FC0 Offset: 0x15675C0 VA: 0x181568FC0
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x1568EA0 Offset: 0x15674A0 VA: 0x181568EA0 Slot: 3
	public override string ToString() { }

}

public class X509Extension // TypeDefIndex: 1719
{	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x2281BE0 Offset: 0x22801E0 VA: 0x182281BE0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2281A80 Offset: 0x2280080 VA: 0x182281A80
	public void .ctor(X509Extension extension) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Oid() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_Critical() { }

	// RVA: 0x2281E90 Offset: 0x2280490 VA: 0x182281E90
	public ASN1 get_Value() { }

	// RVA: 0x2281610 Offset: 0x227FC10 VA: 0x182281610 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE1FA0 Offset: 0xDE05A0 VA: 0x180DE1FA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2281880 Offset: 0x227FE80 VA: 0x182281880
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x2281760 Offset: 0x227FD60 VA: 0x182281760 Slot: 3
	public override string ToString() { }

}

public class X509Extension : AsnEncodedData // TypeDefIndex: 2831
{	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	protected void .ctor() { }

	// RVA: 0x14DB090 Offset: 0x14D9690 VA: 0x1814DB090
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_Critical() { }

	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	public void set_Critical(bool value) { }

	// RVA: 0x14DAE90 Offset: 0x14D9490 VA: 0x1814DAE90 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DAFA0 Offset: 0x14D95A0 VA: 0x1814DAFA0
	internal string FormatUnkownData(byte[] data) { }

}

