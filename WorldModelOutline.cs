public class WorldModelOutline : OutlineObject // TypeDefIndex: 10095
{	// Fields
	private CoverageQueries.Query query; // 0x30
	private const float coverageRadius = 0,06;
	private float currentOcclusion; // 0x38

	// Methods

	// RVA: 0x901610 Offset: 0x8FFC10 VA: 0x180901610 Slot: 7
	public override Color GetColor() { }

	// RVA: 0x901AE0 Offset: 0x9000E0 VA: 0x180901AE0
	public void OnEnable() { }

	// RVA: 0x901A50 Offset: 0x900050 VA: 0x180901A50
	public void OnDisable() { }

	// RVA: 0x9015E0 Offset: 0x8FFBE0 VA: 0x1809015E0 Slot: 5
	public override void BecomeVisible() { }

	// RVA: 0x9015D0 Offset: 0x8FFBD0 VA: 0x1809015D0 Slot: 6
	public override void BecomeInvisible() { }

	// RVA: 0x901F50 Offset: 0x900550 VA: 0x180901F50 Slot: 9
	public override bool ShouldDisplay() { }

	// RVA: 0x9019A0 Offset: 0x8FFFA0 VA: 0x1809019A0 Slot: 10
	public virtual float GetSmoothOcclusion() { }

	// RVA: 0x901C00 Offset: 0x900200 VA: 0x180901C00 Slot: 11
	public virtual float SampleOcclusion() { }

	// RVA: 0x901E70 Offset: 0x900470 VA: 0x180901E70 Slot: 4
	public override float SampleVisibility() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

