public class QueryVis : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9225
{	// Fields
	public Collider checkCollider; // 0x18
	private CoverageQueries.Query query; // 0x20
	public CoverageQueries.RadiusSpace coverageRadiusSpace; // 0x28
	public float coverageRadius; // 0x2C
	private float nextCPUSampleTime; // 0x30
	private float lastCPUSampleValue; // 0x34

	// Methods

	// RVA: 0x69AE60 Offset: 0x699460 VA: 0x18069AE60
	public void OnEnable() { }

	// RVA: 0x69AE40 Offset: 0x699440 VA: 0x18069AE40
	public void OnDisable() { }

	// RVA: 0x69B320 Offset: 0x699920 VA: 0x18069B320
	public float SampleVisibility() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x69AFB0 Offset: 0x6995B0 VA: 0x18069AFB0
	public float SampleVisibilityCPU() { }

	// RVA: 0x69B430 Offset: 0x699A30 VA: 0x18069B430
	public void .ctor() { }

}

