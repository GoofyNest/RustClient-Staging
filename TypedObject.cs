internal class TypedObject // TypeDefIndex: 2149
{	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public int get_Dim() { }

	// RVA: 0xBA1A80 Offset: 0xBA0080 VA: 0x180BA1A80
	public bool get_IsList() { }

	// RVA: 0xEF1C50 Offset: 0xEF0250 VA: 0x180EF1C50
	public bool get_IsDecimal() { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	public Decimal[] get_Dvalue() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object get_Value() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0xEF1A80 Offset: 0xEF0080 VA: 0x180EF1A80
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 3
	public override string ToString() { }

	// RVA: 0xEF1750 Offset: 0xEEFD50 VA: 0x180EF1750
	public void SetDecimal() { }

	// RVA: 0xEF1610 Offset: 0xEEFC10 VA: 0x180EF1610
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0xEF1280 Offset: 0xEEF880 VA: 0x180EF1280
	public bool Equals(TypedObject other) { }

}

private class TypedObject.DecimalStruct // TypeDefIndex: 2150
{	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Properties
	public bool IsDecimal { get; set; }
	public Decimal[] Dvalue { get; }

	// Methods

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsDecimal() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_IsDecimal(bool value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Decimal[] get_Dvalue() { }

	// RVA: 0xEDA360 Offset: 0xED8960 VA: 0x180EDA360
	public void .ctor() { }

	// RVA: 0xEDA3C0 Offset: 0xED89C0 VA: 0x180EDA3C0
	public void .ctor(int dim) { }

}

