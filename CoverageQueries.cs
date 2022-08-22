public class CoverageQueries : MonoBehaviour // TypeDefIndex: 11479
{	// Fields
	public bool debug; // 0x18
	public float depthBias; // 0x1C
	private static List<CoverageQueries.Query> pool; // 0x0
	private static List<CoverageQueries.Query> added; // 0x8
	private static List<CoverageQueries.Query> reused; // 0x10
	private static List<int> removed; // 0x18
	private static List<int> changed; // 0x20
	private static Queue<int> freed; // 0x28
	private static CoverageQueries.BufferSet buffer; // 0x30
	private Camera camera; // 0x20
	private Material coverageMat; // 0x28
	private static CoverageQueries instance; // 0x38
	private static bool _debugShow; // 0x40

	// Properties
	public static CoverageQueries Instance { get; }
	public static bool Supported { get; }
	public static bool DebugShow { get; set; }

	// Methods

	// RVA: 0x6BF570 Offset: 0x6BDB70 VA: 0x1806BF570
	public static CoverageQueries get_Instance() { }

	// RVA: 0x6BF5D0 Offset: 0x6BDBD0 VA: 0x1806BF5D0
	public static bool get_Supported() { }

	// RVA: 0x6BF510 Offset: 0x6BDB10 VA: 0x1806BF510
	public static bool get_DebugShow() { }

	// RVA: 0x6BF5E0 Offset: 0x6BDBE0 VA: 0x1806BF5E0
	public static void set_DebugShow(bool value) { }

	// RVA: 0x6BD290 Offset: 0x6BB890 VA: 0x1806BD290
	private void Awake() { }

	// RVA: 0x6BDB70 Offset: 0x6BC170 VA: 0x1806BDB70
	private void OnEnable() { }

	// RVA: 0x6BDA80 Offset: 0x6BC080 VA: 0x1806BDA80
	private void OnDisable() { }

	// RVA: 0x6BF260 Offset: 0x6BD860 VA: 0x1806BF260
	private void Update() { }

	// RVA: 0x6BDD00 Offset: 0x6BC300 VA: 0x1806BDD00
	private void OnPostRender() { }

	// RVA: 0x6BE900 Offset: 0x6BCF00 VA: 0x1806BE900
	private void UpdateCollection() { }

	// RVA: 0x6BDE20 Offset: 0x6BC420 VA: 0x1806BDE20
	private void PrepareAndDispatch() { }

	// RVA: 0x6BD960 Offset: 0x6BBF60 VA: 0x1806BD960
	private void IssueRead() { }

	// RVA: 0x6BD320 Offset: 0x6BB920 VA: 0x1806BD320
	private void FetchAndAnalyseResults() { }

	// RVA: 0x6BE6A0 Offset: 0x6BCCA0 VA: 0x1806BE6A0
	public static void RegisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BE840 Offset: 0x6BCE40 VA: 0x1806BE840
	public static void UnregisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BF1A0 Offset: 0x6BD7A0 VA: 0x1806BF1A0
	public static void UpdateQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BF500 Offset: 0x6BDB00 VA: 0x1806BF500
	public void .ctor() { }

	// RVA: 0x6BF280 Offset: 0x6BD880 VA: 0x1806BF280
	private static void .cctor() { }

}

public class CoverageQueries.BufferSet // TypeDefIndex: 11480
{	// Fields
	public int width; // 0x10
	public int height; // 0x14
	public Texture2D inputTexture; // 0x18
	public RenderTexture resultTexture; // 0x20
	public Color[] inputData; // 0x28
	public Color32[] resultData; // 0x30
	private Material coverageMat; // 0x38
	private const int MaxAsyncGPUReadbackRequests = 10;
	private Queue<AsyncGPUReadbackRequest> asyncRequests; // 0x40

	// Methods

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	public void Attach(Material coverageMat) { }

	// RVA: 0x6ADA60 Offset: 0x6AC060 VA: 0x1806ADA60
	public void Dispose(bool data = True) { }

