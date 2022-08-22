public static class DefaultControls // TypeDefIndex: 4917
{	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x10C0420 Offset: 0x10BEA20 VA: 0x1810C0420
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x10BFDA0 Offset: 0x10BE3A0 VA: 0x1810BFDA0
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x10BFEB0 Offset: 0x10BE4B0 VA: 0x1810BFEB0
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x10BFFA0 Offset: 0x10BE5A0 VA: 0x1810BFFA0
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0xC6BEF0 Offset: 0xC6A4F0 VA: 0x180C6BEF0
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x10C0110 Offset: 0x10BE710 VA: 0x1810C0110
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x10C0030 Offset: 0x10BE630 VA: 0x1810C0030
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x10BD880 Offset: 0x10BBE80 VA: 0x1810BD880
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x10BB410 Offset: 0x10B9A10 VA: 0x1810BB410
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x10BF370 Offset: 0x10BD970 VA: 0x1810BF370
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x10BD010 Offset: 0x10BB610 VA: 0x1810BD010
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x10BDAE0 Offset: 0x10BC0E0 VA: 0x1810BDAE0
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x10BE9D0 Offset: 0x10BCFD0 VA: 0x1810BE9D0
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x10BE450 Offset: 0x10BCA50 VA: 0x1810BE450
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x10BF570 Offset: 0x10BDB70 VA: 0x1810BF570
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x10BD140 Offset: 0x10BB740 VA: 0x1810BD140
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x10BB8C0 Offset: 0x10B9EC0 VA: 0x1810BB8C0
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x10BDC10 Offset: 0x10BC210 VA: 0x1810BDC10
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x10C0200 Offset: 0x10BE800 VA: 0x1810C0200
	private static void .cctor() { }

}

private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 4919
{	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x1354B

	// Methods

	// RVA: 0x10C0480 Offset: 0x10BEA80 VA: 0x1810C0480 Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10C04F0 Offset: 0x10BEAF0 VA: 0x1810C04F0
	private static void .cctor() { }

}

public struct DefaultControls.Resources // TypeDefIndex: 4920
{	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30

}

