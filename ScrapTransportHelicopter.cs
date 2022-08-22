public class ScrapTransportHelicopter : MiniCopter // TypeDefIndex: 8295
{	// Fields
	public Transform searchlightEye; // 0x630
	public BoxCollider parentTriggerCollider; // 0x638
	[HeaderAttribute] // RVA: 0xACA40 Offset: 0xABE40 VA: 0x1800ACA40
	public ParticleSystemContainer tailDamageLight; // 0x640
	public ParticleSystemContainer tailDamageHeavy; // 0x648
	public ParticleSystemContainer mainEngineDamageLight; // 0x650
	public ParticleSystemContainer mainEngineDamageHeavy; // 0x658
	public ParticleSystemContainer cockpitSparks; // 0x660
	public Transform tailDamageLightEffects; // 0x668
	public Transform mainEngineDamageLightEffects; // 0x670
	public SoundDefinition damagedFireSoundDef; // 0x678
	public SoundDefinition damagedFireTailSoundDef; // 0x680
	public SoundDefinition damagedSparksSoundDef; // 0x688
	private Sound damagedFireSound; // 0x690
	private Sound damagedFireTailSound; // 0x698
	private Sound damagedSparksSound; // 0x6A0
	public float pilotRotorScale; // 0x6A8
	public float compassOffset; // 0x6AC
	[ServerVar] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public static float population; // 0x0
	protected static int speedAnimationIndex; // 0x4
	protected static int altitudeAnimationIndex; // 0x8
	protected static int headingAnimationIndex; // 0xC
	protected int speedShakeIndex; // 0x6B0
	protected int altShakeIndex; // 0x6B4
	private float lastSpeed; // 0x6B8
	private float lastHealthFraction; // 0x6BC

	// Methods

	// RVA: 0x4A29E0 Offset: 0x4A0FE0 VA: 0x1804A29E0 Slot: 198
	protected override float GetMainRotorScale() { }

	// RVA: 0x4A2A20 Offset: 0x4A1020 VA: 0x1804A2A20 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x4A2AC0 Offset: 0x4A10C0 VA: 0x1804A2AC0
	private bool PlayerIsInside(BasePlayer player) { }

	// RVA: 0x4A2960 Offset: 0x4A0F60 VA: 0x1804A2960 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x4A34D0 Offset: 0x4A1AD0 VA: 0x1804A34D0 Slot: 199
	public override void UpdateLayerIndicies() { }

	// RVA: 0x4A2BF0 Offset: 0x4A11F0 VA: 0x1804A2BF0 Slot: 197
	public override void UpdateAnimator() { }

	// RVA: 0x4A2B40 Offset: 0x4A1140 VA: 0x1804A2B40 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4A2F60 Offset: 0x4A1560 VA: 0x1804A2F60
	public void UpdateDamageEffects() { }

	// RVA: 0x4A3550 Offset: 0x4A1B50 VA: 0x1804A3550 Slot: 191
	protected override void WorkshopMode() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x4A3700 Offset: 0x4A1D00 VA: 0x1804A3700
	public void .ctor() { }

	// RVA: 0x4A3660 Offset: 0x4A1C60 VA: 0x1804A3660
	private static void .cctor() { }

}

