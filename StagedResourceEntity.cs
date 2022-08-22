public class StagedResourceEntity : ResourceEntity // TypeDefIndex: 8650
{	// Fields
	public List<StagedResourceEntity.ResourceStage> stages; // 0x180
	public int stage; // 0x188
	public GameObjectRef changeStageEffect; // 0x190
	public GameObject gibSourceTest; // 0x198

	// Methods

	// RVA: 0xA8AFC0 Offset: 0xA895C0 VA: 0x180A8AFC0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8AF20 Offset: 0xA89520 VA: 0x180A8AF20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA8B490 Offset: 0xA89A90 VA: 0x180A8B490
	public void RunChangeEffect() { }

	// RVA: 0xA8AF00 Offset: 0xA89500 VA: 0x180A8AF00 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8B440 Offset: 0xA89A40 VA: 0x180A8B440
	private void ResourceUpdate(BaseEntity.RPCMessage packet) { }

	// RVA: -1 Offset: -1
	public T GetStageComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3CB0 Offset: 0x5D22B0 VA: 0x1805D3CB0
	|-StagedResourceEntity.GetStageComponent<object>
	|-StagedResourceEntity.GetStageComponent<MeshRenderer>
	*/

	// RVA: 0xA8B5C0 Offset: 0xA89BC0 VA: 0x180A8B5C0
	private void UpdateStage() { }

	// RVA: 0xA8B7B0 Offset: 0xA89DB0 VA: 0x180A8B7B0
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

