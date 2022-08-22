public class SprayCan : HeldEntity // TypeDefIndex: 8641
{	// Fields
	public const float MaxFreeSprayDistanceFromStart = 10;
	public const float MaxFreeSprayStartingDistance = 3;
	private SprayCanSpray_Freehand paintingLine; // 0x1F8
	public const BaseEntity.Flags IsFreeSpraying = 128;
	private bool isSpraying; // 0x200
	private bool spawnedLine; // 0x201
	private Vector3 sprayStartPos; // 0x204
	private Vector3 lastPos; // 0x210
	private int colourIndex; // 0x21C
	private int widthIndex; // 0x220
	private BaseEntity sprayingEntity; // 0x228
	private List<AlignedLineDrawer.LinePoint> points; // 0x230
	private TimeSince sprayStarted; // 0x238
	private TimeSince sprayEnded; // 0x23C
	private static Translate.Phrase[] ColourNamePhrases; // 0x0
	private static Translate.Phrase[] ColourDescriptionPhrases; // 0x8
	private static Translate.Phrase[] SpraySizePhrases; // 0x10
	public SoundDefinition SpraySound; // 0x240
	public GameObjectRef SkinSelectPanel; // 0x248
	public float SprayCooldown; // 0x250
	public float ConditionLossPerSpray; // 0x254
	public float ConditionLossPerReskin; // 0x258
	public GameObjectRef LinePrefab; // 0x260
	public Color[] SprayColours; // 0x268
	public float[] SprayWidths; // 0x270
	public ParticleSystem worldSpaceSprayFx; // 0x278
	public GameObjectRef ReskinEffect; // 0x280
	public ItemDefinition SprayDecalItem; // 0x288
	public GameObjectRef SprayDecalEntityRef; // 0x290
	public SteamInventoryItem FreeSprayUnlockItem; // 0x298
	public ParticleSystem.MinMaxGradient DecalSprayGradient; // 0x2A0
	public SoundDefinition SprayLoopDef; // 0x2D8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SprayCan.SprayMode <currentMode>k__BackingField; // 0x2E0
	private int selectedDecalSkin; // 0x2E4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool UseAccurateMeshSnapping; // 0x18
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool DebugMeshSnapping; // 0x19
	private static int paramAttack; // 0x1C
	private static int paramAttackHold; // 0x20
	private TimeSince timeDeployed; // 0x2E8
	private Sound sprayLoop; // 0x2F0

	// Properties
	private Color SelectedSprayColour { get; }
	public static bool HasOpenedColourWheel { get; set; }
	public static bool HasOpenedSizeWheel { get; set; }
	public SprayCan.SprayMode currentMode { get; set; }

	// Methods

	// RVA: 0xA87B40 Offset: 0xA86140 VA: 0x180A87B40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA89E80 Offset: 0xA88480 VA: 0x180A89E80
	private Color get_SelectedSprayColour() { }

	// RVA: 0xA84B10 Offset: 0xA83110 VA: 0x180A84B10
	private void FreePaintInput(BasePlayer player, bool sprayInput) { }

	// RVA: 0xA86C10 Offset: 0xA85210 VA: 0x180A86C10
	private bool HasSprayDecalAttachment(BasePlayer player) { }

	// RVA: 0xA88D40 Offset: 0xA87340 VA: 0x180A88D40
	private Ray SprayRay(BasePlayer player) { }

	// RVA: 0xA863C0 Offset: 0xA849C0 VA: 0x180A863C0
	private bool GetSprayPosition(BasePlayer player, out Vector3 pos, out Vector3 normal, out Vector3 upPos, out BaseEntity hitEntity, out Collider hitCollider) { }

	// RVA: 0xA88AF0 Offset: 0xA870F0 VA: 0x180A88AF0
	public void RegisterInProcessSpray(SprayCanSpray_Freehand spray, List<AlignedLineDrawer.LinePoint> setPoints) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA845A0 Offset: 0xA82BA0 VA: 0x180A845A0
	private void Client_ChangeSprayColour(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA89E00 Offset: 0xA88400 VA: 0x180A89E00
	public static bool get_HasOpenedColourWheel() { }

	// RVA: 0xA89ED0 Offset: 0xA884D0 VA: 0x180A89ED0
	private static void set_HasOpenedColourWheel(bool value) { }

	// RVA: 0xA89E40 Offset: 0xA88440 VA: 0x180A89E40
	public static bool get_HasOpenedSizeWheel() { }

	// RVA: 0xA89F10 Offset: 0xA88510 VA: 0x180A89F10
	private static void set_HasOpenedSizeWheel(bool value) { }

	// RVA: 0xA88CE0 Offset: 0xA872E0 VA: 0x180A88CE0
	private bool ShouldUseMeshSampling(Collider c) { }

	// RVA: 0xA88FE0 Offset: 0xA875E0 VA: 0x180A88FE0
	private Vector3 TrySnapPointToRenderMesh(Vector3 point, Collider c, BasePlayer player) { }

	// RVA: 0xA844A0 Offset: 0xA82AA0 VA: 0x180A844A0
	public bool CanSprayFreehand(BasePlayer player) { }

	// RVA: 0xA86C60 Offset: 0xA85260 VA: 0x180A86C60
	private bool IsSprayBlockedByTrigger(Vector3 pos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69F190 Offset: 0x69D790 VA: 0x18069F190
	public SprayCan.SprayMode get_currentMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89F50 Offset: 0xA88550 VA: 0x180A89F50
	private void set_currentMode(SprayCan.SprayMode value) { }

	// RVA: 0xA872B0 Offset: 0xA858B0 VA: 0x180A872B0 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA885A0 Offset: 0xA86BA0 VA: 0x180A885A0
	private void OpenReskinOptions(BasePlayer player) { }

	// RVA: 0xA84010 Offset: 0xA82610 VA: 0x180A84010
	public bool CanOpenReskinMenu(BasePlayer player) { }

	// RVA: 0xA83E30 Offset: 0xA82430 VA: 0x180A83E30
	private void ApplySkinToItem(BaseEntity targetEntity, int targetSkin) { }

	// RVA: 0xA88850 Offset: 0xA86E50 VA: 0x180A88850
	private void PlayVMAttack() { }

	// RVA: 0xA88EC0 Offset: 0xA874C0 VA: 0x180A88EC0
	private void ToggleVMHold(bool state) { }

	// RVA: 0xA88B00 Offset: 0xA87100 VA: 0x180A88B00
	private void SetVmSprayColour(Color c) { }

	// RVA: 0xA88460 Offset: 0xA86A60 VA: 0x180A88460 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA84750 Offset: 0xA82D50 VA: 0x180A84750
	private void Client_ReskinResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA86DD0 Offset: 0xA853D0 VA: 0x180A86DD0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA889F0 Offset: 0xA86FF0 VA: 0x180A889F0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA88960 Offset: 0xA86F60 VA: 0x180A88960 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA86DA0 Offset: 0xA853A0 VA: 0x180A86DA0 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0xA86D70 Offset: 0xA85370 VA: 0x180A86D70 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0xA83EE0 Offset: 0xA824E0 VA: 0x180A83EE0
	private bool CanEntityBeRespawned(BaseEntity targetEntity, out SprayCan.SprayFailReason reason) { }

	// RVA: 0xA861B0 Offset: 0xA847B0 VA: 0x180A861B0
	public static bool GetItemDefinitionForEntity(BaseEntity be, out ItemDefinition def, bool useRedirect = True) { }

	// RVA: 0xA89CB0 Offset: 0xA882B0 VA: 0x180A89CB0
	public void .ctor() { }

	// RVA: 0xA89500 Offset: 0xA87B00 VA: 0x180A89500
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89230 Offset: 0xA87830 VA: 0x180A89230
	private void <FreePaintInput>b__20_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89230 Offset: 0xA87830 VA: 0x180A89230
	private void <FreePaintInput>b__20_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89260 Offset: 0xA87860 VA: 0x180A89260
	private bool <TrySnapPointToRenderMesh>g__HitPoint|33_0(Renderer forRenderer, out Vector3 trySnapPointToRenderMesh, ref SprayCan.<>c__DisplayClass33_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89240 Offset: 0xA87840 VA: 0x180A89240
	private void <OnInput>b__63_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89250 Offset: 0xA87850 VA: 0x180A89250
	private void <OnInput>b__63_1(BasePlayer ply) { }

}

private enum SprayCan.SprayFailReason // TypeDefIndex: 8642
{	// Fields
	public int value__; // 0x0
	public const SprayCan.SprayFailReason None = 0;
	public const SprayCan.SprayFailReason MountedBlocked = 1;
	public const SprayCan.SprayFailReason IOConnection = 2;
	public const SprayCan.SprayFailReason LineOfSight = 3;
	public const SprayCan.SprayFailReason SkinNotOwned = 4;
	public const SprayCan.SprayFailReason InvalidItem = 5;

}

public enum SprayCan.SprayMode // TypeDefIndex: 8643
{	// Fields
	public int value__; // 0x0
	public const SprayCan.SprayMode FreeHand = 0;
	public const SprayCan.SprayMode Decal = 1;

}

private sealed class SprayCan.<>c__DisplayClass20_0 // TypeDefIndex: 8644
{	// Fields
	public int index; // 0x10
	public SprayCan <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA8FF60 Offset: 0xA8E560 VA: 0x180A8FF60
	internal void <FreePaintInput>b__1(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass20_1 // TypeDefIndex: 8645
{	// Fields
	public int index; // 0x10
	public SprayCan <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA8FF90 Offset: 0xA8E590 VA: 0x180A8FF90
	internal void <FreePaintInput>b__3(BasePlayer ply) { }

}

private struct SprayCan.<>c__DisplayClass33_0 // TypeDefIndex: 8646
{	// Fields
	public SprayCan <>4__this; // 0x0
	public BasePlayer player; // 0x8
	public Vector3 point; // 0x10

}

private sealed class SprayCan.<>c__DisplayClass63_0 // TypeDefIndex: 8647
{	// Fields
	public ItemSkinDirectory.Skin skin; // 0x10
	public SprayCan <>4__this; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA8FFC0 Offset: 0xA8E5C0 VA: 0x180A8FFC0
	internal void <OnInput>b__2(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass64_0 // TypeDefIndex: 8648
{	// Fields
	public SprayCan <>4__this; // 0x10
	public BaseEntity targetEntity; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA8FFF0 Offset: 0xA8E5F0 VA: 0x180A8FFF0
	internal void <OpenReskinOptions>b__0(bool confirmed, int skinId) { }

}

