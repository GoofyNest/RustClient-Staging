public struct ERSOSection // TypeDefIndex: 7188
{	// Fields
	public Vector3 startPosition; // 0x0
	public Vector3 endPosition; // 0xC
	public Vector3 p2; // 0x18
	public Vector3 p3; // 0x24
	public Vector3 ms1; // 0x30
	public Vector3 ms2; // 0x3C
	public Vector3 ms3; // 0x48
	public Vector3 ms4; // 0x54
	public Vector3 me1; // 0x60
	public Vector3 me2; // 0x6C
	public Vector3 me3; // 0x78
	public Vector3 me4; // 0x84
	public Vector3 startSplinePointOrig; // 0x90
	public float startDistance; // 0x9C
	public int startSplinePointObject; // 0xA0
	public int startSplinePoint; // 0xA4
	public int endSplinePoint; // 0xA8
	public float startFraction; // 0xAC
	public float endFraction; // 0xB0
	public float hsStart; // 0xB4
	public float hsEnd; // 0xB8
	public int startSplinePointGeo; // 0xBC
	public float startDistanceGeo; // 0xC0
	public int endSplinePointGeo; // 0xC4
	public float endDistanceGeo; // 0xC8
	public float maxHeightDifference; // 0xCC
	public SideObject so; // 0xD0
	public bool forceSo; // 0xD8
	public ERRoadSide roadSide; // 0xDC
	public double soid; // 0xE0
	public bool acceptBarriers; // 0xE8
	public bool active; // 0xE9
	public double linkedSoId1; // 0xF0
	public double linkedSoId2; // 0xF8

	// Methods

	// RVA: 0xFBDA0 Offset: 0xFB1A0 VA: 0x1800FBDA0
	public void .ctor(Vector3 _startPos, Vector3 _endPos, int _startIndex, int _endIndex, float _startFraction, float _endFraction, float _hsStart, float _hsEnd) { }

	// RVA: 0xA5A7A0 Offset: 0xA58DA0 VA: 0x180A5A7A0
	public static ERSOSection GetERSOSection(ERModularRoad road, int listIndex, ref int index, int leftright, ref string soType, ref List<ERSOSection> sections) { }

	// RVA: 0xA5A550 Offset: 0xA58B50 VA: 0x180A5A550
	public static ERSOSection AdjustEndOffset(ERSOSection target, ERSOSection source) { }

}
