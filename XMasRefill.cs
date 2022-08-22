public class XMasRefill : BaseEntity // TypeDefIndex: 8668
{	// Fields
	public GameObjectRef[] giftPrefabs; // 0x168
	public List<BasePlayer> goodKids; // 0x170
	public List<Stocking> stockings; // 0x178
	public AudioSource bells; // 0x180

	// Methods

	// RVA: 0x1A8B870 Offset: 0x1A89E70 VA: 0x181A8B870 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A8BC40 Offset: 0x1A8A240 VA: 0x181A8BC40
	public void PlayBells() { }

	// RVA: 0x1A8BC70 Offset: 0x1A8A270 VA: 0x181A8BC70
	public void .ctor() { }

}

