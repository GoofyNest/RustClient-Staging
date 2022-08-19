public class HowToExamineHeld : BaseTip // TypeDefIndex: 11593
{	// Fields
	public static Translate.Phrase Phrase; // 0x20090

	// Properties
	public int ExaminedTimes { get; }
	public float SecondsLastExamined { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x75F600 Offset: 0x75DC00 VA: 0x18075F600 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75F6D0 Offset: 0x75DCD0 VA: 0x18075F6D0
	public int get_ExaminedTimes() { }

	// RVA: 0x75F6E0 Offset: 0x75DCE0 VA: 0x18075F6E0
	public float get_SecondsLastExamined() { }

	// RVA: 0x75F750 Offset: 0x75DD50 VA: 0x18075F750 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75F660 Offset: 0x75DC60 VA: 0x18075F660
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

	// RVA: 0x75F8F0 Offset: 0x75DEF0 VA: 0x18075F8F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75F950 Offset: 0x75DF50 VA: 0x18075F950
	public static void UpgradeHappened() { }

	// RVA: 0x75FD20 Offset: 0x75E320 VA: 0x18075FD20
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x75FA60 Offset: 0x75E060 VA: 0x18075FA60
	public static bool get_HasHammerEquipped() { }

	// RVA: 0x75FC40 Offset: 0x75E240 VA: 0x18075FC40 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75F9E0 Offset: 0x75DFE0 VA: 0x18075F9E0
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

	// RVA: 0x75FE10 Offset: 0x75E410 VA: 0x18075FE10 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75FD90 Offset: 0x75E390 VA: 0x18075FD90
	public static void BuildOptionChanged() { }

	// RVA: 0x7601D0 Offset: 0x75E7D0 VA: 0x1807601D0
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x75FEF0 Offset: 0x75E4F0 VA: 0x18075FEF0
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0x7600E0 Offset: 0x75E6E0 VA: 0x1807600E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75FE70 Offset: 0x75E470 VA: 0x18075FE70
	private static void .cctor() { }

}

public class HowToOpenCrafting : BaseTip // TypeDefIndex: 11596
{	// Fields
	public static Translate.Phrase Phrase; // 0x200B5

	// Properties
	public int CraftingOpenedTimes { get; }
	public float CraftingOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x760240 Offset: 0x75E840 VA: 0x180760240 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760350 Offset: 0x75E950 VA: 0x180760350
	public int get_CraftingOpenedTimes() { }

	// RVA: 0x760310 Offset: 0x75E910 VA: 0x180760310
	public float get_CraftingOpenedSecondsAgo() { }

	// RVA: 0x760360 Offset: 0x75E960 VA: 0x180760360 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7602A0 Offset: 0x75E8A0 VA: 0x1807602A0
	private static void .cctor() { }

}

public class HowToOpenInventory : BaseTip // TypeDefIndex: 11597
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11168

	// Properties
	public int InventoryOpenedTimes { get; }
	public float IntentoryOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7603C0 Offset: 0x75E9C0 VA: 0x1807603C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760500 Offset: 0x75EB00 VA: 0x180760500
	public int get_InventoryOpenedTimes() { }

	// RVA: 0x760490 Offset: 0x75EA90 VA: 0x180760490
	public float get_IntentoryOpenedSecondsAgo() { }

	// RVA: 0x760510 Offset: 0x75EB10 VA: 0x180760510 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760420 Offset: 0x75EA20 VA: 0x180760420
	private static void .cctor() { }

}

public class HowToOpenMap : BaseTip // TypeDefIndex: 11598
{	// Fields
	public static Translate.Phrase Phrase; // 0x200C0

	// Properties
	public int MapOpenedTimes { get; }
	public float MapOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7605A0 Offset: 0x75EBA0 VA: 0x1807605A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x7606E0 Offset: 0x75ECE0 VA: 0x1807606E0
	public int get_MapOpenedTimes() { }

	// RVA: 0x760670 Offset: 0x75EC70 VA: 0x180760670
	public float get_MapOpenedSecondsAgo() { }

