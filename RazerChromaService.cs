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

	// RVA: 0x21C00D0 Offset: 0x21BE6D0 VA: 0x1821C00D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	private void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C01A0 Offset: 0x21BE7A0 VA: 0x1821C01A0 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C01C0 Offset: 0x21BE7C0 VA: 0x1821C01C0 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	// RVA: 0x21BF620 Offset: 0x21BDC20 VA: 0x1821BF620 Slot: 7
	public ValueTask Start() { }

	// RVA: 0x21BFBF0 Offset: 0x21BE1F0 VA: 0x1821BFBF0 Slot: 8
	public ValueTask Stop() { }

	// RVA: 0x21C0000 Offset: 0x21BE600 VA: 0x1821C0000 Slot: 9
	public ValueTask Update() { }

	// RVA: 0x21BFA60 Offset: 0x21BE060 VA: 0x1821BFA60 Slot: 10
	public void StaticColor(Color color) { }

	// RVA: 0x21BF0B0 Offset: 0x21BD6B0 VA: 0x1821BF0B0 Slot: 11
	public void PulseColor(Color color, float duration) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public void Event(RgbEventType type) { }

	// RVA: 0x21BEF20 Offset: 0x21BD520 VA: 0x1821BEF20
	private void CalculateAndRenderColor() { }

	// RVA: 0x21BF2A0 Offset: 0x21BD8A0 VA: 0x1821BF2A0
	private static void SetColor(Color32 color) { }

	// RVA: 0x21BF090 Offset: 0x21BD690 VA: 0x1821BF090
	private static int ColorToInt32(byte r, byte g, byte b) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BFE30 Offset: 0x21BE430 VA: 0x1821BFE30
	internal static void <SetColor>g__EnableEffect|21_0(Guid effectId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BFDA0 Offset: 0x21BE3A0 VA: 0x1821BFDA0
	internal static void <SetColor>g__CheckCreateEffect|21_1(int result) { }

}

