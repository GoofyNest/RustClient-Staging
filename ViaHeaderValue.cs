public class ViaHeaderValue : ICloneable // TypeDefIndex: 5810
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Comment>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <ProtocolName>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <ProtocolVersion>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <ReceivedBy>k__BackingField; // 0x28

	// Properties
	public string Comment { get; set; }
	public string ProtocolName { get; set; }
	public string ProtocolVersion { get; set; }
	public string ReceivedBy { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_ProtocolName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_ProtocolName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_ProtocolVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_ProtocolVersion(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_ReceivedBy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_ReceivedBy(string value) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x109B070 Offset: 0x1099670 VA: 0x18109B070 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x109B160 Offset: 0x1099760 VA: 0x18109B160 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x109B890 Offset: 0x1099E90 VA: 0x18109B890
	internal static bool TryParse(string input, int minimalCount, out List<ViaHeaderValue> result) { }

	// RVA: 0x109B4E0 Offset: 0x1099AE0 VA: 0x18109B4E0
	private static bool TryParseElement(Lexer lexer, out ViaHeaderValue parsedValue, out Token t) { }

	// RVA: 0x109B260 Offset: 0x1099860 VA: 0x18109B260 Slot: 3
	public override string ToString() { }

}