	// RVA: 0x7606F0 Offset: 0x75ECF0 VA: 0x1807606F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760600 Offset: 0x75EC00 VA: 0x180760600
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

	// RVA: 0x760780 Offset: 0x75ED80 VA: 0x180760780 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760940 Offset: 0x75EF40 VA: 0x180760940
	public int get_OreSpotsHit() { }

	// RVA: 0x7608D0 Offset: 0x75EED0 VA: 0x1807608D0
	public float get_OreHitSecondsAgo() { }

	// RVA: 0x7607E0 Offset: 0x75EDE0 VA: 0x1807607E0
	public static void OreHit() { }

	// RVA: 0x760950 Offset: 0x75EF50 VA: 0x180760950 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760860 Offset: 0x75EE60 VA: 0x180760860
	private static void .cctor() { }

}

public class HowToRegenWithComfort : BaseTip // TypeDefIndex: 11600
{	// Fields
	public static Translate.Phrase Phrase; // 0x20130

	// Properties
	public static bool IsComfortable { get; }
	public static float TimeComfortableTotal { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7609E0 Offset: 0x75EFE0 VA: 0x1807609E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760AB0 Offset: 0x75F0B0 VA: 0x180760AB0
	public static bool get_IsComfortable() { }

	// RVA: 0x760E20 Offset: 0x75F420 VA: 0x180760E20
	public static float get_TimeComfortableTotal() { }

	// RVA: 0x760C30 Offset: 0x75F230 VA: 0x180760C30 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760A40 Offset: 0x75F040 VA: 0x180760A40
	private static void .cctor() { }

}

public class HowToRetrieveThrown : BaseTip // TypeDefIndex: 11601
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B112D4

	// Properties
	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x760E30 Offset: 0x75F430 VA: 0x180760E30 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760F00 Offset: 0x75F500 VA: 0x180760F00
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x7610F0 Offset: 0x75F6F0 VA: 0x1807610F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760E90 Offset: 0x75F490 VA: 0x180760E90
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

	// RVA: 0x761250 Offset: 0x75F850 VA: 0x180761250 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x7612B0 Offset: 0x75F8B0 VA: 0x1807612B0
	public static void ItemThrown() { }

	// RVA: 0x761340 Offset: 0x75F940 VA: 0x180761340
	public static bool RecentlyThrown() { }

	// RVA: 0x761490 Offset: 0x75FA90 VA: 0x180761490
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x761680 Offset: 0x75FC80 VA: 0x180761680 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761400 Offset: 0x75FA00 VA: 0x180761400
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

	// RVA: 0x761730 Offset: 0x75FD30 VA: 0x180761730 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761980 Offset: 0x75FF80 VA: 0x180761980
	public int get_TreeSpotsHit() { }

	// RVA: 0x761910 Offset: 0x75FF10 VA: 0x180761910
	public float get_TreeHitSecondsAgo() { }

	// RVA: 0x761790 Offset: 0x75FD90 VA: 0x180761790
	public static void TreeHit() { }

	// RVA: 0x761880 Offset: 0x75FE80 VA: 0x180761880 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761810 Offset: 0x75FE10 VA: 0x180761810
	private static void .cctor() { }

}

public class HowToUseBow : BaseTip // TypeDefIndex: 11604
{	// Fields
	public static Translate.Phrase Phrase; // 0x20130

	// Properties
	public static bool HasBowItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x761990 Offset: 0x75FF90 VA: 0x180761990 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761A60 Offset: 0x760060 VA: 0x180761A60
	public static bool get_HasBowItemEquipped() { }

	// RVA: 0x761C40 Offset: 0x760240 VA: 0x180761C40 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7619F0 Offset: 0x75FFF0 VA: 0x1807619F0
	private static void .cctor() { }

}

public class HowToUseGrenade : BaseTip // TypeDefIndex: 11605
{	// Fields
	public static Translate.Phrase Phrase; // 0x20189

