public class HowToExamineHeld : BaseTip // TypeDefIndex: 11593
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B10440

	// Properties
	public int ExaminedTimes { get; }
	public float SecondsLastExamined { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x75F660 Offset: 0x75DC60 VA: 0x18075F660 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75F730 Offset: 0x75DD30 VA: 0x18075F730
	public int get_ExaminedTimes() { }

	// RVA: 0x75F740 Offset: 0x75DD40 VA: 0x18075F740
	public float get_SecondsLastExamined() { }

	// RVA: 0x75F7B0 Offset: 0x75DDB0 VA: 0x18075F7B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75F6C0 Offset: 0x75DCC0 VA: 0x18075F6C0
	private static void .cctor() { }

}

public class HowToHammerUpgrade : BaseTip // TypeDefIndex: 11594
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastBuildChangeTime; // 0x8

	// Properties
	public float TimeSinceBuildChanged { get; }
	public static bool HasHammerEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x75F950 Offset: 0x75DF50 VA: 0x18075F950 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75F9B0 Offset: 0x75DFB0 VA: 0x18075F9B0
	public static void UpgradeHappened() { }

	// RVA: 0x75FD80 Offset: 0x75E380 VA: 0x18075FD80
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x75FAC0 Offset: 0x75E0C0 VA: 0x18075FAC0
	public static bool get_HasHammerEquipped() { }

	// RVA: 0x75FCA0 Offset: 0x75E2A0 VA: 0x18075FCA0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75FA40 Offset: 0x75E040 VA: 0x18075FA40
	private static void .cctor() { }

}

public class HowToOpenBuildOptions : BaseTip // TypeDefIndex: 11595
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastBuildChangeTime; // 0x8

	// Properties
	public float TimeSinceBuildChanged { get; }
	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x75FE70 Offset: 0x75E470 VA: 0x18075FE70 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75FDF0 Offset: 0x75E3F0 VA: 0x18075FDF0
	public static void BuildOptionChanged() { }

	// RVA: 0x760230 Offset: 0x75E830 VA: 0x180760230
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x75FF50 Offset: 0x75E550 VA: 0x18075FF50
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0x760140 Offset: 0x75E740 VA: 0x180760140 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75FED0 Offset: 0x75E4D0 VA: 0x18075FED0
	private static void .cctor() { }

}

public class HowToOpenCrafting : BaseTip // TypeDefIndex: 11596
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E0F0

	// Properties
	public int CraftingOpenedTimes { get; }
	public float CraftingOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7602A0 Offset: 0x75E8A0 VA: 0x1807602A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x7603B0 Offset: 0x75E9B0 VA: 0x1807603B0
	public int get_CraftingOpenedTimes() { }

	// RVA: 0x760370 Offset: 0x75E970 VA: 0x180760370
	public float get_CraftingOpenedSecondsAgo() { }

	// RVA: 0x7603C0 Offset: 0x75E9C0 VA: 0x1807603C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760300 Offset: 0x75E900 VA: 0x180760300
	private static void .cctor() { }

}

public class HowToOpenInventory : BaseTip // TypeDefIndex: 11597
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E138

	// Properties
	public int InventoryOpenedTimes { get; }
	public float IntentoryOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x760420 Offset: 0x75EA20 VA: 0x180760420 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760560 Offset: 0x75EB60 VA: 0x180760560
	public int get_InventoryOpenedTimes() { }

	// RVA: 0x7604F0 Offset: 0x75EAF0 VA: 0x1807604F0
	public float get_IntentoryOpenedSecondsAgo() { }

	// RVA: 0x760570 Offset: 0x75EB70 VA: 0x180760570 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760480 Offset: 0x75EA80 VA: 0x180760480
	private static void .cctor() { }

}

public class HowToOpenMap : BaseTip // TypeDefIndex: 11598
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B10440

	// Properties
	public int MapOpenedTimes { get; }
	public float MapOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x760600 Offset: 0x75EC00 VA: 0x180760600 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760740 Offset: 0x75ED40 VA: 0x180760740
	public int get_MapOpenedTimes() { }

	// RVA: 0x7606D0 Offset: 0x75ECD0 VA: 0x1807606D0
	public float get_MapOpenedSecondsAgo() { }

	// RVA: 0x760750 Offset: 0x75ED50 VA: 0x180760750 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760660 Offset: 0x75EC60 VA: 0x180760660
	private static void .cctor() { }

}

