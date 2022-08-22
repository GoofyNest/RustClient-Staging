public static class LayoutUtility // TypeDefIndex: 4981
{	// Methods

	// RVA: 0x170D3F0 Offset: 0x170B9F0 VA: 0x18170D3F0
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x170D8D0 Offset: 0x170BED0 VA: 0x18170D8D0
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x170CD00 Offset: 0x170B300 VA: 0x18170CD00
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x170D5B0 Offset: 0x170BBB0 VA: 0x18170D5B0
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x170D8F0 Offset: 0x170BEF0 VA: 0x18170D8F0
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x170CEC0 Offset: 0x170B4C0 VA: 0x18170CEC0
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x170D2F0 Offset: 0x170B8F0 VA: 0x18170D2F0
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x170D6B0 Offset: 0x170BCB0 VA: 0x18170D6B0
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x170CC00 Offset: 0x170B200 VA: 0x18170CC00
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x170CFC0 Offset: 0x170B5C0 VA: 0x18170CFC0
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x170CFE0 Offset: 0x170B5E0 VA: 0x18170CFE0
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

	// RVA: 0x1721090 Offset: 0x171F690 VA: 0x181721090
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1720B90 Offset: 0x171F190 VA: 0x181720B90
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x1720C80 Offset: 0x171F280 VA: 0x181720C80
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x1720CD0 Offset: 0x171F2D0 VA: 0x181720CD0
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x1720AF0 Offset: 0x171F0F0 VA: 0x181720AF0
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x1720B40 Offset: 0x171F140 VA: 0x181720B40
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x1720BE0 Offset: 0x171F1E0 VA: 0x181720BE0
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x1720C30 Offset: 0x171F230 VA: 0x181720C30
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x1720AA0 Offset: 0x171F0A0 VA: 0x181720AA0
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

