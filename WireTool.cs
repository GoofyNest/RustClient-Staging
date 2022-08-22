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

	// RVA: 0x8FC340 Offset: 0x8FA940 VA: 0x1808FC340 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8F8080 Offset: 0x8F6680 VA: 0x1808F8080
	private void AddIOOption(IOEntity.IOSlot slot, List<Option> opts, bool input, int index, int order = 0) { }

	// RVA: 0x8F7F00 Offset: 0x8F6500 VA: 0x1808F7F00
	public void AddClearConnections(List<Option> opts) { }

	// RVA: 0x8F97B0 Offset: 0x8F7DB0 VA: 0x1808F97B0
	public List<Option> GetIOOptions(IOEntity source) { }

	// RVA: 0x8FD530 Offset: 0x8FBB30 VA: 0x1808FD530
	public bool get_CanChangeColours() { }

	// RVA: 0x8F8900 Offset: 0x8F6F00 VA: 0x1808F8900
	public void ClearPendingPlug() { }

	// RVA: 0x8F9DA0 Offset: 0x8F83A0 VA: 0x1808F9DA0
	public bool HasPendingPlug() { }

	// RVA: 0x8FC430 Offset: 0x8FAA30 VA: 0x1808FC430
	public bool PendingPlugIsInput() { }

	// RVA: 0x8FC550 Offset: 0x8FAB50 VA: 0x1808FC550
	public bool PendingPlugIsType(IOEntity.IOType type) { }

	// RVA: 0x8FC4C0 Offset: 0x8FAAC0 VA: 0x1808FC4C0
	public bool PendingPlugIsOutput() { }

	// RVA: 0x8FC700 Offset: 0x8FAD00 VA: 0x1808FC700
	public Vector3 PendingPlugWorldPos() { }

	// RVA: 0x8F8640 Offset: 0x8F6C40 VA: 0x1808F8640
	public static bool CanPlayerUseWires(BasePlayer player) { }

	// RVA: 0x8F8550 Offset: 0x8F6B50 VA: 0x1808F8550
	public static bool CanModifyEntity(BasePlayer player, BaseEntity ent) { }

	// RVA: 0x8FC660 Offset: 0x8FAC60 VA: 0x1808FC660
	public bool PendingPlugRoot() { }

	// RVA: 0x8F9E20 Offset: 0x8F8420 VA: 0x1808F9E20
	public bool HasPendingWire() { }

	// RVA: 0x8F9C40 Offset: 0x8F8240 VA: 0x1808F9C40
	public float GetPendingLengthRemaining() { }

	// RVA: 0x8F9CF0 Offset: 0x8F82F0 VA: 0x1808F9CF0
	public int GetWireClicksRemaining() { }

	// RVA: 0x8FCCE0 Offset: 0x8FB2E0 VA: 0x1808FCCE0
	public bool ValidSurface() { }

	// RVA: 0x8F9350 Offset: 0x8F7950 VA: 0x1808F9350
	public void ClientRequestClear(IOEntity ent, int slot, bool input) { }

	// RVA: 0x8F9A90 Offset: 0x8F8090 VA: 0x1808F9A90
	public IOEntity GetLookingAtIOEnt() { }

	// RVA: 0x8FA140 Offset: 0x8F8740 VA: 0x1808FA140 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x8FA080 Offset: 0x8F8680 VA: 0x1808FA080 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x8FD1A0 Offset: 0x8FB7A0 VA: 0x1808FD1A0
	public bool WantsInputList() { }

	// RVA: 0x8FD1C0 Offset: 0x8FB7C0 VA: 0x1808FD1C0
	public bool WantsOutputList() { }

	// RVA: 0x8F8850 Offset: 0x8F6E50 VA: 0x1808F8850
	public void ClearClicked() { }

	// RVA: 0x8F9E80 Offset: 0x8F8480 VA: 0x1808F9E80
	private bool IsSlotOccupied(IOEntity ent, bool input, int index) { }

	// RVA: 0x8F9FB0 Offset: 0x8F85B0 VA: 0x1808F9FB0
	private bool IsSlotValidType(IOEntity ent, bool input, int index) { }

	// RVA: 0x8F8930 Offset: 0x8F6F30 VA: 0x1808F8930
	public void ClientAttemptConnection(bool input, int index) { }

	// RVA: 0x8F8320 Offset: 0x8F6920 VA: 0x1808F8320
	public void BeginLine(Vector3 startWorldPos) { }

	// RVA: 0x8F9410 Offset: 0x8F7A10 VA: 0x1808F9410
	public static ClientIOLine CreateLine(Vector3 spawnPos, Quaternion rotation, IOEntity.IOType type, WireTool.WireColour colour) { }

	// RVA: 0x8F96C0 Offset: 0x8F7CC0 VA: 0x1808F96C0
	private static string GetElectricalWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8F9740 Offset: 0x8F7D40 VA: 0x1808F9740
	private static string GetFluidicWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8F95E0 Offset: 0x8F7BE0 VA: 0x1808F95E0
	public void EndLine(bool destroy = False) { }

	// RVA: 0x8FCAD0 Offset: 0x8FB0D0 VA: 0x1808FCAD0
	private bool SendPendingLine(IOEntity input, int inputIndex, IOEntity output, int outputIndex, List<Vector3> positions) { }

	// RVA: 0x8FA070 Offset: 0x8F8670 VA: 0x1808FA070 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x8FC8C0 Offset: 0x8FAEC0 VA: 0x1808FC8C0
	public static void RefreshDirectionalVisibility() { }

	// RVA: 0x8FA220 Offset: 0x8F8820 VA: 0x1808FA220 Slot: 138
	public override void OnInput() { }

	// RVA: 0x8F96B0 Offset: 0x8F7CB0 VA: 0x1808F96B0
	public float GetClearProgress() { }

	// RVA: 0x8FCC80 Offset: 0x8FB280 VA: 0x1808FCC80
	private void SetCurrentColour(WireTool.WireColour newColour) { }

	// RVA: 0x8FCCF0 Offset: 0x8FB2F0 VA: 0x1808FCCF0
	private bool ValidateLine(List<Vector3> lineList, IOEntity inputEntity, IOEntity outputEntity, BasePlayer byPlayer) { }

	// RVA: 0x8FD4D0 Offset: 0x8FBAD0 VA: 0x1808FD4D0
	public void .ctor() { }

	// RVA: 0x8FD1E0 Offset: 0x8FB7E0 VA: 0x1808FD1E0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8F8850 Offset: 0x8F6E50 VA: 0x1808F8850
	private void <AddClearConnections>b__5_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FCC90 Offset: 0x8FB290 VA: 0x1808FCC90
	private void <OnInput>b__67_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FCCA0 Offset: 0x8FB2A0 VA: 0x1808FCCA0
	private void <OnInput>b__67_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FCCB0 Offset: 0x8FB2B0 VA: 0x1808FCCB0
	private void <OnInput>b__67_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FCCC0 Offset: 0x8FB2C0 VA: 0x1808FCCC0
	private void <OnInput>b__67_3(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8FCCD0 Offset: 0x8FB2D0 VA: 0x1808FCCD0
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

	// RVA: 0x8EE200 Offset: 0x8EC800 VA: 0x1808EE200
	internal void <AddIOOption>b__0(BasePlayer ply) { }

}

private sealed class WireTool.<>c // TypeDefIndex: 8666
{	// Fields
	public static readonly WireTool.<>c <>9; // 0x0
	public static Func<Collider, bool> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x8EE410 Offset: 0x8ECA10 VA: 0x1808EE410
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8EDE80 Offset: 0x8EC480 VA: 0x1808EDE80
	internal bool <CanPlayerUseWires>b__33_0(Collider collider) { }

}

