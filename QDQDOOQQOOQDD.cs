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

	// RVA: 0xB68190 Offset: 0xB66790 VA: 0x180B68190
	public static void ODDCCODOOC(ERModularBase scr, Terrain terrain) { }

	// RVA: 0xB666A0 Offset: 0xB64CA0 VA: 0x180B666A0
	public static void ODCQDDOQCD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float m_minx, float m_maxx, float m_minz, float m_maxz) { }

	// RVA: 0xB6CE80 Offset: 0xB6B480 VA: 0x180B6CE80
	public static void OOCQDQCDOD(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint, RaycastHit hit) { }

	// RVA: 0xB63620 Offset: 0xB61C20 VA: 0x180B63620
	public static void GetHitPointInfoOld(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint) { }

	// RVA: 0xB70730 Offset: 0xB6ED30 VA: 0x180B70730
	public static void OQOQCCCODC(ERModularBase scr, ref float minx, ref float minz, ref float maxx, ref float maxz, float splatmapScale) { }

	// RVA: 0xB699A0 Offset: 0xB67FA0 VA: 0x180B699A0
	public static void ODQODCQQCQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6C760 Offset: 0xB6AD60 VA: 0x180B6C760
	public static void OOCDDQCCDD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6A540 Offset: 0xB68B40 VA: 0x180B6A540
	public static void OOCDDOOCQC(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB64100 Offset: 0xB62700 VA: 0x180B64100
	public static void OCCDDODDDD(ref bool[,] holes, float[,] heights, float height, ref List<ERCell> terrainScrHoles, Vector3 lp, Vector3 rp, Vector3 terrainPos, float stepx, float stepy, float tHeight, float size) { }

	// RVA: 0xB6A260 Offset: 0xB68860 VA: 0x180B6A260
	public static bool ODQODDQCCD(float[,] heights, float height, int x, int y, float rHeight, float tHeight, float size, float terrainY) { }

	// RVA: 0xB690A0 Offset: 0xB676A0 VA: 0x180B690A0
	public static void ODQCOCOQQD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB64C20 Offset: 0xB63220 VA: 0x180B64C20
	public static float[,,] OCCODCQOCO(List<ERSplatmap> mapData, float[,,] trmap, int layers) { }

	// RVA: 0xB685F0 Offset: 0xB66BF0 VA: 0x180B685F0
	public static void ODODDDDCOQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB731B0 Offset: 0xB717B0 VA: 0x180B731B0
	public static void OQQOQOQQQC(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB65CF0 Offset: 0xB642F0 VA: 0x180B65CF0
	public static void ODCOOQCCCD(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB6E4C0 Offset: 0xB6CAC0 VA: 0x180B6E4C0
	public static void OOQDOQDCOO(TerrainData terrainInfo, int layer, List<tPoint> points) { }

	// RVA: 0xB70040 Offset: 0xB6E640 VA: 0x180B70040
	public static List<tPoint> OQODQCQCCQ(ERModularBase scr, Terrain terrain, TerrainData terrainInfo, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6FE10 Offset: 0xB6E410 VA: 0x180B6FE10
	public static void OQCQDDOOCQ(ERTerrain tr, Terrain terrain) { }

	// RVA: 0xB6DF60 Offset: 0xB6C560 VA: 0x180B6DF60
	public static void OOODOOOQCC(ERTerrain tr, Terrain terrain, float perc) { }

	// RVA: 0xB6D9C0 Offset: 0xB6BFC0 VA: 0x180B6D9C0
	public static void OOOCCDQODO(GameObject go, int x, int y, ref List<ERSplatmap> instances, float[,,] trmap, int layers, Vector2 uvy) { }

	// RVA: 0xB6EEE0 Offset: 0xB6D4E0 VA: 0x180B6EEE0
	public static void OOQQQQDCCO(ERModularBase baseScript, ERModularRoad scr) { }

	// RVA: 0xB63180 Offset: 0xB61780 VA: 0x180B63180
	public static GameObject CreateMesh(Transform parent, List<Vector3> vecs, List<int> tris, int layer, ERModularRoad scr, string name) { }

	// RVA: 0xB659D0 Offset: 0xB63FD0 VA: 0x180B659D0
	public static void OCCQODOQDD(ERTerrain terrain, string folder) { }

	// RVA: 0xB6FC20 Offset: 0xB6E220 VA: 0x180B6FC20
	public static void OQCOQDDCCC(ERTerrain terrain, string folder) { }

	// RVA: 0xB6EC40 Offset: 0xB6D240 VA: 0x180B6EC40
	public static void OOQQOOOQOO(ERTerrain terrain, string folder) { }

	// RVA: 0xB65F70 Offset: 0xB64570 VA: 0x180B65F70
	public static void ODCOQQQCCO(ERTerrain terrain, string folder) { }

	// RVA: 0xB65740 Offset: 0xB63D40 VA: 0x180B65740
	public static void OCCOODODOQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB649F0 Offset: 0xB62FF0 VA: 0x180B649F0
	public static void OCCDQQCODQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB6E250 Offset: 0xB6C850 VA: 0x180B6E250
	public static void OOOOCQCDQQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB6E670 Offset: 0xB6CC70 VA: 0x180B6E670
	public static void OOQOCCCCDD(ERTerrain terrain, string folder) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xB73390 Offset: 0xB71990 VA: 0x180B73390
	private static void .cctor() { }

}

