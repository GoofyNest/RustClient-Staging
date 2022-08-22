public class Chainsaw : BaseMelee // TypeDefIndex: 8549
{	// Fields
	public float attackFadeInTime; // 0x2E0
	public float attackFadeInDelay; // 0x2E4
	public float attackFadeOutTime; // 0x2E8
	public float idleFadeInTimeFromOff; // 0x2EC
	public float idleFadeInTimeFromAttack; // 0x2F0
	public float idleFadeInDelay; // 0x2F4
	public float idleFadeOutTime; // 0x2F8
	private bool wasEngineOn; // 0x2FC
	private bool wasAttackingAudio; // 0x2FD
	public Renderer chainRenderer; // 0x300
	private MaterialPropertyBlock block; // 0x308
	private Vector2 saveST; // 0x310
	private float chainSpeed; // 0x318
	private float chainAmount; // 0x31C
	private float chainSpinUpRate; // 0x320
	[HeaderAttribute] // RVA: 0xA9FD0 Offset: 0xA93D0 VA: 0x1800A9FD0
	public float fuelPerSec; // 0x324
	public int maxAmmo; // 0x328
	public int ammo; // 0x32C
	public ItemDefinition fuelType; // 0x330
	public float reloadDuration; // 0x338
	[HeaderAttribute] // RVA: 0xAA090 Offset: 0xA9490 VA: 0x1800AA090
	public SoundPlayer idleLoop; // 0x340
	public SoundPlayer attackLoopAir; // 0x348
	public SoundPlayer revUp; // 0x350
	public SoundPlayer revDown; // 0x358
	public SoundPlayer offSound; // 0x360
	private string lastHitMaterial; // 0x368
	private float lastHitTime; // 0x370
	private float nextReleaseTime; // 0x374
	private float nextPressTime; // 0x378
	private bool wasAttacking; // 0x37C
	private float reloadFinishedTime; // 0x380
	public float engineStartChance; // 0x384

	// Methods

	// RVA: 0x533060 Offset: 0x531660 VA: 0x180533060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x532360 Offset: 0x530960 VA: 0x180532360
	public void DelayedAttackLoop() { }

	// RVA: 0x532390 Offset: 0x530990 VA: 0x180532390
	public void DelayedIdleLoop() { }

	// RVA: 0x533550 Offset: 0x531B50 VA: 0x180533550
	public void UpdateAudio() { }

	// RVA: 0x5333A0 Offset: 0x5319A0 VA: 0x1805333A0
	public void SetupVisuals() { }

	// RVA: 0x533970 Offset: 0x531F70 VA: 0x180533970
	private void UpdateChain(bool on, bool attacking) { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool EngineOn() { }

	// RVA: 0x532980 Offset: 0x530F80 VA: 0x180532980
	public bool IsAttacking() { }

	// RVA: 0x532230 Offset: 0x530830 VA: 0x180532230 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x533BB0 Offset: 0x5321B0 VA: 0x180533BB0
	public void Update() { }

	// RVA: 0x532990 Offset: 0x530F90 VA: 0x180532990
	private bool IsReloading() { }

	// RVA: 0x532830 Offset: 0x530E30 VA: 0x180532830 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x5323D0 Offset: 0x5309D0 VA: 0x1805323D0 Slot: 165
	protected override void DoAttack() { }

	// RVA: 0x533360 Offset: 0x531960 VA: 0x180533360
	public void SendServerReload() { }

	// RVA: 0x533150 Offset: 0x531750 VA: 0x180533150 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x532BA0 Offset: 0x5311A0 VA: 0x180532BA0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x533200 Offset: 0x531800 VA: 0x180533200 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x532750 Offset: 0x530D50 VA: 0x180532750
	public v_chainsaw GetChainsawViewmodel() { }

	// RVA: 0x532A50 Offset: 0x531050 VA: 0x180532A50 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x5321B0 Offset: 0x5307B0 VA: 0x1805321B0
	public void CleanupViewmodel() { }

	// RVA: 0x532B80 Offset: 0x531180 VA: 0x180532B80 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x532A30 Offset: 0x531030 VA: 0x180532A30 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x5334B0 Offset: 0x531AB0 VA: 0x1805334B0 Slot: 168
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x5332B0 Offset: 0x5318B0 VA: 0x1805332B0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x533220 Offset: 0x531820 VA: 0x180533220 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x5323C0 Offset: 0x5309C0 VA: 0x1805323C0 Slot: 160
	public override void DoAttackShared(HitInfo info) { }

	// RVA: 0x5329C0 Offset: 0x530FC0 VA: 0x1805329C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x532960 Offset: 0x530F60 VA: 0x180532960
	public bool HasAmmo() { }

	// RVA: 0x532660 Offset: 0x530C60 VA: 0x180532660
	public Item GetAmmo() { }

	// RVA: 0x533C10 Offset: 0x532210 VA: 0x180533C10
	public void .ctor() { }

}

