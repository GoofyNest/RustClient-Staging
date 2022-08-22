internal sealed class GUIClip // TypeDefIndex: 4033
{	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCB490 Offset: 0xCA890 VA: 0x1800CB490
	// RVA: 0x1A6BD90 Offset: 0x1A6A390 VA: 0x181A6BD90
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB5D0 Offset: 0xCA9D0 VA: 0x1800CB5D0
	// RVA: 0x1A6BB20 Offset: 0x1A6A120 VA: 0x181A6BB20
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB9D0 Offset: 0xCADD0 VA: 0x1800CB9D0
	// RVA: 0x1A6B9E0 Offset: 0x1A69FE0 VA: 0x181A6B9E0
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	[VisibleToOtherModulesAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	// RVA: 0x1A6B980 Offset: 0x1A69F80 VA: 0x181A6B980
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCBFB0 Offset: 0xCB3B0 VA: 0x1800CBFB0
	// RVA: 0x1A6BCB0 Offset: 0x1A6A2B0 VA: 0x181A6BCB0
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	[FreeFunctionAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	// RVA: 0x1A6B930 Offset: 0x1A69F30 VA: 0x181A6B930
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC3F0 Offset: 0xCB7F0 VA: 0x1800CC3F0
	// RVA: 0x1A6BC20 Offset: 0x1A6A220 VA: 0x181A6BC20
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC630 Offset: 0xCBA30 VA: 0x1800CC630
	// RVA: 0x1A6BA60 Offset: 0x1A6A060 VA: 0x181A6BA60
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC900 Offset: 0xCBD00 VA: 0x1800CC900
	// RVA: 0x1A6B9B0 Offset: 0x1A69FB0 VA: 0x181A6B9B0
	internal static void Internal_PopParentClip() { }

	// RVA: 0x1A6BB80 Offset: 0x1A6A180 VA: 0x181A6BB80
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A6BD00 Offset: 0x1A6A300 VA: 0x181A6BD00
	public static Vector2 Unclip(Vector2 pos) { }

	// RVA: 0x1A6BD50 Offset: 0x1A6A350 VA: 0x181A6BD50
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x1A6BAB0 Offset: 0x1A6A0B0 VA: 0x181A6BAB0
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A6BC60 Offset: 0x1A6A260 VA: 0x181A6BC60
	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x1A6B8F0 Offset: 0x1A69EF0 VA: 0x181A6B8F0
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1A6BBE0 Offset: 0x1A6A1E0 VA: 0x181A6BBE0
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x1A6BA10 Offset: 0x1A6A010 VA: 0x181A6BA10
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

