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
	public BaseEntity[] NpcDeathInfo; // 0x70
	public bool ShowDebugData; // 0x78
	private int triggerParam; // 0x7C
	private int closeState; // 0x80

	// Methods

	// RVA: 0x68D070 Offset: 0x68B670 VA: 0x18068D070
	private void OnEnable() { }

	// RVA: 0x68D200 Offset: 0x68B800 VA: 0x18068D200
	public void Refresh() { }

	// RVA: 0x68D0F0 Offset: 0x68B6F0 VA: 0x18068D0F0
	private void Refresh_Age() { }

	// RVA: 0x68D160 Offset: 0x68B760 VA: 0x18068D160
	private void Refresh_Death() { }

	// RVA: 0x68D9D0 Offset: 0x68BFD0 VA: 0x18068D9D0
	private void Show(string name) { }

	// RVA: 0x68E130 Offset: 0x68C730 VA: 0x18068E130
	private void UpdateKilledByAvatar(ulong id) { }

	// RVA: 0x68DA90 Offset: 0x68C090 VA: 0x18068DA90
	public static bool TryGetDefinitionFromEntityName(string entityName, out ItemDefinition def) { }

	// RVA: 0x68E220 Offset: 0x68C820 VA: 0x18068E220
	private void UpdateKilledByWeaponImage(string weaponName) { }

	// RVA: 0x68CFE0 Offset: 0x68B5E0 VA: 0x18068CFE0
	public bool GetDamageDisplay(DamageType forType, out LifeInfographic.DamageSetting setting) { }

	// RVA: 0x68CF00 Offset: 0x68B500 VA: 0x18068CF00
	public void AnimateIn() { }

	[IteratorStateMachineAttribute] // RVA: 0x947F0 Offset: 0x93BF0 VA: 0x1800947F0
	// RVA: 0x68CF70 Offset: 0x68B570 VA: 0x18068CF70
	private IEnumerator Animate() { }

	// RVA: 0x68D070 Offset: 0x68B670 VA: 0x18068D070
	public void ResetAnimators() { }

	// RVA: 0x68DFC0 Offset: 0x68C5C0 VA: 0x18068DFC0
	public bool TryGetPrefabInformationForAttacker(string attackerName, out PrefabInformation info) { }

	// RVA: 0x68E360 Offset: 0x68C960 VA: 0x18068E360
	public void .ctor() { }

}

public struct LifeInfographic.DamageSetting // TypeDefIndex: 11071
{	// Fields
	public DamageType ForType; // 0x0
	public string Display; // 0x8
	public Sprite DamageSprite; // 0x10

}

private sealed class LifeInfographic.<Animate>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11072
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x68FD80 Offset: 0x68E380 VA: 0x18068FD80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x68FEE0 Offset: 0x68E4E0 VA: 0x18068FEE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