public class HowToOreMinigame : BaseTip // TypeDefIndex: 11599
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastOreHitTime; // 0x8

	// Properties
	public int OreSpotsHit { get; }
	public float OreHitSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7607E0 Offset: 0x75EDE0 VA: 0x1807607E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x7609A0 Offset: 0x75EFA0 VA: 0x1807609A0
	public int get_OreSpotsHit() { }

	// RVA: 0x760930 Offset: 0x75EF30 VA: 0x180760930
	public float get_OreHitSecondsAgo() { }

	// RVA: 0x760840 Offset: 0x75EE40 VA: 0x180760840
	public static void OreHit() { }

	// RVA: 0x7609B0 Offset: 0x75EFB0 VA: 0x1807609B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7608C0 Offset: 0x75EEC0 VA: 0x1807608C0
	private static void .cctor() { }

}

public class HowToRegenWithComfort : BaseTip // TypeDefIndex: 11600
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E140

	// Properties
	public static bool IsComfortable { get; }
	public static float TimeComfortableTotal { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x760A40 Offset: 0x75F040 VA: 0x180760A40 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760B10 Offset: 0x75F110 VA: 0x180760B10
	public static bool get_IsComfortable() { }

	// RVA: 0x760E80 Offset: 0x75F480 VA: 0x180760E80
	public static float get_TimeComfortableTotal() { }

	// RVA: 0x760C90 Offset: 0x75F290 VA: 0x180760C90 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760AA0 Offset: 0x75F0A0 VA: 0x180760AA0
	private static void .cctor() { }

}

public class HowToRetrieveThrown : BaseTip // TypeDefIndex: 11601
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E17F

	// Properties
	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x760E90 Offset: 0x75F490 VA: 0x180760E90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760F60 Offset: 0x75F560 VA: 0x180760F60
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x761150 Offset: 0x75F750 VA: 0x180761150 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760EF0 Offset: 0x75F4F0 VA: 0x180760EF0
	private static void .cctor() { }

}

public class HowToThrow : BaseTip // TypeDefIndex: 11602
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool itemThrown; // 0x8
	public static float lastThrownTime; // 0xC

	// Properties
	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7612B0 Offset: 0x75F8B0 VA: 0x1807612B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761310 Offset: 0x75F910 VA: 0x180761310
	public static void ItemThrown() { }

	// RVA: 0x7613A0 Offset: 0x75F9A0 VA: 0x1807613A0
	public static bool RecentlyThrown() { }

	// RVA: 0x7614F0 Offset: 0x75FAF0 VA: 0x1807614F0
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x7616E0 Offset: 0x75FCE0 VA: 0x1807616E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761460 Offset: 0x75FA60 VA: 0x180761460
	private static void .cctor() { }

}

public class HowToTreeMinigame : BaseTip // TypeDefIndex: 11603
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastTreeHitTime; // 0x8

	// Properties
	public int TreeSpotsHit { get; }
	public float TreeHitSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x761790 Offset: 0x75FD90 VA: 0x180761790 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x7619E0 Offset: 0x75FFE0 VA: 0x1807619E0
	public int get_TreeSpotsHit() { }

	// RVA: 0x761970 Offset: 0x75FF70 VA: 0x180761970
	public float get_TreeHitSecondsAgo() { }

	// RVA: 0x7617F0 Offset: 0x75FDF0 VA: 0x1807617F0
	public static void TreeHit() { }

	// RVA: 0x7618E0 Offset: 0x75FEE0 VA: 0x1807618E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761870 Offset: 0x75FE70 VA: 0x180761870
	private static void .cctor() { }

}

public class HowToUseBow : BaseTip // TypeDefIndex: 11604
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B10388

	// Properties
	public static bool HasBowItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7619F0 Offset: 0x75FFF0 VA: 0x1807619F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761AC0 Offset: 0x7600C0 VA: 0x180761AC0
	public static bool get_HasBowItemEquipped() { }

	// RVA: 0x761CA0 Offset: 0x7602A0 VA: 0x180761CA0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761A50 Offset: 0x760050 VA: 0x180761A50
	private static void .cctor() { }

}

