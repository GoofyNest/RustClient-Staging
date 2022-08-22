public class ImpostorRenderer : MonoBehaviour // TypeDefIndex: 10682
{	// Fields
	public const string MainPassName = "DEFERRED";
	private Camera camera; // 0x18
	private static HashSet<ImpostorShadows> Shadows; // 0x0
	private static HashSet<Impostor> Impostors; // 0x8
	private static Dictionary<ImpostorInstanceData, ImpostorBatch> Batches; // 0x10
	private static MaterialPropertyBlock block; // 0x18
	private int treeLayer; // 0x20
	private int treeLayerMask; // 0x24
	private int impostorLayerMask; // 0x28
	private static ImpostorRenderer instance; // 0x20
	private static readonly int NaNProperty; // 0x28
	private static readonly int PositionBufferProperty; // 0x2C

	// Properties
	private Camera Camera { get; }
	public static bool IsSupported { get; }
	public static ImpostorRenderer Instance { get; }

	// Methods

	// RVA: 0x811F40 Offset: 0x810540 VA: 0x180811F40
	private Camera get_Camera() { }

	// RVA: 0x812040 Offset: 0x810640 VA: 0x180812040
	public static bool get_IsSupported() { }

	// RVA: 0x811FE0 Offset: 0x8105E0 VA: 0x180811FE0
	public static ImpostorRenderer get_Instance() { }

	// RVA: 0x810650 Offset: 0x80EC50 VA: 0x180810650
	private void CheckInstance() { }

	// RVA: 0x810750 Offset: 0x80ED50 VA: 0x180810750
	public static void Clear() { }

	// RVA: 0x811940 Offset: 0x80FF40 VA: 0x180811940
	public static void Register(ImpostorShadows shadows) { }

	// RVA: 0x811C70 Offset: 0x810270 VA: 0x180811C70
	public static void Unregister(ImpostorShadows shadows) { }

	// RVA: 0x8119F0 Offset: 0x80FFF0 VA: 0x1808119F0
	public static void Register(Impostor impostor) { }

	// RVA: 0x811D20 Offset: 0x810320 VA: 0x180811D20
	public static void Unregister(Impostor impostor) { }

	// RVA: 0x811700 Offset: 0x80FD00 VA: 0x180811700
	public static void RegisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x811AD0 Offset: 0x8100D0 VA: 0x180811AD0
	public static void UnregisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x8105D0 Offset: 0x80EBD0 VA: 0x1808105D0
	private void Awake() { }

	// RVA: 0x810CB0 Offset: 0x80F2B0 VA: 0x180810CB0
	private void OnEnable() { }

	// RVA: 0x810C60 Offset: 0x80F260 VA: 0x180810C60
	private void OnDisable() { }

	// RVA: 0x810E40 Offset: 0x80F440 VA: 0x180810E40
	public void OnPreCull() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x811E00 Offset: 0x810400 VA: 0x180811E00
	private static void .cctor() { }

}

