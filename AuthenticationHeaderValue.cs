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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Parameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Parameter(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Scheme() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Scheme(string value) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10845B0 Offset: 0x1082BB0 VA: 0x1810845B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1084670 Offset: 0x1082C70 VA: 0x181084670 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10849A0 Offset: 0x1082FA0 VA: 0x1810849A0
	public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue) { }

	// RVA: 0x1084910 Offset: 0x1082F10 VA: 0x181084910
	internal static bool TryParse(string input, int minimalCount, out List<AuthenticationHeaderValue> result) { }

	// RVA: 0x1084750 Offset: 0x1082D50 VA: 0x181084750
	private static bool TryParseElement(Lexer lexer, out AuthenticationHeaderValue parsedValue, out Token t) { }

	// RVA: 0x1084700 Offset: 0x1082D00 VA: 0x181084700 Slot: 3
	public override string ToString() { }

}

