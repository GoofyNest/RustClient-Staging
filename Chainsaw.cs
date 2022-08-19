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
	[HeaderAttribute] // RVA: 0xA9F30 Offset: 0xA9330 VA: 0x1800A9F30
	public float fuelPerSec; // 0x324
	public int maxAmmo; // 0x328
	public int ammo; // 0x32C
	public ItemDefinition fuelType; // 0x330
	public float reloadDuration; // 0x338
	[HeaderAttribute] // RVA: 0xA9FF0 Offset: 0xA93F0 VA: 0x1800A9FF0
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

	// RVA: 0x5330D0 Offset: 0x5316D0 VA: 0x1805330D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5323D0 Offset: 0x5309D0 VA: 0x1805323D0
	public void DelayedAttackLoop() { }

	// RVA: 0x532400 Offset: 0x530A00 VA: 0x180532400
	public void DelayedIdleLoop() { }

	// RVA: 0x5335C0 Offset: 0x531BC0 VA: 0x1805335C0
	public void UpdateAudio() { }

	// RVA: 0x533410 Offset: 0x531A10 VA: 0x180533410
	public void SetupVisuals() { }

	// RVA: 0x5339E0 Offset: 0x531FE0 VA: 0x1805339E0
	private void UpdateChain(bool on, bool attacking) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool EngineOn() { }

	// RVA: 0x5329F0 Offset: 0x530FF0 VA: 0x1805329F0
	public bool IsAttacking() { }

	// RVA: 0x5322A0 Offset: 0x5308A0 VA: 0x1805322A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x533C20 Offset: 0x532220 VA: 0x180533C20
	public void Update() { }

	// RVA: 0x532A00 Offset: 0x531000 VA: 0x180532A00
	private bool IsReloading() { }

	// RVA: 0x5328A0 Offset: 0x530EA0 VA: 0x1805328A0 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x532440 Offset: 0x530A40 VA: 0x180532440 Slot: 165
	protected override void DoAttack() { }

	// RVA: 0x5333D0 Offset: 0x5319D0 VA: 0x1805333D0
	public void SendServerReload() { }

	// RVA: 0x5331C0 Offset: 0x5317C0 VA: 0x1805331C0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x532C10 Offset: 0x531210 VA: 0x180532C10 Slot: 138
	public override void OnInput() { }

	// RVA: 0x533270 Offset: 0x531870 VA: 0x180533270 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x5327C0 Offset: 0x530DC0 VA: 0x1805327C0
	public v_chainsaw GetChainsawViewmodel() { }

	// RVA: 0x532AC0 Offset: 0x5310C0 VA: 0x180532AC0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x532220 Offset: 0x530820 VA: 0x180532220
	public void CleanupViewmodel() { }

	// RVA: 0x532BF0 Offset: 0x5311F0 VA: 0x180532BF0 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x532AA0 Offset: 0x5310A0 VA: 0x180532AA0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x533520 Offset: 0x531B20 VA: 0x180533520 Slot: 168
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x533320 Offset: 0x531920 VA: 0x180533320 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x533290 Offset: 0x531890 VA: 0x180533290 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x532430 Offset: 0x530A30 VA: 0x180532430 Slot: 160
	public override void DoAttackShared(HitInfo info) { }

	// RVA: 0x532A30 Offset: 0x531030 VA: 0x180532A30 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5329D0 Offset: 0x530FD0 VA: 0x1805329D0
	public bool HasAmmo() { }

	// RVA: 0x5326D0 Offset: 0x530CD0 VA: 0x1805326D0
	public Item GetAmmo() { }

	// RVA: 0x533C80 Offset: 0x532280 VA: 0x180533C80
	public void .ctor() { }

}

