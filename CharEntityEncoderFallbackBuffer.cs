internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 1835
{	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x12E3C00 Offset: 0x12E2200 VA: 0x1812E3C00
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x12E3900 Offset: 0x12E1F00 VA: 0x1812E3900 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x12E3600 Offset: 0x12E1C00 VA: 0x1812E3600 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x12E3B70 Offset: 0x12E2170 VA: 0x1812E3B70 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x12E3BC0 Offset: 0x12E21C0 VA: 0x1812E3BC0 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x12E3C80 Offset: 0x12E2280 VA: 0x1812E3C80 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x12E3BE0 Offset: 0x12E21E0 VA: 0x1812E3BE0 Slot: 9
	public override void Reset() { }

	// RVA: 0x12E3BF0 Offset: 0x12E21F0 VA: 0x1812E3BF0
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }

}

