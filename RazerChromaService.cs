public class RazerChromaService : IRgbService // TypeDefIndex: 7713
{	// Fields
	private readonly object _syncRoot; // 0x10
	private Color _baseColor; // 0x18
	private Nullable<float> _pulseDuration; // 0x28
	private Color _pulseColor; // 0x30
	private readonly Stopwatch _pulseTimer; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsConnected>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <ColorCorrection>k__BackingField; // 0x4C

	// Properties
	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }

	// Methods

	// RVA: 0x21BFFD0 Offset: 0x21BE5D0 VA: 0x1821BFFD0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	private void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21C00A0 Offset: 0x21BE6A0 VA: 0x1821C00A0 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21C00C0 Offset: 0x21BE6C0 VA: 0x1821C00C0 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	// RVA: 0x21BF520 Offset: 0x21BDB20 VA: 0x1821BF520 Slot: 7
	public ValueTask Start() { }

	// RVA: 0x21BFAF0 Offset: 0x21BE0F0 VA: 0x1821BFAF0 Slot: 8
	public ValueTask Stop() { }

	// RVA: 0x21BFF00 Offset: 0x21BE500 VA: 0x1821BFF00 Slot: 9
	public ValueTask Update() { }

	// RVA: 0x21BF960 Offset: 0x21BDF60 VA: 0x1821BF960 Slot: 10
	public void StaticColor(Color color) { }

	// RVA: 0x21BEFB0 Offset: 0x21BD5B0 VA: 0x1821BEFB0 Slot: 11
	public void PulseColor(Color color, float duration) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public void Event(RgbEventType type) { }

	// RVA: 0x21BEE20 Offset: 0x21BD420 VA: 0x1821BEE20
	private void CalculateAndRenderColor() { }

	// RVA: 0x21BF1A0 Offset: 0x21BD7A0 VA: 0x1821BF1A0
	private static void SetColor(Color32 color) { }

	// RVA: 0x21BEF90 Offset: 0x21BD590 VA: 0x1821BEF90
	private static int ColorToInt32(byte r, byte g, byte b) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21BFD30 Offset: 0x21BE330 VA: 0x1821BFD30
	internal static void <SetColor>g__EnableEffect|21_0(Guid effectId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21BFCA0 Offset: 0x21BE2A0 VA: 0x1821BFCA0
	internal static void <SetColor>g__CheckCreateEffect|21_1(int result) { }

}

