internal sealed class GUIClip // TypeDefIndex: 4033
{	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCB490 Offset: 0xCA890 VA: 0x1800CB490
	// RVA: 0x1A6C050 Offset: 0x1A6A650 VA: 0x181A6C050
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB5D0 Offset: 0xCA9D0 VA: 0x1800CB5D0
	// RVA: 0x1A6BDE0 Offset: 0x1A6A3E0 VA: 0x181A6BDE0
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB9D0 Offset: 0xCADD0 VA: 0x1800CB9D0
	// RVA: 0x1A6BCA0 Offset: 0x1A6A2A0 VA: 0x181A6BCA0
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	[VisibleToOtherModulesAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	// RVA: 0x1A6BC40 Offset: 0x1A6A240 VA: 0x181A6BC40
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCBFB0 Offset: 0xCB3B0 VA: 0x1800CBFB0
	// RVA: 0x1A6BF70 Offset: 0x1A6A570 VA: 0x181A6BF70
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	[FreeFunctionAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	// RVA: 0x1A6BBF0 Offset: 0x1A6A1F0 VA: 0x181A6BBF0
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC3F0 Offset: 0xCB7F0 VA: 0x1800CC3F0
	// RVA: 0x1A6BEE0 Offset: 0x1A6A4E0 VA: 0x181A6BEE0
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC630 Offset: 0xCBA30 VA: 0x1800CC630
	// RVA: 0x1A6BD20 Offset: 0x1A6A320 VA: 0x181A6BD20
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC900 Offset: 0xCBD00 VA: 0x1800CC900
	// RVA: 0x1A6BC70 Offset: 0x1A6A270 VA: 0x181A6BC70
	internal static void Internal_PopParentClip() { }

	// RVA: 0x1A6BE40 Offset: 0x1A6A440 VA: 0x181A6BE40
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A6BFC0 Offset: 0x1A6A5C0 VA: 0x181A6BFC0
	public static Vector2 Unclip(Vector2 pos) { }

	// RVA: 0x1A6C010 Offset: 0x1A6A610 VA: 0x181A6C010
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x1A6BD70 Offset: 0x1A6A370 VA: 0x181A6BD70
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A6BF20 Offset: 0x1A6A520 VA: 0x181A6BF20
	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x1A6BBB0 Offset: 0x1A6A1B0 VA: 0x181A6BBB0
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1A6BEA0 Offset: 0x1A6A4A0 VA: 0x181A6BEA0
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x1A6BCD0 Offset: 0x1A6A2D0 VA: 0x181A6BCD0
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

}

internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 4034
{	// Fields
	private bool m_Disposed; // 0x0

	// Methods

	// RVA: 0x22ADC0 Offset: 0x22A1C0 VA: 0x18022ADC0
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x22AD80 Offset: 0x22A180 VA: 0x18022AD80 Slot: 4
	public void Dispose() { }

}

