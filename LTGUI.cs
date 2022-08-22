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

	// RVA: 0x19A10D0 Offset: 0x199F6D0 VA: 0x1819A10D0
	public static void init() { }

	// RVA: 0x19A0EF0 Offset: 0x199F4F0 VA: 0x1819A0EF0
	public static void initRectCheck() { }

	// RVA: 0x19A1570 Offset: 0x199FB70 VA: 0x1819A1570
	public static void reset() { }

	// RVA: 0x19A1900 Offset: 0x199FF00 VA: 0x1819A1900
	public static void update(int updateLevel) { }

	// RVA: 0x19A00A0 Offset: 0x199E6A0 VA: 0x1819A00A0
	public static bool checkOnScreen(Rect rect) { }

	// RVA: 0x19A0390 Offset: 0x199E990 VA: 0x1819A0390
	public static void destroy(int id) { }

	// RVA: 0x19A0270 Offset: 0x199E870 VA: 0x1819A0270
	public static void destroyAll(int depth) { }

	// RVA: 0x19A1250 Offset: 0x199F850 VA: 0x1819A1250
	public static LTRect label(Rect rect, string label, int depth) { }

	// RVA: 0x19A11C0 Offset: 0x199F7C0 VA: 0x1819A11C0
	public static LTRect label(LTRect rect, string label, int depth) { }

	// RVA: 0x19A1800 Offset: 0x199FE00 VA: 0x1819A1800
	public static LTRect texture(Rect rect, Texture texture, int depth) { }

	// RVA: 0x19A1760 Offset: 0x199FD60 VA: 0x1819A1760
	public static LTRect texture(LTRect rect, Texture texture, int depth) { }

	// RVA: 0x19A0570 Offset: 0x199EB70 VA: 0x1819A0570
	public static LTRect element(LTRect rect, int depth) { }

	// RVA: 0x19A0AE0 Offset: 0x199F0E0 VA: 0x1819A0AE0
	public static bool hasNoOverlap(Rect rect, int depth) { }

	// RVA: 0x19A1350 Offset: 0x199F950 VA: 0x1819A1350
	public static bool pressedWithinRect(Rect rect) { }

	// RVA: 0x19A01B0 Offset: 0x199E7B0 VA: 0x1819A01B0
	public static bool checkWithinRect(Vector2 vec2, Rect rect) { }

	// RVA: 0x19A09E0 Offset: 0x199EFE0 VA: 0x1819A09E0
	public static Vector2 firstTouch() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x199FFF0 Offset: 0x199E5F0 VA: 0x18199FFF0
	private static void .cctor() { }

}

public enum LTGUI.Element_Type // TypeDefIndex: 5588
{	// Fields
	public int value__; // 0x0
	public const LTGUI.Element_Type Texture = 0;
	public const LTGUI.Element_Type Label = 1;

}

