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

	// RVA: 0x8124D0 Offset: 0x810AD0 VA: 0x1808124D0
	private Camera get_Camera() { }

	// RVA: 0x8125D0 Offset: 0x810BD0 VA: 0x1808125D0
	public static bool get_IsSupported() { }

	// RVA: 0x812570 Offset: 0x810B70 VA: 0x180812570
	public static ImpostorRenderer get_Instance() { }

	// RVA: 0x810BE0 Offset: 0x80F1E0 VA: 0x180810BE0
	private void CheckInstance() { }

	// RVA: 0x810CE0 Offset: 0x80F2E0 VA: 0x180810CE0
	public static void Clear() { }

	// RVA: 0x811ED0 Offset: 0x8104D0 VA: 0x180811ED0
	public static void Register(ImpostorShadows shadows) { }

	// RVA: 0x812200 Offset: 0x810800 VA: 0x180812200
	public static void Unregister(ImpostorShadows shadows) { }

	// RVA: 0x811F80 Offset: 0x810580 VA: 0x180811F80
	public static void Register(Impostor impostor) { }

	// RVA: 0x8122B0 Offset: 0x8108B0 VA: 0x1808122B0
	public static void Unregister(Impostor impostor) { }

	// RVA: 0x811C90 Offset: 0x810290 VA: 0x180811C90
	public static void RegisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x812060 Offset: 0x810660 VA: 0x180812060
	public static void UnregisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x810B60 Offset: 0x80F160 VA: 0x180810B60
	private void Awake() { }

	// RVA: 0x811240 Offset: 0x80F840 VA: 0x180811240
	private void OnEnable() { }

	// RVA: 0x8111F0 Offset: 0x80F7F0 VA: 0x1808111F0
	private void OnDisable() { }

	// RVA: 0x8113D0 Offset: 0x80F9D0 VA: 0x1808113D0
	public void OnPreCull() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x812390 Offset: 0x810990 VA: 0x180812390
	private static void .cctor() { }

}

