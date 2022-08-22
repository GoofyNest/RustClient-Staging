public class HowToExamineHeld : BaseTip // TypeDefIndex: 11593
{	// Fields
	public static Translate.Phrase Phrase; // 0x20090

	// Properties
	public int ExaminedTimes { get; }
	public float SecondsLastExamined { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x75F710 Offset: 0x75DD10 VA: 0x18075F710 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75F7E0 Offset: 0x75DDE0 VA: 0x18075F7E0
	public int get_ExaminedTimes() { }

	// RVA: 0x75F7F0 Offset: 0x75DDF0 VA: 0x18075F7F0
	public float get_SecondsLastExamined() { }

	// RVA: 0x75F860 Offset: 0x75DE60 VA: 0x18075F860 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75F770 Offset: 0x75DD70 VA: 0x18075F770
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

	// RVA: 0x75FA00 Offset: 0x75E000 VA: 0x18075FA00 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75FA60 Offset: 0x75E060 VA: 0x18075FA60
	public static void UpgradeHappened() { }

	// RVA: 0x75FE30 Offset: 0x75E430 VA: 0x18075FE30
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x75FB70 Offset: 0x75E170 VA: 0x18075FB70
	public static bool get_HasHammerEquipped() { }

	// RVA: 0x75FD50 Offset: 0x75E350 VA: 0x18075FD50 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75FAF0 Offset: 0x75E0F0 VA: 0x18075FAF0
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

	// RVA: 0x75FF20 Offset: 0x75E520 VA: 0x18075FF20 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x75FEA0 Offset: 0x75E4A0 VA: 0x18075FEA0
	public static void BuildOptionChanged() { }

	// RVA: 0x7602E0 Offset: 0x75E8E0 VA: 0x1807602E0
	public float get_TimeSinceBuildChanged() { }

	// RVA: 0x760000 Offset: 0x75E600 VA: 0x180760000
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0x7601F0 Offset: 0x75E7F0 VA: 0x1807601F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x75FF80 Offset: 0x75E580 VA: 0x18075FF80
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

	// RVA: 0x760350 Offset: 0x75E950 VA: 0x180760350 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760460 Offset: 0x75EA60 VA: 0x180760460
	public int get_CraftingOpenedTimes() { }

	// RVA: 0x760420 Offset: 0x75EA20 VA: 0x180760420
	public float get_CraftingOpenedSecondsAgo() { }

	// RVA: 0x760470 Offset: 0x75EA70 VA: 0x180760470 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7603B0 Offset: 0x75E9B0 VA: 0x1807603B0
	private static void .cctor() { }

}

public class HowToOpenInventory : BaseTip // TypeDefIndex: 11597
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B111C8

	// Properties
	public int InventoryOpenedTimes { get; }
	public float IntentoryOpenedSecondsAgo { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x7604D0 Offset: 0x75EAD0 VA: 0x1807604D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760610 Offset: 0x75EC10 VA: 0x180760610
	public int get_InventoryOpenedTimes() { }

	// RVA: 0x7605A0 Offset: 0x75EBA0 VA: 0x1807605A0
	public float get_IntentoryOpenedSecondsAgo() { }

	// RVA: 0x760620 Offset: 0x75EC20 VA: 0x180760620 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760530 Offset: 0x75EB30 VA: 0x180760530
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

	// RVA: 0x7606B0 Offset: 0x75ECB0 VA: 0x1807606B0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x7607F0 Offset: 0x75EDF0 VA: 0x1807607F0
	public int get_MapOpenedTimes() { }

	// RVA: 0x760780 Offset: 0x75ED80 VA: 0x180760780
	public float get_MapOpenedSecondsAgo() { }

	// RVA: 0x760800 Offset: 0x75EE00 VA: 0x180760800 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760710 Offset: 0x75ED10 VA: 0x180760710
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

	// RVA: 0x760890 Offset: 0x75EE90 VA: 0x180760890 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760A50 Offset: 0x75F050 VA: 0x180760A50
	public int get_OreSpotsHit() { }

	// RVA: 0x7609E0 Offset: 0x75EFE0 VA: 0x1807609E0
	public float get_OreHitSecondsAgo() { }

	// RVA: 0x7608F0 Offset: 0x75EEF0 VA: 0x1807608F0
	public static void OreHit() { }

	// RVA: 0x760A60 Offset: 0x75F060 VA: 0x180760A60 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760970 Offset: 0x75EF70 VA: 0x180760970
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

	// RVA: 0x760AF0 Offset: 0x75F0F0 VA: 0x180760AF0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x760BC0 Offset: 0x75F1C0 VA: 0x180760BC0
	public static bool get_IsComfortable() { }

	// RVA: 0x760F30 Offset: 0x75F530 VA: 0x180760F30
	public static float get_TimeComfortableTotal() { }

	// RVA: 0x760D40 Offset: 0x75F340 VA: 0x180760D40 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760B50 Offset: 0x75F150 VA: 0x180760B50
	private static void .cctor() { }

}

public class HowToRetrieveThrown : BaseTip // TypeDefIndex: 11601
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B11334

	// Properties
	public static bool HasThrowableItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x760F40 Offset: 0x75F540 VA: 0x180760F40 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761010 Offset: 0x75F610 VA: 0x180761010
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x761200 Offset: 0x75F800 VA: 0x180761200 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x760FA0 Offset: 0x75F5A0 VA: 0x180760FA0
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

	// RVA: 0x761360 Offset: 0x75F960 VA: 0x180761360 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x7613C0 Offset: 0x75F9C0 VA: 0x1807613C0
	public static void ItemThrown() { }

	// RVA: 0x761450 Offset: 0x75FA50 VA: 0x180761450
	public static bool RecentlyThrown() { }

	// RVA: 0x7615A0 Offset: 0x75FBA0 VA: 0x1807615A0
	public static bool get_HasThrowableItemEquipped() { }

	// RVA: 0x761790 Offset: 0x75FD90 VA: 0x180761790 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761510 Offset: 0x75FB10 VA: 0x180761510
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

	// RVA: 0x761840 Offset: 0x75FE40 VA: 0x180761840 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761A90 Offset: 0x760090 VA: 0x180761A90
	public int get_TreeSpotsHit() { }

	// RVA: 0x761A20 Offset: 0x760020 VA: 0x180761A20
	public float get_TreeHitSecondsAgo() { }

	// RVA: 0x7618A0 Offset: 0x75FEA0 VA: 0x1807618A0
	public static void TreeHit() { }

	// RVA: 0x761990 Offset: 0x75FF90 VA: 0x180761990 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761920 Offset: 0x75FF20 VA: 0x180761920
	private static void .cctor() { }

}

