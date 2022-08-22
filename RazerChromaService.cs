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

	// RVA: 0x21BFE10 Offset: 0x21BE410 VA: 0x1821BFE10
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5E0 Offset: 0x4BABE0 VA: 0x1804BC5E0
	private void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BFEE0 Offset: 0x21BE4E0 VA: 0x1821BFEE0 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BFF00 Offset: 0x21BE500 VA: 0x1821BFF00 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	// RVA: 0x21BF360 Offset: 0x21BD960 VA: 0x1821BF360 Slot: 7
	public ValueTask Start() { }

	// RVA: 0x21BF930 Offset: 0x21BDF30 VA: 0x1821BF930 Slot: 8
	public ValueTask Stop() { }

	// RVA: 0x21BFD40 Offset: 0x21BE340 VA: 0x1821BFD40 Slot: 9
	public ValueTask Update() { }

	// RVA: 0x21BF7A0 Offset: 0x21BDDA0 VA: 0x1821BF7A0 Slot: 10
	public void StaticColor(Color color) { }

	// RVA: 0x21BEDF0 Offset: 0x21BD3F0 VA: 0x1821BEDF0 Slot: 11
	public void PulseColor(Color color, float duration) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public void Event(RgbEventType type) { }

	// RVA: 0x21BEC60 Offset: 0x21BD260 VA: 0x1821BEC60
	private void CalculateAndRenderColor() { }

	// RVA: 0x21BEFE0 Offset: 0x21BD5E0 VA: 0x1821BEFE0
	private static void SetColor(Color32 color) { }

	// RVA: 0x21BEDD0 Offset: 0x21BD3D0 VA: 0x1821BEDD0
	private static int ColorToInt32(byte r, byte g, byte b) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BFB70 Offset: 0x21BE170 VA: 0x1821BFB70
	internal static void <SetColor>g__EnableEffect|21_0(Guid effectId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21BFAE0 Offset: 0x21BE0E0 VA: 0x1821BFAE0
	internal static void <SetColor>g__CheckCreateEffect|21_1(int result) { }

}

