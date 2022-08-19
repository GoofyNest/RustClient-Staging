public class XMasRefill : BaseEntity // TypeDefIndex: 8668
{	// Fields
	public GameObjectRef[] giftPrefabs; // 0x168
	public List<BasePlayer> goodKids; // 0x170
	public List<Stocking> stockings; // 0x178
	public AudioSource bells; // 0x180

	// Methods

	// RVA: 0x1AA1C00 Offset: 0x1AA0200 VA: 0x181AA1C00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1AA1FD0 Offset: 0x1AA05D0 VA: 0x181AA1FD0
	public void PlayBells() { }

	// RVA: 0x1AA2000 Offset: 0x1AA0600 VA: 0x181AA2000
	public void .ctor() { }

}

