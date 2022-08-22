internal class X509Extension // TypeDefIndex: 61
{	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Methods

	// RVA: 0x15694A0 Offset: 0x1567AA0 VA: 0x1815694A0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x1569010 Offset: 0x1567610 VA: 0x181569010 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1569280 Offset: 0x1567880 VA: 0x181569280
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x1569160 Offset: 0x1567760 VA: 0x181569160 Slot: 3
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

	// RVA: 0x2281EA0 Offset: 0x22804A0 VA: 0x182281EA0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2281D40 Offset: 0x2280340 VA: 0x182281D40
	public void .ctor(X509Extension extension) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Oid() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_Critical() { }

	// RVA: 0x2282150 Offset: 0x2280750 VA: 0x182282150
	public ASN1 get_Value() { }

	// RVA: 0x22818D0 Offset: 0x227FED0 VA: 0x1822818D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xDE2260 Offset: 0xDE0860 VA: 0x180DE2260 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2281B40 Offset: 0x2280140 VA: 0x182281B40
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x2281A20 Offset: 0x2280020 VA: 0x182281A20 Slot: 3
	public override string ToString() { }

}

public class X509Extension : AsnEncodedData // TypeDefIndex: 2831
{	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	protected void .ctor() { }

	// RVA: 0x14DB350 Offset: 0x14D9950 VA: 0x1814DB350
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_Critical() { }

	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	public void set_Critical(bool value) { }

	// RVA: 0x14DB150 Offset: 0x14D9750 VA: 0x1814DB150 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x14DB260 Offset: 0x14D9860 VA: 0x1814DB260
	internal string FormatUnkownData(byte[] data) { }

}

