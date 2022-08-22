public class SleepingBagButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler // TypeDefIndex: 11220
{	// Fields
	public GameObject TimeLockRoot; // 0x18
	public GameObject LockRoot; // 0x20
	public GameObject OccupiedRoot; // 0x28
	public Button ClickButton; // 0x30
	public TextMeshProUGUI BagName; // 0x38
	public TextMeshProUGUI LockTime; // 0x40
	public Image Icon; // 0x48
	public Sprite SleepingBagSprite; // 0x50
	public Sprite BedSprite; // 0x58
	public Sprite BeachTowelSprite; // 0x60
	public Sprite CamperSprite; // 0x68
	public Image CircleRim; // 0x70
	public Image CircleFill; // 0x78
	public Image Background; // 0x80
	public GameObject DeleteButton; // 0x88
	internal RespawnInformation.SpawnOptions spawnOption; // 0x90
	internal float releaseTime; // 0x98

	// Properties
	public float timerSeconds { get; }
	public string friendlyName { get; }

	// Methods

	// RVA: 0x5A7940 Offset: 0x5A5F40 VA: 0x1805A7940
	public float get_timerSeconds() { }

	// RVA: 0x5A78D0 Offset: 0x5A5ED0 VA: 0x1805A78D0
	public string get_friendlyName() { }

	// RVA: 0x5A7330 Offset: 0x5A5930 VA: 0x1805A7330
	private void OnEnable() { }

	// RVA: 0x5A74E0 Offset: 0x5A5AE0 VA: 0x1805A74E0
	public void Setup(RespawnInformation.SpawnOptions option, UIDeathScreen.RespawnColourScheme colourScheme) { }

	// RVA: 0x5A76C0 Offset: 0x5A5CC0 VA: 0x1805A76C0
	private void UpdateButtonState(RespawnInformation.SpawnOptions option) { }

	// RVA: 0x5A7790 Offset: 0x5A5D90 VA: 0x1805A7790
	public void Update() { }

	// RVA: 0x5A7200 Offset: 0x5A5800 VA: 0x1805A7200
	public void DoSpawn() { }

	// RVA: 0x5A70D0 Offset: 0x5A56D0 VA: 0x1805A70D0
	public void DeleteBag() { }

	// RVA: 0x5A73C0 Offset: 0x5A59C0 VA: 0x1805A73C0 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x5A7450 Offset: 0x5A5A50 VA: 0x1805A7450 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

