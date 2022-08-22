public class TriggerRadiation : TriggerBase // TypeDefIndex: 10043
{	// Fields
	public TriggerRadiation.RadiationTier radiationTier; // 0x30
	public float RadiationAmountOverride; // 0x34
	public float falloff; // 0x38
	private SphereCollider sphereCollider; // 0x40

	// Methods

	// RVA: 0xA22590 Offset: 0xA20B90 VA: 0x180A22590
	public void Awake() { }

	// RVA: 0xA22650 Offset: 0xA20C50 VA: 0x180A22650
	private float GetRadiationSize() { }

	// RVA: 0xA225F0 Offset: 0xA20BF0 VA: 0x180A225F0
	public float GetRadiationAmount() { }

	// RVA: 0xA22740 Offset: 0xA20D40 VA: 0x180A22740
	public void OnDrawGizmosSelected() { }

	// RVA: 0xA22920 Offset: 0xA20F20 VA: 0x180A22920
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

