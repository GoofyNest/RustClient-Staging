public class RgbEffects : SingletonComponent<RgbEffects> // TypeDefIndex: 10706
{	// Fields
	[ClientVar] // RVA: 0x72600 Offset: 0x71A00 VA: 0x180072600
	public static bool Enabled; // 0x0
	[ClientVar] // RVA: 0x73A70 Offset: 0x72E70 VA: 0x180073A70
	public static Vector3 ColorCorrection_SteelSeries; // 0x4
	[ClientVar] // RVA: 0x73BD0 Offset: 0x72FD0 VA: 0x180073BD0
	public static Vector3 ColorCorrection_Razer; // 0x10
	[ClientVar] // RVA: 0x73CF0 Offset: 0x730F0 VA: 0x180073CF0
	public static float Brightness; // 0x1C
	public Color defaultColor; // 0x18
	public Color buildingPrivilegeColor; // 0x28
	public Color coldColor; // 0x38
	public Color hotColor; // 0x48
	public Color hurtColor; // 0x58
	public Color healedColor; // 0x68
	public Color irradiatedColor; // 0x78
	public Color comfortedColor; // 0x88
	private RgbController _controller; // 0x98
	private readonly Stopwatch _lastStaticSet; // 0xA0
	private Nullable<Color> _lastStatic; // 0xA8
	private readonly Stopwatch _lastPulse; // 0xC0
	private float _lastPulseDuration; // 0xC8

	// Methods

	// RVA: 0x4C5620 Offset: 0x4C3C20 VA: 0x1804C5620
	public void OnEnable() { }

	// RVA: 0x4C5590 Offset: 0x4C3B90 VA: 0x1804C5590
	public void OnDisable() { }

	// RVA: 0x4C5EB0 Offset: 0x4C44B0 VA: 0x1804C5EB0
	private void UpdateLighting() { }

	// RVA: 0x4C4DB0 Offset: 0x4C33B0 VA: 0x1804C4DB0
	private void CopyColorCorrection() { }

	// RVA: 0x4C5BD0 Offset: 0x4C41D0 VA: 0x1804C5BD0
	private void SetStaticColor(Color color, bool force = False) { }

	// RVA: 0x4C5770 Offset: 0x4C3D70 VA: 0x1804C5770
	private void PulseColor(RgbColor color, float duration) { }

	// RVA: 0x4C5120 Offset: 0x4C3720 VA: 0x1804C5120
	private Color GetColor(RgbColor color) { }

	// RVA: 0x4C56A0 Offset: 0x4C3CA0 VA: 0x1804C56A0
	private static Color PreprocessColor(Color color) { }

	// RVA: 0x4C5DB0 Offset: 0x4C43B0 VA: 0x1804C5DB0
	public static void Static(RgbColor color) { }

	// RVA: 0x4C5940 Offset: 0x4C3F40 VA: 0x1804C5940
	public static void Pulse(RgbColor color, float duration = 0,5) { }

	// RVA: 0x4C5030 Offset: 0x4C3630 VA: 0x1804C5030
	public static void Event(RgbEventType type) { }

	// RVA: 0x4C4FA0 Offset: 0x4C35A0 VA: 0x1804C4FA0
	public static void DamagePulse(DamageType type) { }

	// RVA: 0x4C5230 Offset: 0x4C3830 VA: 0x1804C5230
	private static RgbColor GetCurrentBackground() { }

	// RVA: 0x4C5330 Offset: 0x4C3930 VA: 0x1804C5330
	private static Nullable<ValueTuple<RgbColor, float>> GetCurrentFlash() { }

	[ClientVar] // RVA: 0x73E60 Offset: 0x73260 VA: 0x180073E60
	[EditorBrowsableAttribute] // RVA: 0x73E60 Offset: 0x73260 VA: 0x180073E60
	// RVA: 0x4C4C90 Offset: 0x4C3290 VA: 0x1804C4C90
	public static void ConVar_Static(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x75330 Offset: 0x74730 VA: 0x180075330
	[EditorBrowsableAttribute] // RVA: 0x75330 Offset: 0x74730 VA: 0x180075330
	// RVA: 0x4C4A60 Offset: 0x4C3060 VA: 0x1804C4A60
	public static void ConVar_Pulse(ConsoleSystem.Arg args) { }

	// RVA: 0x4C66F0 Offset: 0x4C4CF0 VA: 0x1804C66F0
	public void .ctor() { }

	// RVA: 0x4C6610 Offset: 0x4C4C10 VA: 0x1804C6610
	private static void .cctor() { }

}