	// Properties
	private static bool HasGrenadeItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x761CB0 Offset: 0x7602B0 VA: 0x180761CB0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761D80 Offset: 0x760380 VA: 0x180761D80
	private static bool get_HasGrenadeItemEquipped() { }

	// RVA: 0x761F60 Offset: 0x760560 VA: 0x180761F60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761D10 Offset: 0x760310 VA: 0x180761D10
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

	// RVA: 0x762050 Offset: 0x760650 VA: 0x180762050 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x762130 Offset: 0x760730 VA: 0x180762130
	public static void MarkWavedAt(BasePlayer Entity) { }

	// RVA: 0x7620B0 Offset: 0x7606B0 VA: 0x1807620B0
	public static void MarkLocalWave() { }

	// RVA: 0x761FD0 Offset: 0x7605D0 VA: 0x180761FD0
	public bool DidRecentlyWaveLocally() { }

	// RVA: 0x762470 Offset: 0x760A70 VA: 0x180762470
	public bool WasRecentlyWavedAt() { }

	// RVA: 0x762580 Offset: 0x760B80 VA: 0x180762580 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7624F0 Offset: 0x760AF0 VA: 0x1807624F0
	private static void .cctor() { }

}

public class HowToVoiceChat : BaseTip // TypeDefIndex: 11607
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11180

	// Properties
	public float SecondsSpeaking { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5B420 Offset: 0xC59A20 VA: 0x180C5B420 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5B4F0 Offset: 0xC59AF0 VA: 0x180C5B4F0
	public float get_SecondsSpeaking() { }

	// RVA: 0xC5B500 Offset: 0xC59B00 VA: 0x180C5B500 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5B480 Offset: 0xC59A80 VA: 0x180C5B480
	private static void .cctor() { }

}

public class HowToWorldDrink : BaseTip // TypeDefIndex: 11608
{	// Fields
	public static Translate.Phrase Phrase; // 0x20190

	// Properties
	public bool NearFreshWater { get; }
	public float ConsumedWater { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5BB10 Offset: 0xC5A110 VA: 0x180C5BB10 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5BBF0 Offset: 0xC5A1F0 VA: 0x180C5BBF0
	public bool get_NearFreshWater() { }

	// RVA: 0xC5BBE0 Offset: 0xC5A1E0 VA: 0x180C5BBE0
	public float get_ConsumedWater() { }

	// RVA: 0xC5BD80 Offset: 0xC5A380 VA: 0x180C5BD80 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5BB70 Offset: 0xC5A170 VA: 0x180C5BB70
	private static void .cctor() { }

}

public class TipInstrumentFullKeyboard : InstrumentTip // TypeDefIndex: 11610
{	// Fields
	public static Translate.Phrase Phrase; // 0x2022D

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5EF70 Offset: 0xC5D570 VA: 0x180C5EF70 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F040 Offset: 0xC5D640 VA: 0x180C5F040 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5EFD0 Offset: 0xC5D5D0 VA: 0x180C5EFD0
	private static void .cctor() { }

}

public class TipInstrumentNumlock : InstrumentTip // TypeDefIndex: 11611
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11368

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F0E0 Offset: 0xC5D6E0 VA: 0x180C5F0E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F1B0 Offset: 0xC5D7B0 VA: 0x180C5F1B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5F140 Offset: 0xC5D740 VA: 0x180C5F140
	private static void .cctor() { }

}

public class TipInstrumentPlay : InstrumentTip // TypeDefIndex: 11612
{	// Fields
	public static Translate.Phrase Phrase; // 0x20230

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F230 Offset: 0xC5D830 VA: 0x180C5F230 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F300 Offset: 0xC5D900 VA: 0x180C5F300 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5F290 Offset: 0xC5D890 VA: 0x180C5F290
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

	// RVA: 0xC5C500 Offset: 0xC5AB00 VA: 0x180C5C500 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5C380 Offset: 0xC5A980 VA: 0x180C5C380
	public static bool AimingInNoBuild() { }

	// RVA: 0xC5C5D0 Offset: 0xC5ABD0 VA: 0x180C5C5D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5C560 Offset: 0xC5AB60 VA: 0x180C5C560
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

