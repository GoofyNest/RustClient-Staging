public class WorldModelOutline : OutlineObject // TypeDefIndex: 10095
{	// Fields
	private CoverageQueries.Query query; // 0x30
	private const float coverageRadius = 0,06;
	private float currentOcclusion; // 0x38

	// Methods

	// RVA: 0x901720 Offset: 0x8FFD20 VA: 0x180901720 Slot: 7
	public override Color GetColor() { }

	// RVA: 0x901BF0 Offset: 0x9001F0 VA: 0x180901BF0
	public void OnEnable() { }

	// RVA: 0x901B60 Offset: 0x900160 VA: 0x180901B60
	public void OnDisable() { }

	// RVA: 0x9016F0 Offset: 0x8FFCF0 VA: 0x1809016F0 Slot: 5
	public override void BecomeVisible() { }

	// RVA: 0x9016E0 Offset: 0x8FFCE0 VA: 0x1809016E0 Slot: 6
	public override void BecomeInvisible() { }

	// RVA: 0x902060 Offset: 0x900660 VA: 0x180902060 Slot: 9
	public override bool ShouldDisplay() { }

	// RVA: 0x901AB0 Offset: 0x9000B0 VA: 0x180901AB0 Slot: 10
	public virtual float GetSmoothOcclusion() { }

	// RVA: 0x901D10 Offset: 0x900310 VA: 0x180901D10 Slot: 11
	public virtual float SampleOcclusion() { }

	// RVA: 0x901F80 Offset: 0x900580 VA: 0x180901F80 Slot: 4
	public override float SampleVisibility() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