public class HowToUseGrenade : BaseTip // TypeDefIndex: 11605
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E180

	// Properties
	private static bool HasGrenadeItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x761D10 Offset: 0x760310 VA: 0x180761D10 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761DE0 Offset: 0x7603E0 VA: 0x180761DE0
	private static bool get_HasGrenadeItemEquipped() { }

	// RVA: 0x761FC0 Offset: 0x7605C0 VA: 0x180761FC0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761D70 Offset: 0x760370 VA: 0x180761D70
	private static void .cctor() { }

}

public class HowToUseWave : BaseTip // TypeDefIndex: 11606
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float lastWavedAtTime; // 0x8
	public static float lastLocalWaveTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7620B0 Offset: 0x7606B0 VA: 0x1807620B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x762190 Offset: 0x760790 VA: 0x180762190
	public static void MarkWavedAt(BasePlayer Entity) { }

	// RVA: 0x762110 Offset: 0x760710 VA: 0x180762110
	public static void MarkLocalWave() { }

	// RVA: 0x762030 Offset: 0x760630 VA: 0x180762030
	public bool DidRecentlyWaveLocally() { }

	// RVA: 0x7624D0 Offset: 0x760AD0 VA: 0x1807624D0
	public bool WasRecentlyWavedAt() { }

	// RVA: 0x7625E0 Offset: 0x760BE0 VA: 0x1807625E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x762550 Offset: 0x760B50 VA: 0x180762550
	private static void .cctor() { }

}

public class HowToVoiceChat : BaseTip // TypeDefIndex: 11607
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E1F6

	// Properties
	public float SecondsSpeaking { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5BBB0 Offset: 0xC5A1B0 VA: 0x180C5BBB0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5BC80 Offset: 0xC5A280 VA: 0x180C5BC80
	public float get_SecondsSpeaking() { }

	// RVA: 0xC5BC90 Offset: 0xC5A290 VA: 0x180C5BC90 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5BC10 Offset: 0xC5A210 VA: 0x180C5BC10
	private static void .cctor() { }

}

public class HowToWorldDrink : BaseTip // TypeDefIndex: 11608
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B10370

	// Properties
	public bool NearFreshWater { get; }
	public float ConsumedWater { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5C2A0 Offset: 0xC5A8A0 VA: 0x180C5C2A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5C380 Offset: 0xC5A980 VA: 0x180C5C380
	public bool get_NearFreshWater() { }

	// RVA: 0xC5C370 Offset: 0xC5A970 VA: 0x180C5C370
	public float get_ConsumedWater() { }

	// RVA: 0xC5C510 Offset: 0xC5AB10 VA: 0x180C5C510 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5C300 Offset: 0xC5A900 VA: 0x180C5C300
	private static void .cctor() { }

}

public class TipInstrumentFullKeyboard : InstrumentTip // TypeDefIndex: 11610
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E200

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F700 Offset: 0xC5DD00 VA: 0x180C5F700 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F7D0 Offset: 0xC5DDD0 VA: 0x180C5F7D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5F760 Offset: 0xC5DD60 VA: 0x180C5F760
	private static void .cctor() { }

}

public class TipInstrumentNumlock : InstrumentTip // TypeDefIndex: 11611
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E271

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F870 Offset: 0xC5DE70 VA: 0x180C5F870 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F940 Offset: 0xC5DF40 VA: 0x180C5F940 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5F8D0 Offset: 0xC5DED0 VA: 0x180C5F8D0
	private static void .cctor() { }

}

public class TipInstrumentPlay : InstrumentTip // TypeDefIndex: 11612
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B104D4

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F9C0 Offset: 0xC5DFC0 VA: 0x180C5F9C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5FA90 Offset: 0xC5E090 VA: 0x180C5FA90 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5FA20 Offset: 0xC5E020 VA: 0x180C5FA20
	private static void .cctor() { }

}

public class TipBreakCarLock : BaseTip // TypeDefIndex: 11614
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasShowing; // 0x8
	public static float nextTipTime; // 0xC
	public const float MIN_TIME_BETWEEN_TIPS = 300;

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5CC90 Offset: 0xC5B290 VA: 0x180C5CC90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5CB10 Offset: 0xC5B110 VA: 0x180C5CB10
	public static bool AimingInNoBuild() { }

	// RVA: 0xC5CD60 Offset: 0xC5B360 VA: 0x180C5CD60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5CCF0 Offset: 0xC5B2F0 VA: 0x180C5CCF0
	private static void .cctor() { }

}

