public class PowerLineWire : MonoBehaviour // TypeDefIndex: 10368
{	// Fields
	public List<Transform> poles; // 0x18
	public List<PowerLineWireConnectionDef> connections; // 0x20
	public List<PowerLineWireSpan> spans; // 0x28

	// Methods

	// RVA: 0x99E530 Offset: 0x99CB30 VA: 0x18099E530
	public void Copy(PowerLineWire from, PowerLineWireConnectionHelper helper) { }

	// RVA: 0x99E850 Offset: 0x99CE50 VA: 0x18099E850
	public static PowerLineWire Create(PowerLineWire wire, List<GameObject> objs, GameObjectRef wirePrefab, string name, PowerLineWire copyfrom, float wiresize, float str) { }

	// RVA: 0x99EDA0 Offset: 0x99D3A0 VA: 0x18099EDA0
	public void Init() { }

	// RVA: 0x99F0C0 Offset: 0x99D6C0 VA: 0x18099F0C0
	public void .ctor() { }

}

