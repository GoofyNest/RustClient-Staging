internal sealed class GUIClip // TypeDefIndex: 4033
{	internal static Rect visibleRect { get; }


	[FreeFunctionAttribute] // RVA: 0xCB490 Offset: 0xCA890 VA: 0x1800CB490
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB5D0 Offset: 0xCA9D0 VA: 0x1800CB5D0
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB9D0 Offset: 0xCADD0 VA: 0x1800CB9D0
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	[VisibleToOtherModulesAttribute] // RVA: 0xCBC90 Offset: 0xCB090 VA: 0x1800CBC90
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCBFB0 Offset: 0xCB3B0 VA: 0x1800CBFB0
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	[FreeFunctionAttribute] // RVA: 0xCC0A0 Offset: 0xCB4A0 VA: 0x1800CC0A0
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC3F0 Offset: 0xCB7F0 VA: 0x1800CC3F0
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC630 Offset: 0xCBA30 VA: 0x1800CC630
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC900 Offset: 0xCBD00 VA: 0x1800CC900
	internal static void Internal_PopParentClip() { }

	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	public static Vector2 Unclip(Vector2 pos) { }

	private static void get_visibleRect_Injected(out Rect ret) { }

	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

}

internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 4034
{	private bool m_Disposed; // 0x0


	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	public void Dispose() { }

}

