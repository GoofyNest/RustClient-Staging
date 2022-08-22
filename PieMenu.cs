public class PieMenu : UIBehaviour // TypeDefIndex: 11194
{	// Fields
	public static PieMenu Instance; // 0x0
	public Image middleBox; // 0x18
	public PieShape pieBackgroundBlur; // 0x20
	public PieShape pieBackground; // 0x28
	public PieShape pieSelection; // 0x30
	public GameObject pieOptionPrefab; // 0x38
	public GameObject optionsCanvas; // 0x40
	public PieMenu.MenuOption[] options; // 0x48
	public GameObject scaleTarget; // 0x50
	public float sliceGaps; // 0x58
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float outerSize; // 0x5C
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float innerSize; // 0x60
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float iconSize; // 0x64
	[RangeAttribute] // RVA: 0x9F1C0 Offset: 0x9E5C0 VA: 0x18009F1C0
	public float startRadius; // 0x68
	[RangeAttribute] // RVA: 0x9F1C0 Offset: 0x9E5C0 VA: 0x18009F1C0
	public float radiusSize; // 0x6C
	public Image middleImage; // 0x70
	public TextMeshProUGUI middleTitle; // 0x78
	public TextMeshProUGUI middleDesc; // 0x80
	public TextMeshProUGUI middleRequired; // 0x88
	public Color colorIconActive; // 0x90
	public Color colorIconHovered; // 0xA0
	public Color colorIconDisabled; // 0xB0
	public Color colorBackgroundDisabled; // 0xC0
	public SoundDefinition clipOpen; // 0xD0
	public SoundDefinition clipCancel; // 0xD8
	public SoundDefinition clipChanged; // 0xE0
	public SoundDefinition clipSelected; // 0xE8
	public PieMenu.MenuOption defaultOption; // 0xF0
	private bool isClosing; // 0xF8
	private CanvasGroup canvasGroup; // 0x100
	public bool IsOpen; // 0x108
	public Material IconMaterial; // 0x110
	internal PieMenu.MenuOption selectedOption; // 0x118
	private static Color pieSelectionColor; // 0x8
	private static Color middleImageColor; // 0x18
	private static AnimationCurve easePunch; // 0x28

	// Methods

	// RVA: 0x90B840 Offset: 0x909E40 VA: 0x18090B840 Slot: 6
	protected override void Start() { }

	// RVA: 0x90A7B0 Offset: 0x908DB0 VA: 0x18090A7B0
	public void Clear() { }

	// RVA: 0x90A720 Offset: 0x908D20 VA: 0x18090A720
	public void AddOption(PieMenu.MenuOption option) { }

	// RVA: 0x90ABD0 Offset: 0x9091D0 VA: 0x18090ABD0
	public void FinishAndOpen() { }

	// RVA: 0x90AF20 Offset: 0x909520 VA: 0x18090AF20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x90B760 Offset: 0x909D60 VA: 0x18090B760
	public void SetDefaultOption() { }

	// RVA: 0x90AF80 Offset: 0x909580 VA: 0x18090AF80
	public void PlayOpenSound() { }

	// RVA: 0x90AF40 Offset: 0x909540 VA: 0x18090AF40
	public void PlayCancelSound() { }

	// RVA: 0x90A800 Offset: 0x908E00 VA: 0x18090A800
	public void Close(bool success = False) { }

	// RVA: 0x90CB50 Offset: 0x90B150 VA: 0x18090CB50
	private void Update() { }

	// RVA: 0x90AFC0 Offset: 0x9095C0 VA: 0x18090AFC0
	public void Rebuild() { }

	// RVA: 0x90B950 Offset: 0x909F50 VA: 0x18090B950
	public void UpdateInteraction(bool allowLerp = True) { }

	// RVA: 0x90AA90 Offset: 0x909090 VA: 0x18090AA90
	public bool DoSelect() { }

	// RVA: 0x90D1A0 Offset: 0x90B7A0 VA: 0x18090D1A0
	public void .ctor() { }

	// RVA: 0x90CCC0 Offset: 0x90B2C0 VA: 0x18090CCC0
	private static void .cctor() { }

}

public class PieMenu.MenuOption // TypeDefIndex: 11195
{	// Fields
	public string name; // 0x10
	public string desc; // 0x18
	public string requirements; // 0x20
	public Sprite sprite; // 0x28
	public bool disabled; // 0x30
	public int order; // 0x34
	public Nullable<PieMenu.MenuOption.ColorMode> overrideColorMode; // 0x38
	public Action<BasePlayer> action; // 0x50
	public PieOption option; // 0x58
	public bool selected; // 0x60
	public bool allowMerge; // 0x61
	public bool wantsMerge; // 0x62

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct PieMenu.MenuOption.ColorMode // TypeDefIndex: 11196
{	// Fields
	public PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption Mode; // 0x0
	public Color CustomColor; // 0x4

}

public enum PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption // TypeDefIndex: 11197
{	// Fields
	public int value__; // 0x0
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption CustomColor = 0;
	public const PieMenu.MenuOption.ColorMode.PieMenuSpriteColorOption SpriteColor = 1;

}

private sealed class PieMenu.<>c // TypeDefIndex: 11198
{	// Fields
	public static readonly PieMenu.<>c <>9; // 0x0
	public static Func<PieMenu.MenuOption, int> <>9__43_0; // 0x8
	public static Func<PieMenu.MenuOption, bool> <>9__43_1; // 0x10

	// Methods

	// RVA: 0x920CD0 Offset: 0x91F2D0 VA: 0x180920CD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7491F0 Offset: 0x7477F0 VA: 0x1807491F0
	internal int <Rebuild>b__43_0(PieMenu.MenuOption x) { }

	// RVA: 0x920A20 Offset: 0x91F020 VA: 0x180920A20
	internal bool <Rebuild>b__43_1(PieMenu.MenuOption x) { }

}

