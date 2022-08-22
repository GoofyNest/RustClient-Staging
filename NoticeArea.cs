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

	// RVA: 0x9D35B0 Offset: 0x9D1BB0 VA: 0x1809D35B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x9D3610 Offset: 0x9D1C10 VA: 0x1809D3610
	public static void ItemPickUp(ItemDefinition def, int amount, string nameOverride) { }

	// RVA: 0x9D4410 Offset: 0x9D2A10 VA: 0x1809D4410
	private void Update() { }

	// RVA: 0x9D3FC0 Offset: 0x9D25C0 VA: 0x1809D3FC0
	private void UpdateLayout() { }

	// RVA: 0x9D3420 Offset: 0x9D1A20 VA: 0x1809D3420
	private static Vector2 ApplySizing(RectTransform rectT, bool setSize = False) { }

	// RVA: 0x9D3D00 Offset: 0x9D2300 VA: 0x1809D3D00
	public void RefreshNotices() { }

	// RVA: 0x9D45C0 Offset: 0x9D2BC0 VA: 0x1809D45C0
	public void .ctor() { }

}

