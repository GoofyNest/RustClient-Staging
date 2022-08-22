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

	// RVA: 0x10BF6F0 Offset: 0x10BDCF0 VA: 0x1810BF6F0
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x10BF070 Offset: 0x10BD670 VA: 0x1810BF070
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x10BF180 Offset: 0x10BD780 VA: 0x1810BF180
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x10BF270 Offset: 0x10BD870 VA: 0x1810BF270
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0xC6B760 Offset: 0xC69D60 VA: 0x180C6B760
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x10BF3E0 Offset: 0x10BD9E0 VA: 0x1810BF3E0
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x10BF300 Offset: 0x10BD900 VA: 0x1810BF300
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x10BCB50 Offset: 0x10BB150 VA: 0x1810BCB50
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x10BA6E0 Offset: 0x10B8CE0 VA: 0x1810BA6E0
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x10BE640 Offset: 0x10BCC40 VA: 0x1810BE640
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x10BC2E0 Offset: 0x10BA8E0 VA: 0x1810BC2E0
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x10BCDB0 Offset: 0x10BB3B0 VA: 0x1810BCDB0
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x10BDCA0 Offset: 0x10BC2A0 VA: 0x1810BDCA0
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x10BD720 Offset: 0x10BBD20 VA: 0x1810BD720
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x10BE840 Offset: 0x10BCE40 VA: 0x1810BE840
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x10BC410 Offset: 0x10BAA10 VA: 0x1810BC410
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x10BAB90 Offset: 0x10B9190 VA: 0x1810BAB90
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x10BCEE0 Offset: 0x10BB4E0 VA: 0x1810BCEE0
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x10BF4D0 Offset: 0x10BDAD0 VA: 0x1810BF4D0
	private static void .cctor() { }

}

private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 4919
{	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x2B1057C

	// Methods

	// RVA: 0x10BF750 Offset: 0x10BDD50 VA: 0x1810BF750 Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x10BF7C0 Offset: 0x10BDDC0 VA: 0x1810BF7C0
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

