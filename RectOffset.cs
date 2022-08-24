public class RectOffset // TypeDefIndex: 3378
{	[VisibleToOtherModulesAttribute] // RVA: 0x7FD40 Offset: 0x7F140 VA: 0x18007FD40
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	[NativePropertyAttribute] // RVA: 0x80120 Offset: 0x7F520 VA: 0x180080120
	public int left { get; set; }
	[NativePropertyAttribute] // RVA: 0x80560 Offset: 0x7F960 VA: 0x180080560
	public int right { get; set; }
	[NativePropertyAttribute] // RVA: 0x805A0 Offset: 0x7F9A0 VA: 0x1800805A0
	public int top { get; }
	[NativePropertyAttribute] // RVA: 0x805E0 Offset: 0x7F9E0 VA: 0x1800805E0
	public int bottom { get; }
	public int horizontal { get; }
	public int vertical { get; }


	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FEA0 Offset: 0x7F2A0 VA: 0x18007FEA0
	internal void .ctor(object sourceStyle, IntPtr source) { }

	protected override void Finalize() { }

	public override string ToString() { }

	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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