public class TipCannotHarvest : BaseTip // TypeDefIndex: 11615
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float nonEntityHitTime; // 0x8

	// Properties
	public float TimeSinceHitNonEntity { get; }
	public static bool HasToolItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5D020 Offset: 0xC5B620 VA: 0x180C5D020 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5D080 Offset: 0xC5B680 VA: 0x180C5D080
	public static void HitNonEntity() { }

	// RVA: 0xC5D460 Offset: 0xC5BA60 VA: 0x180C5D460
	public float get_TimeSinceHitNonEntity() { }

	// RVA: 0xC5D180 Offset: 0xC5B780 VA: 0x180C5D180
	public static bool get_HasToolItemEquipped() { }

	// RVA: 0xC5D380 Offset: 0xC5B980 VA: 0x180C5D380 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5D100 Offset: 0xC5B700 VA: 0x180C5D100
	private static void .cctor() { }

}

public class TipConsumeFood : BaseTip // TypeDefIndex: 11616
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public float lastFoodPickupTime; // 0x10
	public int lastFoodPickupCount; // 0x14

	// Properties
	public float ConsumedFood { get; }
	public float ConsumedWater { get; }
	public int PickedUpFood { get; }
	public bool HasConsumedEnough { get; }
	public bool RecentlyPickedUpFood { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5D4D0 Offset: 0xC5BAD0 VA: 0x180C5D4D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5D5A0 Offset: 0xC5BBA0 VA: 0x180C5D5A0
	public float get_ConsumedFood() { }

	// RVA: 0xC5C370 Offset: 0xC5A970 VA: 0x180C5C370
	public float get_ConsumedWater() { }

	// RVA: 0xC5D5F0 Offset: 0xC5BBF0 VA: 0x180C5D5F0
	public int get_PickedUpFood() { }

	// RVA: 0xC5D5B0 Offset: 0xC5BBB0 VA: 0x180C5D5B0
	public bool get_HasConsumedEnough() { }

	// RVA: 0xC5D6E0 Offset: 0xC5BCE0 VA: 0x180C5D6E0
	public bool get_RecentlyPickedUpFood() { }

	// RVA: 0xC5D820 Offset: 0xC5BE20 VA: 0x180C5D820 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5D530 Offset: 0xC5BB30 VA: 0x180C5D530
	private static void .cctor() { }

}

public class TipControllingMagnetCrane : BaseTip // TypeDefIndex: 11617
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	private bool wasMounted; // 0x10
	private TimeSince timeSinceShown; // 0x14

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5D990 Offset: 0xC5BF90 VA: 0x180C5D990 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5DA60 Offset: 0xC5C060 VA: 0x180C5DA60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5D9F0 Offset: 0xC5BFF0 VA: 0x180C5D9F0
	private static void .cctor() { }

}

public class TipDrivingSubmarine : BaseTip // TypeDefIndex: 11618
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	private bool wasMounted; // 0x10
	private bool haveShown; // 0x11

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5DC20 Offset: 0xC5C220 VA: 0x180C5DC20 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5DCF0 Offset: 0xC5C2F0 VA: 0x180C5DCF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5DC80 Offset: 0xC5C280 VA: 0x180C5DC80
	private static void .cctor() { }

}

public class TipEquipTorch : BaseTip // TypeDefIndex: 11619
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static float nextTorchTipTime; // 0x8

	// Properties
	public static bool IsDark { get; }
	public static float TimeComfortableTotal { get; }
	public static bool HasTorchThatNeedsLighting { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5DE90 Offset: 0xC5C490 VA: 0x180C5DE90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E220 Offset: 0xC5C820 VA: 0x180C5E220
	public static bool get_IsDark() { }

	// RVA: 0x760E80 Offset: 0x75F480 VA: 0x180760E80
	public static float get_TimeComfortableTotal() { }

	// RVA: 0xC5DEF0 Offset: 0xC5C4F0 VA: 0x180C5DEF0
	public static void TorchLit() { }

	// RVA: 0xC5DFE0 Offset: 0xC5C5E0 VA: 0x180C5DFE0
	public static bool get_HasTorchThatNeedsLighting() { }

	// RVA: 0xC5E2E0 Offset: 0xC5C8E0 VA: 0x180C5E2E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5DF70 Offset: 0xC5C570 VA: 0x180C5DF70
	private static void .cctor() { }

}

