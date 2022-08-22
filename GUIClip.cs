internal sealed class GUIClip // TypeDefIndex: 4033
{	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCB490 Offset: 0xCA890 VA: 0x1800CB490
	// RVA: 0x1A58580 Offset: 0x1A56B80 VA: 0x181A58580
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB5D0 Offset: 0xCA9D0 VA: 0x1800CB5D0
	// RVA: 0x1A58310 Offset: 0x1A56910 VA: 0x181A58310
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB9D0 Offset: 0xCADD0 VA: 0x1800CB9D0
	// RVA: 0x1A581D0 Offset: 0x1A567D0 VA: 0x181A581D0
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	[VisibleToOtherModulesAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	// RVA: 0x1A58170 Offset: 0x1A56770 VA: 0x181A58170
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCBFB0 Offset: 0xCB3B0 VA: 0x1800CBFB0
	// RVA: 0x1A584A0 Offset: 0x1A56AA0 VA: 0x181A584A0
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	[FreeFunctionAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	// RVA: 0x1A58120 Offset: 0x1A56720 VA: 0x181A58120
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC3F0 Offset: 0xCB7F0 VA: 0x1800CC3F0
	// RVA: 0x1A58410 Offset: 0x1A56A10 VA: 0x181A58410
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC630 Offset: 0xCBA30 VA: 0x1800CC630
	// RVA: 0x1A58250 Offset: 0x1A56850 VA: 0x181A58250
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC900 Offset: 0xCBD00 VA: 0x1800CC900
	// RVA: 0x1A581A0 Offset: 0x1A567A0 VA: 0x181A581A0
	internal static void Internal_PopParentClip() { }

	// RVA: 0x1A58370 Offset: 0x1A56970 VA: 0x181A58370
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A584F0 Offset: 0x1A56AF0 VA: 0x181A584F0
	public static Vector2 Unclip(Vector2 pos) { }

	// RVA: 0x1A58540 Offset: 0x1A56B40 VA: 0x181A58540
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x1A582A0 Offset: 0x1A568A0 VA: 0x181A582A0
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A58450 Offset: 0x1A56A50 VA: 0x181A58450
	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x1A580E0 Offset: 0x1A566E0 VA: 0x181A580E0
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1A583D0 Offset: 0x1A569D0 VA: 0x181A583D0
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x1A58200 Offset: 0x1A56800 VA: 0x181A58200
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

}

internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 4034
{	// Fields
	private bool m_Disposed; // 0x0

	// Methods

	// RVA: 0x229DA0 Offset: 0x2291A0 VA: 0x180229DA0
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x229D60 Offset: 0x229160 VA: 0x180229D60 Slot: 4
	public void Dispose() { }

}

