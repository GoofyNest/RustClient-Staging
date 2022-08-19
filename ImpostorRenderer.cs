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

	// RVA: 0x811E30 Offset: 0x810430 VA: 0x180811E30
	private Camera get_Camera() { }

	// RVA: 0x811F30 Offset: 0x810530 VA: 0x180811F30
	public static bool get_IsSupported() { }

	// RVA: 0x811ED0 Offset: 0x8104D0 VA: 0x180811ED0
	public static ImpostorRenderer get_Instance() { }

	// RVA: 0x810540 Offset: 0x80EB40 VA: 0x180810540
	private void CheckInstance() { }

	// RVA: 0x810640 Offset: 0x80EC40 VA: 0x180810640
	public static void Clear() { }

	// RVA: 0x811830 Offset: 0x80FE30 VA: 0x180811830
	public static void Register(ImpostorShadows shadows) { }

	// RVA: 0x811B60 Offset: 0x810160 VA: 0x180811B60
	public static void Unregister(ImpostorShadows shadows) { }

	// RVA: 0x8118E0 Offset: 0x80FEE0 VA: 0x1808118E0
	public static void Register(Impostor impostor) { }

	// RVA: 0x811C10 Offset: 0x810210 VA: 0x180811C10
	public static void Unregister(Impostor impostor) { }

	// RVA: 0x8115F0 Offset: 0x80FBF0 VA: 0x1808115F0
	public static void RegisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x8119C0 Offset: 0x80FFC0 VA: 0x1808119C0
	public static void UnregisterBatching(ImpostorInstanceData data) { }

	// RVA: 0x8104C0 Offset: 0x80EAC0 VA: 0x1808104C0
	private void Awake() { }

	// RVA: 0x810BA0 Offset: 0x80F1A0 VA: 0x180810BA0
	private void OnEnable() { }

	// RVA: 0x810B50 Offset: 0x80F150 VA: 0x180810B50
	private void OnDisable() { }

	// RVA: 0x810D30 Offset: 0x80F330 VA: 0x180810D30
	public void OnPreCull() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x811CF0 Offset: 0x8102F0 VA: 0x180811CF0
	private static void .cctor() { }

}

