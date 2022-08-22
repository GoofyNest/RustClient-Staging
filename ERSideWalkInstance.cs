public class ERSideWalkInstance // TypeDefIndex: 7222
{	// Fields
	public ERSideWalk sidewalk; // 0x10
	public GameObject swObject; // 0x18
	public double id; // 0x20
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float start; // 0x28
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float end; // 0x2C
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 startPos; // 0x30
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 endPos; // 0x3C

	// Methods

	// RVA: 0xA5D8F0 Offset: 0xA5BEF0 VA: 0x180A5D8F0
	public void .ctor(ERSideWalk msidewalk, float mStart, float mEnd, Vector3 mStartPos, Vector3 mEndPos, ERModularRoad road, string side) { }

	// RVA: 0xA5D550 Offset: 0xA5BB50 VA: 0x180A5D550
	public void CreateObject(ERModularRoad road, string side) { }

	// RVA: 0xA5D770 Offset: 0xA5BD70 VA: 0x180A5D770
	public void GetObject(ERModularRoad road, string side) { }

}

