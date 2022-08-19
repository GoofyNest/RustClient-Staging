public class RgbEffects : SingletonComponent<RgbEffects> // TypeDefIndex: 10706
{	// Fields
	[ClientVar] // RVA: 0x72460 Offset: 0x71860 VA: 0x180072460
	public static bool Enabled; // 0x0
	[ClientVar] // RVA: 0x73950 Offset: 0x72D50 VA: 0x180073950
	public static Vector3 ColorCorrection_SteelSeries; // 0x4
	[ClientVar] // RVA: 0x73B00 Offset: 0x72F00 VA: 0x180073B00
	public static Vector3 ColorCorrection_Razer; // 0x10
	[ClientVar] // RVA: 0x73B40 Offset: 0x72F40 VA: 0x180073B40
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

	// RVA: 0x4C5690 Offset: 0x4C3C90 VA: 0x1804C5690
	public void OnEnable() { }

	// RVA: 0x4C5600 Offset: 0x4C3C00 VA: 0x1804C5600
	public void OnDisable() { }

	// RVA: 0x4C5F20 Offset: 0x4C4520 VA: 0x1804C5F20
	private void UpdateLighting() { }

	// RVA: 0x4C4E20 Offset: 0x4C3420 VA: 0x1804C4E20
	private void CopyColorCorrection() { }

	// RVA: 0x4C5C40 Offset: 0x4C4240 VA: 0x1804C5C40
	private void SetStaticColor(Color color, bool force = False) { }

	// RVA: 0x4C57E0 Offset: 0x4C3DE0 VA: 0x1804C57E0
	private void PulseColor(RgbColor color, float duration) { }

	// RVA: 0x4C5190 Offset: 0x4C3790 VA: 0x1804C5190
	private Color GetColor(RgbColor color) { }

	// RVA: 0x4C5710 Offset: 0x4C3D10 VA: 0x1804C5710
	private static Color PreprocessColor(Color color) { }

	// RVA: 0x4C5E20 Offset: 0x4C4420 VA: 0x1804C5E20
	public static void Static(RgbColor color) { }

	// RVA: 0x4C59B0 Offset: 0x4C3FB0 VA: 0x1804C59B0
	public static void Pulse(RgbColor color, float duration = 0,5) { }

	// RVA: 0x4C50A0 Offset: 0x4C36A0 VA: 0x1804C50A0
	public static void Event(RgbEventType type) { }

	// RVA: 0x4C5010 Offset: 0x4C3610 VA: 0x1804C5010
	public static void DamagePulse(DamageType type) { }

	// RVA: 0x4C52A0 Offset: 0x4C38A0 VA: 0x1804C52A0
	private static RgbColor GetCurrentBackground() { }

	// RVA: 0x4C53A0 Offset: 0x4C39A0 VA: 0x1804C53A0
	private static Nullable<ValueTuple<RgbColor, float>> GetCurrentFlash() { }

	[ClientVar] // RVA: 0x73D40 Offset: 0x73140 VA: 0x180073D40
	[EditorBrowsableAttribute] // RVA: 0x73D40 Offset: 0x73140 VA: 0x180073D40
	// RVA: 0x4C4D00 Offset: 0x4C3300 VA: 0x1804C4D00
	public static void ConVar_Static(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x73ED0 Offset: 0x732D0 VA: 0x180073ED0
	[EditorBrowsableAttribute] // RVA: 0x73ED0 Offset: 0x732D0 VA: 0x180073ED0
	// RVA: 0x4C4AD0 Offset: 0x4C30D0 VA: 0x1804C4AD0
	public static void ConVar_Pulse(ConsoleSystem.Arg args) { }

	// RVA: 0x4C6760 Offset: 0x4C4D60 VA: 0x1804C6760
	public void .ctor() { }

	// RVA: 0x4C6680 Offset: 0x4C4C80 VA: 0x1804C6680
	private static void .cctor() { }

}

