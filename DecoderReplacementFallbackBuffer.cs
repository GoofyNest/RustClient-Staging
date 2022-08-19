public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 443
{	// Fields
	private string strDefault; // 0x20
	private int fallbackCount; // 0x28
	private int fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x18AD030 Offset: 0x18AB630 VA: 0x1818AD030
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x18ACF70 Offset: 0x18AB570 VA: 0x1818ACF70 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x18ACFC0 Offset: 0x18AB5C0 VA: 0x1818ACFC0 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x18AD080 Offset: 0x18AB680 VA: 0x1818AD080 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x18AD010 Offset: 0x18AB610 VA: 0x1818AD010 Slot: 7
	public override void Reset() { }

	// RVA: 0xD4CE70 Offset: 0xD4B470 VA: 0x180D4CE70 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

