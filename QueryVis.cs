public class QueryVis : BaseMonoBehaviour, IClientComponent, IOnParentDestroying // TypeDefIndex: 9225
{	// Fields
	public Collider checkCollider; // 0x18
	private CoverageQueries.Query query; // 0x20
	public CoverageQueries.RadiusSpace coverageRadiusSpace; // 0x28
	public float coverageRadius; // 0x2C
	private float nextCPUSampleTime; // 0x30
	private float lastCPUSampleValue; // 0x34

	// Methods

	// RVA: 0x69ADC0 Offset: 0x6993C0 VA: 0x18069ADC0
	public void OnEnable() { }

	// RVA: 0x69ADA0 Offset: 0x6993A0 VA: 0x18069ADA0
	public void OnDisable() { }

	// RVA: 0x69B280 Offset: 0x699880 VA: 0x18069B280
	public float SampleVisibility() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public void OnParentDestroying() { }

	// RVA: 0x69AF10 Offset: 0x699510 VA: 0x18069AF10
	public float SampleVisibilityCPU() { }

	// RVA: 0x69B390 Offset: 0x699990 VA: 0x18069B390
	public void .ctor() { }

}

