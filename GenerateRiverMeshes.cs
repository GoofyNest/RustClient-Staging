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

	// RVA: 0xC922C0 Offset: 0xC908C0 VA: 0x180C922C0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0x57BC40 Offset: 0x57A240 VA: 0x18057BC40
	public void .ctor() { }

}

