public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 4979
{	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x170B6C0 Offset: 0x1709CC0 VA: 0x18170B6C0
	private void Initialize(RectTransform controller) { }

	// RVA: 0x170B540 Offset: 0x1709B40 VA: 0x18170B540
	private void Clear() { }

	// RVA: 0x170CB00 Offset: 0x170B100 VA: 0x18170CB00
	private static void .cctor() { }

	// RVA: 0x170C3D0 Offset: 0x170A9D0 VA: 0x18170C3D0
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x170B710 Offset: 0x1709D10 VA: 0x18170B710 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x170C760 Offset: 0x170AD60 VA: 0x18170C760
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x170B5D0 Offset: 0x1709BD0 VA: 0x18170B5D0
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x170C430 Offset: 0x170AA30 VA: 0x18170C430 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x170C130 Offset: 0x170A730 VA: 0x18170C130
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x170BEB0 Offset: 0x170A4B0 VA: 0x18170BEB0
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x170B7F0 Offset: 0x1709DF0 VA: 0x18170B7F0
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x170C8A0 Offset: 0x170AEA0 VA: 0x18170C8A0
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x170BD40 Offset: 0x170A340 VA: 0x18170BD40
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x170B770 Offset: 0x1709D70 VA: 0x18170B770 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x170B570 Offset: 0x1709B70 VA: 0x18170B570 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x170C860 Offset: 0x170AE60 VA: 0x18170C860 Slot: 3
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

	// RVA: 0x1721030 Offset: 0x171F630 VA: 0x181721030
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1720FF0 Offset: 0x171F5F0 VA: 0x181720FF0
	internal void <.cctor>b__5_0(LayoutRebuilder x) { }

	// RVA: 0x1720EE0 Offset: 0x171F4E0 VA: 0x181720EE0
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x1720D20 Offset: 0x171F320 VA: 0x181720D20
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x1720D90 Offset: 0x171F390 VA: 0x181720D90
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x1720E00 Offset: 0x171F400 VA: 0x181720E00
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x1720E70 Offset: 0x171F470 VA: 0x181720E70
	internal void <Rebuild>b__12_3(Component e) { }

}

