public class ReclaimBackpack : StorageContainer // TypeDefIndex: 8741
{	// Fields
	public int reclaimID; // 0x3D0
	public ulong playerSteamID; // 0x3D8
	public bool onlyOwnerLoot; // 0x3E0
	public Collider myCollider; // 0x3E8
	public GameObject art; // 0x3F0

	// Methods

	// RVA: 0x6AC570 Offset: 0x6AAB70 VA: 0x1806AC570 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6AC390 Offset: 0x6AA990 VA: 0x1806AC390
	private bool BelongsToLocalPlayer() { }

	// RVA: 0x6AC5E0 Offset: 0x6AABE0 VA: 0x1806AC5E0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x6AC510 Offset: 0x6AAB10 VA: 0x1806AC510 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6AC610 Offset: 0x6AAC10 VA: 0x1806AC610
	public void .ctor() { }

}

