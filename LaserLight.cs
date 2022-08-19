public class LaserLight : AudioVisualisationEntity // TypeDefIndex: 9447
{	// Fields
	public Animator LaserAnimator; // 0x320
	public LineRenderer[] LineRenderers; // 0x328
	public MeshRenderer[] DotRenderers; // 0x330
	public MeshRenderer FlareRenderer; // 0x338
	public Light[] LightSources; // 0x340
	public LaserLight.ColourSetting RedSettings; // 0x348
	public LaserLight.ColourSetting GreenSettings; // 0x380
	public LaserLight.ColourSetting BlueSettings; // 0x3B8
	public LaserLight.ColourSetting YellowSettings; // 0x3F0
	public LaserLight.ColourSetting PinkSettings; // 0x428
	private static int AnimSpeedParameter; // 0x0
	private static readonly int TintColor; // 0x4
	private static MaterialPropertyBlock laserBlock; // 0x8
	private float lookingAtTime; // 0x460
	private TimeSince lastLookAtTick; // 0x464
	private static bool hasAwardedLookAtAchievement; // 0x10

	// Properties
	public override bool ShowColourOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }

	// Methods

	// RVA: 0x6899E0 Offset: 0x687FE0 VA: 0x1806899E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x68A380 Offset: 0x688980 VA: 0x18068A380 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x689B80 Offset: 0x688180 VA: 0x180689B80
	private void GetCurrentVolumeRange(out float min, out float max) { }

	// RVA: 0x689B30 Offset: 0x688130 VA: 0x180689B30
	private void GetCurrentSpeedRange(out float minSpeed, out float maxSpeed) { }

	// RVA: 0x689A10 Offset: 0x688010 VA: 0x180689A10
	private LaserLight.ColourSetting GetColourSettings(AudioVisualisationEntity.LightColour colour) { }

	// RVA: 0x689EF0 Offset: 0x6884F0 VA: 0x180689EF0 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 160
	public override bool get_ShowColourOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x689BD0 Offset: 0x6881D0 VA: 0x180689BD0 Slot: 75
	public override void LookingAtTick() { }

	// RVA: 0x689D20 Offset: 0x688320 VA: 0x180689D20 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x68A540 Offset: 0x688B40 VA: 0x18068A540
	public void .ctor() { }

	// RVA: 0x68A4A0 Offset: 0x688AA0 VA: 0x18068A4A0
	private static void .cctor() { }

}

public struct LaserLight.ColourSetting // TypeDefIndex: 9448
{	// Fields
	public Color PointLightColour; // 0x0
	public Material LaserMaterial; // 0x10
	public Color DotColour; // 0x18
	public Color FlareColour; // 0x28

}

