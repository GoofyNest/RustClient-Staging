public class NameValueHeaderValue : ICloneable // TypeDefIndex: 5787
{	// Fields
	internal string value; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x10937C0 Offset: 0x1091DC0 VA: 0x1810937C0
	public void .ctor(string name, string value) { }

	// RVA: 0x1093820 Offset: 0x1091E20 VA: 0x181093820
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

	// RVA: 0x1093870 Offset: 0x1091E70 VA: 0x181093870
	public void set_Value(string value) { }

	// RVA: 0x1092F10 Offset: 0x1091510 VA: 0x181092F10
	internal static NameValueHeaderValue Create(string name, string value) { }

	// RVA: 0x1093090 Offset: 0x1091690 VA: 0x181093090 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1084670 Offset: 0x1082C70 VA: 0x181084670 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1092FA0 Offset: 0x10915A0 VA: 0x181092FA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1093730 Offset: 0x1091D30 VA: 0x181093730
	internal static bool TryParsePragma(string input, int minimalCount, out List<NameValueHeaderValue> result) { }

	// RVA: 0x10933E0 Offset: 0x10919E0 VA: 0x1810933E0
	internal static bool TryParseParameters(Lexer lexer, out List<NameValueHeaderValue> result, out Token t) { }

	// RVA: 0x1093110 Offset: 0x1091710 VA: 0x181093110 Slot: 3
	public override string ToString() { }

	// RVA: 0x1093170 Offset: 0x1091770 VA: 0x181093170
	private static bool TryParseElement(Lexer lexer, out NameValueHeaderValue parsedValue, out Token t) { }

}

