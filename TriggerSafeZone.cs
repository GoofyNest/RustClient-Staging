public class TriggerSafeZone : TriggerBase // TypeDefIndex: 10046
{	// Fields
	public static List<TriggerSafeZone> allSafeZones; // 0x0
	public float maxDepth; // 0x30
	public float maxAltitude; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Collider <triggerCollider>k__BackingField; // 0x38

	// Properties
	public Collider triggerCollider { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public Collider get_triggerCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	private void set_triggerCollider(Collider value) { }

	// RVA: 0xA22AB0 Offset: 0xA210B0 VA: 0x180A22AB0
	protected void Awake() { }

	// RVA: 0xA22E80 Offset: 0xA21480 VA: 0x180A22E80
	protected void OnEnable() { }

	// RVA: 0xA22D20 Offset: 0xA21320 VA: 0x180A22D20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA22C00 Offset: 0xA21200 VA: 0x180A22C00 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA22F00 Offset: 0xA21500 VA: 0x180A22F00
	public bool PassesHeightChecks(Vector3 entPos) { }

	// RVA: 0xA22B00 Offset: 0xA21100 VA: 0x180A22B00
	public float GetSafeLevel(Vector3 pos) { }

	// RVA: 0xA23060 Offset: 0xA21660 VA: 0x180A23060
	public void .ctor() { }

	// RVA: 0xA23000 Offset: 0xA21600 VA: 0x180A23000
	private static void .cctor() { }

}

