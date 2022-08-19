public class WireTool : HeldEntity // TypeDefIndex: 8662
{	// Fields
	public Sprite InputSprite; // 0x1F8
	public Sprite OutputSprite; // 0x200
	public Sprite ClearSprite; // 0x208
	public static float maxWireLength; // 0x0
	private const int maxLineNodes = 16;
	public GameObjectRef plugEffect; // 0x210
	public GameObjectRef ioLine; // 0x218
	public IOEntity.IOType wireType; // 0x220
	public static Translate.Phrase Default; // 0x8
	public static Translate.Phrase DefaultDesc; // 0x10
	public static Translate.Phrase Red; // 0x18
	public static Translate.Phrase RedDesc; // 0x20
	public static Translate.Phrase Green; // 0x28
	public static Translate.Phrase GreenDesc; // 0x30
	public static Translate.Phrase Blue; // 0x38
	public static Translate.Phrase BlueDesc; // 0x40
	public static Translate.Phrase Yellow; // 0x48
	public static Translate.Phrase YellowDesc; // 0x50
	public WireTool.PendingPlug_t pending; // 0x228
	private const float lineThickness = 0,02;
	private bool wantsCrosshair; // 0x240
	private ClientIOLine pendingLine; // 0x248
	private WireTool.WireColour currentColour; // 0x250
	private float nextClearSendTime; // 0x254
	private float remainingDist; // 0x258
	private bool validSurface; // 0x25C
	private bool couldBuild; // 0x25D
	private bool isSolo; // 0x25E
	private float clearProgress; // 0x260

	// Properties
	public bool CanChangeColours { get; }

	// Methods

	// RVA: 0x8FC230 Offset: 0x8FA830 VA: 0x1808FC230 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F7F70 Offset: 0x8F6570 VA: 0x1808F7F70
	private void AddIOOption(IOEntity.IOSlot slot, List<Option> opts, bool input, int index, int order = 0) { }

	// RVA: 0x8F7DF0 Offset: 0x8F63F0 VA: 0x1808F7DF0
	public void AddClearConnections(List<Option> opts) { }

	// RVA: 0x8F96A0 Offset: 0x8F7CA0 VA: 0x1808F96A0
	public List<Option> GetIOOptions(IOEntity source) { }

	// RVA: 0x8FD420 Offset: 0x8FBA20 VA: 0x1808FD420
	public bool get_CanChangeColours() { }

	// RVA: 0x8F87F0 Offset: 0x8F6DF0 VA: 0x1808F87F0
	public void ClearPendingPlug() { }

	// RVA: 0x8F9C90 Offset: 0x8F8290 VA: 0x1808F9C90
	public bool HasPendingPlug() { }

	// RVA: 0x8FC320 Offset: 0x8FA920 VA: 0x1808FC320
	public bool PendingPlugIsInput() { }

	// RVA: 0x8FC440 Offset: 0x8FAA40 VA: 0x1808FC440
	public bool PendingPlugIsType(IOEntity.IOType type) { }

	// RVA: 0x8FC3B0 Offset: 0x8FA9B0 VA: 0x1808FC3B0
	public bool PendingPlugIsOutput() { }

	// RVA: 0x8FC5F0 Offset: 0x8FABF0 VA: 0x1808FC5F0
	public Vector3 PendingPlugWorldPos() { }

	// RVA: 0x8F8530 Offset: 0x8F6B30 VA: 0x1808F8530
	public static bool CanPlayerUseWires(BasePlayer player) { }

	// RVA: 0x8F8440 Offset: 0x8F6A40 VA: 0x1808F8440
	public static bool CanModifyEntity(BasePlayer player, BaseEntity ent) { }

	// RVA: 0x8FC550 Offset: 0x8FAB50 VA: 0x1808FC550
	public bool PendingPlugRoot() { }

	// RVA: 0x8F9D10 Offset: 0x8F8310 VA: 0x1808F9D10
	public bool HasPendingWire() { }

	// RVA: 0x8F9B30 Offset: 0x8F8130 VA: 0x1808F9B30
	public float GetPendingLengthRemaining() { }

	// RVA: 0x8F9BE0 Offset: 0x8F81E0 VA: 0x1808F9BE0
	public int GetWireClicksRemaining() { }

	// RVA: 0x8FCBD0 Offset: 0x8FB1D0 VA: 0x1808FCBD0
	public bool ValidSurface() { }

	// RVA: 0x8F9240 Offset: 0x8F7840 VA: 0x1808F9240
	public void ClientRequestClear(IOEntity ent, int slot, bool input) { }

	// RVA: 0x8F9980 Offset: 0x8F7F80 VA: 0x1808F9980
	public IOEntity GetLookingAtIOEnt() { }

	// RVA: 0x8FA030 Offset: 0x8F8630 VA: 0x1808FA030 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x8F9F70 Offset: 0x8F8570 VA: 0x1808F9F70 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x8FD090 Offset: 0x8FB690 VA: 0x1808FD090
	public bool WantsInputList() { }

	// RVA: 0x8FD0B0 Offset: 0x8FB6B0 VA: 0x1808FD0B0
	public bool WantsOutputList() { }

	// RVA: 0x8F8740 Offset: 0x8F6D40 VA: 0x1808F8740
	public void ClearClicked() { }

	// RVA: 0x8F9D70 Offset: 0x8F8370 VA: 0x1808F9D70
	private bool IsSlotOccupied(IOEntity ent, bool input, int index) { }

	// RVA: 0x8F9EA0 Offset: 0x8F84A0 VA: 0x1808F9EA0
	private bool IsSlotValidType(IOEntity ent, bool input, int index) { }

	// RVA: 0x8F8820 Offset: 0x8F6E20 VA: 0x1808F8820
	public void ClientAttemptConnection(bool input, int index) { }

	// RVA: 0x8F8210 Offset: 0x8F6810 VA: 0x1808F8210
	public void BeginLine(Vector3 startWorldPos) { }

	// RVA: 0x8F9300 Offset: 0x8F7900 VA: 0x1808F9300
	public static ClientIOLine CreateLine(Vector3 spawnPos, Quaternion rotation, IOEntity.IOType type, WireTool.WireColour colour) { }

	// RVA: 0x8F95B0 Offset: 0x8F7BB0 VA: 0x1808F95B0
	private static string GetElectricalWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8F9630 Offset: 0x8F7C30 VA: 0x1808F9630
	private static string GetFluidicWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8F94D0 Offset: 0x8F7AD0 VA: 0x1808F94D0
	public void EndLine(bool destroy = False) { }

	// RVA: 0x8FC9C0 Offset: 0x8FAFC0 VA: 0x1808FC9C0
	private bool SendPendingLine(IOEntity input, int inputIndex, IOEntity output, int outputIndex, List<Vector3> positions) { }

	// RVA: 0x8F9F60 Offset: 0x8F8560 VA: 0x1808F9F60 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x8FC7B0 Offset: 0x8FADB0 VA: 0x1808FC7B0
	public static void RefreshDirectionalVisibility() { }

	// RVA: 0x8FA110 Offset: 0x8F8710 VA: 0x1808FA110 Slot: 138
	public override void OnInput() { }

	// RVA: 0x8F95A0 Offset: 0x8F7BA0 VA: 0x1808F95A0
	public float GetClearProgress() { }

	// RVA: 0x8FCB70 Offset: 0x8FB170 VA: 0x1808FCB70
	private void SetCurrentColour(WireTool.WireColour newColour) { }

	// RVA: 0x8FCBE0 Offset: 0x8FB1E0 VA: 0x1808FCBE0
	private bool ValidateLine(List<Vector3> lineList, IOEntity inputEntity, IOEntity outputEntity, BasePlayer byPlayer) { }

	// RVA: 0x8FD3C0 Offset: 0x8FB9C0 VA: 0x1808FD3C0
	public void .ctor() { }

	// RVA: 0x8FD0D0 Offset: 0x8FB6D0 VA: 0x1808FD0D0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8F8740 Offset: 0x8F6D40 VA: 0x1808F8740
	private void <AddClearConnections>b__5_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8FCB80 Offset: 0x8FB180 VA: 0x1808FCB80
	private void <OnInput>b__67_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8FCB90 Offset: 0x8FB190 VA: 0x1808FCB90
	private void <OnInput>b__67_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8FCBA0 Offset: 0x8FB1A0 VA: 0x1808FCBA0
	private void <OnInput>b__67_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8FCBB0 Offset: 0x8FB1B0 VA: 0x1808FCBB0
	private void <OnInput>b__67_3(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8FCBC0 Offset: 0x8FB1C0 VA: 0x1808FCBC0
	private void <OnInput>b__67_4(BasePlayer ply) { }

}

public enum WireTool.WireColour // TypeDefIndex: 8663
{	// Fields
	public int value__; // 0x0
	public const WireTool.WireColour Default = 0;
	public const WireTool.WireColour Red = 1;
	public const WireTool.WireColour Green = 2;
	public const WireTool.WireColour Blue = 3;
	public const WireTool.WireColour Yellow = 4;

}

public struct WireTool.PendingPlug_t // TypeDefIndex: 8664
{	// Fields
	public IOEntity ent; // 0x0
	public bool input; // 0x8
	public int index; // 0xC
	public GameObject tempLine; // 0x10

}

private sealed class WireTool.<>c__DisplayClass4_0 // TypeDefIndex: 8665
{	// Fields
	public WireTool <>4__this; // 0x10
	public bool input; // 0x18
	public int index; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8EE0F0 Offset: 0x8EC6F0 VA: 0x1808EE0F0
	internal void <AddIOOption>b__0(BasePlayer ply) { }

}

private sealed class WireTool.<>c // TypeDefIndex: 8666
{	// Fields
	public static readonly WireTool.<>c <>9; // 0x0
	public static Func<Collider, bool> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x8EE300 Offset: 0x8EC900 VA: 0x1808EE300
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8EDD70 Offset: 0x8EC370 VA: 0x1808EDD70
	internal bool <CanPlayerUseWires>b__33_0(Collider collider) { }

}