	// RVA: 0xC5C890 Offset: 0xC5AE90 VA: 0x180C5C890 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5C8F0 Offset: 0xC5AEF0 VA: 0x180C5C8F0
	public static void HitNonEntity() { }

	// RVA: 0xC5CCD0 Offset: 0xC5B2D0 VA: 0x180C5CCD0
	public float get_TimeSinceHitNonEntity() { }

	// RVA: 0xC5C9F0 Offset: 0xC5AFF0 VA: 0x180C5C9F0
	public static bool get_HasToolItemEquipped() { }

	// RVA: 0xC5CBF0 Offset: 0xC5B1F0 VA: 0x180C5CBF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5C970 Offset: 0xC5AF70 VA: 0x180C5C970
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

	// RVA: 0xC5CD40 Offset: 0xC5B340 VA: 0x180C5CD40 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5CE10 Offset: 0xC5B410 VA: 0x180C5CE10
	public float get_ConsumedFood() { }

	// RVA: 0xC5BBE0 Offset: 0xC5A1E0 VA: 0x180C5BBE0
	public float get_ConsumedWater() { }

	// RVA: 0xC5CE60 Offset: 0xC5B460 VA: 0x180C5CE60
	public int get_PickedUpFood() { }

	// RVA: 0xC5CE20 Offset: 0xC5B420 VA: 0x180C5CE20
	public bool get_HasConsumedEnough() { }

	// RVA: 0xC5CF50 Offset: 0xC5B550 VA: 0x180C5CF50
	public bool get_RecentlyPickedUpFood() { }

	// RVA: 0xC5D090 Offset: 0xC5B690 VA: 0x180C5D090 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5CDA0 Offset: 0xC5B3A0 VA: 0x180C5CDA0
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

	// RVA: 0xC5D200 Offset: 0xC5B800 VA: 0x180C5D200 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5D2D0 Offset: 0xC5B8D0 VA: 0x180C5D2D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5D260 Offset: 0xC5B860 VA: 0x180C5D260
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

	// RVA: 0xC5D490 Offset: 0xC5BA90 VA: 0x180C5D490 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5D560 Offset: 0xC5BB60 VA: 0x180C5D560 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5D4F0 Offset: 0xC5BAF0 VA: 0x180C5D4F0
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

	// RVA: 0xC5D700 Offset: 0xC5BD00 VA: 0x180C5D700 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5DA90 Offset: 0xC5C090 VA: 0x180C5DA90
	public static bool get_IsDark() { }

	// RVA: 0x760E20 Offset: 0x75F420 VA: 0x180760E20
	public static float get_TimeComfortableTotal() { }

	// RVA: 0xC5D760 Offset: 0xC5BD60 VA: 0x180C5D760
	public static void TorchLit() { }

	// RVA: 0xC5D850 Offset: 0xC5BE50 VA: 0x180C5D850
	public static bool get_HasTorchThatNeedsLighting() { }

	// RVA: 0xC5DB50 Offset: 0xC5C150 VA: 0x180C5DB50 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5D7E0 Offset: 0xC5BDE0 VA: 0x180C5D7E0
	private static void .cctor() { }

}

public class TipFillToolCupboard : BaseTip // TypeDefIndex: 11620
{	// Fields
	public static Translate.Phrase Phrase; // 0x20287

	// Properties
	public int CupboardOpenedTimes { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5DCD0 Offset: 0xC5C2D0 VA: 0x180C5DCD0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5DDA0 Offset: 0xC5C3A0 VA: 0x180C5DDA0
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC5DDB0 Offset: 0xC5C3B0 VA: 0x180C5DDB0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5DD30 Offset: 0xC5C330 VA: 0x180C5DD30
	private static void .cctor() { }

}

public class TipFishingControls : BaseTip // TypeDefIndex: 11621
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11160

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5DF80 Offset: 0xC5C580 VA: 0x180C5DF80 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E050 Offset: 0xC5C650 VA: 0x180C5E050 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5DFE0 Offset: 0xC5C5E0 VA: 0x180C5DFE0
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

