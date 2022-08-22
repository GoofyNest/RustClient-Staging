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

	// RVA: 0x989330 Offset: 0x987930 VA: 0x180989330
	private Gradient get_ColourGradient() { }

	// RVA: 0x9888A0 Offset: 0x986EA0 VA: 0x1809888A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x988990 Offset: 0x986F90 VA: 0x180988990 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x988D70 Offset: 0x987370 VA: 0x180988D70 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x988A70 Offset: 0x987070 VA: 0x180988A70 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 163
	public override bool get_ShowPatternOption() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 164
	public override bool get_ShowGradientOption() { }

	// RVA: 0x988D10 Offset: 0x987310 VA: 0x180988D10 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x988A30 Offset: 0x987030 VA: 0x180988A30
	private float GetCurrentVolumeSensitivity() { }

	// RVA: 0x988A00 Offset: 0x987000 VA: 0x180988A00
	private float GetCurrentSpeed() { }

	// RVA: 0x9892C0 Offset: 0x9878C0 VA: 0x1809892C0
	public void .ctor() { }

}

