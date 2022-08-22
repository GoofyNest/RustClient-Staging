public class ERMaterial : ScriptableObject // TypeDefIndex: 7223
{	// Fields
	public int id; // 0x18
	public string name; // 0x20
	public double roadType1ID; // 0x28
	public double roadType2ID; // 0x30
	public double roadType3ID; // 0x38
	public Material road1Material; // 0x40
	public Material road2Material; // 0x48
	public Material road3Material; // 0x50
	public float connectorLength1; // 0x58
	public float connectorLength2; // 0x5C
	public float connectorLength3; // 0x60
	public float road1Stretch; // 0x64
	public float road2Stretch; // 0x68
	public float road3Stretch; // 0x6C
	public int road1StretchType; // 0x70
	public int road2StretchType; // 0x74
	public int road3StretchType; // 0x78
	public int subdivide1; // 0x7C
	public int subdivide2; // 0x80
	public int subdivide3; // 0x84
	public float resolution; // 0x88
	public bool blend; // 0x8C
	public float blendDistance; // 0x90
	public int blendSection; // 0x94
	public bool triangleStrip; // 0x98
	public float triangleStripDistance; // 0x9C
	public float triangleStripUVStart; // 0xA0
	public float triangleStripUVEnd; // 0xA4
	public Material triangleStripMaterial; // 0xA8

	// Methods

	// RVA: 0x9BCF10 Offset: 0x9BB510 VA: 0x1809BCF10
	public void Init(ERModularBase scr) { }

	// RVA: 0x9BCE30 Offset: 0x9BB430 VA: 0x1809BCE30
	public static ERMaterial CreateInstance(ERModularBase scr) { }

	// RVA: 0x9BCFB0 Offset: 0x9BB5B0 VA: 0x1809BCFB0
	public static string[] OCQOOCOQQC(ERModularBase scr) { }

	// RVA: 0x9BD6B0 Offset: 0x9BBCB0 VA: 0x1809BD6B0
	public static ERMaterial OQDQOCCODO(ERModularBase scr, ERIConnector prefab, ref int targetRoad, ref int index) { }

	// RVA: 0x9BD0E0 Offset: 0x9BB6E0 VA: 0x1809BD0E0
	public static Material OOQCDDQODC(ERModularBase scr, ERIConnector prefab) { }

	// RVA: 0x9BD8B0 Offset: 0x9BBEB0 VA: 0x1809BD8B0
	public void .ctor() { }

}

