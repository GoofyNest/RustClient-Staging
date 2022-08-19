public struct ERRoadShape // TypeDefIndex: 7204
{	// Fields
	public List<Vector2> nodes; // 0x0
	public List<bool> hardEdge; // 0x8
	public int priorityNodeIndexLeft; // 0x10
	public int priorityNodeIndexRight; // 0x14
	public List<Vector3> nodesV3; // 0x18
	public List<ERLane> lanes; // 0x20
	public int leftLanes; // 0x28
	public int rightLanes; // 0x2C
	public bool symmetrical; // 0x30
	public float leftSidewalkOffset; // 0x34
	public float rightSidewalkOffset; // 0x38
	public int outerLaneMarkingLeftIndex; // 0x3C
	public bool includeOuterlaneLeftInShape; // 0x40
	public bool includeOuterlaneRightInShape; // 0x41
	public int outerLaneMarkingRightIndex; // 0x44
	public int outerOuterLaneMarkingLeftIndex; // 0x48
	public int outerOuterLaneMarkingRightIndex; // 0x4C
	public int selectedNode; // 0x50
	public int selectedLaneNode; // 0x54
	public int isSymmetrical; // 0x58
	public bool isset; // 0x5C

	// Methods

	// RVA: 0xFCF80 Offset: 0xFC380 VA: 0x1800FCF80
	public void .ctor(float width) { }

	// RVA: 0xFCF10 Offset: 0xFC310 VA: 0x1800FCF10
	public void OCCQQDOQOD(List<Vector2> _nodes) { }

	// RVA: 0xFCCD0 Offset: 0xFC0D0 VA: 0x1800FCCD0
	public void Copy(ERRoadShape shape) { }

	// RVA: 0xFCD20 Offset: 0xFC120 VA: 0x1800FCD20
	public void IsSymmetrical() { }

}
