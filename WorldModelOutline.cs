public class WorldModelOutline : OutlineObject // TypeDefIndex: 10095
{	// Fields
	private CoverageQueries.Query query; // 0x30
	private const float coverageRadius = 0,06;
	private float currentOcclusion; // 0x38

	// Methods

	// RVA: 0x901C30 Offset: 0x900230 VA: 0x180901C30 Slot: 7
	public override Color GetColor() { }

	// RVA: 0x902100 Offset: 0x900700 VA: 0x180902100
	public void OnEnable() { }

	// RVA: 0x902070 Offset: 0x900670 VA: 0x180902070
	public void OnDisable() { }

	// RVA: 0x901C00 Offset: 0x900200 VA: 0x180901C00 Slot: 5
	public override void BecomeVisible() { }

	// RVA: 0x901BF0 Offset: 0x9001F0 VA: 0x180901BF0 Slot: 6
	public override void BecomeInvisible() { }

	// RVA: 0x902570 Offset: 0x900B70 VA: 0x180902570 Slot: 9
	public override bool ShouldDisplay() { }

	// RVA: 0x901FC0 Offset: 0x9005C0 VA: 0x180901FC0 Slot: 10
	public virtual float GetSmoothOcclusion() { }

	// RVA: 0x902220 Offset: 0x900820 VA: 0x180902220 Slot: 11
	public virtual float SampleOcclusion() { }

	// RVA: 0x902490 Offset: 0x900A90 VA: 0x180902490 Slot: 4
	public override float SampleVisibility() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

