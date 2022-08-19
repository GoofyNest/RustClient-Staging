public class ScrapTransportHelicopter : MiniCopter // TypeDefIndex: 8295
{	// Fields
	public Transform searchlightEye; // 0x630
	public BoxCollider parentTriggerCollider; // 0x638
	[HeaderAttribute] // RVA: 0xAC940 Offset: 0xABD40 VA: 0x1800AC940
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
	[ServerVar] // RVA: 0x71E60 Offset: 0x71260 VA: 0x180071E60
	public static float population; // 0x0
	protected static int speedAnimationIndex; // 0x4
	protected static int altitudeAnimationIndex; // 0x8
	protected static int headingAnimationIndex; // 0xC
	protected int speedShakeIndex; // 0x6B0
	protected int altShakeIndex; // 0x6B4
	private float lastSpeed; // 0x6B8
	private float lastHealthFraction; // 0x6BC

	// Methods

	// RVA: 0x4A2A50 Offset: 0x4A1050 VA: 0x1804A2A50 Slot: 198
	protected override float GetMainRotorScale() { }

	// RVA: 0x4A2A90 Offset: 0x4A1090 VA: 0x1804A2A90 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x4A2B30 Offset: 0x4A1130 VA: 0x1804A2B30
	private bool PlayerIsInside(BasePlayer player) { }

	// RVA: 0x4A29D0 Offset: 0x4A0FD0 VA: 0x1804A29D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x4A3540 Offset: 0x4A1B40 VA: 0x1804A3540 Slot: 199
	public override void UpdateLayerIndicies() { }

	// RVA: 0x4A2C60 Offset: 0x4A1260 VA: 0x1804A2C60 Slot: 197
	public override void UpdateAnimator() { }

	// RVA: 0x4A2BB0 Offset: 0x4A11B0 VA: 0x1804A2BB0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4A2FD0 Offset: 0x4A15D0 VA: 0x1804A2FD0
	public void UpdateDamageEffects() { }

	// RVA: 0x4A35C0 Offset: 0x4A1BC0 VA: 0x1804A35C0 Slot: 191
	protected override void WorkshopMode() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x4A3770 Offset: 0x4A1D70 VA: 0x1804A3770
	public void .ctor() { }

	// RVA: 0x4A36D0 Offset: 0x4A1CD0 VA: 0x1804A36D0
	private static void .cctor() { }

}

