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

	// RVA: 0x8FC850 Offset: 0x8FAE50 VA: 0x1808FC850 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F8590 Offset: 0x8F6B90 VA: 0x1808F8590
	private void AddIOOption(IOEntity.IOSlot slot, List<Option> opts, bool input, int index, int order = 0) { }

	// RVA: 0x8F8410 Offset: 0x8F6A10 VA: 0x1808F8410
	public void AddClearConnections(List<Option> opts) { }

	// RVA: 0x8F9CC0 Offset: 0x8F82C0 VA: 0x1808F9CC0
	public List<Option> GetIOOptions(IOEntity source) { }

	// RVA: 0x8FDA40 Offset: 0x8FC040 VA: 0x1808FDA40
	public bool get_CanChangeColours() { }

	// RVA: 0x8F8E10 Offset: 0x8F7410 VA: 0x1808F8E10
	public void ClearPendingPlug() { }

	// RVA: 0x8FA2B0 Offset: 0x8F88B0 VA: 0x1808FA2B0
	public bool HasPendingPlug() { }

	// RVA: 0x8FC940 Offset: 0x8FAF40 VA: 0x1808FC940
	public bool PendingPlugIsInput() { }

	// RVA: 0x8FCA60 Offset: 0x8FB060 VA: 0x1808FCA60
	public bool PendingPlugIsType(IOEntity.IOType type) { }

	// RVA: 0x8FC9D0 Offset: 0x8FAFD0 VA: 0x1808FC9D0
	public bool PendingPlugIsOutput() { }

	// RVA: 0x8FCC10 Offset: 0x8FB210 VA: 0x1808FCC10
	public Vector3 PendingPlugWorldPos() { }

	// RVA: 0x8F8B50 Offset: 0x8F7150 VA: 0x1808F8B50
	public static bool CanPlayerUseWires(BasePlayer player) { }

	// RVA: 0x8F8A60 Offset: 0x8F7060 VA: 0x1808F8A60
	public static bool CanModifyEntity(BasePlayer player, BaseEntity ent) { }

	// RVA: 0x8FCB70 Offset: 0x8FB170 VA: 0x1808FCB70
	public bool PendingPlugRoot() { }

	// RVA: 0x8FA330 Offset: 0x8F8930 VA: 0x1808FA330
	public bool HasPendingWire() { }

	// RVA: 0x8FA150 Offset: 0x8F8750 VA: 0x1808FA150
	public float GetPendingLengthRemaining() { }

	// RVA: 0x8FA200 Offset: 0x8F8800 VA: 0x1808FA200
	public int GetWireClicksRemaining() { }

	// RVA: 0x8FD1F0 Offset: 0x8FB7F0 VA: 0x1808FD1F0
	public bool ValidSurface() { }

	// RVA: 0x8F9860 Offset: 0x8F7E60 VA: 0x1808F9860
	public void ClientRequestClear(IOEntity ent, int slot, bool input) { }

	// RVA: 0x8F9FA0 Offset: 0x8F85A0 VA: 0x1808F9FA0
	public IOEntity GetLookingAtIOEnt() { }

	// RVA: 0x8FA650 Offset: 0x8F8C50 VA: 0x1808FA650 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x8FA590 Offset: 0x8F8B90 VA: 0x1808FA590 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x8FD6B0 Offset: 0x8FBCB0 VA: 0x1808FD6B0
	public bool WantsInputList() { }

	// RVA: 0x8FD6D0 Offset: 0x8FBCD0 VA: 0x1808FD6D0
	public bool WantsOutputList() { }

	// RVA: 0x8F8D60 Offset: 0x8F7360 VA: 0x1808F8D60
	public void ClearClicked() { }

	// RVA: 0x8FA390 Offset: 0x8F8990 VA: 0x1808FA390
	private bool IsSlotOccupied(IOEntity ent, bool input, int index) { }

	// RVA: 0x8FA4C0 Offset: 0x8F8AC0 VA: 0x1808FA4C0
	private bool IsSlotValidType(IOEntity ent, bool input, int index) { }

	// RVA: 0x8F8E40 Offset: 0x8F7440 VA: 0x1808F8E40
	public void ClientAttemptConnection(bool input, int index) { }

	// RVA: 0x8F8830 Offset: 0x8F6E30 VA: 0x1808F8830
	public void BeginLine(Vector3 startWorldPos) { }

	// RVA: 0x8F9920 Offset: 0x8F7F20 VA: 0x1808F9920
	public static ClientIOLine CreateLine(Vector3 spawnPos, Quaternion rotation, IOEntity.IOType type, WireTool.WireColour colour) { }

	// RVA: 0x8F9BD0 Offset: 0x8F81D0 VA: 0x1808F9BD0
	private static string GetElectricalWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8F9C50 Offset: 0x8F8250 VA: 0x1808F9C50
	private static string GetFluidicWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8F9AF0 Offset: 0x8F80F0 VA: 0x1808F9AF0
	public void EndLine(bool destroy = False) { }

	// RVA: 0x8FCFE0 Offset: 0x8FB5E0 VA: 0x1808FCFE0
	private bool SendPendingLine(IOEntity input, int inputIndex, IOEntity output, int outputIndex, List<Vector3> positions) { }

	// RVA: 0x8FA580 Offset: 0x8F8B80 VA: 0x1808FA580 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x8FCDD0 Offset: 0x8FB3D0 VA: 0x1808FCDD0
	public static void RefreshDirectionalVisibility() { }

	// RVA: 0x8FA730 Offset: 0x8F8D30 VA: 0x1808FA730 Slot: 138
	public override void OnInput() { }

	// RVA: 0x8F9BC0 Offset: 0x8F81C0 VA: 0x1808F9BC0
	public float GetClearProgress() { }

	// RVA: 0x8FD190 Offset: 0x8FB790 VA: 0x1808FD190
	private void SetCurrentColour(WireTool.WireColour newColour) { }

	// RVA: 0x8FD200 Offset: 0x8FB800 VA: 0x1808FD200
	private bool ValidateLine(List<Vector3> lineList, IOEntity inputEntity, IOEntity outputEntity, BasePlayer byPlayer) { }

	// RVA: 0x8FD9E0 Offset: 0x8FBFE0 VA: 0x1808FD9E0
	public void .ctor() { }

	// RVA: 0x8FD6F0 Offset: 0x8FBCF0 VA: 0x1808FD6F0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8F8D60 Offset: 0x8F7360 VA: 0x1808F8D60
	private void <AddClearConnections>b__5_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FD1A0 Offset: 0x8FB7A0 VA: 0x1808FD1A0
	private void <OnInput>b__67_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FD1B0 Offset: 0x8FB7B0 VA: 0x1808FD1B0
	private void <OnInput>b__67_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FD1C0 Offset: 0x8FB7C0 VA: 0x1808FD1C0
	private void <OnInput>b__67_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FD1D0 Offset: 0x8FB7D0 VA: 0x1808FD1D0
	private void <OnInput>b__67_3(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FD1E0 Offset: 0x8FB7E0 VA: 0x1808FD1E0
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

	// RVA: 0x8EE710 Offset: 0x8ECD10 VA: 0x1808EE710
	internal void <AddIOOption>b__0(BasePlayer ply) { }

}

private sealed class WireTool.<>c // TypeDefIndex: 8666
{	// Fields
	public static readonly WireTool.<>c <>9; // 0x0
	public static Func<Collider, bool> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x8EE920 Offset: 0x8ECF20 VA: 0x1808EE920
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8EE390 Offset: 0x8EC990 VA: 0x1808EE390
	internal bool <CanPlayerUseWires>b__33_0(Collider collider) { }

}

