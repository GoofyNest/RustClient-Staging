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

	// RVA: 0x78F440 Offset: 0x78DA40 VA: 0x18078F440 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x78EBD0 Offset: 0x78D1D0 VA: 0x18078EBD0
	private bool IsWeaponBusy() { }

	// RVA: 0x78F6C0 Offset: 0x78DCC0 VA: 0x18078F6C0
	private void SetBusyFor(float dur) { }

	// RVA: 0x78E6E0 Offset: 0x78CCE0 VA: 0x18078E6E0
	private void ClearBusy() { }

	// RVA: 0x78F5F0 Offset: 0x78DBF0 VA: 0x18078F5F0
	public void ReduceAmmo(float firingTime) { }

	// RVA: 0x78F5B0 Offset: 0x78DBB0 VA: 0x18078F5B0
	public void PilotLightToggle_Shared() { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool IsPilotOn() { }

	// RVA: 0x788A50 Offset: 0x787050 VA: 0x180788A50
	public bool IsFlameOn() { }

	// RVA: 0x78EAD0 Offset: 0x78D0D0 VA: 0x18078EAD0
	public bool HasAmmo() { }

	// RVA: 0x78E710 Offset: 0x78CD10 VA: 0x18078E710
	public Item GetAmmo() { }

	// RVA: 0x78E800 Offset: 0x78CE00 VA: 0x18078E800
	public Sound GetFlameLoopSound() { }

	// RVA: 0x78EA00 Offset: 0x78D000 VA: 0x18078EA00
	public Sound GetPilotLoopSound() { }

	// RVA: 0x78FAE0 Offset: 0x78E0E0 VA: 0x18078FAE0
	public void Update() { }

	// RVA: 0x78F8F0 Offset: 0x78DEF0 VA: 0x18078F8F0
	private void UpdateSounds(bool isFirstPerson = False) { }

	// RVA: 0x78EC80 Offset: 0x78D280 VA: 0x18078EC80 Slot: 138
	public override void OnInput() { }

	// RVA: 0x78F790 Offset: 0x78DD90 VA: 0x18078F790
	public void UpdateFlameStateFirstPerson() { }

	// RVA: 0x78F530 Offset: 0x78DB30 VA: 0x18078F530 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x78EC70 Offset: 0x78D270 VA: 0x18078EC70 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x78EC00 Offset: 0x78D200 VA: 0x18078EC00 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x78E8D0 Offset: 0x78CED0 VA: 0x18078E8D0 Slot: 51
	public override void GetItemOptions(List<Option> options) { }

	// RVA: 0x78F6F0 Offset: 0x78DCF0 VA: 0x18078F6F0 Slot: 160
	protected virtual void UpdateAmmoDisplay() { }

	// RVA: 0x78FDB0 Offset: 0x78E3B0 VA: 0x18078FDB0
	public void .ctor() { }

}

