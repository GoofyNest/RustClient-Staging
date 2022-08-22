internal sealed class ParsingResult // TypeDefIndex: 7630
{	public static readonly ParsingResult Parsed; // 0x0
	public static readonly ParsingResult EmptyInputString; // 0x8
	public static readonly ParsingResult NotMatched; // 0x10
	private readonly string _error; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ParsingStatus <Status>k__BackingField; // 0x18


	private void .ctor(string error) { }

	private void .ctor(ParsingStatus status) { }

	private void .ctor(ParsingStatus status, string error) { }

	public static ParsingResult Error(string error) { }

	private static void .cctor() { }

}

