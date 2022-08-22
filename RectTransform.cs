public sealed class RectTransform : Transform // TypeDefIndex: 3565
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x2B111C8

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
	// RVA: 0x19ACAF0 Offset: 0x19AB0F0 VA: 0x1819ACAF0
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AD240 Offset: 0x19AB840 VA: 0x1819AD240
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x19AD150 Offset: 0x19AB750 VA: 0x1819AD150
	public Rect get_rect() { }

	// RVA: 0x19ACC90 Offset: 0x19AB290 VA: 0x1819ACC90
	public Vector2 get_anchorMin() { }

	// RVA: 0x19AD3D0 Offset: 0x19AB9D0 VA: 0x1819AD3D0
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x19ACBF0 Offset: 0x19AB1F0 VA: 0x1819ACBF0
	public Vector2 get_anchorMax() { }

	// RVA: 0x19AD340 Offset: 0x19AB940 VA: 0x1819AD340
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x19ACDE0 Offset: 0x19AB3E0 VA: 0x1819ACDE0
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x19AD540 Offset: 0x19ABB40 VA: 0x1819AD540
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x19AD1F0 Offset: 0x19AB7F0 VA: 0x1819AD1F0
	public Vector2 get_sizeDelta() { }

	// RVA: 0x19ADB40 Offset: 0x19AC140 VA: 0x1819ADB40
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x19AD0B0 Offset: 0x19AB6B0 VA: 0x1819AD0B0
	public Vector2 get_pivot() { }

	// RVA: 0x19ADAB0 Offset: 0x19AC0B0 VA: 0x1819ADAB0
	public void set_pivot(Vector2 value) { }

	// RVA: 0x19ACCE0 Offset: 0x19AB2E0 VA: 0x1819ACCE0
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x19AD410 Offset: 0x19ABA10 VA: 0x1819AD410
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x19ACF60 Offset: 0x19AB560 VA: 0x1819ACF60
	public Vector2 get_offsetMin() { }

	// RVA: 0x19AD7F0 Offset: 0x19ABDF0 VA: 0x1819AD7F0
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x19ACE30 Offset: 0x19AB430 VA: 0x1819ACE30
	public Vector2 get_offsetMax() { }

	// RVA: 0x19AD580 Offset: 0x19ABB80 VA: 0x1819AD580
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x19AC000 Offset: 0x19AA600 VA: 0x1819AC000
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19AC380 Offset: 0x19AA980 VA: 0x1819AC380
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19AC550 Offset: 0x19AAB50 VA: 0x1819AC550
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x19AC870 Offset: 0x19AAE70 VA: 0x1819AC870
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19AC500 Offset: 0x19AAB00 VA: 0x1819AC500
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x19AC270 Offset: 0x19AA870 VA: 0x1819AC270
	private Vector2 GetParentSize() { }

	// RVA: 0x19AD100 Offset: 0x19AB700 VA: 0x1819AD100
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19ACC40 Offset: 0x19AB240 VA: 0x1819ACC40
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x19AD380 Offset: 0x19AB980 VA: 0x1819AD380
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x19ACBA0 Offset: 0x19AB1A0 VA: 0x1819ACBA0
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x19AD2F0 Offset: 0x19AB8F0 VA: 0x1819AD2F0
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x19ACD90 Offset: 0x19AB390 VA: 0x1819ACD90
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x19AD4F0 Offset: 0x19ABAF0 VA: 0x1819AD4F0
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x19AD1A0 Offset: 0x19AB7A0 VA: 0x1819AD1A0
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x19ADAF0 Offset: 0x19AC0F0 VA: 0x1819ADAF0
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x19AD060 Offset: 0x19AB660 VA: 0x1819AD060
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x19ADA60 Offset: 0x19AC060 VA: 0x1819ADA60
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

	// RVA: 0x12E3190 Offset: 0x12E1790 VA: 0x1812E3190 Slot: 12
	public virtual void Invoke(RectTransform driven) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

