public sealed class RectTransformUtility // TypeDefIndex: 4733
{	// Fields
	private static readonly Vector3[] s_Corners; // 0x13425

	// Methods

	// RVA: 0x230A2F0 Offset: 0x23088F0 VA: 0x18230A2F0
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x230A3F0 Offset: 0x23089F0 VA: 0x18230A3F0
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x230A4F0 Offset: 0x2308AF0 VA: 0x18230A4F0
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam) { }

	// RVA: 0x230A580 Offset: 0x2308B80 VA: 0x18230A580
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x230A9B0 Offset: 0x2308FB0 VA: 0x18230A9B0
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x230A660 Offset: 0x2308C60 VA: 0x18230A660
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x230A7E0 Offset: 0x2308DE0 VA: 0x18230A7E0
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x230AD50 Offset: 0x2309350 VA: 0x18230AD50
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x2309F70 Offset: 0x2308570 VA: 0x182309F70
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x2309CC0 Offset: 0x23082C0 VA: 0x182309CC0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x230A240 Offset: 0x2308840 VA: 0x18230A240
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x230AE80 Offset: 0x2309480 VA: 0x18230AE80
	private static void .cctor() { }

	// RVA: 0x230A280 Offset: 0x2308880 VA: 0x18230A280
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x230A390 Offset: 0x2308990 VA: 0x18230A390
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x230A490 Offset: 0x2308A90 VA: 0x18230A490
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam) { }

}