public class HowToUseBow : BaseTip // TypeDefIndex: 11604
{	// Fields
	public static Translate.Phrase Phrase; // 0x20130

	// Properties
	public static bool HasBowItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x761AA0 Offset: 0x7600A0 VA: 0x180761AA0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761B70 Offset: 0x760170 VA: 0x180761B70
	public static bool get_HasBowItemEquipped() { }

	// RVA: 0x761D50 Offset: 0x760350 VA: 0x180761D50 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761B00 Offset: 0x760100 VA: 0x180761B00
	private static void .cctor() { }

}

public class HowToUseGrenade : BaseTip // TypeDefIndex: 11605
{	// Fields
	public static Translate.Phrase Phrase; // 0x20189

	// Properties
	private static bool HasGrenadeItemEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0x761DC0 Offset: 0x7603C0 VA: 0x180761DC0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x761E90 Offset: 0x760490 VA: 0x180761E90
	private static bool get_HasGrenadeItemEquipped() { }

	// RVA: 0x762070 Offset: 0x760670 VA: 0x180762070 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x761E20 Offset: 0x760420 VA: 0x180761E20
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

	// RVA: 0x762160 Offset: 0x760760 VA: 0x180762160 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0x762240 Offset: 0x760840 VA: 0x180762240
	public static void MarkWavedAt(BasePlayer Entity) { }

	// RVA: 0x7621C0 Offset: 0x7607C0 VA: 0x1807621C0
	public static void MarkLocalWave() { }

	// RVA: 0x7620E0 Offset: 0x7606E0 VA: 0x1807620E0
	public bool DidRecentlyWaveLocally() { }

	// RVA: 0x762580 Offset: 0x760B80 VA: 0x180762580
	public bool WasRecentlyWavedAt() { }

	// RVA: 0x762690 Offset: 0x760C90 VA: 0x180762690 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x762600 Offset: 0x760C00 VA: 0x180762600
	private static void .cctor() { }

}

