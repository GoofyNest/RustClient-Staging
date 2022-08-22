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

	// RVA: 0xC95380 Offset: 0xC93980 VA: 0x180C95380 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0x57BBD0 Offset: 0x57A1D0 VA: 0x18057BBD0
	public void .ctor() { }

}

