public class RectOffset // TypeDefIndex: 3378
{	[VisibleToOtherModulesAttribute] // RVA: 0x7FCE0 Offset: 0x7F0E0 VA: 0x18007FCE0
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

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


	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FEE0 Offset: 0x7F2E0 VA: 0x18007FEE0
	internal void .ctor(object sourceStyle, IntPtr source) { }

	protected override void Finalize() { }

	public override string ToString() { }

	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void InternalDestroy(IntPtr ptr) { }

	public int get_left() { }

	public void set_left(int value) { }

	public int get_right() { }

	public void set_right(int value) { }

	public int get_top() { }

	public int get_bottom() { }

	public int get_horizontal() { }

	public int get_vertical() { }

	public Rect Add(Rect rect) { }

	public Rect Remove(Rect rect) { }

	private void Add_Injected(ref Rect rect, out Rect ret) { }

	private void Remove_Injected(ref Rect rect, out Rect ret) { }

}

