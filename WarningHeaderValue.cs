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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Agent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Agent(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Code() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	private void set_Code(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x109D110 Offset: 0x109B710 VA: 0x18109D110
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x109D130 Offset: 0x109B730 VA: 0x18109D130
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	private void set_Text(string value) { }

	// RVA: 0x109C890 Offset: 0x109AE90 VA: 0x18109C890
	private static bool IsCodeValid(int code) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x109C650 Offset: 0x109AC50 VA: 0x18109C650 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x109C7B0 Offset: 0x109ADB0 VA: 0x18109C7B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x109D080 Offset: 0x109B680 VA: 0x18109D080
	internal static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result) { }

	// RVA: 0x109CBD0 Offset: 0x109B1D0 VA: 0x18109CBD0
	private static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t) { }

	// RVA: 0x109C8B0 Offset: 0x109AEB0 VA: 0x18109C8B0 Slot: 3
	public override string ToString() { }

}

