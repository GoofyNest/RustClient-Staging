public class TriggerRadiation : TriggerBase // TypeDefIndex: 10043
{	// Fields
	public TriggerRadiation.RadiationTier radiationTier; // 0x30
	public float RadiationAmountOverride; // 0x34
	public float falloff; // 0x38
	private SphereCollider sphereCollider; // 0x40

	// Methods

	// RVA: 0xA222D0 Offset: 0xA208D0 VA: 0x180A222D0
	public void Awake() { }

	// RVA: 0xA22390 Offset: 0xA20990 VA: 0x180A22390
	private float GetRadiationSize() { }

	// RVA: 0xA22330 Offset: 0xA20930 VA: 0x180A22330
	public float GetRadiationAmount() { }

	// RVA: 0xA22480 Offset: 0xA20A80 VA: 0x180A22480
	public void OnDrawGizmosSelected() { }

	// RVA: 0xA22660 Offset: 0xA20C60 VA: 0x180A22660
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

