internal sealed class ParsingResult // TypeDefIndex: 7630
{	// Fields
	public static readonly ParsingResult Parsed; // 0x0
	public static readonly ParsingResult EmptyInputString; // 0x8
	public static readonly ParsingResult NotMatched; // 0x10
	private readonly string _error; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ParsingStatus <Status>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13A48C0 Offset: 0x13A2EC0 VA: 0x1813A48C0
	private void .ctor(string error) { }

	// RVA: 0x13A4940 Offset: 0x13A2F40 VA: 0x1813A4940
	private void .ctor(ParsingStatus status) { }

	// RVA: 0x13A4900 Offset: 0x13A2F00 VA: 0x1813A4900
	private void .ctor(ParsingStatus status, string error) { }

	// RVA: 0x13A4740 Offset: 0x13A2D40 VA: 0x1813A4740
	public static ParsingResult Error(string error) { }

	// RVA: 0x13A47B0 Offset: 0x13A2DB0 VA: 0x1813A47B0
	private static void .cctor() { }

}

