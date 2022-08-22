public class NameValueHeaderValue : ICloneable // TypeDefIndex: 5787
{	// Fields
	internal string value; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1093500 Offset: 0x1091B00 VA: 0x181093500
	public void .ctor(string name, string value) { }

	// RVA: 0x1093560 Offset: 0x1091B60 VA: 0x181093560
	protected internal void .ctor(NameValueHeaderValue source) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Name(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Value() { }

	// RVA: 0x10935B0 Offset: 0x1091BB0 VA: 0x1810935B0
	public void set_Value(string value) { }

	// RVA: 0x1092C50 Offset: 0x1091250 VA: 0x181092C50
	internal static NameValueHeaderValue Create(string name, string value) { }

	// RVA: 0x1092DD0 Offset: 0x10913D0 VA: 0x181092DD0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10843B0 Offset: 0x10829B0 VA: 0x1810843B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1092CE0 Offset: 0x10912E0 VA: 0x181092CE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1093470 Offset: 0x1091A70 VA: 0x181093470
	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	// RVA: 0x1093120 Offset: 0x1091720 VA: 0x181093120
	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	// RVA: 0x1092E50 Offset: 0x1091450 VA: 0x181092E50 Slot: 3
	public override string ToString() { }

	// RVA: 0x1092EB0 Offset: 0x10914B0 VA: 0x181092EB0
	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }

}

