public class DiscoFloor : AudioVisualisationEntity // TypeDefIndex: 9439
{	// Fields
	public float GradientDuration; // 0x320
	public float VolumeSensitivityMultiplier; // 0x324
	public float BaseSpeed; // 0x328
	public Light[] LightSources; // 0x330
	public DiscoFloorMesh FloorMesh; // 0x338
	private float currentFloorTime; // 0x340
	private DiscoFloorColourLookups cachedLookups; // 0x348

	// Properties
	private Gradient ColourGradient { get; }
	public override bool ShowPatternOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }
	public override bool ShowGradientOption { get; }

	// Methods

	// RVA: 0x988E30 Offset: 0x987430 VA: 0x180988E30
	private Gradient get_ColourGradient() { }

	// RVA: 0x9883A0 Offset: 0x9869A0 VA: 0x1809883A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x988490 Offset: 0x986A90 VA: 0x180988490 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x988870 Offset: 0x986E70 VA: 0x180988870 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x988570 Offset: 0x986B70 VA: 0x180988570 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 163
	public override bool get_ShowPatternOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 164
	public override bool get_ShowGradientOption() { }

	// RVA: 0x988810 Offset: 0x986E10 VA: 0x180988810 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x988530 Offset: 0x986B30 VA: 0x180988530
	private float GetCurrentVolumeSensitivity() { }

	// RVA: 0x988500 Offset: 0x986B00 VA: 0x180988500
	private float GetCurrentSpeed() { }

	// RVA: 0x988DC0 Offset: 0x9873C0 VA: 0x180988DC0
	public void .ctor() { }

}

