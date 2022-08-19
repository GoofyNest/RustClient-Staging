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

	// RVA: 0x988D20 Offset: 0x987320 VA: 0x180988D20
	private Gradient get_ColourGradient() { }

	// RVA: 0x988290 Offset: 0x986890 VA: 0x180988290 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x988380 Offset: 0x986980 VA: 0x180988380 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x988760 Offset: 0x986D60 VA: 0x180988760 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x988460 Offset: 0x986A60 VA: 0x180988460 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 163
	public override bool get_ShowPatternOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 164
	public override bool get_ShowGradientOption() { }

	// RVA: 0x988700 Offset: 0x986D00 VA: 0x180988700 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x988420 Offset: 0x986A20 VA: 0x180988420
	private float GetCurrentVolumeSensitivity() { }

	// RVA: 0x9883F0 Offset: 0x9869F0 VA: 0x1809883F0
	private float GetCurrentSpeed() { }

	// RVA: 0x988CB0 Offset: 0x9872B0 VA: 0x180988CB0
	public void .ctor() { }

}

