public sealed class DecoderReplacementFallback : DecoderFallback // TypeDefIndex: 442
{	// Fields
	private string strDefault; // 0x18

	// Properties
	public string DefaultString { get; }
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x18ACB40 Offset: 0x18AB140 VA: 0x1818ACB40
	public void .ctor() { }

	// RVA: 0x18ACB80 Offset: 0x18AB180 VA: 0x1818ACB80
	public void .ctor(string replacement) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_DefaultString() { }

	// RVA: 0x18ACA30 Offset: 0x18AB030 VA: 0x1818ACA30 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x18ACD30 Offset: 0x18AB330 VA: 0x1818ACD30 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x18ACAB0 Offset: 0x18AB0B0 VA: 0x1818ACAB0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0xAE6200 Offset: 0xAE4800 VA: 0x180AE6200 Slot: 2
	public override int GetHashCode() { }

}