	// RVA: 0xC5E1E0 Offset: 0xC5C7E0 VA: 0x180C5E1E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E3F0 Offset: 0xC5C9F0 VA: 0x180C5E3F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5E2F0 Offset: 0xC5C8F0 VA: 0x180C5E2F0
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

	// RVA: 0xC5E600 Offset: 0xC5CC00 VA: 0x180C5E600 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E8A0 Offset: 0xC5CEA0 VA: 0x180C5E8A0
	public bool get_IsHurt() { }

	// RVA: 0x760E20 Offset: 0x75F420 VA: 0x180760E20
	public float get_TimeComfortableTotal() { }

	// RVA: 0xC5E6E0 Offset: 0xC5CCE0 VA: 0x180C5E6E0
	public bool get_HealEligable() { }

	// RVA: 0xC5EA10 Offset: 0xC5D010 VA: 0x180C5EA10
	public bool get_RecentlyHurt() { }

	// RVA: 0xC5EC20 Offset: 0xC5D220 VA: 0x180C5EC20 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0xC5E6D0 Offset: 0xC5CCD0 VA: 0x180C5E6D0
	public void .ctor() { }

	// RVA: 0xC5E660 Offset: 0xC5CC60 VA: 0x180C5E660
	private static void .cctor() { }

}

public class TipKayakPaddle : BaseTip // TypeDefIndex: 11624
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static bool <hasPaddledWithoutOar>k__BackingField; // 0x8

	// Properties
	public override bool ShouldShow { get; }
	public static bool hasPaddledWithoutOar { get; set; }

	// Methods

	// RVA: 0xC5F3A0 Offset: 0xC5D9A0 VA: 0x180C5F3A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F480 Offset: 0xC5DA80 VA: 0x180C5F480 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC5F7A0 Offset: 0xC5DDA0 VA: 0x180C5F7A0
	public static bool get_hasPaddledWithoutOar() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC5F800 Offset: 0xC5DE00 VA: 0x180C5F800
	public static void set_hasPaddledWithoutOar(bool value) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5F400 Offset: 0xC5DA00 VA: 0x180C5F400
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

	// RVA: 0xC5F860 Offset: 0xC5DE60 VA: 0x180C5F860 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F930 Offset: 0xC5DF30 VA: 0x180C5F930 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5F8C0 Offset: 0xC5DEC0 VA: 0x180C5F8C0
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

	// RVA: 0xC5FB50 Offset: 0xC5E150 VA: 0x180C5FB50 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5FC20 Offset: 0xC5E220 VA: 0x180C5FC20 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5FBB0 Offset: 0xC5E1B0 VA: 0x180C5FBB0
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

	// RVA: 0xC5FE20 Offset: 0xC5E420 VA: 0x180C5FE20 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5FEF0 Offset: 0xC5E4F0 VA: 0x180C5FEF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC5FE80 Offset: 0xC5E480 VA: 0x180C5FE80
	private static void .cctor() { }

}

public class TipMissingLure : BaseTip // TypeDefIndex: 11628
{	// Fields
	public static Translate.Phrase Phrase; // 0x20290

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60120 Offset: 0xC5E720 VA: 0x180C60120 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC601F0 Offset: 0xC5E7F0 VA: 0x180C601F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC60180 Offset: 0xC5E780 VA: 0x180C60180
	private static void .cctor() { }

}

public class TipNoBuild : BaseTip // TypeDefIndex: 11629
{	// Fields
	public static Translate.Phrase Phrase; // 0x202CF

	// Properties
	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60520 Offset: 0xC5EB20 VA: 0x180C60520 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC605F0 Offset: 0xC5EBF0 VA: 0x180C605F0
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0xC603A0 Offset: 0xC5E9A0 VA: 0x180C603A0
	public static bool AimingInNoBuild() { }

	// RVA: 0xC607D0 Offset: 0xC5EDD0 VA: 0x180C607D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC60580 Offset: 0xC5EB80 VA: 0x180C60580
	private static void .cctor() { }

}

