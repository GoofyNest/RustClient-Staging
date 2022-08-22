public class ERDecal : ScriptableObject // TypeDefIndex: 7213
{	// Fields
	public int id; // 0x18
	public string name; // 0x20
	public ERDecalType type; // 0x28
	public double roadType1; // 0x30
	public double roadType2; // 0x38
	public int connection; // 0x40
	public GameObject decalPrefab; // 0x48
	public float baseWidth; // 0x50
	public float meshWidth; // 0x54
	public float scale; // 0x58
	public Vector3 localScale; // 0x5C
	public int priority; // 0x68
	public bool collapsed; // 0x6C
	public float heightOffset; // 0x70
	public Material material; // 0x78
	public Vector2 uvLeftTop; // 0x80
	public Vector2 uvRightBottom; // 0x88
	public float width; // 0x90
	public float length; // 0x94
	public float xOffset; // 0x98
	public float startOffset; // 0x9C
	public float endOffset; // 0xA0
	public float endRotation; // 0xA4
	public List<Vector2> uvBreakPoints; // 0xA8
	public List<float> distances; // 0xB0
	public ERDecalPosition position; // 0xB8
	public Vector2 uvLeftTop1; // 0xBC
	public Vector2 uvRightBottom1; // 0xC4
	public Vector2 uvLeftTop2; // 0xCC
	public Vector2 uvRightBottom2; // 0xD4
	public float width1; // 0xDC
	public float width2; // 0xE0

	// Methods

	// RVA: 0x9AA5D0 Offset: 0x9A8BD0 VA: 0x1809AA5D0
	public void Init(GameObject prefab, float baseWidth) { }

	// RVA: 0x9AA340 Offset: 0x9A8940 VA: 0x1809AA340
	public static ERDecal CreateInstance(GameObject prefab, float baseWidth) { }

	// RVA: 0x9AA0D0 Offset: 0x9A86D0 VA: 0x1809AA0D0
	public static void CopyDecal(ERDecalClass source, ERDecal target) { }

	// RVA: 0x9AAF40 Offset: 0x9A9540 VA: 0x1809AAF40
	public static void OODDOCCOCC(ERDecal source, ERDecal target) { }

	// RVA: 0x9AAB70 Offset: 0x9A9170 VA: 0x1809AAB70
	public void OCQCQCOCOO() { }

	// RVA: 0x9AA9F0 Offset: 0x9A8FF0 VA: 0x1809AA9F0
	public static ERDecal OCQCDQDODQ(int id, List<ERDecal> decalPresets) { }

	// RVA: 0x9AA420 Offset: 0x9A8A20 VA: 0x1809AA420
	public static List<ERDecal> FilterByType(List<ERDecal> lst, ERDecalType type) { }

	// RVA: 0x9AB120 Offset: 0x9A9720 VA: 0x1809AB120
	public static string[] OQDOCOQOQD(ref List<ERDecal> decals, string firstItem, int id1, int id2, ref int _index1, ref int _index2, ERDecalType type, ERDecalPosition position) { }

	// RVA: 0x9AAD70 Offset: 0x9A9370 VA: 0x1809AAD70
	public static int ODCOCCOOOO(List<ERDecal> decals, int tindex, ERDecalType type) { }

	// RVA: 0x9AA7E0 Offset: 0x9A8DE0 VA: 0x1809AA7E0
	public static GameObject[] OCCODDOQDO(List<ERDecal> decals, ref List<int> priority, ref List<float> scale) { }

	// RVA: 0x9AA680 Offset: 0x9A8C80 VA: 0x1809AA680
	public void MatchDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

	// RVA: 0x9AB4C0 Offset: 0x9A9AC0 VA: 0x1809AB4C0
	public void SetBreakPointDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

	// RVA: 0x9AB580 Offset: 0x9A9B80 VA: 0x1809AB580
	public void .ctor() { }

}

