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

	// RVA: 0x19A0E10 Offset: 0x199F410 VA: 0x1819A0E10
	public static void init() { }

	// RVA: 0x19A0C30 Offset: 0x199F230 VA: 0x1819A0C30
	public static void initRectCheck() { }

	// RVA: 0x19A12B0 Offset: 0x199F8B0 VA: 0x1819A12B0
	public static void reset() { }

	// RVA: 0x19A1640 Offset: 0x199FC40 VA: 0x1819A1640
	public static void update(int updateLevel) { }

	// RVA: 0x199FDE0 Offset: 0x199E3E0 VA: 0x18199FDE0
	public static bool checkOnScreen(Rect rect) { }

	// RVA: 0x19A00D0 Offset: 0x199E6D0 VA: 0x1819A00D0
	public static void destroy(int id) { }

	// RVA: 0x199FFB0 Offset: 0x199E5B0 VA: 0x18199FFB0
	public static void destroyAll(int depth) { }

	// RVA: 0x19A0F90 Offset: 0x199F590 VA: 0x1819A0F90
	public static LTRect label(Rect rect, string label, int depth) { }

	// RVA: 0x19A0F00 Offset: 0x199F500 VA: 0x1819A0F00
	public static LTRect label(LTRect rect, string label, int depth) { }

	// RVA: 0x19A1540 Offset: 0x199FB40 VA: 0x1819A1540
	public static LTRect texture(Rect rect, Texture texture, int depth) { }

	// RVA: 0x19A14A0 Offset: 0x199FAA0 VA: 0x1819A14A0
	public static LTRect texture(LTRect rect, Texture texture, int depth) { }

	// RVA: 0x19A02B0 Offset: 0x199E8B0 VA: 0x1819A02B0
	public static LTRect element(LTRect rect, int depth) { }

	// RVA: 0x19A0820 Offset: 0x199EE20 VA: 0x1819A0820
	public static bool hasNoOverlap(Rect rect, int depth) { }

	// RVA: 0x19A1090 Offset: 0x199F690 VA: 0x1819A1090
	public static bool pressedWithinRect(Rect rect) { }

	// RVA: 0x199FEF0 Offset: 0x199E4F0 VA: 0x18199FEF0
	public static bool checkWithinRect(Vector2 vec2, Rect rect) { }

	// RVA: 0x19A0720 Offset: 0x199ED20 VA: 0x1819A0720
	public static Vector2 firstTouch() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x199FD30 Offset: 0x199E330 VA: 0x18199FD30
	private static void .cctor() { }

}

public enum LTGUI.Element_Type // TypeDefIndex: 5588
{	// Fields
	public int value__; // 0x0
	public const LTGUI.Element_Type Texture = 0;
	public const LTGUI.Element_Type Label = 1;

}