public class TipPetControlWheel : BaseTip // TypeDefIndex: 11630
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool haveShown; // 0x8

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60910 Offset: 0xC5EF10 VA: 0x180C60910 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC609E0 Offset: 0xC5EFE0 VA: 0x180C609E0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC60970 Offset: 0xC5EF70 VA: 0x180C60970
	private static void .cctor() { }

}

public class TipPlaceSleepingBag : BaseTip // TypeDefIndex: 11631
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B1119C

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60B40 Offset: 0xC5F140 VA: 0x180C60B40 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC60C10 Offset: 0xC5F210 VA: 0x180C60C10 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC60BA0 Offset: 0xC5F1A0 VA: 0x180C60BA0
	private static void .cctor() { }

}

public class TipPlaceToolCupboard : BaseTip // TypeDefIndex: 11632
{	// Fields
	public static Translate.Phrase Phrase; // 0x202D0

	// Properties
	public int CupboardOpenedTimes { get; }
	public int NumBlocksPlaced { get; }
	public int NumBlocksUpgraded { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60F10 Offset: 0xC5F510 VA: 0x180C60F10 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5DDA0 Offset: 0xC5C3A0 VA: 0x180C5DDA0
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC60FE0 Offset: 0xC5F5E0 VA: 0x180C60FE0
	public int get_NumBlocksPlaced() { }

	// RVA: 0xC60FF0 Offset: 0xC5F5F0 VA: 0x180C60FF0
	public int get_NumBlocksUpgraded() { }

	// RVA: 0xC61000 Offset: 0xC5F600 VA: 0x180C61000 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC60F70 Offset: 0xC5F570 VA: 0x180C60F70
	private static void .cctor() { }

}

public class TipPokerWinnings : BaseTip // TypeDefIndex: 11633
{	// Fields
	public static Translate.Phrase Phrase; // 0x20322

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC61280 Offset: 0xC5F880 VA: 0x180C61280 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61350 Offset: 0xC5F950 VA: 0x180C61350 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC612E0 Offset: 0xC5F8E0 VA: 0x180C612E0
	private static void .cctor() { }

}

public class TipRads : BaseTip // TypeDefIndex: 11634
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11160

	// Properties
	public float RadDuration { get; }
	public bool HasRads { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC61530 Offset: 0xC5FB30 VA: 0x180C61530 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61780 Offset: 0xC5FD80 VA: 0x180C61780
	public float get_RadDuration() { }

	// RVA: 0xC61600 Offset: 0xC5FC00 VA: 0x180C61600
	public bool get_HasRads() { }

	// RVA: 0xC61790 Offset: 0xC5FD90 VA: 0x180C61790 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC61590 Offset: 0xC5FB90 VA: 0x180C61590
	private static void .cctor() { }

}

public class TipRemoveRads : BaseTip // TypeDefIndex: 11635
{	// Fields
	public static Translate.Phrase Phrase; // 0x20330

	// Properties
	public float RadDuration { get; }
	public bool HasRads { get; }
	public bool HasRadExposure { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC61920 Offset: 0xC5FF20 VA: 0x180C61920 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61780 Offset: 0xC5FD80 VA: 0x180C61780
	public float get_RadDuration() { }

	// RVA: 0xC61B70 Offset: 0xC60170 VA: 0x180C61B70
	public bool get_HasRads() { }

	// RVA: 0xC619F0 Offset: 0xC5FFF0 VA: 0x180C619F0
	public bool get_HasRadExposure() { }

	// RVA: 0xC61CF0 Offset: 0xC602F0 VA: 0x180C61CF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC61980 Offset: 0xC5FF80 VA: 0x180C61980
	private static void .cctor() { }

}

public class TipReskinObject : BaseTip // TypeDefIndex: 11636
{	// Fields
	public static Translate.Phrase Phrase; // 0x20382

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC62000 Offset: 0xC60600 VA: 0x180C62000 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC620D0 Offset: 0xC606D0 VA: 0x180C620D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC62060 Offset: 0xC60660 VA: 0x180C62060
	private static void .cctor() { }

}

public class TipSledPlacement : BaseTip // TypeDefIndex: 11637
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11160

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC62260 Offset: 0xC60860 VA: 0x180C62260 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62330 Offset: 0xC60930 VA: 0x180C62330 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC622C0 Offset: 0xC608C0 VA: 0x180C622C0
	private static void .cctor() { }

}

public class TipSleepingBagPlacement : BaseTip // TypeDefIndex: 11638
{	// Fields
	public static Translate.Phrase Phrase; // 0x20390

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC624D0 Offset: 0xC60AD0 VA: 0x180C624D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC625A0 Offset: 0xC60BA0 VA: 0x180C625A0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC62530 Offset: 0xC60B30 VA: 0x180C62530
	private static void .cctor() { }

}

public class TipSnapAttractionPoint : BaseTip // TypeDefIndex: 11639
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static bool <HasDismissedSnap>k__BackingField; // 0x8

