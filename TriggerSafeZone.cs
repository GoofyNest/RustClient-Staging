public class TriggerSafeZone : TriggerBase // TypeDefIndex: 10046
{	public static List<TriggerSafeZone> allSafeZones; // 0x0
	public float maxDepth; // 0x30
	public float maxAltitude; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Collider <triggerCollider>k__BackingField; // 0x38

	public Collider triggerCollider { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Collider get_triggerCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_triggerCollider(Collider value) { }

	protected void Awake() { }

	protected void OnEnable() { }

	protected override void OnDisable() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	public bool PassesHeightChecks(Vector3 entPos) { }

	public float GetSafeLevel(Vector3 pos) { }

	public void .ctor() { }

	private static void .cctor() { }

}

