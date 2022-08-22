public class XMasRefill : BaseEntity // TypeDefIndex: 8668
{	// Fields
	public GameObjectRef[] giftPrefabs; // 0x168
	public List<BasePlayer> goodKids; // 0x170
	public List<Stocking> stockings; // 0x178
	public AudioSource bells; // 0x180

	// Methods

	// RVA: 0x1A8BB30 Offset: 0x1A8A130 VA: 0x181A8BB30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A8BF00 Offset: 0x1A8A500 VA: 0x181A8BF00
	public void PlayBells() { }

	// RVA: 0x1A8BF30 Offset: 0x1A8A530 VA: 0x181A8BF30
	public void .ctor() { }

}

