public class GenerateRailMeshes : ProceduralComponent // TypeDefIndex: 10490
{	// Fields
	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = False;
	public Mesh RailMesh; // 0x28
	public Mesh[] RailMeshes; // 0x30
	public Material RailMaterial; // 0x38
	public PhysicMaterial RailPhysicMaterial; // 0x40

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0xC8CF80 Offset: 0xC8B580 VA: 0x180C8CF80 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC8CD20 Offset: 0xC8B320 VA: 0x180C8CD20
	private void AddTrackSpline(PathList rail) { }

	// RVA: 0x57BC40 Offset: 0x57A240 VA: 0x18057BC40
	public void .ctor() { }

}

