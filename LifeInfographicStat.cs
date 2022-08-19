public class LifeInfographicStat : MonoBehaviour // TypeDefIndex: 11073
{	// Fields
	public LifeInfographicStat.DataType dataSource; // 0x18
	[HeaderAttribute] // RVA: 0x94C10 Offset: 0x94010 VA: 0x180094C10
	public string genericStatKey; // 0x20
	[HeaderAttribute] // RVA: 0x94CE0 Offset: 0x940E0 VA: 0x180094CE0
	public string targetWeaponName; // 0x28
	public LifeInfographicStat.WeaponInfoType weaponInfoType; // 0x30
	public TextMeshProUGUI targetText; // 0x38
	public Image StatImage; // 0x40
	private LifeInfographic cachedInfographic; // 0x48

	// Methods

	// RVA: 0x68C270 Offset: 0x68A870 VA: 0x18068C270
	private string GetText() { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	private void OnEnable() { }

	// RVA: 0x68CC40 Offset: 0x68B240 VA: 0x18068CC40 Slot: 4
	public virtual void InfographicUpdated() { }

	// RVA: 0x68CE10 Offset: 0x68B410 VA: 0x18068CE10
	public void SetStatImage(Sprite sprite) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum LifeInfographicStat.DataType // TypeDefIndex: 11074
{	// Fields
	public int value__; // 0x0
	public const LifeInfographicStat.DataType None = 0;
	public const LifeInfographicStat.DataType AliveTime_Short = 1;
	public const LifeInfographicStat.DataType SleepingTime_Short = 2;
	public const LifeInfographicStat.DataType KillerName = 3;
	public const LifeInfographicStat.DataType KillerWeapon = 4;
	public const LifeInfographicStat.DataType AliveTime_Long = 5;
	public const LifeInfographicStat.DataType KillerDistance = 6;
	public const LifeInfographicStat.DataType GenericStat = 7;
	public const LifeInfographicStat.DataType DistanceTravelledWalk = 8;
	public const LifeInfographicStat.DataType DistanceTravelledRun = 9;
	public const LifeInfographicStat.DataType DamageTaken = 10;
	public const LifeInfographicStat.DataType DamageHealed = 11;
	public const LifeInfographicStat.DataType WeaponInfo = 12;
	public const LifeInfographicStat.DataType SecondsWilderness = 13;
	public const LifeInfographicStat.DataType SecondsSwimming = 14;
	public const LifeInfographicStat.DataType SecondsInBase = 15;
	public const LifeInfographicStat.DataType SecondsInMonument = 16;
	public const LifeInfographicStat.DataType SecondsFlying = 17;
	public const LifeInfographicStat.DataType SecondsBoating = 18;
	public const LifeInfographicStat.DataType PlayersKilled = 19;
	public const LifeInfographicStat.DataType ScientistsKilled = 20;
	public const LifeInfographicStat.DataType AnimalsKilled = 21;
	public const LifeInfographicStat.DataType SecondsDriving = 22;

}

public enum LifeInfographicStat.WeaponInfoType // TypeDefIndex: 11075
{	// Fields
	public int value__; // 0x0
	public const LifeInfographicStat.WeaponInfoType TotalShots = 0;
	public const LifeInfographicStat.WeaponInfoType ShotsHit = 1;
	public const LifeInfographicStat.WeaponInfoType ShotsMissed = 2;
	public const LifeInfographicStat.WeaponInfoType AccuracyPercentage = 3;

}

