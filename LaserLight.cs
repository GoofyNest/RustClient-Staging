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

	// RVA: 0x689970 Offset: 0x687F70 VA: 0x180689970 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x68A310 Offset: 0x688910 VA: 0x18068A310 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x689B10 Offset: 0x688110 VA: 0x180689B10
	private void GetCurrentVolumeRange(out float min, out float max) { }

	// RVA: 0x689AC0 Offset: 0x6880C0 VA: 0x180689AC0
	private void GetCurrentSpeedRange(out float minSpeed, out float maxSpeed) { }

	// RVA: 0x6899A0 Offset: 0x687FA0 VA: 0x1806899A0
	private LaserLight.ColourSetting GetColourSettings(AudioVisualisationEntity.LightColour colour) { }

	// RVA: 0x689E80 Offset: 0x688480 VA: 0x180689E80 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 160
	public override bool get_ShowColourOption() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x689B60 Offset: 0x688160 VA: 0x180689B60 Slot: 75
	public override void LookingAtTick() { }

	// RVA: 0x689CB0 Offset: 0x6882B0 VA: 0x180689CB0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x68A4D0 Offset: 0x688AD0 VA: 0x18068A4D0
	public void .ctor() { }

	// RVA: 0x68A430 Offset: 0x688A30 VA: 0x18068A430
	private static void .cctor() { }

}

public struct LaserLight.ColourSetting // TypeDefIndex: 9448
{	// Fields
	public Color PointLightColour; // 0x0
	public Material LaserMaterial; // 0x10
	public Color DotColour; // 0x18
	public Color FlareColour; // 0x28

}

