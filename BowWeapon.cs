public class BowWeapon : BaseProjectile // TypeDefIndex: 8535
{	protected bool attackReady; // 0x378
	private float arrowBack; // 0x37C
	private SwapArrows swapArrows; // 0x380
	private bool wasAiming; // 0x388


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	public void UpdatePullbackThink() { }

	public void CancelPullbackThink() { }

	public void PullbackThink() { }

	public override void OnInput() { }

	public override void OnHolstered() { }

	public override void DoAttack() { }

	public bool IsAiming() { }

	public override void OnViewmodelEvent(string name) { }

	public override void OnFrame() { }

	public override void PostNetworkUpdate() { }

	private void TryReload() { }

	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	public void .ctor() { }

}

