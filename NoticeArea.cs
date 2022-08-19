public class NoticeArea : SingletonComponent<NoticeArea> // TypeDefIndex: 11041
{	// Fields
	public GameObjectRef itemPickupPrefab; // 0x18
	public GameObjectRef itemPickupCondensedText; // 0x20
	public GameObjectRef itemDroppedPrefab; // 0x28
	public AnimationCurve pickupSizeCurve; // 0x30
	public AnimationCurve pickupAlphaCurve; // 0x38
	public AnimationCurve reuseAlphaCurve; // 0x40
	public AnimationCurve reuseSizeCurve; // 0x48
	private IVitalNotice[] notices; // 0x50
	private List<ItemPickupNotice> pickups; // 0x58
	private RealTimeSince timeSinceUpdatedNotices; // 0x60

	// Methods

	// RVA: 0x9D32F0 Offset: 0x9D18F0 VA: 0x1809D32F0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x9D3350 Offset: 0x9D1950 VA: 0x1809D3350
	public static void ItemPickUp(ItemDefinition def, int amount, string nameOverride) { }

	// RVA: 0x9D4150 Offset: 0x9D2750 VA: 0x1809D4150
	private void Update() { }

	// RVA: 0x9D3D00 Offset: 0x9D2300 VA: 0x1809D3D00
	private void UpdateLayout() { }

	// RVA: 0x9D3160 Offset: 0x9D1760 VA: 0x1809D3160
	private static Vector2 ApplySizing(RectTransform rectT, bool setSize = False) { }

	// RVA: 0x9D3A40 Offset: 0x9D2040 VA: 0x1809D3A40
	public void RefreshNotices() { }

	// RVA: 0x9D4300 Offset: 0x9D2900 VA: 0x1809D4300
	public void .ctor() { }

}

