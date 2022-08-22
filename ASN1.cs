internal class ASN1 // TypeDefIndex: 45
{	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1626D70 Offset: 0x1625370 VA: 0x181626D70
	public void .ctor(byte tag) { }

	// RVA: 0x1626D30 Offset: 0x1625330 VA: 0x181626D30
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1626B90 Offset: 0x1625190 VA: 0x181626B90
	public void .ctor(byte[] data) { }

	// RVA: 0x1626DB0 Offset: 0x16253B0 VA: 0x181626DB0
	public int get_Count() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public byte get_Tag() { }

	// RVA: 0x1626EB0 Offset: 0x16254B0 VA: 0x181626EB0
	public int get_Length() { }

	// RVA: 0x1626EC0 Offset: 0x16254C0 VA: 0x181626EC0
	public byte[] get_Value() { }

	// RVA: 0x1626F60 Offset: 0x1625560 VA: 0x181626F60
	public void set_Value(byte[] value) { }

	// RVA: 0x1625C30 Offset: 0x1624230 VA: 0x181625C30
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1625CD0 Offset: 0x16242D0 VA: 0x181625CD0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1625B90 Offset: 0x1624190 VA: 0x181625B90
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x16261D0 Offset: 0x16247D0 VA: 0x1816261D0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1625EB0 Offset: 0x16244B0 VA: 0x181625EB0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1625D60 Offset: 0x1624360 VA: 0x181625D60
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1626DD0 Offset: 0x16253D0 VA: 0x181626DD0
	public ASN1 get_Item(int index) { }

	// RVA: 0x16260C0 Offset: 0x16246C0 VA: 0x1816260C0
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x16268C0 Offset: 0x1624EC0 VA: 0x1816268C0 Slot: 3
	public override string ToString() { }

}

public class ASN1 // TypeDefIndex: 1704
{	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1626D70 Offset: 0x1625370 VA: 0x181626D70
	public void .ctor(byte tag) { }

	// RVA: 0x1626D30 Offset: 0x1625330 VA: 0x181626D30
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1AAEDE0 Offset: 0x1AAD3E0 VA: 0x181AAEDE0
	public void .ctor(byte[] data) { }

	// RVA: 0x1626DB0 Offset: 0x16253B0 VA: 0x181626DB0
	public int get_Count() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public byte get_Tag() { }

	// RVA: 0x1626EB0 Offset: 0x16254B0 VA: 0x181626EB0
	public int get_Length() { }

	// RVA: 0x1AAF060 Offset: 0x1AAD660 VA: 0x181AAF060
	public byte[] get_Value() { }

	// RVA: 0x1AAF100 Offset: 0x1AAD700 VA: 0x181AAF100
	public void set_Value(byte[] value) { }

	// RVA: 0x1625C30 Offset: 0x1624230 VA: 0x181625C30
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1625CD0 Offset: 0x16242D0 VA: 0x181625CD0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1AADF10 Offset: 0x1AAC510 VA: 0x181AADF10
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1AAE420 Offset: 0x1AACA20 VA: 0x181AAE420 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1AAE100 Offset: 0x1AAC700 VA: 0x181AAE100
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1AADFB0 Offset: 0x1AAC5B0 VA: 0x181AADFB0
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1AAEF80 Offset: 0x1AAD580 VA: 0x181AAEF80
	public ASN1 get_Item(int index) { }

	// RVA: 0x1AAE310 Offset: 0x1AAC910 VA: 0x181AAE310
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1AAEB10 Offset: 0x1AAD110 VA: 0x181AAEB10 Slot: 3
	public override string ToString() { }

}

