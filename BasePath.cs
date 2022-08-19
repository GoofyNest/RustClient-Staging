public class BasePath : MonoBehaviour // TypeDefIndex: 8858
{	// Fields
	public List<BasePathNode> nodes; // 0x18
	public List<PathInterestNode> interestZones; // 0x20
	public List<PathSpeedZone> speedZones; // 0x28

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Start() { }

	// RVA: 0xA523A0 Offset: 0xA509A0 VA: 0x180A523A0
	private void AddChildren() { }

	// RVA: 0xA52A80 Offset: 0xA51080 VA: 0x180A52A80
	private void ClearChildren() { }

	// RVA: 0xA525A0 Offset: 0xA50BA0 VA: 0x180A525A0
	public static void AutoGenerateLinks(BasePath path) { }

	// RVA: 0xA52E90 Offset: 0xA51490 VA: 0x180A52E90
	public void GetNodesNear(Vector3 point, ref List<BasePathNode> nearNodes, float dist = 10) { }

	// RVA: 0xA52BD0 Offset: 0xA511D0 VA: 0x180A52BD0
	public BasePathNode GetClosestToPoint(Vector3 point) { }

	// RVA: 0xA53130 Offset: 0xA51730 VA: 0x180A53130
	public PathInterestNode GetRandomInterestNodeAwayFrom(Vector3 from, float dist = 10) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

