public class QueryVis : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9225
{	// Fields
	public Collider checkCollider; // 0x18
	private CoverageQueries.Query query; // 0x20
	public CoverageQueries.RadiusSpace coverageRadiusSpace; // 0x28
	public float coverageRadius; // 0x2C
	private float nextCPUSampleTime; // 0x30
	private float lastCPUSampleValue; // 0x34

	// Methods

	// RVA: 0x69AED0 Offset: 0x6994D0 VA: 0x18069AED0
	public void OnEnable() { }

	// RVA: 0x69AEB0 Offset: 0x6994B0 VA: 0x18069AEB0
	public void OnDisable() { }

	// RVA: 0x69B390 Offset: 0x699990 VA: 0x18069B390
	public float SampleVisibility() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x69B020 Offset: 0x699620 VA: 0x18069B020
	public float SampleVisibilityCPU() { }

	// RVA: 0x69B4A0 Offset: 0x699AA0 VA: 0x18069B4A0
	public void .ctor() { }

}