public class HowToVoiceChat : BaseTip // TypeDefIndex: 11607
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B111E0

	// Properties
	public float SecondsSpeaking { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5B6E0 Offset: 0xC59CE0 VA: 0x180C5B6E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5B7B0 Offset: 0xC59DB0 VA: 0x180C5B7B0
	public float get_SecondsSpeaking() { }

	// RVA: 0xC5B7C0 Offset: 0xC59DC0 VA: 0x180C5B7C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5B740 Offset: 0xC59D40 VA: 0x180C5B740
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

	// RVA: 0xC5BDD0 Offset: 0xC5A3D0 VA: 0x180C5BDD0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5BEB0 Offset: 0xC5A4B0 VA: 0x180C5BEB0
	public bool get_NearFreshWater() { }

	// RVA: 0xC5BEA0 Offset: 0xC5A4A0 VA: 0x180C5BEA0
	public float get_ConsumedWater() { }

	// RVA: 0xC5C040 Offset: 0xC5A640 VA: 0x180C5C040 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5BE30 Offset: 0xC5A430 VA: 0x180C5BE30
	private static void .cctor() { }

}

public class TipInstrumentFullKeyboard : InstrumentTip // TypeDefIndex: 11610
{	// Fields
	public static Translate.Phrase Phrase; // 0x2022D

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F230 Offset: 0xC5D830 VA: 0x180C5F230 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F300 Offset: 0xC5D900 VA: 0x180C5F300 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5F290 Offset: 0xC5D890 VA: 0x180C5F290
	private static void .cctor() { }

}

public class TipInstrumentNumlock : InstrumentTip // TypeDefIndex: 11611
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B113C8

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F3A0 Offset: 0xC5D9A0 VA: 0x180C5F3A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F470 Offset: 0xC5DA70 VA: 0x180C5F470 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5F400 Offset: 0xC5DA00 VA: 0x180C5F400
	private static void .cctor() { }

}

public class TipInstrumentPlay : InstrumentTip // TypeDefIndex: 11612
{	// Fields
	public static Translate.Phrase Phrase; // 0x20230

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5F4F0 Offset: 0xC5DAF0 VA: 0x180C5F4F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F5C0 Offset: 0xC5DBC0 VA: 0x180C5F5C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5F550 Offset: 0xC5DB50 VA: 0x180C5F550
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

	// RVA: 0xC5C7C0 Offset: 0xC5ADC0 VA: 0x180C5C7C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5C640 Offset: 0xC5AC40 VA: 0x180C5C640
	public static bool AimingInNoBuild() { }

	// RVA: 0xC5C890 Offset: 0xC5AE90 VA: 0x180C5C890 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5C820 Offset: 0xC5AE20 VA: 0x180C5C820
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

	// RVA: 0xC5CB50 Offset: 0xC5B150 VA: 0x180C5CB50 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5CBB0 Offset: 0xC5B1B0 VA: 0x180C5CBB0
	public static void HitNonEntity() { }

	// RVA: 0xC5CF90 Offset: 0xC5B590 VA: 0x180C5CF90
	public float get_TimeSinceHitNonEntity() { }

	// RVA: 0xC5CCB0 Offset: 0xC5B2B0 VA: 0x180C5CCB0
	public static bool get_HasToolItemEquipped() { }

	// RVA: 0xC5CEB0 Offset: 0xC5B4B0 VA: 0x180C5CEB0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5CC30 Offset: 0xC5B230 VA: 0x180C5CC30
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

	// RVA: 0xC5D000 Offset: 0xC5B600 VA: 0x180C5D000 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5D0D0 Offset: 0xC5B6D0 VA: 0x180C5D0D0
	public float get_ConsumedFood() { }

	// RVA: 0xC5BEA0 Offset: 0xC5A4A0 VA: 0x180C5BEA0
	public float get_ConsumedWater() { }

	// RVA: 0xC5D120 Offset: 0xC5B720 VA: 0x180C5D120
	public int get_PickedUpFood() { }

	// RVA: 0xC5D0E0 Offset: 0xC5B6E0 VA: 0x180C5D0E0
	public bool get_HasConsumedEnough() { }

	// RVA: 0xC5D210 Offset: 0xC5B810 VA: 0x180C5D210
	public bool get_RecentlyPickedUpFood() { }

	// RVA: 0xC5D350 Offset: 0xC5B950 VA: 0x180C5D350 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5D060 Offset: 0xC5B660 VA: 0x180C5D060
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

	// RVA: 0xC5D4C0 Offset: 0xC5BAC0 VA: 0x180C5D4C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5D590 Offset: 0xC5BB90 VA: 0x180C5D590 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5D520 Offset: 0xC5BB20 VA: 0x180C5D520
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

