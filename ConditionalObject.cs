public class ConditionalObject // TypeDefIndex: 12096
{	// Fields
	public GameObject gameObject; // 0x10
	public GameObject ownerGameObject; // 0x18
	public ConditionalSocketSettings[] socketSettings; // 0x20
	public bool restrictOnHealth; // 0x28
	public float healthRestrictionMin; // 0x2C
	public float healthRestrictionMax; // 0x30
	public bool restrictOnAdjacent; // 0x34
	public ConditionalObject.AdjacentCondition adjacentRestriction; // 0x38
	public ConditionalObject.AdjacentMatchType adjacentMatch; // 0x3C
	public bool restrictOnLockable; // 0x40
	public bool lockableRestriction; // 0x41
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Nullable<bool> <IsActive>k__BackingField; // 0x42

	// Properties
	public Nullable<bool> IsActive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BB480 Offset: 0x4B9A80 VA: 0x1804BB480
	public Nullable<bool> get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BB490 Offset: 0x4B9A90 VA: 0x1804BB490
	private void set_IsActive(Nullable<bool> value) { }

	// RVA: 0x4BB3E0 Offset: 0x4B99E0 VA: 0x1804BB3E0
	public void .ctor(GameObject conditionalGO, GameObject ownerGO, int socketsTaken) { }

	// RVA: 0x4BB340 Offset: 0x4B9940 VA: 0x1804BB340
	public void SetActive(bool active) { }

	// RVA: 0x4BB2D0 Offset: 0x4B98D0 VA: 0x1804BB2D0
	public void RefreshActive() { }

}

public enum ConditionalObject.AdjacentCondition // TypeDefIndex: 12097
{	// Fields
	public int value__; // 0x0
	public const ConditionalObject.AdjacentCondition SameInFront = 0;
	public const ConditionalObject.AdjacentCondition SameBehind = 1;
	public const ConditionalObject.AdjacentCondition DifferentInFront = 2;
	public const ConditionalObject.AdjacentCondition DifferentBehind = 3;
	public const ConditionalObject.AdjacentCondition BothDifferent = 4;
	public const ConditionalObject.AdjacentCondition BothSame = 5;

}

public enum ConditionalObject.AdjacentMatchType // TypeDefIndex: 12098
{	// Fields
	public int value__; // 0x0
	public const ConditionalObject.AdjacentMatchType GroupOrExact = 0;
	public const ConditionalObject.AdjacentMatchType ExactOnly = 1;
	public const ConditionalObject.AdjacentMatchType GroupNotExact = 2;

}

