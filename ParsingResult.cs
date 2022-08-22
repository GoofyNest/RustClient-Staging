internal sealed class ParsingResult // TypeDefIndex: 7630
{	// Fields
	public static readonly ParsingResult Parsed; // 0x0
	public static readonly ParsingResult EmptyInputString; // 0x8
	public static readonly ParsingResult NotMatched; // 0x10
	private readonly string _error; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ParsingStatus <Status>k__BackingField; // 0x18

	// Methods

	// RVA: 0x13A39C0 Offset: 0x13A1FC0 VA: 0x1813A39C0
	private void .ctor(string error) { }

	// RVA: 0x13A3A40 Offset: 0x13A2040 VA: 0x1813A3A40
	private void .ctor(ParsingStatus status) { }

	// RVA: 0x13A3A00 Offset: 0x13A2000 VA: 0x1813A3A00
	private void .ctor(ParsingStatus status, string error) { }

	// RVA: 0x13A3840 Offset: 0x13A1E40 VA: 0x1813A3840
	public static ParsingResult Error(string error) { }

	// RVA: 0x13A38B0 Offset: 0x13A1EB0 VA: 0x1813A38B0
	private static void .cctor() { }

}

