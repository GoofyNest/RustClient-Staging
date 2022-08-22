internal struct ResourceLocator // TypeDefIndex: 494
{	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x14C6B0 Offset: 0x14BAB0 VA: 0x18014C6B0
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	internal int get_DataPosition() { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	internal object get_Value() { }

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	internal void set_Value(object value) { }

	// RVA: 0xFED370 Offset: 0xFEB970 VA: 0x180FED370
	internal static bool CanCache(ResourceTypeCode value) { }

}

