internal class ListMap : ObjectMap // TypeDefIndex: 2129
{	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_ChoiceMember(string value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1101BB0 Offset: 0x11001B0 VA: 0x181101BB0
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x11021E0 Offset: 0x11007E0 VA: 0x1811021E0
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x11023E0 Offset: 0x11009E0 VA: 0x1811023E0
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x11025C0 Offset: 0x1100BC0 VA: 0x1811025C0
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x1101A30 Offset: 0x1100030 VA: 0x181101A30 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

