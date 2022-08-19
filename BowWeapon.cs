public class BowWeapon : BaseProjectile // TypeDefIndex: 8535
{	// Fields
	protected bool attackReady; // 0x378
	private float arrowBack; // 0x37C
	private SwapArrows swapArrows; // 0x380
	private bool wasAiming; // 0x388

	// Methods

	// RVA: 0x51E100 Offset: 0x51C700 VA: 0x18051E100 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x51D860 Offset: 0x51BE60 VA: 0x18051D860 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x51E1F0 Offset: 0x51C7F0 VA: 0x18051E1F0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x51E640 Offset: 0x51CC40 VA: 0x18051E640
	public void UpdatePullbackThink() { }

	// RVA: 0x51D7F0 Offset: 0x51BDF0 VA: 0x18051D7F0
	public void CancelPullbackThink() { }

	// RVA: 0x51E500 Offset: 0x51CB00 VA: 0x18051E500
	public void PullbackThink() { }

	// RVA: 0x51DD80 Offset: 0x51C380 VA: 0x18051DD80 Slot: 138
	public override void OnInput() { }

	// RVA: 0x51DD40 Offset: 0x51C340 VA: 0x18051DD40 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x51D8D0 Offset: 0x51BED0 VA: 0x18051D8D0 Slot: 171
	public override void DoAttack() { }

	// RVA: 0x51DB70 Offset: 0x51C170 VA: 0x18051DB70
	public bool IsAiming() { }

	// RVA: 0x51E360 Offset: 0x51C960 VA: 0x18051E360 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x51DC10 Offset: 0x51C210 VA: 0x18051DC10 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x51E3D0 Offset: 0x51C9D0 VA: 0x18051E3D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x51E5D0 Offset: 0x51CBD0 VA: 0x18051E5D0
	private void TryReload() { }

	// RVA: 0x51E470 Offset: 0x51CA70 VA: 0x18051E470 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x51E730 Offset: 0x51CD30 VA: 0x18051E730
	public void .ctor() { }

}

