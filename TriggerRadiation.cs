public class TriggerRadiation : TriggerBase // TypeDefIndex: 10043
{	// Fields
	public TriggerRadiation.RadiationTier radiationTier; // 0x30
	public float RadiationAmountOverride; // 0x34
	public float falloff; // 0x38
	private SphereCollider sphereCollider; // 0x40

	// Methods

	// RVA: 0xA22A80 Offset: 0xA21080 VA: 0x180A22A80
	public void Awake() { }

	// RVA: 0xA22B40 Offset: 0xA21140 VA: 0x180A22B40
	private float GetRadiationSize() { }

	// RVA: 0xA22AE0 Offset: 0xA210E0 VA: 0x180A22AE0
	public float GetRadiationAmount() { }

	// RVA: 0xA22C30 Offset: 0xA21230 VA: 0x180A22C30
	public void OnDrawGizmosSelected() { }

	// RVA: 0xA22E10 Offset: 0xA21410 VA: 0x180A22E10
	public void .ctor() { }

}

public enum TriggerRadiation.RadiationTier // TypeDefIndex: 10044
{	// Fields
	public int value__; // 0x0
	public const TriggerRadiation.RadiationTier MINIMAL = 0;
	public const TriggerRadiation.RadiationTier LOW = 1;
	public const TriggerRadiation.RadiationTier MEDIUM = 2;
	public const TriggerRadiation.RadiationTier HIGH = 3;

}

