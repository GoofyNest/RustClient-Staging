public class SpawnPopulation : BaseScriptableObject // TypeDefIndex: 9995
{	[HeaderAttribute] // RVA: 0xAC240 Offset: 0xAB640 VA: 0x1800AC240
	public string ResourceFolder; // 0x20
	public GameObjectRef[] ResourceList; // 0x28
	[HeaderAttribute] // RVA: 0xAC2D0 Offset: 0xAB6D0 VA: 0x1800AC2D0
	[TooltipAttribute] // RVA: 0xAC2D0 Offset: 0xAB6D0 VA: 0x1800AC2D0
	[SerializeField] // RVA: 0xAC2D0 Offset: 0xAB6D0 VA: 0x1800AC2D0
	[FormerlySerializedAsAttribute] // RVA: 0xAC2D0 Offset: 0xAB6D0 VA: 0x1800AC2D0
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

	public virtual float TargetDensity { get; }


	public virtual float get_TargetDensity() { }

	public void .ctor() { }

}