public class TipFillToolCupboard : BaseTip // TypeDefIndex: 11620
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E280

	// Properties
	public int CupboardOpenedTimes { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5E460 Offset: 0xC5CA60 VA: 0x180C5E460 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E530 Offset: 0xC5CB30 VA: 0x180C5E530
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC5E540 Offset: 0xC5CB40 VA: 0x180C5E540 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5E4C0 Offset: 0xC5CAC0 VA: 0x180C5E4C0
	private static void .cctor() { }

}

public class TipFishingControls : BaseTip // TypeDefIndex: 11621
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E2F5

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5E710 Offset: 0xC5CD10 VA: 0x180C5E710 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E7E0 Offset: 0xC5CDE0 VA: 0x180C5E7E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5E770 Offset: 0xC5CD70 VA: 0x180C5E770
	private static void .cctor() { }

}

public class TipFishingFail : BaseTip // TypeDefIndex: 11622
{	// Fields
	public static Translate.Phrase StrainPhrase; // 0x0
	public static Translate.Phrase AnglePhrase; // 0x8
	public static Translate.Phrase ObstructedPhrase; // 0x10

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5E970 Offset: 0xC5CF70 VA: 0x180C5E970 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5EB80 Offset: 0xC5D180 VA: 0x180C5EB80 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5EA80 Offset: 0xC5D080 VA: 0x180C5EA80
	private static void .cctor() { }

}

public class TipHealAtCampfire : BaseTip // TypeDefIndex: 11623
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public float oldHealth; // 0x10
	public float lastHurtTime; // 0x14

	// Properties
	public bool IsHurt { get; }
	public float TimeComfortableTotal { get; }
	public bool HealEligable { get; }
	public bool RecentlyHurt { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5ED90 Offset: 0xC5D390 VA: 0x180C5ED90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F030 Offset: 0xC5D630 VA: 0x180C5F030
	public bool get_IsHurt() { }

	// RVA: 0x760E80 Offset: 0x75F480 VA: 0x180760E80
	public float get_TimeComfortableTotal() { }

	// RVA: 0xC5EE70 Offset: 0xC5D470 VA: 0x180C5EE70
	public bool get_HealEligable() { }

	// RVA: 0xC5F1A0 Offset: 0xC5D7A0 VA: 0x180C5F1A0
	public bool get_RecentlyHurt() { }

	// RVA: 0xC5F3B0 Offset: 0xC5D9B0 VA: 0x180C5F3B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0xC5EE60 Offset: 0xC5D460 VA: 0x180C5EE60
	public void .ctor() { }

	// RVA: 0xC5EDF0 Offset: 0xC5D3F0 VA: 0x180C5EDF0
	private static void .cctor() { }

}

public class TipKayakPaddle : BaseTip // TypeDefIndex: 11624
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <hasPaddledWithoutOar>k__BackingField; // 0x8

	// Properties
	public override bool ShouldShow { get; }
	public static bool hasPaddledWithoutOar { get; set; }

	// Methods

	// RVA: 0xC5FB30 Offset: 0xC5E130 VA: 0x180C5FB30 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5FC10 Offset: 0xC5E210 VA: 0x180C5FC10 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC5FF30 Offset: 0xC5E530 VA: 0x180C5FF30
	public static bool get_hasPaddledWithoutOar() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC5FF90 Offset: 0xC5E590 VA: 0x180C5FF90
	public static void set_hasPaddledWithoutOar(bool value) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC5FB90 Offset: 0xC5E190 VA: 0x180C5FB90
	private static void .cctor() { }

}

public class TipMLRSAimingModule : BaseTip // TypeDefIndex: 11625
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5FFF0 Offset: 0xC5E5F0 VA: 0x180C5FFF0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC600C0 Offset: 0xC5E6C0 VA: 0x180C600C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC60050 Offset: 0xC5E650 VA: 0x180C60050
	private static void .cctor() { }

}

public class TipMLRSBrokenDown : BaseTip // TypeDefIndex: 11626
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC602E0 Offset: 0xC5E8E0 VA: 0x180C602E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC603B0 Offset: 0xC5E9B0 VA: 0x180C603B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC60340 Offset: 0xC5E940 VA: 0x180C60340
	private static void .cctor() { }

}

public class TipMLRSNoRockets : BaseTip // TypeDefIndex: 11627
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool wasMounted; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC605B0 Offset: 0xC5EBB0 VA: 0x180C605B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC60680 Offset: 0xC5EC80 VA: 0x180C60680 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC60610 Offset: 0xC5EC10 VA: 0x180C60610
	private static void .cctor() { }

}

