public class BaseLauncher : BaseProjectile // TypeDefIndex: 8521
{	// Fields
	private int lastSpectatorReloadAmmo; // 0x378
	private TimeSince lastSpectatorAmmoInsert; // 0x37C

	// Methods

	// RVA: 0xA42830 Offset: 0xA40E30 VA: 0x180A42830 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA42390 Offset: 0xA40990 VA: 0x180A42390 Slot: 172
	public override void LaunchProjectile() { }

	// RVA: 0xA42700 Offset: 0xA40D00 VA: 0x180A42700 Slot: 137
	public override void OnFrame() { }

	// RVA: 0xA42920 Offset: 0xA40F20 VA: 0x180A42920 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA42AC0 Offset: 0xA410C0 VA: 0x180A42AC0
	private void SpectatorInsertAmmo() { }

	// RVA: 0x51E730 Offset: 0x51CD30 VA: 0x18051E730
	public void .ctor() { }

}

