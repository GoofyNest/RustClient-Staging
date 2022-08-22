public class QDQDOOQQOOQDD : MonoBehaviour // TypeDefIndex: 7280
{	// Fields
	private List<Vector3> ᙃ; // 0x18
	private float[,] ᙄ; // 0x20
	private float[] ᙅ; // 0x28
	private TerrainData 4AAAA; // 0x30
	public static float minx; // 0x0
	public static float minz; // 0x4
	public static float maxx; // 0x8
	public static float maxz; // 0xC
	public static Vector2 splatMapScale; // 0x10
	public static List<GameObject> surfaceObjects; // 0x18
	public static List<GameObject> tunnelObjects; // 0x20
	public static int crossingSurfacesStart; // 0x28
	public static int sideObjectSurfacesStart; // 0x2C
	public static List<GameObject> treeObjects; // 0x30
	public static List<GameObject> detailObjects; // 0x38

	// Methods

	// RVA: 0xB68660 Offset: 0xB66C60 VA: 0x180B68660
	public static void ODDCCODOOC(ERModularBase scr, Terrain terrain) { }

	// RVA: 0xB66B70 Offset: 0xB65170 VA: 0x180B66B70
	public static void ODCQDDOQCD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float m_minx, float m_maxx, float m_minz, float m_maxz) { }

	// RVA: 0xB6D350 Offset: 0xB6B950 VA: 0x180B6D350
	public static void OOCQDQCDOD(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint, RaycastHit hit) { }

	// RVA: 0xB63AF0 Offset: 0xB620F0 VA: 0x180B63AF0
	public static void GetHitPointInfoOld(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint) { }

	// RVA: 0xB70C00 Offset: 0xB6F200 VA: 0x180B70C00
	public static void OQOQCCCODC(ERModularBase scr, ref float minx, ref float minz, ref float maxx, ref float maxz, float splatmapScale) { }

	// RVA: 0xB69E70 Offset: 0xB68470 VA: 0x180B69E70
	public static void ODQODCQQCQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6CC30 Offset: 0xB6B230 VA: 0x180B6CC30
	public static void OOCDDQCCDD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6AA10 Offset: 0xB69010 VA: 0x180B6AA10
	public static void OOCDDOOCQC(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB645D0 Offset: 0xB62BD0 VA: 0x180B645D0
	public static void OCCDDODDDD(ref bool[,] holes, float[,] heights, float height, ref List<ERCell> terrainScrHoles, Vector3 lp, Vector3 rp, Vector3 terrainPos, float stepx, float stepy, float tHeight, float size) { }

	// RVA: 0xB6A730 Offset: 0xB68D30 VA: 0x180B6A730
	public static bool ODQODDQCCD(float[,] heights, float height, int x, int y, float rHeight, float tHeight, float size, float terrainY) { }

	// RVA: 0xB69570 Offset: 0xB67B70 VA: 0x180B69570
	public static void ODQCOCOQQD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB650F0 Offset: 0xB636F0 VA: 0x180B650F0
	public static float[,,] OCCODCQOCO(List<ERSplatmap> mapData, float[,,] trmap, int layers) { }

	// RVA: 0xB68AC0 Offset: 0xB670C0 VA: 0x180B68AC0
	public static void ODODDDDCOQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB73680 Offset: 0xB71C80 VA: 0x180B73680
	public static void OQQOQOQQQC(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB661C0 Offset: 0xB647C0 VA: 0x180B661C0
	public static void ODCOOQCCCD(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB6E990 Offset: 0xB6CF90 VA: 0x180B6E990
	public static void OOQDOQDCOO(TerrainData terrainInfo, int layer, List<tPoint> points) { }

	// RVA: 0xB70510 Offset: 0xB6EB10 VA: 0x180B70510
	public static List<tPoint> OQODQCQCCQ(ERModularBase scr, Terrain terrain, TerrainData terrainInfo, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB702E0 Offset: 0xB6E8E0 VA: 0x180B702E0
	public static void OQCQDDOOCQ(ERTerrain tr, Terrain terrain) { }

	// RVA: 0xB6E430 Offset: 0xB6CA30 VA: 0x180B6E430
	public static void OOODOOOQCC(ERTerrain tr, Terrain terrain, float perc) { }

	// RVA: 0xB6DE90 Offset: 0xB6C490 VA: 0x180B6DE90
	public static void OOOCCDQODO(GameObject go, int x, int y, ref List<ERSplatmap> instances, float[,,] trmap, int layers, Vector2 uvy) { }

	// RVA: 0xB6F3B0 Offset: 0xB6D9B0 VA: 0x180B6F3B0
	public static void OOQQQQDCCO(ERModularBase baseScript, ERModularRoad scr) { }

	// RVA: 0xB63650 Offset: 0xB61C50 VA: 0x180B63650
	public static GameObject CreateMesh(Transform parent, List<Vector3> vecs, List<int> tris, int layer, ERModularRoad scr, string name) { }

	// RVA: 0xB65EA0 Offset: 0xB644A0 VA: 0x180B65EA0
	public static void OCCQODOQDD(ERTerrain terrain, string folder) { }

	// RVA: 0xB700F0 Offset: 0xB6E6F0 VA: 0x180B700F0
	public static void OQCOQDDCCC(ERTerrain terrain, string folder) { }

	// RVA: 0xB6F110 Offset: 0xB6D710 VA: 0x180B6F110
	public static void OOQQOOOQOO(ERTerrain terrain, string folder) { }

	// RVA: 0xB66440 Offset: 0xB64A40 VA: 0x180B66440
	public static void ODCOQQQCCO(ERTerrain terrain, string folder) { }

	// RVA: 0xB65C10 Offset: 0xB64210 VA: 0x180B65C10
	public static void OCCOODODOQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB64EC0 Offset: 0xB634C0 VA: 0x180B64EC0
	public static void OCCDQQCODQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB6E720 Offset: 0xB6CD20 VA: 0x180B6E720
	public static void OOOOCQCDQQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB6EB40 Offset: 0xB6D140 VA: 0x180B6EB40
	public static void OOQOCCCCDD(ERTerrain terrain, string folder) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xB73860 Offset: 0xB71E60 VA: 0x180B73860
	private static void .cctor() { }

}

