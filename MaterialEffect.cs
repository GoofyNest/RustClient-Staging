public class MaterialEffect : ScriptableObject // TypeDefIndex: 10196
{	// Fields
	public GameObjectRef DefaultEffect; // 0x18
	public SoundDefinition DefaultSoundDefinition; // 0x20
	public MaterialEffect.Entry[] Entries; // 0x28
	public int waterFootstepIndex; // 0x30
	public MaterialEffect.Entry deepWaterEntry; // 0x38
	public float deepWaterDepth; // 0x40
	public MaterialEffect.Entry submergedWaterEntry; // 0x48
	public float submergedWaterDepth; // 0x50
	public bool ScaleVolumeWithSpeed; // 0x54
	public AnimationCurve SpeedGainCurve; // 0x58

	// Methods

	// RVA: 0x95ADF0 Offset: 0x9593F0 VA: 0x18095ADF0
	public MaterialEffect.Entry GetEntryFromMaterial(PhysicMaterial mat) { }

	// RVA: 0x95AED0 Offset: 0x9594D0 VA: 0x18095AED0
	public MaterialEffect.Entry GetWaterEntry() { }

	// RVA: 0x95B130 Offset: 0x959730 VA: 0x18095B130
	public void SpawnOnRay(Ray ray, int mask, float length = 0,5, Vector3 forward, float speed = 0) { }

	// RVA: 0x95B020 Offset: 0x959620 VA: 0x18095B020
	public void PlaySound(SoundDefinition definition, Vector3 position, float velocity = 0) { }

	// RVA: 0x95B910 Offset: 0x959F10 VA: 0x18095B910
	public void .ctor() { }

}

public class MaterialEffect.Entry // TypeDefIndex: 10197
{	// Fields
	public PhysicMaterial Material; // 0x10
	public GameObjectRef Effect; // 0x18
	public SoundDefinition SoundDefinition; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

