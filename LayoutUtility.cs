public static class LayoutUtility // TypeDefIndex: 4981
{	// Methods

	// RVA: 0x1713CE0 Offset: 0x17122E0 VA: 0x181713CE0
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x17141C0 Offset: 0x17127C0 VA: 0x1817141C0
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x17135F0 Offset: 0x1711BF0 VA: 0x1817135F0
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x1713EA0 Offset: 0x17124A0 VA: 0x181713EA0
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x17141E0 Offset: 0x17127E0 VA: 0x1817141E0
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x17137B0 Offset: 0x1711DB0 VA: 0x1817137B0
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x1713BE0 Offset: 0x17121E0 VA: 0x181713BE0
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x1713FA0 Offset: 0x17125A0 VA: 0x181713FA0
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x17134F0 Offset: 0x1711AF0 VA: 0x1817134F0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x17138B0 Offset: 0x1711EB0 VA: 0x1817138B0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x17138D0 Offset: 0x1711ED0 VA: 0x1817138D0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }

}

private sealed class LayoutUtility.<>c // TypeDefIndex: 4982
{	// Fields
	public static readonly LayoutUtility.<>c <>9; // 0x0
	public static Func<ILayoutElement, float> <>9__3_0; // 0x8
	public static Func<ILayoutElement, float> <>9__4_0; // 0x10
	public static Func<ILayoutElement, float> <>9__4_1; // 0x18
	public static Func<ILayoutElement, float> <>9__5_0; // 0x20
	public static Func<ILayoutElement, float> <>9__6_0; // 0x28
	public static Func<ILayoutElement, float> <>9__7_0; // 0x30
	public static Func<ILayoutElement, float> <>9__7_1; // 0x38
	public static Func<ILayoutElement, float> <>9__8_0; // 0x40

	// Methods

	// RVA: 0x17279B0 Offset: 0x1725FB0 VA: 0x1817279B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x17274B0 Offset: 0x1725AB0 VA: 0x1817274B0
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x17275A0 Offset: 0x1725BA0 VA: 0x1817275A0
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x17275F0 Offset: 0x1725BF0 VA: 0x1817275F0
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x1727410 Offset: 0x1725A10 VA: 0x181727410
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x1727460 Offset: 0x1725A60 VA: 0x181727460
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x1727500 Offset: 0x1725B00 VA: 0x181727500
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x1727550 Offset: 0x1725B50 VA: 0x181727550
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x17273C0 Offset: 0x17259C0 VA: 0x1817273C0
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

