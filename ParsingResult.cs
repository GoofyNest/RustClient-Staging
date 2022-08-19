internal sealed class ParsingResult // TypeDefIndex: 7630
{	// Fields
	public static readonly ParsingResult Parsed; // 0x0
	public static readonly ParsingResult EmptyInputString; // 0x8
	public static readonly ParsingResult NotMatched; // 0x10
	private readonly string _error; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly ParsingStatus <Status>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13A4600 Offset: 0x13A2C00 VA: 0x1813A4600
	private void .ctor(string error) { }

	// RVA: 0x13A4680 Offset: 0x13A2C80 VA: 0x1813A4680
	private void .ctor(ParsingStatus status) { }

	// RVA: 0x13A4640 Offset: 0x13A2C40 VA: 0x1813A4640
	private void .ctor(ParsingStatus status, string error) { }

	// RVA: 0x13A4480 Offset: 0x13A2A80 VA: 0x1813A4480
	public static ParsingResult Error(string error) { }

	// RVA: 0x13A44F0 Offset: 0x13A2AF0 VA: 0x1813A44F0
	private static void .cctor() { }

}

