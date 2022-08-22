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

	// RVA: 0x19ABDC0 Offset: 0x19AA3C0 VA: 0x1819ABDC0
	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FEE0 Offset: 0x7F2E0 VA: 0x18007FEE0
	// RVA: 0x19ABD70 Offset: 0x19AA370 VA: 0x1819ABD70
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x19AB890 Offset: 0x19A9E90 VA: 0x1819AB890 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19ABAB0 Offset: 0x19AA0B0 VA: 0x1819ABAB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19AB810 Offset: 0x19A9E10 VA: 0x1819AB810
	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AB980 Offset: 0x19A9F80 VA: 0x1819AB980
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AB9B0 Offset: 0x19A9FB0 VA: 0x1819AB9B0
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x19ABE80 Offset: 0x19AA480 VA: 0x1819ABE80
	public int get_left() { }

	// RVA: 0x19ABF80 Offset: 0x19AA580 VA: 0x1819ABF80
	public void set_left(int value) { }

	// RVA: 0x19ABEC0 Offset: 0x19AA4C0 VA: 0x1819ABEC0
	public int get_right() { }

	// RVA: 0x19ABFC0 Offset: 0x19AA5C0 VA: 0x1819ABFC0
	public void set_right(int value) { }

	// RVA: 0x19ABF00 Offset: 0x19AA500 VA: 0x1819ABF00
	public int get_top() { }

	// RVA: 0x19ABE00 Offset: 0x19AA400 VA: 0x1819ABE00
	public int get_bottom() { }

	// RVA: 0x19ABE40 Offset: 0x19AA440 VA: 0x1819ABE40
	public int get_horizontal() { }

	// RVA: 0x19ABF40 Offset: 0x19AA540 VA: 0x1819ABF40
	public int get_vertical() { }

	// RVA: 0x19AB7B0 Offset: 0x19A9DB0 VA: 0x1819AB7B0
	public Rect Add(Rect rect) { }

	// RVA: 0x19ABA50 Offset: 0x19AA050 VA: 0x1819ABA50
	public Rect Remove(Rect rect) { }

	// RVA: 0x19AB750 Offset: 0x19A9D50 VA: 0x1819AB750
	private void Add_Injected(ref Rect rect, out Rect ret) { }

	// RVA: 0x19AB9F0 Offset: 0x19A9FF0 VA: 0x1819AB9F0
	private void Remove_Injected(ref Rect rect, out Rect ret) { }

}

