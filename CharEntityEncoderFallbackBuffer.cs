internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 1835
{	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	public override int Remaining { get; }


	internal void .ctor(CharEntityEncoderFallback parent) { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

	public override int get_Remaining() { }

	public override void Reset() { }

	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }

}

