public class ReclaimBackpack : StorageContainer // TypeDefIndex: 10467
{
	public int reclaimID;
	public ulong playerSteamID;
	public bool onlyOwnerLoot;
	public Collider myCollider;
	public GameObject art;


	public override void Load(BaseNetworkable.LoadInfo info) { }

	private bool BelongsToLocalPlayer() { }

	public override bool ShouldShowLootMenus() { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

}

