public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 4979
{	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x1711FB0 Offset: 0x17105B0 VA: 0x181711FB0
	private void Initialize(RectTransform controller) { }

	// RVA: 0x1711E30 Offset: 0x1710430 VA: 0x181711E30
	private void Clear() { }

	// RVA: 0x17133F0 Offset: 0x17119F0 VA: 0x1817133F0
	private static void .cctor() { }

	// RVA: 0x1712CC0 Offset: 0x17112C0 VA: 0x181712CC0
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x1712000 Offset: 0x1710600 VA: 0x181712000 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x1713050 Offset: 0x1711650 VA: 0x181713050
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x1711EC0 Offset: 0x17104C0 VA: 0x181711EC0
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x1712D20 Offset: 0x1711320 VA: 0x181712D20 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1712A20 Offset: 0x1711020 VA: 0x181712A20
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x17127A0 Offset: 0x1710DA0 VA: 0x1817127A0
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x17120E0 Offset: 0x17106E0 VA: 0x1817120E0
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x1713190 Offset: 0x1711790 VA: 0x181713190
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x1712630 Offset: 0x1710C30 VA: 0x181712630
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x1712060 Offset: 0x1710660 VA: 0x181712060 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1711E60 Offset: 0x1710460 VA: 0x181711E60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1713150 Offset: 0x1711750 VA: 0x181713150 Slot: 3
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

	// RVA: 0x1727950 Offset: 0x1725F50 VA: 0x181727950
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1727910 Offset: 0x1725F10 VA: 0x181727910
	internal void <.cctor>b__5_0(LayoutRebuilder x) { }

	// RVA: 0x1727800 Offset: 0x1725E00 VA: 0x181727800
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x1727640 Offset: 0x1725C40 VA: 0x181727640
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x17276B0 Offset: 0x1725CB0 VA: 0x1817276B0
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x1727720 Offset: 0x1725D20 VA: 0x181727720
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x1727790 Offset: 0x1725D90 VA: 0x181727790
	internal void <Rebuild>b__12_3(Component e) { }

}

