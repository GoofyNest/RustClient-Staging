public class RectOffset // TypeDefIndex: 3378
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x7FCE0 Offset: 0x7F0E0 VA: 0x18007FCE0
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x801B0 Offset: 0x7F5B0 VA: 0x1800801B0
	public int left { get; set; }
	[NativePropertyAttribute] // RVA: 0x805F0 Offset: 0x7F9F0 VA: 0x1800805F0
	public int right { get; set; }
	[NativePropertyAttribute] // RVA: 0x80630 Offset: 0x7FA30 VA: 0x180080630
	public int top { get; }
	[NativePropertyAttribute] // RVA: 0x80670 Offset: 0x7FA70 VA: 0x180080670
	public int bottom { get; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x19ABB00 Offset: 0x19AA100 VA: 0x1819ABB00
	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FEE0 Offset: 0x7F2E0 VA: 0x18007FEE0
	// RVA: 0x19ABAB0 Offset: 0x19AA0B0 VA: 0x1819ABAB0
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x19AB5D0 Offset: 0x19A9BD0 VA: 0x1819AB5D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19AB7F0 Offset: 0x19A9DF0 VA: 0x1819AB7F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19AB550 Offset: 0x19A9B50 VA: 0x1819AB550
	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AB6C0 Offset: 0x19A9CC0 VA: 0x1819AB6C0
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AB6F0 Offset: 0x19A9CF0 VA: 0x1819AB6F0
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x19ABBC0 Offset: 0x19AA1C0 VA: 0x1819ABBC0
	public int get_left() { }

	// RVA: 0x19ABCC0 Offset: 0x19AA2C0 VA: 0x1819ABCC0
	public void set_left(int value) { }

	// RVA: 0x19ABC00 Offset: 0x19AA200 VA: 0x1819ABC00
	public int get_right() { }

	// RVA: 0x19ABD00 Offset: 0x19AA300 VA: 0x1819ABD00
	public void set_right(int value) { }

	// RVA: 0x19ABC40 Offset: 0x19AA240 VA: 0x1819ABC40
	public int get_top() { }

	// RVA: 0x19ABB40 Offset: 0x19AA140 VA: 0x1819ABB40
	public int get_bottom() { }

	// RVA: 0x19ABB80 Offset: 0x19AA180 VA: 0x1819ABB80
	public int get_horizontal() { }

	// RVA: 0x19ABC80 Offset: 0x19AA280 VA: 0x1819ABC80
	public int get_vertical() { }

	// RVA: 0x19AB4F0 Offset: 0x19A9AF0 VA: 0x1819AB4F0
	public Rect Add(Rect rect) { }

	// RVA: 0x19AB790 Offset: 0x19A9D90 VA: 0x1819AB790
	public Rect Remove(Rect rect) { }

	// RVA: 0x19AB490 Offset: 0x19A9A90 VA: 0x1819AB490
	private void Add_Injected(ref Rect rect, out Rect ret) { }

	// RVA: 0x19AB730 Offset: 0x19A9D30 VA: 0x1819AB730
	private void Remove_Injected(ref Rect rect, out Rect ret) { }

}

