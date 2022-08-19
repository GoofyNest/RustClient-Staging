public class RectOffset // TypeDefIndex: 3378
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x7FC20 Offset: 0x7F020 VA: 0x18007FC20
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x800F0 Offset: 0x7F4F0 VA: 0x1800800F0
	public int left { get; set; }
	[NativePropertyAttribute] // RVA: 0x80250 Offset: 0x7F650 VA: 0x180080250
	public int right { get; set; }
	[NativePropertyAttribute] // RVA: 0x80570 Offset: 0x7F970 VA: 0x180080570
	public int top { get; }
	[NativePropertyAttribute] // RVA: 0x805B0 Offset: 0x7F9B0 VA: 0x1800805B0
	public int bottom { get; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x19ABB40 Offset: 0x19AA140 VA: 0x1819ABB40
	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FE20 Offset: 0x7F220 VA: 0x18007FE20
	// RVA: 0x19ABAF0 Offset: 0x19AA0F0 VA: 0x1819ABAF0
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x19AB610 Offset: 0x19A9C10 VA: 0x1819AB610 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19AB830 Offset: 0x19A9E30 VA: 0x1819AB830 Slot: 3
	public override string ToString() { }

	// RVA: 0x19AB590 Offset: 0x19A9B90 VA: 0x1819AB590
	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19AB700 Offset: 0x19A9D00 VA: 0x1819AB700
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19AB730 Offset: 0x19A9D30 VA: 0x1819AB730
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x19ABC00 Offset: 0x19AA200 VA: 0x1819ABC00
	public int get_left() { }

	// RVA: 0x19ABD00 Offset: 0x19AA300 VA: 0x1819ABD00
	public void set_left(int value) { }

	// RVA: 0x19ABC40 Offset: 0x19AA240 VA: 0x1819ABC40
	public int get_right() { }

	// RVA: 0x19ABD40 Offset: 0x19AA340 VA: 0x1819ABD40
	public void set_right(int value) { }

	// RVA: 0x19ABC80 Offset: 0x19AA280 VA: 0x1819ABC80
	public int get_top() { }

	// RVA: 0x19ABB80 Offset: 0x19AA180 VA: 0x1819ABB80
	public int get_bottom() { }

	// RVA: 0x19ABBC0 Offset: 0x19AA1C0 VA: 0x1819ABBC0
	public int get_horizontal() { }

	// RVA: 0x19ABCC0 Offset: 0x19AA2C0 VA: 0x1819ABCC0
	public int get_vertical() { }

	// RVA: 0x19AB530 Offset: 0x19A9B30 VA: 0x1819AB530
	public Rect Add(Rect rect) { }

	// RVA: 0x19AB7D0 Offset: 0x19A9DD0 VA: 0x1819AB7D0
	public Rect Remove(Rect rect) { }

	// RVA: 0x19AB4D0 Offset: 0x19A9AD0 VA: 0x1819AB4D0
	private void Add_Injected(ref Rect rect, out Rect ret) { }

	// RVA: 0x19AB770 Offset: 0x19A9D70 VA: 0x1819AB770
	private void Remove_Injected(ref Rect rect, out Rect ret) { }

}

