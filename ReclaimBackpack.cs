public class ReclaimBackpack : StorageContainer // TypeDefIndex: 8741
{	// Fields
	public int reclaimID; // 0x3D0
	public ulong playerSteamID; // 0x3D8
	public bool onlyOwnerLoot; // 0x3E0
	public Collider myCollider; // 0x3E8
	public GameObject art; // 0x3F0

	// Methods

	// RVA: 0x6AC460 Offset: 0x6AAA60 VA: 0x1806AC460 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6AC280 Offset: 0x6AA880 VA: 0x1806AC280
	private bool BelongsToLocalPlayer() { }

	// RVA: 0x6AC4D0 Offset: 0x6AAAD0 VA: 0x1806AC4D0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x6AC400 Offset: 0x6AAA00 VA: 0x1806AC400 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6AC500 Offset: 0x6AAB00 VA: 0x1806AC500
	public void .ctor() { }

}