	// RVA: 0xC5D750 Offset: 0xC5BD50 VA: 0x180C5D750 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5D820 Offset: 0xC5BE20 VA: 0x180C5D820 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5D7B0 Offset: 0xC5BDB0 VA: 0x180C5D7B0
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

	// RVA: 0xC5D9C0 Offset: 0xC5BFC0 VA: 0x180C5D9C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5DD50 Offset: 0xC5C350 VA: 0x180C5DD50
	public static bool get_IsDark() { }

	// RVA: 0x760F30 Offset: 0x75F530 VA: 0x180760F30
	public static float get_TimeComfortableTotal() { }

	// RVA: 0xC5DA20 Offset: 0xC5C020 VA: 0x180C5DA20
	public static void TorchLit() { }

	// RVA: 0xC5DB10 Offset: 0xC5C110 VA: 0x180C5DB10
	public static bool get_HasTorchThatNeedsLighting() { }

	// RVA: 0xC5DE10 Offset: 0xC5C410 VA: 0x180C5DE10 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5DAA0 Offset: 0xC5C0A0 VA: 0x180C5DAA0
	private static void .cctor() { }

}

public class TipFillToolCupboard : BaseTip // TypeDefIndex: 11620
{	// Fields
	public static Translate.Phrase Phrase; // 0x20287

	// Properties
	public int CupboardOpenedTimes { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5DF90 Offset: 0xC5C590 VA: 0x180C5DF90 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E060 Offset: 0xC5C660 VA: 0x180C5E060
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC5E070 Offset: 0xC5C670 VA: 0x180C5E070 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5DFF0 Offset: 0xC5C5F0 VA: 0x180C5DFF0
	private static void .cctor() { }

}

public class TipFishingControls : BaseTip // TypeDefIndex: 11621
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B111C0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC5E240 Offset: 0xC5C840 VA: 0x180C5E240 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E310 Offset: 0xC5C910 VA: 0x180C5E310 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5E2A0 Offset: 0xC5C8A0 VA: 0x180C5E2A0
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

	// RVA: 0xC5E4A0 Offset: 0xC5CAA0 VA: 0x180C5E4A0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E6B0 Offset: 0xC5CCB0 VA: 0x180C5E6B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5E5B0 Offset: 0xC5CBB0 VA: 0x180C5E5B0
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

	// RVA: 0xC5E8C0 Offset: 0xC5CEC0 VA: 0x180C5E8C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5EB60 Offset: 0xC5D160 VA: 0x180C5EB60
	public bool get_IsHurt() { }

	// RVA: 0x760F30 Offset: 0x75F530 VA: 0x180760F30
	public float get_TimeComfortableTotal() { }

	// RVA: 0xC5E9A0 Offset: 0xC5CFA0 VA: 0x180C5E9A0
	public bool get_HealEligable() { }

	// RVA: 0xC5ECD0 Offset: 0xC5D2D0 VA: 0x180C5ECD0
	public bool get_RecentlyHurt() { }

	// RVA: 0xC5EEE0 Offset: 0xC5D4E0 VA: 0x180C5EEE0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0xC5E990 Offset: 0xC5CF90 VA: 0x180C5E990
	public void .ctor() { }

	// RVA: 0xC5E920 Offset: 0xC5CF20 VA: 0x180C5E920
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

	// RVA: 0xC5F660 Offset: 0xC5DC60 VA: 0x180C5F660 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5F740 Offset: 0xC5DD40 VA: 0x180C5F740 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC5FA60 Offset: 0xC5E060 VA: 0x180C5FA60
	public static bool get_hasPaddledWithoutOar() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC5FAC0 Offset: 0xC5E0C0 VA: 0x180C5FAC0
	public static void set_hasPaddledWithoutOar(bool value) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5F6C0 Offset: 0xC5DCC0 VA: 0x180C5F6C0
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

	// RVA: 0xC5FB20 Offset: 0xC5E120 VA: 0x180C5FB20 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5FBF0 Offset: 0xC5E1F0 VA: 0x180C5FBF0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5FB80 Offset: 0xC5E180 VA: 0x180C5FB80
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

	// RVA: 0xC5FE10 Offset: 0xC5E410 VA: 0x180C5FE10 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5FEE0 Offset: 0xC5E4E0 VA: 0x180C5FEE0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC5FE70 Offset: 0xC5E470 VA: 0x180C5FE70
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

