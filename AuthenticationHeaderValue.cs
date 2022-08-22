public class AuthenticationHeaderValue : ICloneable // TypeDefIndex: 5758
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Parameter>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Scheme>k__BackingField; // 0x18

	// Properties
	public string Parameter { get; set; }
	public string Scheme { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Parameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Parameter(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Scheme() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Scheme(string value) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1085020 Offset: 0x1083620 VA: 0x181085020 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10850E0 Offset: 0x10836E0 VA: 0x1810850E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1085410 Offset: 0x1083A10 VA: 0x181085410
	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	// RVA: 0x1085380 Offset: 0x1083980 VA: 0x181085380
	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) { }

	// RVA: 0x10851C0 Offset: 0x10837C0 VA: 0x1810851C0
	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1085170 Offset: 0x1083770 VA: 0x181085170 Slot: 3
	public override string ToString() { }

}

