public class IndividualSpawner : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 10002
{	public GameObjectRef entityPrefab; // 0x18
	public float respawnDelayMin; // 0x20
	public float respawnDelayMax; // 0x24
	public bool useCustomBoundsCheckMask; // 0x28
	public LayerMask customBoundsCheckMask; // 0x2C
	[TooltipAttribute] // RVA: 0xAC930 Offset: 0xABD30 VA: 0x1800AC930
	[SerializeField] // RVA: 0xAC930 Offset: 0xABD30 VA: 0x1800AC930
	private bool oneTimeSpawner; // 0x30


	public void .ctor() { }

}

