internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 1835
{	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x12E3940 Offset: 0x12E1F40 VA: 0x1812E3940
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x12E3640 Offset: 0x12E1C40 VA: 0x1812E3640 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x12E3340 Offset: 0x12E1940 VA: 0x1812E3340 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x12E38B0 Offset: 0x12E1EB0 VA: 0x1812E38B0 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x12E3900 Offset: 0x12E1F00 VA: 0x1812E3900 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x12E39C0 Offset: 0x12E1FC0 VA: 0x1812E39C0 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x12E3920 Offset: 0x12E1F20 VA: 0x1812E3920 Slot: 9
	public override void Reset() { }

	// RVA: 0x12E3930 Offset: 0x12E1F30 VA: 0x1812E3930
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }

}

