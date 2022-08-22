public sealed class RectTransform : Transform // TypeDefIndex: 3565
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x2B10188

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
	// RVA: 0x19AC830 Offset: 0x19AAE30 VA: 0x1819AC830
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19ACF80 Offset: 0x19AB580 VA: 0x1819ACF80
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x19ACE90 Offset: 0x19AB490 VA: 0x1819ACE90
	public Rect get_rect() { }

	// RVA: 0x19AC9D0 Offset: 0x19AAFD0 VA: 0x1819AC9D0
	public Vector2 get_anchorMin() { }

	// RVA: 0x19AD110 Offset: 0x19AB710 VA: 0x1819AD110
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x19AC930 Offset: 0x19AAF30 VA: 0x1819AC930
	public Vector2 get_anchorMax() { }

	// RVA: 0x19AD080 Offset: 0x19AB680 VA: 0x1819AD080
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x19ACB20 Offset: 0x19AB120 VA: 0x1819ACB20
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x19AD280 Offset: 0x19AB880 VA: 0x1819AD280
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x19ACF30 Offset: 0x19AB530 VA: 0x1819ACF30
	public Vector2 get_sizeDelta() { }

	// RVA: 0x19AD880 Offset: 0x19ABE80 VA: 0x1819AD880
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x19ACDF0 Offset: 0x19AB3F0 VA: 0x1819ACDF0
	public Vector2 get_pivot() { }

	// RVA: 0x19AD7F0 Offset: 0x19ABDF0 VA: 0x1819AD7F0
	public void set_pivot(Vector2 value) { }

	// RVA: 0x19ACA20 Offset: 0x19AB020 VA: 0x1819ACA20
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x19AD150 Offset: 0x19AB750 VA: 0x1819AD150
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x19ACCA0 Offset: 0x19AB2A0 VA: 0x1819ACCA0
	public Vector2 get_offsetMin() { }

	// RVA: 0x19AD530 Offset: 0x19ABB30 VA: 0x1819AD530
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x19ACB70 Offset: 0x19AB170 VA: 0x1819ACB70
	public Vector2 get_offsetMax() { }

	// RVA: 0x19AD2C0 Offset: 0x19AB8C0 VA: 0x1819AD2C0
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x19ABD40 Offset: 0x19AA340 VA: 0x1819ABD40
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19AC0C0 Offset: 0x19AA6C0 VA: 0x1819AC0C0
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19AC290 Offset: 0x19AA890 VA: 0x1819AC290
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x19AC5B0 Offset: 0x19AABB0 VA: 0x1819AC5B0
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AC240 Offset: 0x19AA840 VA: 0x1819AC240
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x19ABFB0 Offset: 0x19AA5B0 VA: 0x1819ABFB0
	private Vector2 GetParentSize() { }

	// RVA: 0x19ACE40 Offset: 0x19AB440 VA: 0x1819ACE40
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19AC980 Offset: 0x19AAF80 VA: 0x1819AC980
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x19AD0C0 Offset: 0x19AB6C0 VA: 0x1819AD0C0
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x19AC8E0 Offset: 0x19AAEE0 VA: 0x1819AC8E0
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x19AD030 Offset: 0x19AB630 VA: 0x1819AD030
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x19ACAD0 Offset: 0x19AB0D0 VA: 0x1819ACAD0
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x19AD230 Offset: 0x19AB830 VA: 0x1819AD230
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x19ACEE0 Offset: 0x19AB4E0 VA: 0x1819ACEE0
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x19AD830 Offset: 0x19ABE30 VA: 0x1819AD830
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x19ACDA0 Offset: 0x19AB3A0 VA: 0x1819ACDA0
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x19AD7A0 Offset: 0x19ABDA0 VA: 0x1819AD7A0
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

	// RVA: 0x12E2ED0 Offset: 0x12E14D0 VA: 0x1812E2ED0 Slot: 12
	public virtual void Invoke(RectTransform driven) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

