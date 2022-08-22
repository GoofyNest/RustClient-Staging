public class ReclaimBackpack : StorageContainer // TypeDefIndex: 8741
{	// Fields
	public int reclaimID; // 0x3D0
	public ulong playerSteamID; // 0x3D8
	public bool onlyOwnerLoot; // 0x3E0
	public Collider myCollider; // 0x3E8
	public GameObject art; // 0x3F0

	// Methods

	// RVA: 0x6AC500 Offset: 0x6AAB00 VA: 0x1806AC500 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6AC320 Offset: 0x6AA920 VA: 0x1806AC320
	private bool BelongsToLocalPlayer() { }

	// RVA: 0x6AC570 Offset: 0x6AAB70 VA: 0x1806AC570 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x6AC4A0 Offset: 0x6AAAA0 VA: 0x1806AC4A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6AC5A0 Offset: 0x6AABA0 VA: 0x1806AC5A0
	public void .ctor() { }

}

