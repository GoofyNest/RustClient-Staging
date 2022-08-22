internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 1835
{	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x12EA0B0 Offset: 0x12E86B0 VA: 0x1812EA0B0
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x12E9DB0 Offset: 0x12E83B0 VA: 0x1812E9DB0 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x12E9AB0 Offset: 0x12E80B0 VA: 0x1812E9AB0 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x12EA020 Offset: 0x12E8620 VA: 0x1812EA020 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x12EA070 Offset: 0x12E8670 VA: 0x1812EA070 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x12EA130 Offset: 0x12E8730 VA: 0x1812EA130 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x12EA090 Offset: 0x12E8690 VA: 0x1812EA090 Slot: 9
	public override void Reset() { }

	// RVA: 0x12EA0A0 Offset: 0x12E86A0 VA: 0x1812EA0A0
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }

}

