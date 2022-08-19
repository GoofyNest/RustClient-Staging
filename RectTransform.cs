public sealed class RectTransform : Transform // TypeDefIndex: 3565
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x2B11168

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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19AC870 Offset: 0x19AAE70 VA: 0x1819AC870
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19ACFC0 Offset: 0x19AB5C0 VA: 0x1819ACFC0
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x19ACED0 Offset: 0x19AB4D0 VA: 0x1819ACED0
	public Rect get_rect() { }

	// RVA: 0x19ACA10 Offset: 0x19AB010 VA: 0x1819ACA10
	public Vector2 get_anchorMin() { }

	// RVA: 0x19AD150 Offset: 0x19AB750 VA: 0x1819AD150
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x19AC970 Offset: 0x19AAF70 VA: 0x1819AC970
	public Vector2 get_anchorMax() { }

	// RVA: 0x19AD0C0 Offset: 0x19AB6C0 VA: 0x1819AD0C0
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x19ACB60 Offset: 0x19AB160 VA: 0x1819ACB60
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x19AD2C0 Offset: 0x19AB8C0 VA: 0x1819AD2C0
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x19ACF70 Offset: 0x19AB570 VA: 0x1819ACF70
	public Vector2 get_sizeDelta() { }

	// RVA: 0x19AD8C0 Offset: 0x19ABEC0 VA: 0x1819AD8C0
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x19ACE30 Offset: 0x19AB430 VA: 0x1819ACE30
	public Vector2 get_pivot() { }

	// RVA: 0x19AD830 Offset: 0x19ABE30 VA: 0x1819AD830
	public void set_pivot(Vector2 value) { }

	// RVA: 0x19ACA60 Offset: 0x19AB060 VA: 0x1819ACA60
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x19AD190 Offset: 0x19AB790 VA: 0x1819AD190
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x19ACCE0 Offset: 0x19AB2E0 VA: 0x1819ACCE0
	public Vector2 get_offsetMin() { }

	// RVA: 0x19AD570 Offset: 0x19ABB70 VA: 0x1819AD570
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x19ACBB0 Offset: 0x19AB1B0 VA: 0x1819ACBB0
	public Vector2 get_offsetMax() { }

	// RVA: 0x19AD300 Offset: 0x19AB900 VA: 0x1819AD300
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x19ABD80 Offset: 0x19AA380 VA: 0x1819ABD80
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19AC100 Offset: 0x19AA700 VA: 0x1819AC100
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19AC2D0 Offset: 0x19AA8D0 VA: 0x1819AC2D0
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x19AC5F0 Offset: 0x19AABF0 VA: 0x1819AC5F0
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19AC280 Offset: 0x19AA880 VA: 0x1819AC280
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x19ABFF0 Offset: 0x19AA5F0 VA: 0x1819ABFF0
	private Vector2 GetParentSize() { }

	// RVA: 0x19ACE80 Offset: 0x19AB480 VA: 0x1819ACE80
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19AC9C0 Offset: 0x19AAFC0 VA: 0x1819AC9C0
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x19AD100 Offset: 0x19AB700 VA: 0x1819AD100
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x19AC920 Offset: 0x19AAF20 VA: 0x1819AC920
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x19AD070 Offset: 0x19AB670 VA: 0x1819AD070
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x19ACB10 Offset: 0x19AB110 VA: 0x1819ACB10
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x19AD270 Offset: 0x19AB870 VA: 0x1819AD270
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x19ACF20 Offset: 0x19AB520 VA: 0x1819ACF20
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x19AD870 Offset: 0x19ABE70 VA: 0x1819AD870
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x19ACDE0 Offset: 0x19AB3E0 VA: 0x1819ACDE0
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x19AD7E0 Offset: 0x19ABDE0 VA: 0x1819AD7E0
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

