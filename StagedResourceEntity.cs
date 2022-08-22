public class StagedResourceEntity : ResourceEntity // TypeDefIndex: 8650
{	// Fields
	public List<StagedResourceEntity.ResourceStage> stages; // 0x180
	public int stage; // 0x188
	public GameObjectRef changeStageEffect; // 0x190
	public GameObject gibSourceTest; // 0x198

	// Methods

	// RVA: 0xA8AAF0 Offset: 0xA890F0 VA: 0x180A8AAF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8AA50 Offset: 0xA89050 VA: 0x180A8AA50 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA8AFC0 Offset: 0xA895C0 VA: 0x180A8AFC0
	public void RunChangeEffect() { }

	// RVA: 0xA8AA30 Offset: 0xA89030 VA: 0x180A8AA30 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8AF70 Offset: 0xA89570 VA: 0x180A8AF70
	private void ResourceUpdate(BaseEntity.RPCMessage packet) { }

	// RVA: -1 Offset: -1
	public T GetStageComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D20 Offset: 0x5D2320 VA: 0x1805D3D20
	|-StagedResourceEntity.GetStageComponent<object>
	|-StagedResourceEntity.GetStageComponent<MeshRenderer>
	*/

	// RVA: 0xA8B0F0 Offset: 0xA896F0 VA: 0x180A8B0F0
	private void UpdateStage() { }

	// RVA: 0xA8B2E0 Offset: 0xA898E0 VA: 0x180A8B2E0
	public void .ctor() { }

}

public class StagedResourceEntity.ResourceStage // TypeDefIndex: 8651
{	// Fields
	public float health; // 0x10
	public GameObject instance; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

