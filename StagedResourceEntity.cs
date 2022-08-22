public class StagedResourceEntity : ResourceEntity // TypeDefIndex: 8650
{	// Fields
	public List<StagedResourceEntity.ResourceStage> stages; // 0x180
	public int stage; // 0x188
	public GameObjectRef changeStageEffect; // 0x190
	public GameObject gibSourceTest; // 0x198

	// Methods

	// RVA: 0xA8A830 Offset: 0xA88E30 VA: 0x180A8A830 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8A790 Offset: 0xA88D90 VA: 0x180A8A790 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA8AD00 Offset: 0xA89300 VA: 0x180A8AD00
	public void RunChangeEffect() { }

	// RVA: 0xA8A770 Offset: 0xA88D70 VA: 0x180A8A770 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8ACB0 Offset: 0xA892B0 VA: 0x180A8ACB0
	private void ResourceUpdate(BaseEntity.RPCMessage packet) { }

	// RVA: -1 Offset: -1
	public T GetStageComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3D20 Offset: 0x5D2320 VA: 0x1805D3D20
	|-StagedResourceEntity.GetStageComponent<object>
	|-StagedResourceEntity.GetStageComponent<MeshRenderer>
	*/

	// RVA: 0xA8AE30 Offset: 0xA89430 VA: 0x180A8AE30
	private void UpdateStage() { }

	// RVA: 0xA8B020 Offset: 0xA89620 VA: 0x180A8B020
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

