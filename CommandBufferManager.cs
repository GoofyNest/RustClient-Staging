public class CommandBufferManager : MonoBehaviour // TypeDefIndex: 10646
{	// Fields
	private Camera _targetCamera; // 0x18
	private Dictionary<int, CommandBufferManager.CommandBufferEntry> commandBuffers; // 0x20
	private bool changed; // 0x28
	public Action OnPreRenderCall; // 0x30
	public Action OnPreCullCall; // 0x38
	private static Dictionary<Camera, CommandBufferManager> instances; // 0x0

	// Properties
	public Camera targetCamera { get; }
	public Camera Camera { get; }
	public bool IsReady { get; }

	// Methods

	// RVA: 0x57DEF0 Offset: 0x57C4F0 VA: 0x18057DEF0
	public Camera get_targetCamera() { }

	// RVA: 0x57DE70 Offset: 0x57C470 VA: 0x18057DE70
	public Camera get_Camera() { }

	// RVA: 0x57DE80 Offset: 0x57C480 VA: 0x18057DE80
	public bool get_IsReady() { }

	// RVA: 0x57D790 Offset: 0x57BD90 VA: 0x18057D790
	public static CommandBufferManager GetInstance(Camera camera) { }

	// RVA: 0x57D4C0 Offset: 0x57BAC0 VA: 0x18057D4C0
	private void Awake() { }

	// RVA: 0x57D820 Offset: 0x57BE20 VA: 0x18057D820
	private void OnDestroy() { }

	// RVA: 0x57DA80 Offset: 0x57C080 VA: 0x18057DA80
	private void OnEnable() { }

	// RVA: 0x57D8F0 Offset: 0x57BEF0 VA: 0x18057D8F0
	private void OnDisable() { }

	// RVA: 0x57D300 Offset: 0x57B900 VA: 0x18057D300
	public void AddCommands(CommandBufferDesc desc) { }

	// RVA: 0x57DCB0 Offset: 0x57C2B0 VA: 0x18057DCB0
	public void RemoveCommands(CommandBufferDesc desc) { }

	// RVA: 0x57D550 Offset: 0x57BB50 VA: 0x18057D550
	private void CheckUpdateCameraEvents() { }

	// RVA: 0x57DB10 Offset: 0x57C110 VA: 0x18057DB10
	private void OnPreCull() { }

	// RVA: 0x57DC90 Offset: 0x57C290 VA: 0x18057DC90
	private void OnPreRender() { }

	// RVA: 0x57DE00 Offset: 0x57C400 VA: 0x18057DE00
	public void .ctor() { }

	// RVA: 0x57DDA0 Offset: 0x57C3A0 VA: 0x18057DDA0
	private static void .cctor() { }

}

private struct CommandBufferManager.CommandBufferEntry : IEquatable<CommandBufferManager.CommandBufferEntry> // TypeDefIndex: 10647
{	// Fields
	public CommandBuffer buffer; // 0x0
	public List<KeyValuePair<int, Action<CommandBuffer>>> orderedFill; // 0x8

	// Methods

	// RVA: 0xF2C60 Offset: 0xF2060 VA: 0x1800F2C60
	public void Add(int orderId, Action<CommandBuffer> value) { }

	// RVA: 0xF2CC0 Offset: 0xF20C0 VA: 0x1800F2CC0
	public void Remove(int orderId) { }

	// RVA: 0xF2C70 Offset: 0xF2070 VA: 0x1800F2C70
	public bool Contains(int orderId) { }

	// RVA: 0xF2C80 Offset: 0xF2080 VA: 0x1800F2C80 Slot: 4
	public bool Equals(CommandBufferManager.CommandBufferEntry other) { }

	// RVA: 0xF2C90 Offset: 0xF2090 VA: 0x1800F2C90 Slot: 2
	public override int GetHashCode() { }

}

private sealed class CommandBufferManager.CommandBufferEntry.<>c__DisplayClass3_0 // TypeDefIndex: 10648
{	// Fields
	public int orderId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589C50 Offset: 0x588250 VA: 0x180589C50
	internal bool <Remove>b__0(KeyValuePair<int, Action<CommandBuffer>> s) { }

}

