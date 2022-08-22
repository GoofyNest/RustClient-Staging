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

	// RVA: 0xA87E00 Offset: 0xA86400 VA: 0x180A87E00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA8A140 Offset: 0xA88740 VA: 0x180A8A140
	private Color get_SelectedSprayColour() { }

	// RVA: 0xA84DD0 Offset: 0xA833D0 VA: 0x180A84DD0
	private void FreePaintInput(BasePlayer player, bool sprayInput) { }

	// RVA: 0xA86ED0 Offset: 0xA854D0 VA: 0x180A86ED0
	private bool HasSprayDecalAttachment(BasePlayer player) { }

	// RVA: 0xA89000 Offset: 0xA87600 VA: 0x180A89000
	private Ray SprayRay(BasePlayer player) { }

	// RVA: 0xA86680 Offset: 0xA84C80 VA: 0x180A86680
	private bool GetSprayPosition(BasePlayer player, out Vector3 pos, out Vector3 normal, out Vector3 upPos, out BaseEntity hitEntity, out Collider hitCollider) { }

	// RVA: 0xA88DB0 Offset: 0xA873B0 VA: 0x180A88DB0
	public void RegisterInProcessSpray(SprayCanSpray_Freehand spray, List<AlignedLineDrawer.LinePoint> setPoints) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA84860 Offset: 0xA82E60 VA: 0x180A84860
	private void Client_ChangeSprayColour(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA8A0C0 Offset: 0xA886C0 VA: 0x180A8A0C0
	public static bool get_HasOpenedColourWheel() { }

	// RVA: 0xA8A190 Offset: 0xA88790 VA: 0x180A8A190
	private static void set_HasOpenedColourWheel(bool value) { }

	// RVA: 0xA8A100 Offset: 0xA88700 VA: 0x180A8A100
	public static bool get_HasOpenedSizeWheel() { }

	// RVA: 0xA8A1D0 Offset: 0xA887D0 VA: 0x180A8A1D0
	private static void set_HasOpenedSizeWheel(bool value) { }

	// RVA: 0xA88FA0 Offset: 0xA875A0 VA: 0x180A88FA0
	private bool ShouldUseMeshSampling(Collider c) { }

	// RVA: 0xA892A0 Offset: 0xA878A0 VA: 0x180A892A0
	private Vector3 TrySnapPointToRenderMesh(Vector3 point, Collider c, BasePlayer player) { }

	// RVA: 0xA84760 Offset: 0xA82D60 VA: 0x180A84760
	public bool CanSprayFreehand(BasePlayer player) { }

	// RVA: 0xA86F20 Offset: 0xA85520 VA: 0x180A86F20
	private bool IsSprayBlockedByTrigger(Vector3 pos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69F2A0 Offset: 0x69D8A0 VA: 0x18069F2A0
	public SprayCan.SprayMode get_currentMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA8A210 Offset: 0xA88810 VA: 0x180A8A210
	private void set_currentMode(SprayCan.SprayMode value) { }

	// RVA: 0xA87570 Offset: 0xA85B70 VA: 0x180A87570 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA88860 Offset: 0xA86E60 VA: 0x180A88860
	private void OpenReskinOptions(BasePlayer player) { }

	// RVA: 0xA842D0 Offset: 0xA828D0 VA: 0x180A842D0
	public bool CanOpenReskinMenu(BasePlayer player) { }

	// RVA: 0xA840F0 Offset: 0xA826F0 VA: 0x180A840F0
	private void ApplySkinToItem(BaseEntity targetEntity, int targetSkin) { }

	// RVA: 0xA88B10 Offset: 0xA87110 VA: 0x180A88B10
	private void PlayVMAttack() { }

	// RVA: 0xA89180 Offset: 0xA87780 VA: 0x180A89180
	private void ToggleVMHold(bool state) { }

	// RVA: 0xA88DC0 Offset: 0xA873C0 VA: 0x180A88DC0
	private void SetVmSprayColour(Color c) { }

	// RVA: 0xA88720 Offset: 0xA86D20 VA: 0x180A88720 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA84A10 Offset: 0xA83010 VA: 0x180A84A10
	private void Client_ReskinResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA87090 Offset: 0xA85690 VA: 0x180A87090 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA88CB0 Offset: 0xA872B0 VA: 0x180A88CB0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA88C20 Offset: 0xA87220 VA: 0x180A88C20 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA87060 Offset: 0xA85660 VA: 0x180A87060 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0xA87030 Offset: 0xA85630 VA: 0x180A87030 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0xA841A0 Offset: 0xA827A0 VA: 0x180A841A0
	private bool CanEntityBeRespawned(BaseEntity targetEntity, out SprayCan.SprayFailReason reason) { }

	// RVA: 0xA86470 Offset: 0xA84A70 VA: 0x180A86470
	public static bool GetItemDefinitionForEntity(BaseEntity be, out ItemDefinition def, bool useRedirect = True) { }

	// RVA: 0xA89F70 Offset: 0xA88570 VA: 0x180A89F70
	public void .ctor() { }

	// RVA: 0xA897C0 Offset: 0xA87DC0 VA: 0x180A897C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA894F0 Offset: 0xA87AF0 VA: 0x180A894F0
	private void <FreePaintInput>b__20_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA894F0 Offset: 0xA87AF0 VA: 0x180A894F0
	private void <FreePaintInput>b__20_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89520 Offset: 0xA87B20 VA: 0x180A89520
	private bool <TrySnapPointToRenderMesh>g__HitPoint|33_0(Renderer forRenderer, out Vector3 trySnapPointToRenderMesh, ref SprayCan.<>c__DisplayClass33_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89500 Offset: 0xA87B00 VA: 0x180A89500
	private void <OnInput>b__63_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA89510 Offset: 0xA87B10 VA: 0x180A89510
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

	// RVA: 0xA90220 Offset: 0xA8E820 VA: 0x180A90220
	internal void <FreePaintInput>b__1(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass20_1 // TypeDefIndex: 8645
{	// Fields
	public int index; // 0x10
	public SprayCan <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA90250 Offset: 0xA8E850 VA: 0x180A90250
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

	// RVA: 0xA90280 Offset: 0xA8E880 VA: 0x180A90280
	internal void <OnInput>b__2(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass64_0 // TypeDefIndex: 8648
{	// Fields
	public SprayCan <>4__this; // 0x10
	public BaseEntity targetEntity; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA902B0 Offset: 0xA8E8B0 VA: 0x180A902B0
	internal void <OpenReskinOptions>b__0(bool confirmed, int skinId) { }

}

