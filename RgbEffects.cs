public class RgbEffects : SingletonComponent<RgbEffects> // TypeDefIndex: 10706
{	[ClientVar] // RVA: 0x72600 Offset: 0x71A00 VA: 0x180072600
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


	public void OnEnable() { }

	public void OnDisable() { }

	private void UpdateLighting() { }

	private void CopyColorCorrection() { }

	private void SetStaticColor(Color color, bool force = False) { }

	private void PulseColor(RgbColor color, float duration) { }

	private Color GetColor(RgbColor color) { }

	private static Color PreprocessColor(Color color) { }

	public static void Static(RgbColor color) { }

	public static void Pulse(RgbColor color, float duration = 0,5) { }

	public static void Event(RgbEventType type) { }

	public static void DamagePulse(DamageType type) { }

	private static RgbColor GetCurrentBackground() { }

	private static Nullable<ValueTuple<RgbColor, float>> GetCurrentFlash() { }

	[ClientVar] // RVA: 0x73E60 Offset: 0x73260 VA: 0x180073E60
	[EditorBrowsableAttribute] // RVA: 0x73E60 Offset: 0x73260 VA: 0x180073E60
	public static void ConVar_Static(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x75330 Offset: 0x74730 VA: 0x180075330
	[EditorBrowsableAttribute] // RVA: 0x75330 Offset: 0x74730 VA: 0x180075330
	public static void ConVar_Pulse(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

