public class GenerateRoadMeshes : ProceduralComponent // TypeDefIndex: 10515
{	// Fields
	public const float NormalSmoothing = 0;
	public const bool SnapToTerrain = True;
	public Mesh RoadMesh; // 0x28
	public Mesh[] RoadMeshes; // 0x30
	public Material RoadMaterial; // 0x38
	public Material RoadRingMaterial; // 0x40
	public PhysicMaterial RoadPhysicMaterial; // 0x48

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0xC94EE0 Offset: 0xC934E0 VA: 0x180C94EE0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0x57BC40 Offset: 0x57A240 VA: 0x18057BC40
	public void .ctor() { }

}

