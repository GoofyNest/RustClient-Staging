public class StringWithQualityHeaderValue : ICloneable // TypeDefIndex: 5807
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<double> <Quality>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Value>k__BackingField; // 0x20

	// Properties
	public Nullable<double> Quality { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFE6AE0 Offset: 0xFE50E0 VA: 0x180FE6AE0
	public Nullable<double> get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10972D0 Offset: 0x10958D0 VA: 0x1810972D0
	private void set_Quality(Nullable<double> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Value(string value) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1097A30 Offset: 0x1096030 VA: 0x181097A30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1097B10 Offset: 0x1096110 VA: 0x181097B10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1098030 Offset: 0x1096630 VA: 0x181098030
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	// RVA: 0x1097C70 Offset: 0x1096270 VA: 0x181097C70
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1097BA0 Offset: 0x10961A0 VA: 0x181097BA0 Slot: 3
	public override string ToString() { }

}

