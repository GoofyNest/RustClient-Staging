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

	// RVA: 0x9A9E20 Offset: 0x9A8420 VA: 0x1809A9E20
	public void Init(GameObject prefab, float baseWidth) { }

	// RVA: 0x9A9B90 Offset: 0x9A8190 VA: 0x1809A9B90
	public static ERDecal CreateInstance(GameObject prefab, float baseWidth) { }

	// RVA: 0x9A9920 Offset: 0x9A7F20 VA: 0x1809A9920
	public static void CopyDecal(ERDecalClass source, ERDecal target) { }

	// RVA: 0x9AA790 Offset: 0x9A8D90 VA: 0x1809AA790
	public static void OODDOCCOCC(ERDecal source, ERDecal target) { }

	// RVA: 0x9AA3C0 Offset: 0x9A89C0 VA: 0x1809AA3C0
	public void OCQCQCOCOO() { }

	// RVA: 0x9AA240 Offset: 0x9A8840 VA: 0x1809AA240
	public static ERDecal OCQCDQDODQ(int id, List<ERDecal> decalPresets) { }

	// RVA: 0x9A9C70 Offset: 0x9A8270 VA: 0x1809A9C70
	public static List<ERDecal> FilterByType(List<ERDecal> lst, ERDecalType type) { }

	// RVA: 0x9AA970 Offset: 0x9A8F70 VA: 0x1809AA970
	public static string[] OQDOCOQOQD(ref List<ERDecal> decals, string firstItem, int id1, int id2, ref int _index1, ref int _index2, ERDecalType type, ERDecalPosition position) { }

	// RVA: 0x9AA5C0 Offset: 0x9A8BC0 VA: 0x1809AA5C0
	public static int ODCOCCOOOO(List<ERDecal> decals, int tindex, ERDecalType type) { }

	// RVA: 0x9AA030 Offset: 0x9A8630 VA: 0x1809AA030
	public static GameObject[] OCCODDOQDO(List<ERDecal> decals, ref List<int> priority, ref List<float> scale) { }

	// RVA: 0x9A9ED0 Offset: 0x9A84D0 VA: 0x1809A9ED0
	public void MatchDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

	// RVA: 0x9AAD10 Offset: 0x9A9310 VA: 0x1809AAD10
	public void SetBreakPointDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

	// RVA: 0x9AADD0 Offset: 0x9A93D0 VA: 0x1809AADD0
	public void .ctor() { }

}

