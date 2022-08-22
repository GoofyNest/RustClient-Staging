public class BasePath : MonoBehaviour // TypeDefIndex: 8858
{	// Fields
	public List<BasePathNode> nodes; // 0x18
	public List<PathInterestNode> interestZones; // 0x20
	public List<PathSpeedZone> speedZones; // 0x28

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Start() { }

	// RVA: 0xA52660 Offset: 0xA50C60 VA: 0x180A52660
	private void AddChildren() { }

	// RVA: 0xA52D40 Offset: 0xA51340 VA: 0x180A52D40
	private void ClearChildren() { }

	// RVA: 0xA52860 Offset: 0xA50E60 VA: 0x180A52860
	public static void AutoGenerateLinks(BasePath path) { }

	// RVA: 0xA53150 Offset: 0xA51750 VA: 0x180A53150
	public void GetNodesNear(Vector3 point, ref List<BasePathNode> nearNodes, float dist = 10) { }

	// RVA: 0xA52E90 Offset: 0xA51490 VA: 0x180A52E90
	public BasePathNode GetClosestToPoint(Vector3 point) { }

	// RVA: 0xA533F0 Offset: 0xA519F0 VA: 0x180A533F0
	public PathInterestNode GetRandomInterestNodeAwayFrom(Vector3 from, float dist = 10) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

