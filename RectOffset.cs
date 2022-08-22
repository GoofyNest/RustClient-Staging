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

	// RVA: 0x19991C0 Offset: 0x19977C0 VA: 0x1819991C0
	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x7FEE0 Offset: 0x7F2E0 VA: 0x18007FEE0
	// RVA: 0x1999170 Offset: 0x1997770 VA: 0x181999170
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x1998C90 Offset: 0x1997290 VA: 0x181998C90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1998EB0 Offset: 0x19974B0 VA: 0x181998EB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1998C10 Offset: 0x1997210 VA: 0x181998C10
	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1998D80 Offset: 0x1997380 VA: 0x181998D80
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1998DB0 Offset: 0x19973B0 VA: 0x181998DB0
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x1999280 Offset: 0x1997880 VA: 0x181999280
	public int get_left() { }

	// RVA: 0x1999380 Offset: 0x1997980 VA: 0x181999380
	public void set_left(int value) { }

	// RVA: 0x19992C0 Offset: 0x19978C0 VA: 0x1819992C0
	public int get_right() { }

	// RVA: 0x19993C0 Offset: 0x19979C0 VA: 0x1819993C0
	public void set_right(int value) { }

	// RVA: 0x1999300 Offset: 0x1997900 VA: 0x181999300
	public int get_top() { }

	// RVA: 0x1999200 Offset: 0x1997800 VA: 0x181999200
	public int get_bottom() { }

	// RVA: 0x1999240 Offset: 0x1997840 VA: 0x181999240
	public int get_horizontal() { }

	// RVA: 0x1999340 Offset: 0x1997940 VA: 0x181999340
	public int get_vertical() { }

	// RVA: 0x1998BB0 Offset: 0x19971B0 VA: 0x181998BB0
	public Rect Add(Rect rect) { }

	// RVA: 0x1998E50 Offset: 0x1997450 VA: 0x181998E50
	public Rect Remove(Rect rect) { }

	// RVA: 0x1998B50 Offset: 0x1997150 VA: 0x181998B50
	private void Add_Injected(ref Rect rect, out Rect ret) { }

	// RVA: 0x1998DF0 Offset: 0x19973F0 VA: 0x181998DF0
	private void Remove_Injected(ref Rect rect, out Rect ret) { }

}

