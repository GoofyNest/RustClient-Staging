public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 4979
{	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x1712270 Offset: 0x1710870 VA: 0x181712270
	private void Initialize(RectTransform controller) { }

	// RVA: 0x17120F0 Offset: 0x17106F0 VA: 0x1817120F0
	private void Clear() { }

	// RVA: 0x17136B0 Offset: 0x1711CB0 VA: 0x1817136B0
	private static void .cctor() { }

	// RVA: 0x1712F80 Offset: 0x1711580 VA: 0x181712F80
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x17122C0 Offset: 0x17108C0 VA: 0x1817122C0 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x1713310 Offset: 0x1711910 VA: 0x181713310
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x1712180 Offset: 0x1710780 VA: 0x181712180
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x1712FE0 Offset: 0x17115E0 VA: 0x181712FE0 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1712CE0 Offset: 0x17112E0 VA: 0x181712CE0
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x1712A60 Offset: 0x1711060 VA: 0x181712A60
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x17123A0 Offset: 0x17109A0 VA: 0x1817123A0
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x1713450 Offset: 0x1711A50 VA: 0x181713450
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x17128F0 Offset: 0x1710EF0 VA: 0x1817128F0
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x1712320 Offset: 0x1710920 VA: 0x181712320 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1712120 Offset: 0x1710720 VA: 0x181712120 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1713410 Offset: 0x1711A10 VA: 0x181713410 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class LayoutRebuilder.<>c // TypeDefIndex: 4980
{	// Fields
	public static readonly LayoutRebuilder.<>c <>9; // 0x0
	public static Predicate<Component> <>9__10_0; // 0x8
	public static UnityAction<Component> <>9__12_0; // 0x10
	public static UnityAction<Component> <>9__12_1; // 0x18
	public static UnityAction<Component> <>9__12_2; // 0x20
	public static UnityAction<Component> <>9__12_3; // 0x28

	// Methods

	// RVA: 0x1727C10 Offset: 0x1726210 VA: 0x181727C10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1727BD0 Offset: 0x17261D0 VA: 0x181727BD0
	internal void <.cctor>b__5_0(LayoutRebuilder x) { }

	// RVA: 0x1727AC0 Offset: 0x17260C0 VA: 0x181727AC0
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x1727900 Offset: 0x1725F00 VA: 0x181727900
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x1727970 Offset: 0x1725F70 VA: 0x181727970
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x17279E0 Offset: 0x1725FE0 VA: 0x1817279E0
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x1727A50 Offset: 0x1726050 VA: 0x181727A50
	internal void <Rebuild>b__12_3(Component e) { }

}

