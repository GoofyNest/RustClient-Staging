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

	// RVA: 0xA5D420 Offset: 0xA5BA20 VA: 0x180A5D420
	public void .ctor(ERSideWalk msidewalk, float mStart, float mEnd, Vector3 mStartPos, Vector3 mEndPos, ERModularRoad road, string side) { }

	// RVA: 0xA5D080 Offset: 0xA5B680 VA: 0x180A5D080
	public void CreateObject(ERModularRoad road, string side) { }

	// RVA: 0xA5D2A0 Offset: 0xA5B8A0 VA: 0x180A5D2A0
	public void GetObject(ERModularRoad road, string side) { }

}

