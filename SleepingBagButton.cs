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

	// RVA: 0x5A79B0 Offset: 0x5A5FB0 VA: 0x1805A79B0
	public float get_timerSeconds() { }

	// RVA: 0x5A7940 Offset: 0x5A5F40 VA: 0x1805A7940
	public string get_friendlyName() { }

	// RVA: 0x5A73A0 Offset: 0x5A59A0 VA: 0x1805A73A0
	private void OnEnable() { }

	// RVA: 0x5A7550 Offset: 0x5A5B50 VA: 0x1805A7550
	public void Setup(RespawnInformation.SpawnOptions option, UIDeathScreen.RespawnColourScheme colourScheme) { }

	// RVA: 0x5A7730 Offset: 0x5A5D30 VA: 0x1805A7730
	private void UpdateButtonState(RespawnInformation.SpawnOptions option) { }

	// RVA: 0x5A7800 Offset: 0x5A5E00 VA: 0x1805A7800
	public void Update() { }

	// RVA: 0x5A7270 Offset: 0x5A5870 VA: 0x1805A7270
	public void DoSpawn() { }

	// RVA: 0x5A7140 Offset: 0x5A5740 VA: 0x1805A7140
	public void DeleteBag() { }

	// RVA: 0x5A7430 Offset: 0x5A5A30 VA: 0x1805A7430 Slot: 4
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x5A74C0 Offset: 0x5A5AC0 VA: 0x1805A74C0 Slot: 5
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

