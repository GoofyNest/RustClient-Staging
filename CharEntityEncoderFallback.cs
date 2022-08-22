internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 1834
{	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x18
	private int[] textContentMarks; // 0x20
	private int endMarkPos; // 0x28
	private int curMarkPos; // 0x2C
	private int startOffset; // 0x30

	// Properties
	public override int MaxCharCount { get; }
	internal int StartOffset { set; }

	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	internal void .ctor() { }

	// RVA: 0x12E3D10 Offset: 0x12E2310 VA: 0x1812E3D10 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0xB9F620 Offset: 0xB9DC20 VA: 0x180B9F620 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	internal void set_StartOffset(int value) { }

	// RVA: 0x12E3DE0 Offset: 0x12E23E0 VA: 0x1812E3DE0
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x12E3CB0 Offset: 0x12E22B0 VA: 0x1812E3CB0
	internal bool CanReplaceAt(int index) { }

}

