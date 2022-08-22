public static class LayoutUtility // TypeDefIndex: 4981
{	// Methods

	// RVA: 0x1713FA0 Offset: 0x17125A0 VA: 0x181713FA0
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x1714480 Offset: 0x1712A80 VA: 0x181714480
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x17138B0 Offset: 0x1711EB0 VA: 0x1817138B0
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x1714160 Offset: 0x1712760 VA: 0x181714160
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x17144A0 Offset: 0x1712AA0 VA: 0x1817144A0
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x1713A70 Offset: 0x1712070 VA: 0x181713A70
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x1713EA0 Offset: 0x17124A0 VA: 0x181713EA0
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x1714260 Offset: 0x1712860 VA: 0x181714260
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x17137B0 Offset: 0x1711DB0 VA: 0x1817137B0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x1713B70 Offset: 0x1712170 VA: 0x181713B70
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x1713B90 Offset: 0x1712190 VA: 0x181713B90
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

	// RVA: 0x1727C70 Offset: 0x1726270 VA: 0x181727C70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1727770 Offset: 0x1725D70 VA: 0x181727770
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x1727860 Offset: 0x1725E60 VA: 0x181727860
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x17278B0 Offset: 0x1725EB0 VA: 0x1817278B0
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x17276D0 Offset: 0x1725CD0 VA: 0x1817276D0
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x1727720 Offset: 0x1725D20 VA: 0x181727720
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x17277C0 Offset: 0x1725DC0 VA: 0x1817277C0
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x1727810 Offset: 0x1725E10 VA: 0x181727810
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x1727680 Offset: 0x1725C80 VA: 0x181727680
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

