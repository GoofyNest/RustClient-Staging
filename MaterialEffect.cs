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

	// RVA: 0x95B2F0 Offset: 0x9598F0 VA: 0x18095B2F0
	public MaterialEffect.Entry GetEntryFromMaterial(PhysicMaterial mat) { }

	// RVA: 0x95B3D0 Offset: 0x9599D0 VA: 0x18095B3D0
	public MaterialEffect.Entry GetWaterEntry() { }

	// RVA: 0x95B630 Offset: 0x959C30 VA: 0x18095B630
	public void SpawnOnRay(Ray ray, int mask, float length = 0,5, Vector3 forward, float speed = 0) { }

	// RVA: 0x95B520 Offset: 0x959B20 VA: 0x18095B520
	public void PlaySound(SoundDefinition definition, Vector3 position, float velocity = 0) { }

	// RVA: 0x95BE10 Offset: 0x95A410 VA: 0x18095BE10
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

