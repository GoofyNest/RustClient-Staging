public class LifeInfographic : MonoBehaviour // TypeDefIndex: 11070
{	// Fields
	public PlayerLifeStory life; // 0x18
	public GameObject container; // 0x20
	public RawImage AttackerAvatarImage; // 0x28
	public Image DamageSourceImage; // 0x30
	public LifeInfographicStat[] Stats; // 0x38
	public Animator[] AllAnimators; // 0x40
	public GameObject WeaponRoot; // 0x48
	public GameObject DistanceRoot; // 0x50
	public GameObject DistanceDivider; // 0x58
	public Image WeaponImage; // 0x60
	public LifeInfographic.DamageSetting[] DamageDisplays; // 0x68
	public bool ShowDebugData; // 0x70
	private int triggerParam; // 0x74
	private int closeState; // 0x78

	// Methods

	// RVA: 0x68D070 Offset: 0x68B670 VA: 0x18068D070
	private void OnEnable() { }

	// RVA: 0x68D1F0 Offset: 0x68B7F0 VA: 0x18068D1F0
	public void Refresh() { }

	// RVA: 0x68D0E0 Offset: 0x68B6E0 VA: 0x18068D0E0
	private void Refresh_Age() { }

	// RVA: 0x68D150 Offset: 0x68B750 VA: 0x18068D150
	private void Refresh_Death() { }

	// RVA: 0x68D9C0 Offset: 0x68BFC0 VA: 0x18068D9C0
	private void Show(string name) { }

	// RVA: 0x68E240 Offset: 0x68C840 VA: 0x18068E240
	private void UpdateKilledByAvatar(ulong id) { }

	// RVA: 0x68DA80 Offset: 0x68C080 VA: 0x18068DA80
	public static bool TryGetDefinitionFromEntityName(string entityName, out ItemDefinition def) { }

	// RVA: 0x68E330 Offset: 0x68C930 VA: 0x18068E330
	private void UpdateKilledByWeaponImage(string weaponName) { }

	// RVA: 0x68CFE0 Offset: 0x68B5E0 VA: 0x18068CFE0
	public bool GetDamageDisplay(DamageType forType, out LifeInfographic.DamageSetting setting) { }

	// RVA: 0x68CF00 Offset: 0x68B500 VA: 0x18068CF00
	public void AnimateIn() { }

	[IteratorStateMachineAttribute] // RVA: 0x94870 Offset: 0x93C70 VA: 0x180094870
	// RVA: 0x68CF70 Offset: 0x68B570 VA: 0x18068CF70
	private IEnumerator Animate() { }

	// RVA: 0x68D070 Offset: 0x68B670 VA: 0x18068D070
	public void ResetAnimators() { }

	// RVA: 0x68DFB0 Offset: 0x68C5B0 VA: 0x18068DFB0
	public bool TryGetPrefabInformationForAttacker(string attackerName, out PrefabInformation info) { }

	// RVA: 0x68E470 Offset: 0x68CA70 VA: 0x18068E470
	public void .ctor() { }

}

public struct LifeInfographic.DamageSetting // TypeDefIndex: 11071
{	// Fields
	public DamageType ForType; // 0x0
	public string Display; // 0x8
	public Sprite DamageSprite; // 0x10

}

private sealed class LifeInfographic.<Animate>d__25 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11072
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public LifeInfographic <>4__this; // 0x20
	private Animator[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x68FE90 Offset: 0x68E490 VA: 0x18068FE90 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x68FFF0 Offset: 0x68E5F0 VA: 0x18068FFF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

