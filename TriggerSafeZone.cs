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
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public Collider get_triggerCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	private void set_triggerCollider(Collider value) { }

	// RVA: 0xA23260 Offset: 0xA21860 VA: 0x180A23260
	protected void Awake() { }

	// RVA: 0xA23630 Offset: 0xA21C30 VA: 0x180A23630
	protected void OnEnable() { }

	// RVA: 0xA234D0 Offset: 0xA21AD0 VA: 0x180A234D0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0xA233B0 Offset: 0xA219B0 VA: 0x180A233B0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA236B0 Offset: 0xA21CB0 VA: 0x180A236B0
	public bool PassesHeightChecks(Vector3 entPos) { }

	// RVA: 0xA232B0 Offset: 0xA218B0 VA: 0x180A232B0
	public float GetSafeLevel(Vector3 pos) { }

	// RVA: 0xA23810 Offset: 0xA21E10 VA: 0x180A23810
	public void .ctor() { }

	// RVA: 0xA237B0 Offset: 0xA21DB0 VA: 0x180A237B0
	private static void .cctor() { }

}

