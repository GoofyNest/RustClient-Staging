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
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	private void set_triggerCollider(Collider value) { }

	// RVA: 0xA22D70 Offset: 0xA21370 VA: 0x180A22D70
	protected void Awake() { }

	// RVA: 0xA23140 Offset: 0xA21740 VA: 0x180A23140
	protected void OnEnable() { }

	// RVA: 0xA22FE0 Offset: 0xA215E0 VA: 0x180A22FE0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA22EC0 Offset: 0xA214C0 VA: 0x180A22EC0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA231C0 Offset: 0xA217C0 VA: 0x180A231C0
	public bool PassesHeightChecks(Vector3 entPos) { }

	// RVA: 0xA22DC0 Offset: 0xA213C0 VA: 0x180A22DC0
	public float GetSafeLevel(Vector3 pos) { }

	// RVA: 0xA23320 Offset: 0xA21920 VA: 0x180A23320
	public void .ctor() { }

	// RVA: 0xA232C0 Offset: 0xA218C0 VA: 0x180A232C0
	private static void .cctor() { }

}

