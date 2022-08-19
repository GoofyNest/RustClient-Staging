public class BaseLauncher : BaseProjectile // TypeDefIndex: 8521
{	// Fields
	private int lastSpectatorReloadAmmo; // 0x378
	private TimeSince lastSpectatorAmmoInsert; // 0x37C

	// Methods

	// RVA: 0xA42570 Offset: 0xA40B70 VA: 0x180A42570 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA420D0 Offset: 0xA406D0 VA: 0x180A420D0 Slot: 172
	public override void LaunchProjectile() { }

	// RVA: 0xA42440 Offset: 0xA40A40 VA: 0x180A42440 Slot: 137
	public override void OnFrame() { }

	// RVA: 0xA42660 Offset: 0xA40C60 VA: 0x180A42660 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA42800 Offset: 0xA40E00 VA: 0x180A42800
	private void SpectatorInsertAmmo() { }

	// RVA: 0x51E730 Offset: 0x51CD30 VA: 0x18051E730
	public void .ctor() { }

}

