public class FlameThrower : AttackEntity // TypeDefIndex: 8568
{	// Fields
	[HeaderAttribute] // RVA: 0xAB110 Offset: 0xAA510 VA: 0x1800AB110
	public int maxAmmo; // 0x280
	public int ammo; // 0x284
	public ItemDefinition fuelType; // 0x288
	public float timeSinceLastAttack; // 0x290
	[FormerlySerializedAsAttribute] // RVA: 0xAB2C0 Offset: 0xAA6C0 VA: 0x1800AB2C0
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

	// RVA: 0x78F530 Offset: 0x78DB30 VA: 0x18078F530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x78ECC0 Offset: 0x78D2C0 VA: 0x18078ECC0
	private bool IsWeaponBusy() { }

	// RVA: 0x78F7B0 Offset: 0x78DDB0 VA: 0x18078F7B0
	private void SetBusyFor(float dur) { }

	// RVA: 0x78E7D0 Offset: 0x78CDD0 VA: 0x18078E7D0
	private void ClearBusy() { }

	// RVA: 0x78F6E0 Offset: 0x78DCE0 VA: 0x18078F6E0
	public void ReduceAmmo(float firingTime) { }

	// RVA: 0x78F6A0 Offset: 0x78DCA0 VA: 0x18078F6A0
	public void PilotLightToggle_Shared() { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsPilotOn() { }

	// RVA: 0x788B00 Offset: 0x787100 VA: 0x180788B00
	public bool IsFlameOn() { }

	// RVA: 0x78EBC0 Offset: 0x78D1C0 VA: 0x18078EBC0
	public bool HasAmmo() { }

	// RVA: 0x78E800 Offset: 0x78CE00 VA: 0x18078E800
	public Item GetAmmo() { }

	// RVA: 0x78E8F0 Offset: 0x78CEF0 VA: 0x18078E8F0
	public Sound GetFlameLoopSound() { }

	// RVA: 0x78EAF0 Offset: 0x78D0F0 VA: 0x18078EAF0
	public Sound GetPilotLoopSound() { }

	// RVA: 0x78FBD0 Offset: 0x78E1D0 VA: 0x18078FBD0
	public void Update() { }

	// RVA: 0x78F9E0 Offset: 0x78DFE0 VA: 0x18078F9E0
	private void UpdateSounds(bool isFirstPerson = False) { }

	// RVA: 0x78ED70 Offset: 0x78D370 VA: 0x18078ED70 Slot: 138
	public override void OnInput() { }

	// RVA: 0x78F880 Offset: 0x78DE80 VA: 0x18078F880
	public void UpdateFlameStateFirstPerson() { }

	// RVA: 0x78F620 Offset: 0x78DC20 VA: 0x18078F620 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x78ED60 Offset: 0x78D360 VA: 0x18078ED60 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x78ECF0 Offset: 0x78D2F0 VA: 0x18078ECF0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x78E9C0 Offset: 0x78CFC0 VA: 0x18078E9C0 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x78F7E0 Offset: 0x78DDE0 VA: 0x18078F7E0 Slot: 160
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x78FEA0 Offset: 0x78E4A0 VA: 0x18078FEA0
	public void .ctor() { }

}

