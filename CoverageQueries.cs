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

	// RVA: 0x6BF5E0 Offset: 0x6BDBE0 VA: 0x1806BF5E0
	public static CoverageQueries get_Instance() { }

	// RVA: 0x6BF640 Offset: 0x6BDC40 VA: 0x1806BF640
	public static bool get_Supported() { }

	// RVA: 0x6BF580 Offset: 0x6BDB80 VA: 0x1806BF580
	public static bool get_DebugShow() { }

	// RVA: 0x6BF650 Offset: 0x6BDC50 VA: 0x1806BF650
	public static void set_DebugShow(bool value) { }

	// RVA: 0x6BD300 Offset: 0x6BB900 VA: 0x1806BD300
	private void Awake() { }

	// RVA: 0x6BDBE0 Offset: 0x6BC1E0 VA: 0x1806BDBE0
	private void OnEnable() { }

	// RVA: 0x6BDAF0 Offset: 0x6BC0F0 VA: 0x1806BDAF0
	private void OnDisable() { }

	// RVA: 0x6BF2D0 Offset: 0x6BD8D0 VA: 0x1806BF2D0
	private void Update() { }

	// RVA: 0x6BDD70 Offset: 0x6BC370 VA: 0x1806BDD70
	private void OnPostRender() { }

	// RVA: 0x6BE970 Offset: 0x6BCF70 VA: 0x1806BE970
	private void UpdateCollection() { }

	// RVA: 0x6BDE90 Offset: 0x6BC490 VA: 0x1806BDE90
	private void PrepareAndDispatch() { }

	// RVA: 0x6BD9D0 Offset: 0x6BBFD0 VA: 0x1806BD9D0
	private void IssueRead() { }

	// RVA: 0x6BD390 Offset: 0x6BB990 VA: 0x1806BD390
	private void FetchAndAnalyseResults() { }

	// RVA: 0x6BE710 Offset: 0x6BCD10 VA: 0x1806BE710
	public static void RegisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BE8B0 Offset: 0x6BCEB0 VA: 0x1806BE8B0
	public static void UnregisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BF210 Offset: 0x6BD810 VA: 0x1806BF210
	public static void UpdateQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BF570 Offset: 0x6BDB70 VA: 0x1806BF570
	public void .ctor() { }

	// RVA: 0x6BF2F0 Offset: 0x6BD8F0 VA: 0x1806BF2F0
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

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	public void Attach(Material coverageMat) { }

	// RVA: 0x6ADAD0 Offset: 0x6AC0D0 VA: 0x1806ADAD0
	public void Dispose(bool data = True) { }

	// RVA: 0x6AD6D0 Offset: 0x6ABCD0 VA: 0x1806AD6D0
	public bool CheckResize(int count) { }

	// RVA: 0x6ADE40 Offset: 0x6AC440 VA: 0x1806ADE40
	public void UploadData() { }

	// RVA: 0x6AD9E0 Offset: 0x6ABFE0 VA: 0x1806AD9E0
	public void Dispatch(int count) { }

	// RVA: 0x6ADDB0 Offset: 0x6AC3B0 VA: 0x1806ADDB0
	public void IssueRead() { }

	// RVA: 0x6ADC60 Offset: 0x6AC260 VA: 0x1806ADC60
	public void GetResults() { }

	// RVA: 0x6ADE90 Offset: 0x6AC490 VA: 0x1806ADE90
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

	// RVA: 0x6C85D0 Offset: 0x6C6BD0 VA: 0x1806C85D0
	public bool get_IsRegistered() { }

	// RVA: 0x6C8260 Offset: 0x6C6860 VA: 0x1806C8260
	private void Reset() { }

	// RVA: 0x6C8500 Offset: 0x6C6B00 VA: 0x1806C8500
	public void .ctor() { }

	// RVA: 0x6C8540 Offset: 0x6C6B40 VA: 0x1806C8540
	public void .ctor(Vector3 position, CoverageQueries.RadiusSpace radiusSpace, float radius, int sampleCount, float smoothingSpeed = 15) { }

	// RVA: 0x6C8200 Offset: 0x6C6800 VA: 0x1806C8200
	public void Register() { }

	// RVA: 0x6C8470 Offset: 0x6C6A70 VA: 0x1806C8470
	public void Update(Vector3 position, float radius) { }

	// RVA: 0x6C8390 Offset: 0x6C6990 VA: 0x1806C8390
	public void UpdatePosition(Vector3 position) { }

	// RVA: 0x6C8400 Offset: 0x6C6A00 VA: 0x1806C8400
	public void UpdateRadius(float radius) { }

	// RVA: 0x6C8290 Offset: 0x6C6890 VA: 0x1806C8290
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

