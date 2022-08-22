public sealed class RectTransformUtility // TypeDefIndex: 4733
{	// Fields
	private static readonly Vector3[] s_Corners; // 0x2B10190

	// Methods

	// RVA: 0x2309810 Offset: 0x2307E10 VA: 0x182309810
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x2309910 Offset: 0x2307F10 VA: 0x182309910
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x2309A10 Offset: 0x2308010 VA: 0x182309A10
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam) { }

	// RVA: 0x2309AA0 Offset: 0x23080A0 VA: 0x182309AA0
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x2309ED0 Offset: 0x23084D0 VA: 0x182309ED0
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x2309B80 Offset: 0x2308180 VA: 0x182309B80
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x2309D00 Offset: 0x2308300 VA: 0x182309D00
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x230A270 Offset: 0x2308870 VA: 0x18230A270
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x2309490 Offset: 0x2307A90 VA: 0x182309490
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x23091E0 Offset: 0x23077E0 VA: 0x1823091E0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x2309760 Offset: 0x2307D60 VA: 0x182309760
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x230A3A0 Offset: 0x23089A0 VA: 0x18230A3A0
	private static void .cctor() { }

	// RVA: 0x23097A0 Offset: 0x2307DA0 VA: 0x1823097A0
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x23098B0 Offset: 0x2307EB0 VA: 0x1823098B0
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x23099B0 Offset: 0x2307FB0 VA: 0x1823099B0
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam) { }

}

