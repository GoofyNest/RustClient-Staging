public class BasePath : MonoBehaviour // TypeDefIndex: 8858
{	// Fields
	public List<BasePathNode> nodes; // 0x18
	public List<PathInterestNode> interestZones; // 0x20
	public List<PathSpeedZone> speedZones; // 0x28

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Start() { }

	// RVA: 0xA52B30 Offset: 0xA51130 VA: 0x180A52B30
	private void AddChildren() { }

	// RVA: 0xA53210 Offset: 0xA51810 VA: 0x180A53210
	private void ClearChildren() { }

	// RVA: 0xA52D30 Offset: 0xA51330 VA: 0x180A52D30
	public static void AutoGenerateLinks(BasePath path) { }

	// RVA: 0xA53620 Offset: 0xA51C20 VA: 0x180A53620
	public void GetNodesNear(Vector3 point, ref List<BasePathNode> nearNodes, float dist = 10) { }

	// RVA: 0xA53360 Offset: 0xA51960 VA: 0x180A53360
	public BasePathNode GetClosestToPoint(Vector3 point) { }

	// RVA: 0xA538C0 Offset: 0xA51EC0 VA: 0x180A538C0
	public PathInterestNode GetRandomInterestNodeAwayFrom(Vector3 from, float dist = 10) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

