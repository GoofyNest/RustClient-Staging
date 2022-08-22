public class GenerateRiverMeshes : ProceduralComponent // TypeDefIndex: 10501
{	// Fields
	public const float NormalSmoothing = 0,1;
	public const bool SnapToTerrain = True;
	public Mesh RiverMesh; // 0x28
	public Mesh[] RiverMeshes; // 0x30
	public Material RiverMaterial; // 0x38
	public PhysicMaterial RiverPhysicMaterial; // 0x40

	// Properties
	public override bool RunOnCache { get; }

	// Methods

	// RVA: 0xC92760 Offset: 0xC90D60 VA: 0x180C92760 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0x57BBD0 Offset: 0x57A1D0 VA: 0x18057BBD0
	public void .ctor() { }

}

