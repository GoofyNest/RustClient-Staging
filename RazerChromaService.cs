public class RazerChromaService : IRgbService // TypeDefIndex: 7713
{	// Fields
	private readonly object _syncRoot; // 0x10
	private Color _baseColor; // 0x18
	private Nullable<float> _pulseDuration; // 0x28
	private Color _pulseColor; // 0x30
	private readonly Stopwatch _pulseTimer; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsConnected>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <ColorCorrection>k__BackingField; // 0x4C

	// Properties
	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }

	// Methods

	// RVA: 0x21C08F0 Offset: 0x21BEEF0 VA: 0x1821C08F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC570 Offset: 0x4BAB70 VA: 0x1804BC570
	private void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C09C0 Offset: 0x21BEFC0 VA: 0x1821C09C0 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C09E0 Offset: 0x21BEFE0 VA: 0x1821C09E0 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	// RVA: 0x21BFE40 Offset: 0x21BE440 VA: 0x1821BFE40 Slot: 7
	public ValueTask Start() { }

	// RVA: 0x21C0410 Offset: 0x21BEA10 VA: 0x1821C0410 Slot: 8
	public ValueTask Stop() { }

	// RVA: 0x21C0820 Offset: 0x21BEE20 VA: 0x1821C0820 Slot: 9
	public ValueTask Update() { }

	// RVA: 0x21C0280 Offset: 0x21BE880 VA: 0x1821C0280 Slot: 10
	public void StaticColor(Color color) { }

	// RVA: 0x21BF8D0 Offset: 0x21BDED0 VA: 0x1821BF8D0 Slot: 11
	public void PulseColor(Color color, float duration) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public void Event(RgbEventType type) { }

	// RVA: 0x21BF740 Offset: 0x21BDD40 VA: 0x1821BF740
	private void CalculateAndRenderColor() { }

	// RVA: 0x21BFAC0 Offset: 0x21BE0C0 VA: 0x1821BFAC0
	private static void SetColor(Color32 color) { }

	// RVA: 0x21BF8B0 Offset: 0x21BDEB0 VA: 0x1821BF8B0
	private static int ColorToInt32(byte r, byte g, byte b) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C0650 Offset: 0x21BEC50 VA: 0x1821C0650
	internal static void <SetColor>g__EnableEffect|21_0(Guid effectId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C05C0 Offset: 0x21BEBC0 VA: 0x1821C05C0
	internal static void <SetColor>g__CheckCreateEffect|21_1(int result) { }

}

