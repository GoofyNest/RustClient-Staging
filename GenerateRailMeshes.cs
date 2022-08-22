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

	// RVA: 0xC8D420 Offset: 0xC8BA20 VA: 0x180C8D420 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 4
	public override bool get_RunOnCache() { }

	// RVA: 0xC8D1C0 Offset: 0xC8B7C0 VA: 0x180C8D1C0
	private void AddTrackSpline(PathList rail) { }

	// RVA: 0x57BBD0 Offset: 0x57A1D0 VA: 0x18057BBD0
	public void .ctor() { }

}