	// Properties
	public override bool ShouldShow { get; }
	public static bool HasDismissedSnap { get; set; }

	// Methods

	// RVA: 0xC627B0 Offset: 0xC60DB0 VA: 0x180C627B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC628F0 Offset: 0xC60EF0 VA: 0x180C628F0 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC62890 Offset: 0xC60E90 VA: 0x180C62890
	public static bool get_HasDismissedSnap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xC62B20 Offset: 0xC61120 VA: 0x180C62B20
	public static void set_HasDismissedSnap(bool value) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC62810 Offset: 0xC60E10 VA: 0x180C62810
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

	// RVA: 0xC62B80 Offset: 0xC61180 VA: 0x180C62B80 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62C50 Offset: 0xC61250 VA: 0x180C62C50 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC62BE0 Offset: 0xC611E0 VA: 0x180C62BE0
	private static void .cctor() { }

}

public class TipSprayControls : BaseTip // TypeDefIndex: 11641
{	// Fields
	public static Translate.Phrase Phrase; // 0x203BC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC62E60 Offset: 0xC61460 VA: 0x180C62E60 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62F30 Offset: 0xC61530 VA: 0x180C62F30 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC62EC0 Offset: 0xC614C0 VA: 0x180C62EC0
	private static void .cctor() { }

}

public class TipTooCold : BaseTip // TypeDefIndex: 11642
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11194

	// Properties
	public float ColdDuration { get; }
	public bool IsCold { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC63110 Offset: 0xC61710 VA: 0x180C63110 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61780 Offset: 0xC5FD80 VA: 0x180C61780
	public float get_ColdDuration() { }

	// RVA: 0xC631E0 Offset: 0xC617E0 VA: 0x180C631E0
	public bool get_IsCold() { }

	// RVA: 0xC63360 Offset: 0xC61960 VA: 0x180C63360 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC63170 Offset: 0xC61770 VA: 0x180C63170
	private static void .cctor() { }

}

public class TipTooHot : BaseTip // TypeDefIndex: 11643
{	// Fields
	public static Translate.Phrase Phrase; // 0x203C0

	// Properties
	public float HotDuration { get; }
	public bool IsHot { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC63500 Offset: 0xC61B00 VA: 0x180C63500 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC635D0 Offset: 0xC61BD0 VA: 0x180C635D0
	public float get_HotDuration() { }

	// RVA: 0xC635E0 Offset: 0xC61BE0 VA: 0x180C635E0
	public bool get_IsHot() { }

	// RVA: 0xC63760 Offset: 0xC61D60 VA: 0x180C63760 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC63560 Offset: 0xC61B60 VA: 0x180C63560
	private static void .cctor() { }

}

public class TipZipline : BaseTip // TypeDefIndex: 11644
{	// Fields
	public static Translate.Phrase Phrase; // 0x20416

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC63900 Offset: 0xC61F00 VA: 0x180C63900 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC639D0 Offset: 0xC61FD0 VA: 0x180C639D0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0xC63960 Offset: 0xC61F60 VA: 0x180C63960
	private static void .cctor() { }

}

