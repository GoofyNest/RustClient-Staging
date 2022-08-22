public class IndividualSpawner : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 10002
{	// Fields
	public GameObjectRef entityPrefab; // 0x18
	public float respawnDelayMin; // 0x20
	public float respawnDelayMax; // 0x24
	public bool useCustomBoundsCheckMask; // 0x28
	public LayerMask customBoundsCheckMask; // 0x2C
	[TooltipAttribute] // RVA: 0xACF60 Offset: 0xAC360 VA: 0x1800ACF60
	[SerializeField] // RVA: 0xACF60 Offset: 0xAC360 VA: 0x1800ACF60
	private bool oneTimeSpawner; // 0x30

	// Methods

	// RVA: 0x813840 Offset: 0x811E40 VA: 0x180813840
	public void .ctor() { }

}

