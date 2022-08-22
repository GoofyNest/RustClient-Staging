public sealed class RectTransform : Transform // TypeDefIndex: 3565
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x1458F

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1999EF0 Offset: 0x19984F0 VA: 0x181999EF0
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x199A640 Offset: 0x1998C40 VA: 0x18199A640
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x199A550 Offset: 0x1998B50 VA: 0x18199A550
	public Rect get_rect() { }

	// RVA: 0x199A090 Offset: 0x1998690 VA: 0x18199A090
	public Vector2 get_anchorMin() { }

	// RVA: 0x199A7D0 Offset: 0x1998DD0 VA: 0x18199A7D0
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x1999FF0 Offset: 0x19985F0 VA: 0x181999FF0
	public Vector2 get_anchorMax() { }

	// RVA: 0x199A740 Offset: 0x1998D40 VA: 0x18199A740
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x199A1E0 Offset: 0x19987E0 VA: 0x18199A1E0
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x199A940 Offset: 0x1998F40 VA: 0x18199A940
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x199A5F0 Offset: 0x1998BF0 VA: 0x18199A5F0
	public Vector2 get_sizeDelta() { }

	// RVA: 0x199AF40 Offset: 0x1999540 VA: 0x18199AF40
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x199A4B0 Offset: 0x1998AB0 VA: 0x18199A4B0
	public Vector2 get_pivot() { }

	// RVA: 0x199AEB0 Offset: 0x19994B0 VA: 0x18199AEB0
	public void set_pivot(Vector2 value) { }

	// RVA: 0x199A0E0 Offset: 0x19986E0 VA: 0x18199A0E0
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x199A810 Offset: 0x1998E10 VA: 0x18199A810
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x199A360 Offset: 0x1998960 VA: 0x18199A360
	public Vector2 get_offsetMin() { }

	// RVA: 0x199ABF0 Offset: 0x19991F0 VA: 0x18199ABF0
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x199A230 Offset: 0x1998830 VA: 0x18199A230
	public Vector2 get_offsetMax() { }

	// RVA: 0x199A980 Offset: 0x1998F80 VA: 0x18199A980
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x1999400 Offset: 0x1997A00 VA: 0x181999400
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x1999780 Offset: 0x1997D80 VA: 0x181999780
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x1999950 Offset: 0x1997F50 VA: 0x181999950
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x1999C70 Offset: 0x1998270 VA: 0x181999C70
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1999900 Offset: 0x1997F00 VA: 0x181999900
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x1999670 Offset: 0x1997C70 VA: 0x181999670
	private Vector2 GetParentSize() { }

	// RVA: 0x199A500 Offset: 0x1998B00 VA: 0x18199A500
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x199A040 Offset: 0x1998640 VA: 0x18199A040
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x199A780 Offset: 0x1998D80 VA: 0x18199A780
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x1999FA0 Offset: 0x19985A0 VA: 0x181999FA0
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x199A6F0 Offset: 0x1998CF0 VA: 0x18199A6F0
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x199A190 Offset: 0x1998790 VA: 0x18199A190
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x199A8F0 Offset: 0x1998EF0 VA: 0x18199A8F0
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x199A5A0 Offset: 0x1998BA0 VA: 0x18199A5A0
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x199AEF0 Offset: 0x19994F0 VA: 0x18199AEF0
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x199A460 Offset: 0x1998A60 VA: 0x18199A460
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x199AE60 Offset: 0x1999460 VA: 0x18199AE60
	private void set_pivot_Injected(ref Vector2 value) { }

}

public enum RectTransform.Edge // TypeDefIndex: 3566
{	// Fields
	public int value__; // 0x0
	public const RectTransform.Edge Left = 0;
	public const RectTransform.Edge Right = 1;
	public const RectTransform.Edge Top = 2;
	public const RectTransform.Edge Bottom = 3;

}

public enum RectTransform.Axis // TypeDefIndex: 3567
{	// Fields
	public int value__; // 0x0
	public const RectTransform.Axis Horizontal = 0;
	public const RectTransform.Axis Vertical = 1;

}

public sealed class RectTransform.ReapplyDrivenProperties : MulticastDelegate // TypeDefIndex: 3568
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12E9640 Offset: 0x12E7C40 VA: 0x1812E9640 Slot: 12
	public virtual void Invoke(RectTransform driven) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

