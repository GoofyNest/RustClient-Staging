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

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	internal void .ctor() { }

	// RVA: 0x12E3A50 Offset: 0x12E2050 VA: 0x1812E3A50 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0xB9F360 Offset: 0xB9D960 VA: 0x180B9F360 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	internal void set_StartOffset(int value) { }

	// RVA: 0x12E3B20 Offset: 0x12E2120 VA: 0x1812E3B20
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x12E39F0 Offset: 0x12E1FF0 VA: 0x1812E39F0
	internal bool CanReplaceAt(int index) { }

}

