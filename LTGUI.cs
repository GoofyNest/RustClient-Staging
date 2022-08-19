public class LTGUI // TypeDefIndex: 5587
{	// Fields
	public static int RECT_LEVELS; // 0x0
	public static int RECTS_PER_LEVEL; // 0x4
	public static int BUTTONS_MAX; // 0x8
	private static LTRect[] levels; // 0x10
	private static int[] levelDepths; // 0x18
	private static Rect[] buttons; // 0x20
	private static int[] buttonLevels; // 0x28
	private static int[] buttonLastFrame; // 0x30
	private static LTRect r; // 0x38
	private static Color color; // 0x40
	private static bool isGUIEnabled; // 0x50
	private static int global_counter; // 0x54

	// Methods

	// RVA: 0x19A0E50 Offset: 0x199F450 VA: 0x1819A0E50
	public static void init() { }

	// RVA: 0x19A0C70 Offset: 0x199F270 VA: 0x1819A0C70
	public static void initRectCheck() { }

	// RVA: 0x19A12F0 Offset: 0x199F8F0 VA: 0x1819A12F0
	public static void reset() { }

	// RVA: 0x19A1680 Offset: 0x199FC80 VA: 0x1819A1680
	public static void update(int updateLevel) { }

	// RVA: 0x199FE20 Offset: 0x199E420 VA: 0x18199FE20
	public static bool checkOnScreen(Rect rect) { }

	// RVA: 0x19A0110 Offset: 0x199E710 VA: 0x1819A0110
	public static void destroy(int id) { }

	// RVA: 0x199FFF0 Offset: 0x199E5F0 VA: 0x18199FFF0
	public static void destroyAll(int depth) { }

	// RVA: 0x19A0FD0 Offset: 0x199F5D0 VA: 0x1819A0FD0
	public static LTRect label(Rect rect, string label, int depth) { }

	// RVA: 0x19A0F40 Offset: 0x199F540 VA: 0x1819A0F40
	public static LTRect label(LTRect rect, string label, int depth) { }

	// RVA: 0x19A1580 Offset: 0x199FB80 VA: 0x1819A1580
	public static LTRect texture(Rect rect, Texture texture, int depth) { }

	// RVA: 0x19A14E0 Offset: 0x199FAE0 VA: 0x1819A14E0
	public static LTRect texture(LTRect rect, Texture texture, int depth) { }

	// RVA: 0x19A02F0 Offset: 0x199E8F0 VA: 0x1819A02F0
	public static LTRect element(LTRect rect, int depth) { }

	// RVA: 0x19A0860 Offset: 0x199EE60 VA: 0x1819A0860
	public static bool hasNoOverlap(Rect rect, int depth) { }

	// RVA: 0x19A10D0 Offset: 0x199F6D0 VA: 0x1819A10D0
	public static bool pressedWithinRect(Rect rect) { }

	// RVA: 0x199FF30 Offset: 0x199E530 VA: 0x18199FF30
	public static bool checkWithinRect(Vector2 vec2, Rect rect) { }

	// RVA: 0x19A0760 Offset: 0x199ED60 VA: 0x1819A0760
	public static Vector2 firstTouch() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x199FD70 Offset: 0x199E370 VA: 0x18199FD70
	private static void .cctor() { }

}

public enum LTGUI.Element_Type // TypeDefIndex: 5588
{	// Fields
	public int value__; // 0x0
	public const LTGUI.Element_Type Texture = 0;
	public const LTGUI.Element_Type Label = 1;

}

