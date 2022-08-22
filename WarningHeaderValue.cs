public class WarningHeaderValue : ICloneable // TypeDefIndex: 5811
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Agent>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Code>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Text>k__BackingField; // 0x38

	// Properties
	public string Agent { get; set; }
	public int Code { get; set; }
	public Nullable<DateTimeOffset> Date { get; set; }
	public string Text { get; set; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Agent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Agent(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Code() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	private void set_Code(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x109C6A0 Offset: 0x109ACA0 VA: 0x18109C6A0
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x109C6C0 Offset: 0x109ACC0 VA: 0x18109C6C0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	private void set_Text(string value) { }

	// RVA: 0x109BE20 Offset: 0x109A420 VA: 0x18109BE20
	private static bool IsCodeValid(int code) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x109BBE0 Offset: 0x109A1E0 VA: 0x18109BBE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x109BD40 Offset: 0x109A340 VA: 0x18109BD40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x109C610 Offset: 0x109AC10 VA: 0x18109C610
	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) { }

	// RVA: 0x109C160 Offset: 0x109A760 VA: 0x18109C160
	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

	// RVA: 0x109BE40 Offset: 0x109A440 VA: 0x18109BE40 Slot: 3
	public override string ToString() { }

}

