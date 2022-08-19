public class FlameThrower : AttackEntity // TypeDefIndex: 8568
{	// Fields
	[HeaderAttribute] // RVA: 0xAB070 Offset: 0xAA470 VA: 0x1800AB070
	public int maxAmmo; // 0x280
	public int ammo; // 0x284
	public ItemDefinition fuelType; // 0x288
	public float timeSinceLastAttack; // 0x290
	[FormerlySerializedAsAttribute] // RVA: 0xAB220 Offset: 0xAA620 VA: 0x1800AB220
	public float nextReadyTime; // 0x294
	public float flameRange; // 0x298
	public float flameRadius; // 0x29C
	public ParticleSystem[] flameEffects; // 0x2A0
	public FlameJet jet; // 0x2A8
	public GameObjectRef fireballPrefab; // 0x2B0
	public List<DamageTypeEntry> damagePerSec; // 0x2B8
	public SoundDefinition flameStart3P; // 0x2C0
	public SoundDefinition flameLoop3P; // 0x2C8
	public SoundDefinition flameStop3P; // 0x2D0
	public SoundDefinition pilotLoopSoundDef; // 0x2D8
	private float tickRate; // 0x2E0
	private float lastFlameTick; // 0x2E4
	public float fuelPerSec; // 0x2E8
	private float ammoRemainder; // 0x2EC
	public float reloadDuration; // 0x2F0
	private bool isReloading; // 0x2F4
	private Sound loopSound; // 0x2F8
	private Sound pilotLoopSound; // 0x300
	private float currentGaugeSetting; // 0x308
	private bool wasFlameOn; // 0x30C
	private float nextUnfireTime; // 0x310
	private bool firing; // 0x314

	// Methods

	// RVA: 0x78F420 Offset: 0x78DA20 VA: 0x18078F420 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x78EBB0 Offset: 0x78D1B0 VA: 0x18078EBB0
	private bool IsWeaponBusy() { }

	// RVA: 0x78F6A0 Offset: 0x78DCA0 VA: 0x18078F6A0
	private void SetBusyFor(float dur) { }

	// RVA: 0x78E6C0 Offset: 0x78CCC0 VA: 0x18078E6C0
	private void ClearBusy() { }

	// RVA: 0x78F5D0 Offset: 0x78DBD0 VA: 0x18078F5D0
	public void ReduceAmmo(float firingTime) { }

	// RVA: 0x78F590 Offset: 0x78DB90 VA: 0x18078F590
	public void PilotLightToggle_Shared() { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsPilotOn() { }

	// RVA: 0x7889F0 Offset: 0x786FF0 VA: 0x1807889F0
	public bool IsFlameOn() { }

	// RVA: 0x78EAB0 Offset: 0x78D0B0 VA: 0x18078EAB0
	public bool HasAmmo() { }

	// RVA: 0x78E6F0 Offset: 0x78CCF0 VA: 0x18078E6F0
	public Item GetAmmo() { }

	// RVA: 0x78E7E0 Offset: 0x78CDE0 VA: 0x18078E7E0
	public Sound GetFlameLoopSound() { }

	// RVA: 0x78E9E0 Offset: 0x78CFE0 VA: 0x18078E9E0
	public Sound GetPilotLoopSound() { }

	// RVA: 0x78FAC0 Offset: 0x78E0C0 VA: 0x18078FAC0
	public void Update() { }

	// RVA: 0x78F8D0 Offset: 0x78DED0 VA: 0x18078F8D0
	private void UpdateSounds(bool isFirstPerson = False) { }

	// RVA: 0x78EC60 Offset: 0x78D260 VA: 0x18078EC60 Slot: 138
	public override void OnInput() { }

	// RVA: 0x78F770 Offset: 0x78DD70 VA: 0x18078F770
	public void UpdateFlameStateFirstPerson() { }

	// RVA: 0x78F510 Offset: 0x78DB10 VA: 0x18078F510 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x78EC50 Offset: 0x78D250 VA: 0x18078EC50 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x78EBE0 Offset: 0x78D1E0 VA: 0x18078EBE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x78E8B0 Offset: 0x78CEB0 VA: 0x18078E8B0 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x78F6D0 Offset: 0x78DCD0 VA: 0x18078F6D0 Slot: 160
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x78FD90 Offset: 0x78E390 VA: 0x18078FD90
	public void .ctor() { }

}

