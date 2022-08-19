internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 434
{	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20
	internal char cReplacement; // 0x28

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191BD70 Offset: 0x191A370 VA: 0x18191BD70
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191BC30 Offset: 0x191A230 VA: 0x18191BC30 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191BC90 Offset: 0x191A290 VA: 0x18191BC90 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191BD40 Offset: 0x191A340 VA: 0x18191BD40 Slot: 2
	public override int GetHashCode() { }

}

