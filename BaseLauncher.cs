public class BaseLauncher : BaseProjectile // TypeDefIndex: 8521
{	// Fields
	private int lastSpectatorReloadAmmo; // 0x378
	private TimeSince lastSpectatorAmmoInsert; // 0x37C

	// Methods

	// RVA: 0xA42D20 Offset: 0xA41320 VA: 0x180A42D20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA42880 Offset: 0xA40E80 VA: 0x180A42880 Slot: 172
	public override void LaunchProjectile() { }

	// RVA: 0xA42BF0 Offset: 0xA411F0 VA: 0x180A42BF0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0xA42E10 Offset: 0xA41410 VA: 0x180A42E10 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA42FB0 Offset: 0xA415B0 VA: 0x180A42FB0
	private void SpectatorInsertAmmo() { }

	// RVA: 0x51E6C0 Offset: 0x51CCC0 VA: 0x18051E6C0
	public void .ctor() { }

}

