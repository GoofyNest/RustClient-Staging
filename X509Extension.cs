internal class X509Extension // TypeDefIndex: 61
{	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Methods

	// RVA: 0x1568570 Offset: 0x1566B70 VA: 0x181568570
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x15680E0 Offset: 0x15666E0 VA: 0x1815680E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2D10 Offset: 0xDE1310 VA: 0x180DE2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1568350 Offset: 0x1566950 VA: 0x181568350
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x1568230 Offset: 0x1566830 VA: 0x181568230 Slot: 3
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

	// RVA: 0x22826C0 Offset: 0x2280CC0 VA: 0x1822826C0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2282560 Offset: 0x2280B60 VA: 0x182282560
	public void .ctor(X509Extension extension) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Oid() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_Critical() { }

	// RVA: 0x2282970 Offset: 0x2280F70 VA: 0x182282970
	public ASN1 get_Value() { }

	// RVA: 0x22820F0 Offset: 0x22806F0 VA: 0x1822820F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2D10 Offset: 0xDE1310 VA: 0x180DE2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2282360 Offset: 0x2280960 VA: 0x182282360
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x2282240 Offset: 0x2280840 VA: 0x182282240 Slot: 3
	public override string ToString() { }

}

public class X509Extension : AsnEncodedData // TypeDefIndex: 2831
{	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

	// RVA: 0x14DA420 Offset: 0x14D8A20 VA: 0x1814DA420
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_Critical() { }

	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	public void set_Critical(bool value) { }

	// RVA: 0x14DA220 Offset: 0x14D8820 VA: 0x1814DA220 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DA330 Offset: 0x14D8930 VA: 0x1814DA330
	internal string FormatUnkownData(byte[] data) { }

}

