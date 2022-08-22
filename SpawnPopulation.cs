public class SpawnPopulation : BaseScriptableObject // TypeDefIndex: 9995
{	// Fields
	[HeaderAttribute] // RVA: 0xAC840 Offset: 0xABC40 VA: 0x1800AC840
	public string ResourceFolder; // 0x20
	public GameObjectRef[] ResourceList; // 0x28
	[HeaderAttribute] // RVA: 0xAC990 Offset: 0xABD90 VA: 0x1800AC990
	[TooltipAttribute] // RVA: 0xAC990 Offset: 0xABD90 VA: 0x1800AC990
	[SerializeField] // RVA: 0xAC990 Offset: 0xABD90 VA: 0x1800AC990
	[FormerlySerializedAsAttribute] // RVA: 0xAC990 Offset: 0xABD90 VA: 0x1800AC990
	private float _targetDensity; // 0x30
	public float SpawnRate; // 0x34
	public int ClusterSizeMin; // 0x38
	public int ClusterSizeMax; // 0x3C
	public int ClusterDithering; // 0x40
	public int SpawnAttemptsInitial; // 0x44
	public int SpawnAttemptsRepeating; // 0x48
	public bool EnforcePopulationLimits; // 0x4C
	public bool ScaleWithLargeMaps; // 0x4D
	public bool ScaleWithSpawnFilter; // 0x4E
	public bool ScaleWithServerPopulation; // 0x4F
	public bool AlignToNormal; // 0x50
	public SpawnFilter Filter; // 0x58
	public float FilterCutoff; // 0x60

	// Properties
	public virtual float TargetDensity { get; }

	// Methods

	// RVA: 0x6BB9D0 Offset: 0x6B9FD0 VA: 0x1806BB9D0 Slot: 4
	public virtual float get_TargetDensity() { }

	// RVA: 0xA7E340 Offset: 0xA7C940 VA: 0x180A7E340
	public void .ctor() { }

}

