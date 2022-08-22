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

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	internal void .ctor() { }

	// RVA: 0x12EA1C0 Offset: 0x12E87C0 VA: 0x1812EA1C0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0xB9FAF0 Offset: 0xB9E0F0 VA: 0x180B9FAF0 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	internal void set_StartOffset(int value) { }

	// RVA: 0x12EA290 Offset: 0x12E8890 VA: 0x1812EA290
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x12EA160 Offset: 0x12E8760 VA: 0x1812EA160
	internal bool CanReplaceAt(int index) { }

}

