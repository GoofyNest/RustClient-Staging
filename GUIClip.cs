internal sealed class GUIClip // TypeDefIndex: 4033
{	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCB400 Offset: 0xCA800 VA: 0x1800CB400
	// RVA: 0x1A6BDD0 Offset: 0x1A6A3D0 VA: 0x181A6BDD0
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB540 Offset: 0xCA940 VA: 0x1800CB540
	// RVA: 0x1A6BB60 Offset: 0x1A6A160 VA: 0x181A6BB60
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB940 Offset: 0xCAD40 VA: 0x1800CB940
	// RVA: 0x1A6BA20 Offset: 0x1A6A020 VA: 0x181A6BA20
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] // RVA: 0xCBC00 Offset: 0xCB000 VA: 0x1800CBC00
	[VisibleToOtherModulesAttribute] // RVA: 0xCBC00 Offset: 0xCB000 VA: 0x1800CBC00
	// RVA: 0x1A6B9C0 Offset: 0x1A69FC0 VA: 0x181A6B9C0
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCBF20 Offset: 0xCB320 VA: 0x1800CBF20
	// RVA: 0x1A6BCF0 Offset: 0x1A6A2F0 VA: 0x181A6BCF0
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC040 Offset: 0xCB440 VA: 0x1800CC040
	[FreeFunctionAttribute] // RVA: 0xCC040 Offset: 0xCB440 VA: 0x1800CC040
	// RVA: 0x1A6B970 Offset: 0x1A69F70 VA: 0x181A6B970
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC360 Offset: 0xCB760 VA: 0x1800CC360
	// RVA: 0x1A6BC60 Offset: 0x1A6A260 VA: 0x181A6BC60
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC5A0 Offset: 0xCB9A0 VA: 0x1800CC5A0
	// RVA: 0x1A6BAA0 Offset: 0x1A6A0A0 VA: 0x181A6BAA0
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC840 Offset: 0xCBC40 VA: 0x1800CC840
	// RVA: 0x1A6B9F0 Offset: 0x1A69FF0 VA: 0x181A6B9F0
	internal static void Internal_PopParentClip() { }

	// RVA: 0x1A6BBC0 Offset: 0x1A6A1C0 VA: 0x181A6BBC0
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A6BD40 Offset: 0x1A6A340 VA: 0x181A6BD40
	public static Vector2 Unclip(Vector2 pos) { }

	// RVA: 0x1A6BD90 Offset: 0x1A6A390 VA: 0x181A6BD90
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x1A6BAF0 Offset: 0x1A6A0F0 VA: 0x181A6BAF0
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A6BCA0 Offset: 0x1A6A2A0 VA: 0x181A6BCA0
	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x1A6B930 Offset: 0x1A69F30 VA: 0x181A6B930
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1A6BC20 Offset: 0x1A6A220 VA: 0x181A6BC20
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x1A6BA50 Offset: 0x1A6A050 VA: 0x181A6BA50
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

}

internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 4034
{	// Fields
	private bool m_Disposed; // 0x0

	// Methods

	// RVA: 0x22AE40 Offset: 0x22A240 VA: 0x18022AE40
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x22AE00 Offset: 0x22A200 VA: 0x18022AE00 Slot: 4
	public void Dispose() { }

}

