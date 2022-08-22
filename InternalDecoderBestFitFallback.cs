internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 434
{	// Fields
	internal Encoding encoding; // 0x18
	internal char[] arrayBestFit; // 0x20
	internal char cReplacement; // 0x28

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x191BD30 Offset: 0x191A330 VA: 0x18191BD30
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x191BBF0 Offset: 0x191A1F0 VA: 0x18191BBF0 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x191BC50 Offset: 0x191A250 VA: 0x18191BC50 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x191BD00 Offset: 0x191A300 VA: 0x18191BD00 Slot: 2
	public override int GetHashCode() { }

}

