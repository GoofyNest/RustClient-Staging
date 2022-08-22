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
	// RVA: 0xFE6040 Offset: 0xFE4640 VA: 0x180FE6040
	public Nullable<double> get_Quality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1096860 Offset: 0x1094E60 VA: 0x181096860
	private void set_Quality(Nullable<double> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Value(string value) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1096FC0 Offset: 0x10955C0 VA: 0x181096FC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10970A0 Offset: 0x10956A0 VA: 0x1810970A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10975C0 Offset: 0x1095BC0 VA: 0x1810975C0
	internal static bool TryParse(string input, int minimalCount, out List<StringWithQualityHeaderValue> result) { }

	// RVA: 0x1097200 Offset: 0x1095800 VA: 0x181097200
	private static bool TryParseElement(Lexer lexer, out StringWithQualityHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1097130 Offset: 0x1095730 VA: 0x181097130 Slot: 3
	public override string ToString() { }

}

