public class BowWeapon : BaseProjectile // TypeDefIndex: 8535
{	// Fields
	protected bool attackReady; // 0x378
	private float arrowBack; // 0x37C
	private SwapArrows swapArrows; // 0x380
	private bool wasAiming; // 0x388

	// Methods

	// RVA: 0x51E090 Offset: 0x51C690 VA: 0x18051E090 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x51D7F0 Offset: 0x51BDF0 VA: 0x18051D7F0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x51E180 Offset: 0x51C780 VA: 0x18051E180 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x51E5D0 Offset: 0x51CBD0 VA: 0x18051E5D0
	public void UpdatePullbackThink() { }

	// RVA: 0x51D780 Offset: 0x51BD80 VA: 0x18051D780
	public void CancelPullbackThink() { }

	// RVA: 0x51E490 Offset: 0x51CA90 VA: 0x18051E490
	public void PullbackThink() { }

	// RVA: 0x51DD10 Offset: 0x51C310 VA: 0x18051DD10 Slot: 138
	public override void OnInput() { }

	// RVA: 0x51DCD0 Offset: 0x51C2D0 VA: 0x18051DCD0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x51D860 Offset: 0x51BE60 VA: 0x18051D860 Slot: 171
	public override void DoAttack() { }

	// RVA: 0x51DB00 Offset: 0x51C100 VA: 0x18051DB00
	public bool IsAiming() { }

	// RVA: 0x51E2F0 Offset: 0x51C8F0 VA: 0x18051E2F0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x51DBA0 Offset: 0x51C1A0 VA: 0x18051DBA0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x51E360 Offset: 0x51C960 VA: 0x18051E360 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x51E560 Offset: 0x51CB60 VA: 0x18051E560
	private void TryReload() { }

	// RVA: 0x51E400 Offset: 0x51CA00 VA: 0x18051E400 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x51E6C0 Offset: 0x51CCC0 VA: 0x18051E6C0
	public void .ctor() { }

}

