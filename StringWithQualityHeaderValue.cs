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
	// RVA: 0xFE5D80 Offset: 0xFE4380 VA: 0x180FE5D80
	public Nullable<double> get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x10965A0 Offset: 0x1094BA0 VA: 0x1810965A0
	private void set_Quality(Nullable<double> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Value(string value) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1096D00 Offset: 0x1095300 VA: 0x181096D00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1096DE0 Offset: 0x10953E0 VA: 0x181096DE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1097300 Offset: 0x1095900 VA: 0x181097300
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	// RVA: 0x1096F40 Offset: 0x1095540 VA: 0x181096F40
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1096E70 Offset: 0x1095470 VA: 0x181096E70 Slot: 3
	public override string ToString() { }

}