	// RVA: 0xC600E0 Offset: 0xC5E6E0 VA: 0x180C600E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC601B0 Offset: 0xC5E7B0 VA: 0x180C601B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC60140 Offset: 0xC5E740 VA: 0x180C60140
	private static void .cctor() { }

}

public class TipMissingLure : BaseTip // TypeDefIndex: 11628
{	// Fields
	public static Translate.Phrase Phrase; // 0x20290

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC603E0 Offset: 0xC5E9E0 VA: 0x180C603E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC604B0 Offset: 0xC5EAB0 VA: 0x180C604B0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC60440 Offset: 0xC5EA40 VA: 0x180C60440
	private static void .cctor() { }

}

public class TipNoBuild : BaseTip // TypeDefIndex: 11629
{	// Fields
	public static Translate.Phrase Phrase; // 0x202CF

	// Properties
	public static bool HasBuildingPlanEquipped { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC607E0 Offset: 0xC5EDE0 VA: 0x180C607E0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC608B0 Offset: 0xC5EEB0 VA: 0x180C608B0
	public static bool get_HasBuildingPlanEquipped() { }

	// RVA: 0xC60660 Offset: 0xC5EC60 VA: 0x180C60660
	public static bool AimingInNoBuild() { }

	// RVA: 0xC60A90 Offset: 0xC5F090 VA: 0x180C60A90 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC60840 Offset: 0xC5EE40 VA: 0x180C60840
	private static void .cctor() { }

}

public class TipPetControlWheel : BaseTip // TypeDefIndex: 11630
{	// Fields
	public static Translate.Phrase Phrase; // 0x0
	public static bool haveShown; // 0x8

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60BD0 Offset: 0xC5F1D0 VA: 0x180C60BD0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC60CA0 Offset: 0xC5F2A0 VA: 0x180C60CA0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC60C30 Offset: 0xC5F230 VA: 0x180C60C30
	private static void .cctor() { }

}

public class TipPlaceSleepingBag : BaseTip // TypeDefIndex: 11631
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B111FC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC60E00 Offset: 0xC5F400 VA: 0x180C60E00 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC60ED0 Offset: 0xC5F4D0 VA: 0x180C60ED0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC60E60 Offset: 0xC5F460 VA: 0x180C60E60
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

	// RVA: 0xC611D0 Offset: 0xC5F7D0 VA: 0x180C611D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC5E060 Offset: 0xC5C660 VA: 0x180C5E060
	public int get_CupboardOpenedTimes() { }

	// RVA: 0xC612A0 Offset: 0xC5F8A0 VA: 0x180C612A0
	public int get_NumBlocksPlaced() { }

	// RVA: 0xC612B0 Offset: 0xC5F8B0 VA: 0x180C612B0
	public int get_NumBlocksUpgraded() { }

	// RVA: 0xC612C0 Offset: 0xC5F8C0 VA: 0x180C612C0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC61230 Offset: 0xC5F830 VA: 0x180C61230
	private static void .cctor() { }

}

public class TipPokerWinnings : BaseTip // TypeDefIndex: 11633
{	// Fields
	public static Translate.Phrase Phrase; // 0x20322

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC61540 Offset: 0xC5FB40 VA: 0x180C61540 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61610 Offset: 0xC5FC10 VA: 0x180C61610 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC615A0 Offset: 0xC5FBA0 VA: 0x180C615A0
	private static void .cctor() { }

}

public class TipRads : BaseTip // TypeDefIndex: 11634
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B111C0

	// Properties
	public float RadDuration { get; }
	public bool HasRads { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC617F0 Offset: 0xC5FDF0 VA: 0x180C617F0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61A40 Offset: 0xC60040 VA: 0x180C61A40
	public float get_RadDuration() { }

	// RVA: 0xC618C0 Offset: 0xC5FEC0 VA: 0x180C618C0
	public bool get_HasRads() { }

	// RVA: 0xC61A50 Offset: 0xC60050 VA: 0x180C61A50 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC61850 Offset: 0xC5FE50 VA: 0x180C61850
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

	// RVA: 0xC61BE0 Offset: 0xC601E0 VA: 0x180C61BE0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61A40 Offset: 0xC60040 VA: 0x180C61A40
	public float get_RadDuration() { }

	// RVA: 0xC61E30 Offset: 0xC60430 VA: 0x180C61E30
	public bool get_HasRads() { }

	// RVA: 0xC61CB0 Offset: 0xC602B0 VA: 0x180C61CB0
	public bool get_HasRadExposure() { }

	// RVA: 0xC61FB0 Offset: 0xC605B0 VA: 0x180C61FB0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC61C40 Offset: 0xC60240 VA: 0x180C61C40
	private static void .cctor() { }

}

