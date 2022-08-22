public class PowerLineWire : MonoBehaviour // TypeDefIndex: 10368
{	// Fields
	public List<Transform> poles; // 0x18
	public List<PowerLineWireConnectionDef> connections; // 0x20
	public List<PowerLineWireSpan> spans; // 0x28

	// Methods

	// RVA: 0x99EB30 Offset: 0x99D130 VA: 0x18099EB30
	public void Copy(PowerLineWire from, PowerLineWireConnectionHelper helper) { }

	// RVA: 0x99EE50 Offset: 0x99D450 VA: 0x18099EE50
	public static PowerLineWire Create(PowerLineWire wire, List<GameObject> objs, GameObjectRef wirePrefab, string name, PowerLineWire copyfrom, float wiresize, float str) { }

	// RVA: 0x99F3A0 Offset: 0x99D9A0 VA: 0x18099F3A0
	public void Init() { }

	// RVA: 0x99F6C0 Offset: 0x99DCC0 VA: 0x18099F6C0
	public void .ctor() { }

}