	// RVA: 0x6AD660 Offset: 0x6ABC60 VA: 0x1806AD660
	public bool CheckResize(int count) { }

	// RVA: 0x6ADDD0 Offset: 0x6AC3D0 VA: 0x1806ADDD0
	public void UploadData() { }

	// RVA: 0x6AD970 Offset: 0x6ABF70 VA: 0x1806AD970
	public void Dispatch(int count) { }

	// RVA: 0x6ADD40 Offset: 0x6AC340 VA: 0x1806ADD40
	public void IssueRead() { }

	// RVA: 0x6ADBF0 Offset: 0x6AC1F0 VA: 0x1806ADBF0
	public void GetResults() { }

	// RVA: 0x6ADE20 Offset: 0x6AC420 VA: 0x1806ADE20
	public void .ctor() { }

}

public enum CoverageQueries.RadiusSpace // TypeDefIndex: 11481
{	// Fields
	public int value__; // 0x0
	public const CoverageQueries.RadiusSpace ScreenNormalized = 0;
	public const CoverageQueries.RadiusSpace World = 1;

}

public class CoverageQueries.Query // TypeDefIndex: 11482
{	// Fields
	public CoverageQueries.Query.Input input; // 0x10
	public CoverageQueries.Query.Internal intern; // 0x2C
	public CoverageQueries.Query.Result result; // 0x30

	// Properties
	public bool IsRegistered { get; }

	// Methods

	// RVA: 0x6C8560 Offset: 0x6C6B60 VA: 0x1806C8560
	public bool get_IsRegistered() { }

	// RVA: 0x6C81F0 Offset: 0x6C67F0 VA: 0x1806C81F0
	private void Reset() { }

	// RVA: 0x6C8490 Offset: 0x6C6A90 VA: 0x1806C8490
	public void .ctor() { }

	// RVA: 0x6C84D0 Offset: 0x6C6AD0 VA: 0x1806C84D0
	public void .ctor(Vector3 position, CoverageQueries.RadiusSpace radiusSpace, float radius, int sampleCount, float smoothingSpeed = 15) { }

	// RVA: 0x6C8190 Offset: 0x6C6790 VA: 0x1806C8190
	public void Register() { }

	// RVA: 0x6C8400 Offset: 0x6C6A00 VA: 0x1806C8400
	public void Update(Vector3 position, float radius) { }

	// RVA: 0x6C8320 Offset: 0x6C6920 VA: 0x1806C8320
	public void UpdatePosition(Vector3 position) { }

	// RVA: 0x6C8390 Offset: 0x6C6990 VA: 0x1806C8390
	public void UpdateRadius(float radius) { }

	// RVA: 0x6C8220 Offset: 0x6C6820 VA: 0x1806C8220
	public void Unregister() { }

}

public struct CoverageQueries.Query.Input // TypeDefIndex: 11483
{	// Fields
	public Vector3 position; // 0x0
	public CoverageQueries.RadiusSpace radiusSpace; // 0xC
	public float radius; // 0x10
	public int sampleCount; // 0x14
	public float smoothingSpeed; // 0x18

}

public struct CoverageQueries.Query.Internal // TypeDefIndex: 11484
{	// Fields
	public int id; // 0x0

	// Methods

	// RVA: 0xF3DA0 Offset: 0xF31A0 VA: 0x1800F3DA0
	public void Reset() { }

}

public struct CoverageQueries.Query.Result // TypeDefIndex: 11485
{	// Fields
	public int passed; // 0x0
	public float coverage; // 0x4
	public float smoothCoverage; // 0x8
	public float weightedCoverage; // 0xC
	public float weightedSmoothCoverage; // 0x10
	public bool originOccluded; // 0x14
	public int frame; // 0x18
	public float originVisibility; // 0x1C
	public float originSmoothVisibility; // 0x20

	// Methods

	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public void Reset() { }

}

