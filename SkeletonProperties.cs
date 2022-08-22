public class SkeletonProperties : ScriptableObject // TypeDefIndex: 9982
{	// Fields
	public GameObject boneReference; // 0x18
	[BonePropertyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public SkeletonProperties.BoneProperty[] bones; // 0x20
	private Dictionary<uint, SkeletonProperties.BoneProperty> quickLookup; // 0x28

	// Methods

	// RVA: 0x59E1D0 Offset: 0x59C7D0 VA: 0x18059E1D0
	public void OnValidate() { }

	// RVA: 0x59DC30 Offset: 0x59C230 VA: 0x18059DC30
	private void BuildDictionary() { }

	// RVA: 0x59E150 Offset: 0x59C750 VA: 0x18059E150
	public SkeletonProperties.BoneProperty FindBone(uint id) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class SkeletonProperties.BoneProperty // TypeDefIndex: 9983
{	// Fields
	public GameObject bone; // 0x10
	public Translate.Phrase name; // 0x18
	public HitArea area; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class SkeletonProperties.<>c__DisplayClass3_0 // TypeDefIndex: 9984
{	// Fields
	public Transform child; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4930 Offset: 0x5A2F30 VA: 0x1805A4930
	internal bool <OnValidate>b__0(SkeletonProperties.BoneProperty x) { }

}

