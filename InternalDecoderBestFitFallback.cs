internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 434
{	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20
	internal char cReplacement; // 0x28

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191BFF0 Offset: 0x191A5F0 VA: 0x18191BFF0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191BEB0 Offset: 0x191A4B0 VA: 0x18191BEB0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191BF10 Offset: 0x191A510 VA: 0x18191BF10 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191BFC0 Offset: 0x191A5C0 VA: 0x18191BFC0 Slot: 2
	public override int GetHashCode() { }

}

