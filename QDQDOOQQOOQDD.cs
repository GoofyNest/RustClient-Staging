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

	// RVA: 0xB67ED0 Offset: 0xB664D0 VA: 0x180B67ED0
	public static void ODDCCODOOC(ERModularBase scr, Terrain terrain) { }

	// RVA: 0xB663E0 Offset: 0xB649E0 VA: 0x180B663E0
	public static void ODCQDDOQCD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float m_minx, float m_maxx, float m_minz, float m_maxz) { }

	// RVA: 0xB6CBC0 Offset: 0xB6B1C0 VA: 0x180B6CBC0
	public static void OOCQDQCDOD(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint, RaycastHit hit) { }

	// RVA: 0xB63360 Offset: 0xB61960 VA: 0x180B63360
	public static void GetHitPointInfoOld(int triangleIndex, Collider collider, Vector3 hitPos, ref float perc, ref bool critical, ref float outerHeight, ref Vector3 outerPoint) { }

	// RVA: 0xB70470 Offset: 0xB6EA70 VA: 0x180B70470
	public static void OQOQCCCODC(ERModularBase scr, ref float minx, ref float minz, ref float maxx, ref float maxz, float splatmapScale) { }

	// RVA: 0xB696E0 Offset: 0xB67CE0 VA: 0x180B696E0
	public static void ODQODCQQCQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6C4A0 Offset: 0xB6AAA0 VA: 0x180B6C4A0
	public static void OOCDDQCCDD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6A280 Offset: 0xB68880 VA: 0x180B6A280
	public static void OOCDDOOCQC(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB63E40 Offset: 0xB62440 VA: 0x180B63E40
	public static void OCCDDODDDD(ref bool[,] holes, float[,] heights, float height, ref List<ERCell> terrainScrHoles, Vector3 lp, Vector3 rp, Vector3 terrainPos, float stepx, float stepy, float tHeight, float size) { }

	// RVA: 0xB69FA0 Offset: 0xB685A0 VA: 0x180B69FA0
	public static bool ODQODDQCCD(float[,] heights, float height, int x, int y, float rHeight, float tHeight, float size, float terrainY) { }

	// RVA: 0xB68DE0 Offset: 0xB673E0 VA: 0x180B68DE0
	public static void ODQCOCOQQD(ERModularBase scr, ERTerrain terrainScr, Terrain terrain, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB64960 Offset: 0xB62F60 VA: 0x180B64960
	public static float[,,] OCCODCQOCO(List<ERSplatmap> mapData, float[,,] trmap, int layers) { }

	// RVA: 0xB68330 Offset: 0xB66930 VA: 0x180B68330
	public static void ODODDDDCOQ(ERModularBase scr, ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB72EF0 Offset: 0xB714F0 VA: 0x180B72EF0
	public static void OQQOQOQQQC(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB65A30 Offset: 0xB64030 VA: 0x180B65A30
	public static void ODCOOQCCCD(ERTerrain terrainScr, Terrain terrain) { }

	// RVA: 0xB6E200 Offset: 0xB6C800 VA: 0x180B6E200
	public static void OOQDOQDCOO(TerrainData terrainInfo, int layer, List<tPoint> points) { }

	// RVA: 0xB6FD80 Offset: 0xB6E380 VA: 0x180B6FD80
	public static List<tPoint> OQODQCQCCQ(ERModularBase scr, Terrain terrain, TerrainData terrainInfo, float minx, float maxx, float minz, float maxz) { }

	// RVA: 0xB6FB50 Offset: 0xB6E150 VA: 0x180B6FB50
	public static void OQCQDDOOCQ(ERTerrain tr, Terrain terrain) { }

	// RVA: 0xB6DCA0 Offset: 0xB6C2A0 VA: 0x180B6DCA0
	public static void OOODOOOQCC(ERTerrain tr, Terrain terrain, float perc) { }

	// RVA: 0xB6D700 Offset: 0xB6BD00 VA: 0x180B6D700
	public static void OOOCCDQODO(GameObject go, int x, int y, ref List<ERSplatmap> instances, float[,,] trmap, int layers, Vector2 uvy) { }

	// RVA: 0xB6EC20 Offset: 0xB6D220 VA: 0x180B6EC20
	public static void OOQQQQDCCO(ERModularBase baseScript, ERModularRoad scr) { }

	// RVA: 0xB62EC0 Offset: 0xB614C0 VA: 0x180B62EC0
	public static GameObject CreateMesh(Transform parent, List<Vector3> vecs, List<int> tris, int layer, ERModularRoad scr, string name) { }

	// RVA: 0xB65710 Offset: 0xB63D10 VA: 0x180B65710
	public static void OCCQODOQDD(ERTerrain terrain, string folder) { }

	// RVA: 0xB6F960 Offset: 0xB6DF60 VA: 0x180B6F960
	public static void OQCOQDDCCC(ERTerrain terrain, string folder) { }

	// RVA: 0xB6E980 Offset: 0xB6CF80 VA: 0x180B6E980
	public static void OOQQOOOQOO(ERTerrain terrain, string folder) { }

	// RVA: 0xB65CB0 Offset: 0xB642B0 VA: 0x180B65CB0
	public static void ODCOQQQCCO(ERTerrain terrain, string folder) { }

	// RVA: 0xB65480 Offset: 0xB63A80 VA: 0x180B65480
	public static void OCCOODODOQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB64730 Offset: 0xB62D30 VA: 0x180B64730
	public static void OCCDQQCODQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB6DF90 Offset: 0xB6C590 VA: 0x180B6DF90
	public static void OOOOCQCDQQ(ERTerrain terrain, string folder) { }

	// RVA: 0xB6E3B0 Offset: 0xB6C9B0 VA: 0x180B6E3B0
	public static void OOQOCCCCDD(ERTerrain terrain, string folder) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xB730D0 Offset: 0xB716D0 VA: 0x180B730D0
	private static void .cctor() { }

}

