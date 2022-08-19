public class SleepingBagMapMarker : MonoBehaviour // TypeDefIndex: 10961
{	// Fields
	public Image MapIcon; // 0x18
	public Image SleepingBagIcon; // 0x20
	public Sprite SleepingBagSprite; // 0x28
	public Sprite BedSprite; // 0x30
	public Sprite BeachTowelSprite; // 0x38
	public Sprite CamperSprite; // 0x40
	public Tooltip MarkerTooltip; // 0x48
	public GameObject LockRoot; // 0x50
	public TextMeshProUGUI LockTime; // 0x58
	public GameObject OccupiedRoot; // 0x60
	public Image CircleRim; // 0x68
	public Image CircleFill; // 0x70
	private RespawnInformation.SpawnOptions cachedSpawnInfo; // 0x78
	private float releaseTime; // 0x80

	// Properties
	private float timerSeconds { get; }
	private string friendlyName { get; }

	// Methods

	// RVA: 0x5A8BC0 Offset: 0x5A71C0 VA: 0x1805A8BC0
	private float get_timerSeconds() { }

	// RVA: 0x5A8B50 Offset: 0x5A7150 VA: 0x1805A8B50
	private string get_friendlyName() { }

	// RVA: 0x5A87D0 Offset: 0x5A6DD0 VA: 0x1805A87D0
	public void Populate(RespawnInformation.SpawnOptions spawnInfo, UIDeathScreen.RespawnColourScheme colourScheme) { }

	// RVA: 0x5A89A0 Offset: 0x5A6FA0 VA: 0x1805A89A0
	public void Update() { }

	// RVA: 0x5A8680 Offset: 0x5A6C80 VA: 0x1805A8680
	public void OnClicked() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}
