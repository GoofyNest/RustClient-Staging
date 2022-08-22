public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 443
{	// Fields
	private string strDefault; // 0x20
	private int fallbackCount; // 0x28
	private int fallbackIndex; // 0x2C

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x18AD2B0 Offset: 0x18AB8B0 VA: 0x1818AD2B0
	public void .ctor(DecoderReplacementFallback fallback) { }

	// RVA: 0x18AD1F0 Offset: 0x18AB7F0 VA: 0x1818AD1F0 Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x18AD240 Offset: 0x18AB840 VA: 0x1818AD240 Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x18AD300 Offset: 0x18AB900 VA: 0x1818AD300 Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x18AD290 Offset: 0x18AB890 VA: 0x1818AD290 Slot: 7
	public override void Reset() { }

	// RVA: 0xD4D130 Offset: 0xD4B730 VA: 0x180D4D130 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

}

