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

	// RVA: 0x57DF60 Offset: 0x57C560 VA: 0x18057DF60
	public Camera get_targetCamera() { }

	// RVA: 0x57DEE0 Offset: 0x57C4E0 VA: 0x18057DEE0
	public Camera get_Camera() { }

	// RVA: 0x57DEF0 Offset: 0x57C4F0 VA: 0x18057DEF0
	public bool get_IsReady() { }

	// RVA: 0x57D800 Offset: 0x57BE00 VA: 0x18057D800
	public static CommandBufferManager GetInstance(Camera camera) { }

	// RVA: 0x57D530 Offset: 0x57BB30 VA: 0x18057D530
	private void Awake() { }

	// RVA: 0x57D890 Offset: 0x57BE90 VA: 0x18057D890
	private void OnDestroy() { }

	// RVA: 0x57DAF0 Offset: 0x57C0F0 VA: 0x18057DAF0
	private void OnEnable() { }

	// RVA: 0x57D960 Offset: 0x57BF60 VA: 0x18057D960
	private void OnDisable() { }

	// RVA: 0x57D370 Offset: 0x57B970 VA: 0x18057D370
	public void AddCommands(CommandBufferDesc desc) { }

	// RVA: 0x57DD20 Offset: 0x57C320 VA: 0x18057DD20
	public void RemoveCommands(CommandBufferDesc desc) { }

	// RVA: 0x57D5C0 Offset: 0x57BBC0 VA: 0x18057D5C0
	private void CheckUpdateCameraEvents() { }

	// RVA: 0x57DB80 Offset: 0x57C180 VA: 0x18057DB80
	private void OnPreCull() { }

	// RVA: 0x57DD00 Offset: 0x57C300 VA: 0x18057DD00
	private void OnPreRender() { }

	// RVA: 0x57DE70 Offset: 0x57C470 VA: 0x18057DE70
	public void .ctor() { }

	// RVA: 0x57DE10 Offset: 0x57C410 VA: 0x18057DE10
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

	// RVA: 0x589CC0 Offset: 0x5882C0 VA: 0x180589CC0
	internal bool <Remove>b__0(KeyValuePair<int, Action<CommandBuffer>> s) { }

}

