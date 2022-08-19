public sealed class RectTransformUtility // TypeDefIndex: 4733
{	// Fields
	private static readonly Vector3[] s_Corners; // 0x2B11170

	// Methods

	// RVA: 0x23099D0 Offset: 0x2307FD0 VA: 0x1823099D0
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x2309AD0 Offset: 0x23080D0 VA: 0x182309AD0
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x2309BD0 Offset: 0x23081D0 VA: 0x182309BD0
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam) { }

	// RVA: 0x2309C60 Offset: 0x2308260 VA: 0x182309C60
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x230A090 Offset: 0x2308690 VA: 0x18230A090
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x2309D40 Offset: 0x2308340 VA: 0x182309D40
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x2309EC0 Offset: 0x23084C0 VA: 0x182309EC0
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x230A430 Offset: 0x2308A30 VA: 0x18230A430
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x2309650 Offset: 0x2307C50 VA: 0x182309650
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x23093A0 Offset: 0x23079A0 VA: 0x1823093A0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x2309920 Offset: 0x2307F20 VA: 0x182309920
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x230A560 Offset: 0x2308B60 VA: 0x18230A560
	private static void .cctor() { }

	// RVA: 0x2309960 Offset: 0x2307F60 VA: 0x182309960
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x2309A70 Offset: 0x2308070 VA: 0x182309A70
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x2309B70 Offset: 0x2308170 VA: 0x182309B70
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam) { }

}