public class TipReskinObject : BaseTip // TypeDefIndex: 11636
{	// Fields
	public static Translate.Phrase Phrase; // 0x20382

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC622C0 Offset: 0xC608C0 VA: 0x180C622C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62390 Offset: 0xC60990 VA: 0x180C62390 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC62320 Offset: 0xC60920 VA: 0x180C62320
	private static void .cctor() { }

}

public class TipSledPlacement : BaseTip // TypeDefIndex: 11637
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B111C0

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC62520 Offset: 0xC60B20 VA: 0x180C62520 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC625F0 Offset: 0xC60BF0 VA: 0x180C625F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC62580 Offset: 0xC60B80 VA: 0x180C62580
	private static void .cctor() { }

}

public class TipSleepingBagPlacement : BaseTip // TypeDefIndex: 11638
{	// Fields
	public static Translate.Phrase Phrase; // 0x20390

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC62790 Offset: 0xC60D90 VA: 0x180C62790 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62860 Offset: 0xC60E60 VA: 0x180C62860 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC627F0 Offset: 0xC60DF0 VA: 0x180C627F0
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

	// RVA: 0xC62A70 Offset: 0xC61070 VA: 0x180C62A70 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62BB0 Offset: 0xC611B0 VA: 0x180C62BB0 Slot: 5
	public override bool get_ShouldShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC62B50 Offset: 0xC61150 VA: 0x180C62B50
	public static bool get_HasDismissedSnap() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC62DE0 Offset: 0xC613E0 VA: 0x180C62DE0
	public static void set_HasDismissedSnap(bool value) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC62AD0 Offset: 0xC610D0 VA: 0x180C62AD0
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

	// RVA: 0xC62E40 Offset: 0xC61440 VA: 0x180C62E40 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC62F10 Offset: 0xC61510 VA: 0x180C62F10 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC62EA0 Offset: 0xC614A0 VA: 0x180C62EA0
	private static void .cctor() { }

}

public class TipSprayControls : BaseTip // TypeDefIndex: 11641
{	// Fields
	public static Translate.Phrase Phrase; // 0x203BC

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC63120 Offset: 0xC61720 VA: 0x180C63120 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC631F0 Offset: 0xC617F0 VA: 0x180C631F0 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC63180 Offset: 0xC61780 VA: 0x180C63180
	private static void .cctor() { }

}

public class TipTooCold : BaseTip // TypeDefIndex: 11642
{	// Fields
	public static Translate.Phrase Phrase; // 0x2B111F4

	// Properties
	public float ColdDuration { get; }
	public bool IsCold { get; }
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC633D0 Offset: 0xC619D0 VA: 0x180C633D0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC61A40 Offset: 0xC60040 VA: 0x180C61A40
	public float get_ColdDuration() { }

	// RVA: 0xC634A0 Offset: 0xC61AA0 VA: 0x180C634A0
	public bool get_IsCold() { }

	// RVA: 0xC63620 Offset: 0xC61C20 VA: 0x180C63620 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC63430 Offset: 0xC61A30 VA: 0x180C63430
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

	// RVA: 0xC637C0 Offset: 0xC61DC0 VA: 0x180C637C0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC63890 Offset: 0xC61E90 VA: 0x180C63890
	public float get_HotDuration() { }

	// RVA: 0xC638A0 Offset: 0xC61EA0 VA: 0x180C638A0
	public bool get_IsHot() { }

	// RVA: 0xC63A20 Offset: 0xC62020 VA: 0x180C63A20 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC63820 Offset: 0xC61E20 VA: 0x180C63820
	private static void .cctor() { }

}

public class TipZipline : BaseTip // TypeDefIndex: 11644
{	// Fields
	public static Translate.Phrase Phrase; // 0x20416

	// Properties
	public override bool ShouldShow { get; }

	// Methods

	// RVA: 0xC63BC0 Offset: 0xC621C0 VA: 0x180C63BC0 Slot: 4
	public override Translate.Phrase GetPhrase() { }

	// RVA: 0xC63C90 Offset: 0xC62290 VA: 0x180C63C90 Slot: 5
	public override bool get_ShouldShow() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0xC63C20 Offset: 0xC62220 VA: 0x180C63C20
	private static void .cctor() { }

}

