internal class ListMap : ObjectMap // TypeDefIndex: 2129
{	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ChoiceMember(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1101140 Offset: 0x10FF740 VA: 0x181101140
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x1101770 Offset: 0x10FFD70 VA: 0x181101770
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x1101970 Offset: 0x10FFF70 VA: 0x181101970
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x1101B50 Offset: 0x1100150 VA: 0x181101B50
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x1100FC0 Offset: 0x10FF5C0 VA: 0x181100FC0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