public class TipMissingLure : BaseTip // TypeDefIndex: 11628
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B103D0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC608B0 Offset: 0xC5EEB0 VA: 0x180C608B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC60980 Offset: 0xC5EF80 VA: 0x180C60980 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC60910 Offset: 0xC5EF10 VA: 0x180C60910
	private static void .cctor() { }

}

public class TipNoBuild : BaseTip // TypeDefIndex: 11629
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E300

	// Properties
	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60CB0 Offset: 0xC5F2B0 VA: 0x180C60CB0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC60D80 Offset: 0xC5F380 VA: 0x180C60D80
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0xC60B30 Offset: 0xC5F130 VA: 0x180C60B30
	public static bool AimingInNoBuild() { }

	// RVA: 0xC60F60 Offset: 0xC5F560 VA: 0x180C60F60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC60D10 Offset: 0xC5F310 VA: 0x180C60D10
	private static void .cctor() { }

}

public class TipPetControlWheel : BaseTip // TypeDefIndex: 11630
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool haveShown; // 0x8

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC610A0 Offset: 0xC5F6A0 VA: 0x180C610A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61170 Offset: 0xC5F770 VA: 0x180C61170 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC61100 Offset: 0xC5F700 VA: 0x180C61100
	private static void .cctor() { }

}

public class TipPlaceSleepingBag : BaseTip // TypeDefIndex: 11631
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E379

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC612D0 Offset: 0xC5F8D0 VA: 0x180C612D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC613A0 Offset: 0xC5F9A0 VA: 0x180C613A0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC61330 Offset: 0xC5F930 VA: 0x180C61330
	private static void .cctor() { }

}

public class TipPlaceToolCupboard : BaseTip // TypeDefIndex: 11632
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B104DC

	// Properties
	public int CupboardOpenedTimes { get; }
	public int NumBlocksPlaced { get; }
	public int NumBlocksUpgraded { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC616A0 Offset: 0xC5FCA0 VA: 0x180C616A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E530 Offset: 0xC5CB30 VA: 0x180C5E530
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC61770 Offset: 0xC5FD70 VA: 0x180C61770
	public int get_NumBlocksPlaced() { }

	// RVA: 0xC61780 Offset: 0xC5FD80 VA: 0x180C61780
	public int get_NumBlocksUpgraded() { }

	// RVA: 0xC61790 Offset: 0xC5FD90 VA: 0x180C61790 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC61700 Offset: 0xC5FD00 VA: 0x180C61700
	private static void .cctor() { }

}

public class TipPokerWinnings : BaseTip // TypeDefIndex: 11633
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E380

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC61A10 Offset: 0xC60010 VA: 0x180C61A10 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61AE0 Offset: 0xC600E0 VA: 0x180C61AE0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC61A70 Offset: 0xC60070 VA: 0x180C61A70
	private static void .cctor() { }

}

public class TipRads : BaseTip // TypeDefIndex: 11634
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E40E

	// Properties
	public float RadDuration { get; }
	public bool HasRads { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC61CC0 Offset: 0xC602C0 VA: 0x180C61CC0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61F10 Offset: 0xC60510 VA: 0x180C61F10
	public float get_RadDuration() { }

	// RVA: 0xC61D90 Offset: 0xC60390 VA: 0x180C61D90
	public bool get_HasRads() { }

	// RVA: 0xC61F20 Offset: 0xC60520 VA: 0x180C61F20 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC61D20 Offset: 0xC60320 VA: 0x180C61D20
	private static void .cctor() { }

}

public class TipRemoveRads : BaseTip // TypeDefIndex: 11635
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B10550

	// Properties
	public float RadDuration { get; }
	public bool HasRads { get; }
	public bool HasRadExposure { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC620B0 Offset: 0xC606B0 VA: 0x180C620B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61F10 Offset: 0xC60510 VA: 0x180C61F10
	public float get_RadDuration() { }

	// RVA: 0xC62300 Offset: 0xC60900 VA: 0x180C62300
	public bool get_HasRads() { }

	// RVA: 0xC62180 Offset: 0xC60780 VA: 0x180C62180
	public bool get_HasRadExposure() { }

	// RVA: 0xC62480 Offset: 0xC60A80 VA: 0x180C62480 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC62110 Offset: 0xC60710 VA: 0x180C62110
	private static void .cctor() { }

}

