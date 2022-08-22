public sealed class RectTransformUtility // TypeDefIndex: 4733
{	// Fields
	private static readonly Vector3[] s_Corners; // 0x2B111D0

	// Methods

	// RVA: 0x2309AD0 Offset: 0x23080D0 VA: 0x182309AD0
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x2309BD0 Offset: 0x23081D0 VA: 0x182309BD0
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x2309CD0 Offset: 0x23082D0 VA: 0x182309CD0
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam) { }

	// RVA: 0x2309D60 Offset: 0x2308360 VA: 0x182309D60
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x230A190 Offset: 0x2308790 VA: 0x18230A190
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x2309E40 Offset: 0x2308440 VA: 0x182309E40
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x2309FC0 Offset: 0x23085C0 VA: 0x182309FC0
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x230A530 Offset: 0x2308B30 VA: 0x18230A530
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x2309750 Offset: 0x2307D50 VA: 0x182309750
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x23094A0 Offset: 0x2307AA0 VA: 0x1823094A0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x2309A20 Offset: 0x2308020 VA: 0x182309A20
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x230A660 Offset: 0x2308C60 VA: 0x18230A660
	private static void .cctor() { }

	// RVA: 0x2309A60 Offset: 0x2308060 VA: 0x182309A60
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x2309B70 Offset: 0x2308170 VA: 0x182309B70
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x2309C70 Offset: 0x2308270 VA: 0x182309C70
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam) { }

}

