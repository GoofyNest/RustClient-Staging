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

	// RVA: 0x10BF9B0 Offset: 0x10BDFB0 VA: 0x1810BF9B0
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x10BF330 Offset: 0x10BD930 VA: 0x1810BF330
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x10BF440 Offset: 0x10BDA40 VA: 0x1810BF440
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x10BF530 Offset: 0x10BDB30 VA: 0x1810BF530
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0xC6BA20 Offset: 0xC6A020 VA: 0x180C6BA20
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x10BF6A0 Offset: 0x10BDCA0 VA: 0x1810BF6A0
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x10BF5C0 Offset: 0x10BDBC0 VA: 0x1810BF5C0
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x10BCE10 Offset: 0x10BB410 VA: 0x1810BCE10
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x10BA9A0 Offset: 0x10B8FA0 VA: 0x1810BA9A0
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x10BE900 Offset: 0x10BCF00 VA: 0x1810BE900
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x10BC5A0 Offset: 0x10BABA0 VA: 0x1810BC5A0
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x10BD070 Offset: 0x10BB670 VA: 0x1810BD070
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x10BDF60 Offset: 0x10BC560 VA: 0x1810BDF60
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x10BD9E0 Offset: 0x10BBFE0 VA: 0x1810BD9E0
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x10BEB00 Offset: 0x10BD100 VA: 0x1810BEB00
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x10BC6D0 Offset: 0x10BACD0 VA: 0x1810BC6D0
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x10BAE50 Offset: 0x10B9450 VA: 0x1810BAE50
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x10BD1A0 Offset: 0x10BB7A0 VA: 0x1810BD1A0
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x10BF790 Offset: 0x10BDD90 VA: 0x1810BF790
	private static void .cctor() { }

}

private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 4919
{	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x2B115BC

	// Methods

	// RVA: 0x10BFA10 Offset: 0x10BE010 VA: 0x1810BFA10 Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10BFA80 Offset: 0x10BE080 VA: 0x1810BFA80
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

