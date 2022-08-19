public class ERSideWalkInstance // TypeDefIndex: 7222
{	// Fields
	public ERSideWalk sidewalk; // 0x10
	public GameObject swObject; // 0x18
	public double id; // 0x20
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public float start; // 0x28
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public float end; // 0x2C
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Vector3 startPos; // 0x30
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Vector3 endPos; // 0x3C

	// Methods

	// RVA: 0xA5D160 Offset: 0xA5B760 VA: 0x180A5D160
	public void .ctor(ERSideWalk msidewalk, float mStart, float mEnd, Vector3 mStartPos, Vector3 mEndPos, ERModularRoad road, string side) { }

	// RVA: 0xA5CDC0 Offset: 0xA5B3C0 VA: 0x180A5CDC0
	public void CreateObject(ERModularRoad road, string side) { }

	// RVA: 0xA5CFE0 Offset: 0xA5B5E0 VA: 0x180A5CFE0
	public void GetObject(ERModularRoad road, string side) { }

}

