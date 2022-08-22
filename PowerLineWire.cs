public class PowerLineWire : MonoBehaviour // TypeDefIndex: 10368
{	// Fields
	public List<Transform> poles; // 0x18
	public List<PowerLineWireConnectionDef> connections; // 0x20
	public List<PowerLineWireSpan> spans; // 0x28

	// Methods

	// RVA: 0x99E640 Offset: 0x99CC40 VA: 0x18099E640
	public void Copy(PowerLineWire from, PowerLineWireConnectionHelper helper) { }

	// RVA: 0x99E960 Offset: 0x99CF60 VA: 0x18099E960
	public static PowerLineWire Create(PowerLineWire wire, List<GameObject> objs, GameObjectRef wirePrefab, string name, PowerLineWire copyfrom, float wiresize, float str) { }

	// RVA: 0x99EEB0 Offset: 0x99D4B0 VA: 0x18099EEB0
	public void Init() { }

	// RVA: 0x99F1D0 Offset: 0x99D7D0 VA: 0x18099F1D0
	public void .ctor() { }

}

