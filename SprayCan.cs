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

	// RVA: 0xA882D0 Offset: 0xA868D0 VA: 0x180A882D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8A610 Offset: 0xA88C10 VA: 0x180A8A610
	private Color get_SelectedSprayColour() { }

	// RVA: 0xA852A0 Offset: 0xA838A0 VA: 0x180A852A0
	private void FreePaintInput(BasePlayer player, bool sprayInput) { }

	// RVA: 0xA873A0 Offset: 0xA859A0 VA: 0x180A873A0
	private bool HasSprayDecalAttachment(BasePlayer player) { }

	// RVA: 0xA894D0 Offset: 0xA87AD0 VA: 0x180A894D0
	private Ray SprayRay(BasePlayer player) { }

	// RVA: 0xA86B50 Offset: 0xA85150 VA: 0x180A86B50
	private bool GetSprayPosition(BasePlayer player, out Vector3 pos, out Vector3 normal, out Vector3 upPos, out BaseEntity hitEntity, out Collider hitCollider) { }

	// RVA: 0xA89280 Offset: 0xA87880 VA: 0x180A89280
	public void RegisterInProcessSpray(SprayCanSpray_Freehand spray, List<AlignedLineDrawer.LinePoint> setPoints) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA84D30 Offset: 0xA83330 VA: 0x180A84D30
	private void Client_ChangeSprayColour(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA8A590 Offset: 0xA88B90 VA: 0x180A8A590
	public static bool get_HasOpenedColourWheel() { }

	// RVA: 0xA8A660 Offset: 0xA88C60 VA: 0x180A8A660
	private static void set_HasOpenedColourWheel(bool value) { }

	// RVA: 0xA8A5D0 Offset: 0xA88BD0 VA: 0x180A8A5D0
	public static bool get_HasOpenedSizeWheel() { }

	// RVA: 0xA8A6A0 Offset: 0xA88CA0 VA: 0x180A8A6A0
	private static void set_HasOpenedSizeWheel(bool value) { }

	// RVA: 0xA89470 Offset: 0xA87A70 VA: 0x180A89470
	private bool ShouldUseMeshSampling(Collider c) { }

	// RVA: 0xA89770 Offset: 0xA87D70 VA: 0x180A89770
	private Vector3 TrySnapPointToRenderMesh(Vector3 point, Collider c, BasePlayer player) { }

	// RVA: 0xA84C30 Offset: 0xA83230 VA: 0x180A84C30
	public bool CanSprayFreehand(BasePlayer player) { }

	// RVA: 0xA873F0 Offset: 0xA859F0 VA: 0x180A873F0
	private bool IsSprayBlockedByTrigger(Vector3 pos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69F230 Offset: 0x69D830 VA: 0x18069F230
	public SprayCan.SprayMode get_currentMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8A6E0 Offset: 0xA88CE0 VA: 0x180A8A6E0
	private void set_currentMode(SprayCan.SprayMode value) { }

	// RVA: 0xA87A40 Offset: 0xA86040 VA: 0x180A87A40 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA88D30 Offset: 0xA87330 VA: 0x180A88D30
	private void OpenReskinOptions(BasePlayer player) { }

	// RVA: 0xA847A0 Offset: 0xA82DA0 VA: 0x180A847A0
	public bool CanOpenReskinMenu(BasePlayer player) { }

	// RVA: 0xA845C0 Offset: 0xA82BC0 VA: 0x180A845C0
	private void ApplySkinToItem(BaseEntity targetEntity, int targetSkin) { }

	// RVA: 0xA88FE0 Offset: 0xA875E0 VA: 0x180A88FE0
	private void PlayVMAttack() { }

	// RVA: 0xA89650 Offset: 0xA87C50 VA: 0x180A89650
	private void ToggleVMHold(bool state) { }

	// RVA: 0xA89290 Offset: 0xA87890 VA: 0x180A89290
	private void SetVmSprayColour(Color c) { }

	// RVA: 0xA88BF0 Offset: 0xA871F0 VA: 0x180A88BF0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA84EE0 Offset: 0xA834E0 VA: 0x180A84EE0
	private void Client_ReskinResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA87560 Offset: 0xA85B60 VA: 0x180A87560 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA89180 Offset: 0xA87780 VA: 0x180A89180 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA890F0 Offset: 0xA876F0 VA: 0x180A890F0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA87530 Offset: 0xA85B30 VA: 0x180A87530 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0xA87500 Offset: 0xA85B00 VA: 0x180A87500 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0xA84670 Offset: 0xA82C70 VA: 0x180A84670
	private bool CanEntityBeRespawned(BaseEntity targetEntity, out SprayCan.SprayFailReason reason) { }

	// RVA: 0xA86940 Offset: 0xA84F40 VA: 0x180A86940
	public static bool GetItemDefinitionForEntity(BaseEntity be, out ItemDefinition def, bool useRedirect = True) { }

	// RVA: 0xA8A440 Offset: 0xA88A40 VA: 0x180A8A440
	public void .ctor() { }

	// RVA: 0xA89C90 Offset: 0xA88290 VA: 0x180A89C90
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA899C0 Offset: 0xA87FC0 VA: 0x180A899C0
	private void <FreePaintInput>b__20_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA899C0 Offset: 0xA87FC0 VA: 0x180A899C0
	private void <FreePaintInput>b__20_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA899F0 Offset: 0xA87FF0 VA: 0x180A899F0
	private bool <TrySnapPointToRenderMesh>g__HitPoint|33_0(Renderer forRenderer, out Vector3 trySnapPointToRenderMesh, ref SprayCan.<>c__DisplayClass33_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA899D0 Offset: 0xA87FD0 VA: 0x180A899D0
	private void <OnInput>b__63_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA899E0 Offset: 0xA87FE0 VA: 0x180A899E0
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

	// RVA: 0xA906F0 Offset: 0xA8ECF0 VA: 0x180A906F0
	internal void <FreePaintInput>b__1(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass20_1 // TypeDefIndex: 8645
{	// Fields
	public int index; // 0x10
	public SprayCan <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA90720 Offset: 0xA8ED20 VA: 0x180A90720
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

	// RVA: 0xA90750 Offset: 0xA8ED50 VA: 0x180A90750
	internal void <OnInput>b__2(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass64_0 // TypeDefIndex: 8648
{	// Fields
	public SprayCan <>4__this; // 0x10
	public BaseEntity targetEntity; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA90780 Offset: 0xA8ED80 VA: 0x180A90780
	internal void <OpenReskinOptions>b__0(bool confirmed, int skinId) { }

}