public class TipReskinObject : BaseTip // TypeDefIndex: 11636
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E410

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC62790 Offset: 0xC60D90 VA: 0x180C62790 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62860 Offset: 0xC60E60 VA: 0x180C62860 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC627F0 Offset: 0xC60DF0 VA: 0x180C627F0
	private static void .cctor() { }

}

public class TipSledPlacement : BaseTip // TypeDefIndex: 11637
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E48D

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC629F0 Offset: 0xC60FF0 VA: 0x180C629F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62AC0 Offset: 0xC610C0 VA: 0x180C62AC0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC62A50 Offset: 0xC61050 VA: 0x180C62A50
	private static void .cctor() { }

}

public class TipSleepingBagPlacement : BaseTip // TypeDefIndex: 11638
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B10568

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC62C60 Offset: 0xC61260 VA: 0x180C62C60 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62D30 Offset: 0xC61330 VA: 0x180C62D30 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC62CC0 Offset: 0xC612C0 VA: 0x180C62CC0
	private static void .cctor() { }

}

public class TipSnapAttractionPoint : BaseTip // TypeDefIndex: 11639
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <HasDismissedSnap>k__BackingField; // 0x8

	// Properties
	public override bool ShouldShow { get; }
	public static bool HasDismissedSnap { get; set; }

	// Methods

	// RVA: 0xC62F40 Offset: 0xC61540 VA: 0x180C62F40 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC63080 Offset: 0xC61680 VA: 0x180C63080 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC63020 Offset: 0xC61620 VA: 0x180C63020
	public static bool get_HasDismissedSnap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC632B0 Offset: 0xC618B0 VA: 0x180C632B0
	public static void set_HasDismissedSnap(bool value) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC62FA0 Offset: 0xC615A0 VA: 0x180C62FA0
	private static void .cctor() { }

}

public class TipSnowmobileSurface : BaseTip // TypeDefIndex: 11640
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool showedMessage; // 0x8
	public static float nextTipTime; // 0xC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC63310 Offset: 0xC61910 VA: 0x180C63310 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC633E0 Offset: 0xC619E0 VA: 0x180C633E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC63370 Offset: 0xC61970 VA: 0x180C63370
	private static void .cctor() { }

}

public class TipSprayControls : BaseTip // TypeDefIndex: 11641
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E490

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC635F0 Offset: 0xC61BF0 VA: 0x180C635F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC636C0 Offset: 0xC61CC0 VA: 0x180C636C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC63650 Offset: 0xC61C50 VA: 0x180C63650
	private static void .cctor() { }

}

public class TipTooCold : BaseTip // TypeDefIndex: 11642
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E4B0

	// Properties
	public float ColdDuration { get; }
	public bool IsCold { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC638A0 Offset: 0xC61EA0 VA: 0x180C638A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61F10 Offset: 0xC60510 VA: 0x180C61F10
	public float get_ColdDuration() { }

	// RVA: 0xC63970 Offset: 0xC61F70 VA: 0x180C63970
	public bool get_IsCold() { }

	// RVA: 0xC63AF0 Offset: 0xC620F0 VA: 0x180C63AF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC63900 Offset: 0xC61F00 VA: 0x180C63900
	private static void .cctor() { }

}

public class TipTooHot : BaseTip // TypeDefIndex: 11643
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B10368

	// Properties
	public float HotDuration { get; }
	public bool IsHot { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC63C90 Offset: 0xC62290 VA: 0x180C63C90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC63D60 Offset: 0xC62360 VA: 0x180C63D60
	public float get_HotDuration() { }

	// RVA: 0xC63D70 Offset: 0xC62370 VA: 0x180C63D70
	public bool get_IsHot() { }

	// RVA: 0xC63EF0 Offset: 0xC624F0 VA: 0x180C63EF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC63CF0 Offset: 0xC622F0 VA: 0x180C63CF0
	private static void .cctor() { }

}

public class TipZipline : BaseTip // TypeDefIndex: 11644
{	// Fields
	public static Translate.Phrase Phrase; // 0x1E4B0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC64090 Offset: 0xC62690 VA: 0x180C64090 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC64160 Offset: 0xC62760 VA: 0x180C64160 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0xC640F0 Offset: 0xC626F0 VA: 0x180C640F0
	private static void .cctor() { }

}

