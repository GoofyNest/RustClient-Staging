public class CardReader : IOEntity // TypeDefIndex: 8543
{	// Fields
	public float accessDuration; // 0x288
	public int accessLevel; // 0x28C
	public GameObjectRef accessGrantedEffect; // 0x290
	public GameObjectRef accessDeniedEffect; // 0x298
	public GameObjectRef swipeEffect; // 0x2A0
	public Transform audioPosition; // 0x2A8
	public BaseEntity.Flags AccessLevel1; // 0x2B0
	public BaseEntity.Flags AccessLevel2; // 0x2B4
	public BaseEntity.Flags AccessLevel3; // 0x2B8

	// Methods

	// RVA: 0x6FE760 Offset: 0x6FCD60 VA: 0x1806FE760 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x6FE6F0 Offset: 0x6FCCF0 VA: 0x1806FE6F0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6FE5A0 Offset: 0x6FCBA0 VA: 0x1806FE5A0
	public void ClientCardSwiped(Keycard card) { }

	// RVA: 0x6FE850 Offset: 0x6FCE50 VA: 0x1806FE850
	public void .ctor() { }

}

