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

	// RVA: 0x198E4D0 Offset: 0x198CAD0 VA: 0x18198E4D0
	public static void init() { }

	// RVA: 0x198E2F0 Offset: 0x198C8F0 VA: 0x18198E2F0
	public static void initRectCheck() { }

	// RVA: 0x198E970 Offset: 0x198CF70 VA: 0x18198E970
	public static void reset() { }

	// RVA: 0x198ED00 Offset: 0x198D300 VA: 0x18198ED00
	public static void update(int updateLevel) { }

	// RVA: 0x198D4A0 Offset: 0x198BAA0 VA: 0x18198D4A0
	public static bool checkOnScreen(Rect rect) { }

	// RVA: 0x198D790 Offset: 0x198BD90 VA: 0x18198D790
	public static void destroy(int id) { }

	// RVA: 0x198D670 Offset: 0x198BC70 VA: 0x18198D670
	public static void destroyAll(int depth) { }

	// RVA: 0x198E650 Offset: 0x198CC50 VA: 0x18198E650
	public static LTRect label(Rect rect, string label, int depth) { }

	// RVA: 0x198E5C0 Offset: 0x198CBC0 VA: 0x18198E5C0
	public static LTRect label(LTRect rect, string label, int depth) { }

	// RVA: 0x198EC00 Offset: 0x198D200 VA: 0x18198EC00
	public static LTRect texture(Rect rect, Texture texture, int depth) { }

	// RVA: 0x198EB60 Offset: 0x198D160 VA: 0x18198EB60
	public static LTRect texture(LTRect rect, Texture texture, int depth) { }

	// RVA: 0x198D970 Offset: 0x198BF70 VA: 0x18198D970
	public static LTRect element(LTRect rect, int depth) { }

	// RVA: 0x198DEE0 Offset: 0x198C4E0 VA: 0x18198DEE0
	public static bool hasNoOverlap(Rect rect, int depth) { }

	// RVA: 0x198E750 Offset: 0x198CD50 VA: 0x18198E750
	public static bool pressedWithinRect(Rect rect) { }

	// RVA: 0x198D5B0 Offset: 0x198BBB0 VA: 0x18198D5B0
	public static bool checkWithinRect(Vector2 vec2, Rect rect) { }

	// RVA: 0x198DDE0 Offset: 0x198C3E0 VA: 0x18198DDE0
	public static Vector2 firstTouch() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x198D3F0 Offset: 0x198B9F0 VA: 0x18198D3F0
	private static void .cctor() { }

}

public enum LTGUI.Element_Type // TypeDefIndex: 5588
{	// Fields
	public int value__; // 0x0
	public const LTGUI.Element_Type Texture = 0;
	public const LTGUI.Element_Type Label = 1;

}

