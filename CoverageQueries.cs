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

	// RVA: 0x6BF4D0 Offset: 0x6BDAD0 VA: 0x1806BF4D0
	public static CoverageQueries get_Instance() { }

	// RVA: 0x6BF530 Offset: 0x6BDB30 VA: 0x1806BF530
	public static bool get_Supported() { }

	// RVA: 0x6BF470 Offset: 0x6BDA70 VA: 0x1806BF470
	public static bool get_DebugShow() { }

	// RVA: 0x6BF540 Offset: 0x6BDB40 VA: 0x1806BF540
	public static void set_DebugShow(bool value) { }

	// RVA: 0x6BD1F0 Offset: 0x6BB7F0 VA: 0x1806BD1F0
	private void Awake() { }

	// RVA: 0x6BDAD0 Offset: 0x6BC0D0 VA: 0x1806BDAD0
	private void OnEnable() { }

	// RVA: 0x6BD9E0 Offset: 0x6BBFE0 VA: 0x1806BD9E0
	private void OnDisable() { }

	// RVA: 0x6BF1C0 Offset: 0x6BD7C0 VA: 0x1806BF1C0
	private void Update() { }

	// RVA: 0x6BDC60 Offset: 0x6BC260 VA: 0x1806BDC60
	private void OnPostRender() { }

	// RVA: 0x6BE860 Offset: 0x6BCE60 VA: 0x1806BE860
	private void UpdateCollection() { }

	// RVA: 0x6BDD80 Offset: 0x6BC380 VA: 0x1806BDD80
	private void PrepareAndDispatch() { }

	// RVA: 0x6BD8C0 Offset: 0x6BBEC0 VA: 0x1806BD8C0
	private void IssueRead() { }

	// RVA: 0x6BD280 Offset: 0x6BB880 VA: 0x1806BD280
	private void FetchAndAnalyseResults() { }

	// RVA: 0x6BE600 Offset: 0x6BCC00 VA: 0x1806BE600
	public static void RegisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BE7A0 Offset: 0x6BCDA0 VA: 0x1806BE7A0
	public static void UnregisterQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BF100 Offset: 0x6BD700 VA: 0x1806BF100
	public static void UpdateQuery(CoverageQueries.Query query) { }

	// RVA: 0x6BF460 Offset: 0x6BDA60 VA: 0x1806BF460
	public void .ctor() { }

	// RVA: 0x6BF1E0 Offset: 0x6BD7E0 VA: 0x1806BF1E0
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

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	public void Attach(Material coverageMat) { }

	// RVA: 0x6AD9C0 Offset: 0x6ABFC0 VA: 0x1806AD9C0
	public void Dispose(bool data = True) { }

	// RVA: 0x6AD5C0 Offset: 0x6ABBC0 VA: 0x1806AD5C0
	public bool CheckResize(int count) { }

	// RVA: 0x6ADD30 Offset: 0x6AC330 VA: 0x1806ADD30
	public void UploadData() { }

	// RVA: 0x6AD8D0 Offset: 0x6ABED0 VA: 0x1806AD8D0
	public void Dispatch(int count) { }

	// RVA: 0x6ADCA0 Offset: 0x6AC2A0 VA: 0x1806ADCA0
	public void IssueRead() { }

	// RVA: 0x6ADB50 Offset: 0x6AC150 VA: 0x1806ADB50
	public void GetResults() { }

	// RVA: 0x6ADD80 Offset: 0x6AC380 VA: 0x1806ADD80
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

	// RVA: 0x6C84C0 Offset: 0x6C6AC0 VA: 0x1806C84C0
	public bool get_IsRegistered() { }

	// RVA: 0x6C8150 Offset: 0x6C6750 VA: 0x1806C8150
	private void Reset() { }

	// RVA: 0x6C83F0 Offset: 0x6C69F0 VA: 0x1806C83F0
	public void .ctor() { }

	// RVA: 0x6C8430 Offset: 0x6C6A30 VA: 0x1806C8430
	public void .ctor(Vector3 position, CoverageQueries.RadiusSpace radiusSpace, float radius, int sampleCount, float smoothingSpeed = 15) { }

	// RVA: 0x6C80F0 Offset: 0x6C66F0 VA: 0x1806C80F0
	public void Register() { }

	// RVA: 0x6C8360 Offset: 0x6C6960 VA: 0x1806C8360
	public void Update(Vector3 position, float radius) { }

	// RVA: 0x6C8280 Offset: 0x6C6880 VA: 0x1806C8280
	public void UpdatePosition(Vector3 position) { }

	// RVA: 0x6C82F0 Offset: 0x6C68F0 VA: 0x1806C82F0
	public void UpdateRadius(float radius) { }

	// RVA: 0x6C8180 Offset: 0x6C6780 VA: 0x1806C8180
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

