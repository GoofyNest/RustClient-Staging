public class NameValueHeaderValue : ICloneable // TypeDefIndex: 5787
{	// Fields
	internal string value; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1094230 Offset: 0x1092830 VA: 0x181094230
	public void .ctor(string name, string value) { }

	// RVA: 0x1094290 Offset: 0x1092890 VA: 0x181094290
	protected internal void .ctor(NameValueHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Name(string value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Value() { }

	// RVA: 0x10942E0 Offset: 0x10928E0 VA: 0x1810942E0
	public void set_Value(string value) { }

	// RVA: 0x1093980 Offset: 0x1091F80 VA: 0x181093980
	internal static NameValueHeaderValue Create(string name, string value) { }

	// RVA: 0x1093B00 Offset: 0x1092100 VA: 0x181093B00 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10850E0 Offset: 0x10836E0 VA: 0x1810850E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1093A10 Offset: 0x1092010 VA: 0x181093A10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10941A0 Offset: 0x10927A0 VA: 0x1810941A0
	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	// RVA: 0x1093E50 Offset: 0x1092450 VA: 0x181093E50
	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	// RVA: 0x1093B80 Offset: 0x1092180 VA: 0x181093B80 Slot: 3
	public override string ToString() { }

	// RVA: 0x1093BE0 Offset: 0x10921E0 VA: 0x181093BE0
	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }

}

