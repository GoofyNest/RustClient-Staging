public class ExpandedLifeStats : MonoBehaviour // TypeDefIndex: 10924
{	// Fields
	public GameObject DisplayRoot; // 0x18
	public GameObjectRef GenericStatRow; // 0x20
	[HeaderAttribute] // RVA: 0x8ABC0 Offset: 0x89FC0 VA: 0x18008ABC0
	public Transform ResourcesStatRoot; // 0x28
	public List<ExpandedLifeStats.GenericStatDisplay> ResourceStats; // 0x30
	[HeaderAttribute] // RVA: 0x8AC90 Offset: 0x8A090 VA: 0x18008AC90
	public GameObjectRef WeaponStatRow; // 0x38
	public Transform WeaponsRoot; // 0x40
	[HeaderAttribute] // RVA: 0x71E00 Offset: 0x71200 VA: 0x180071E00
	public Transform MiscRoot; // 0x48
	public List<ExpandedLifeStats.GenericStatDisplay> MiscStats; // 0x50
	public LifeInfographic Infographic; // 0x58
	public RectTransform MoveRoot; // 0x60
	public Vector2 OpenPosition; // 0x68
	public Vector2 ClosedPosition; // 0x70
	public GameObject OpenButtonRoot; // 0x78
	public GameObject CloseButtonRoot; // 0x80
	public GameObject ScrollGradient; // 0x88
	public ScrollRect Scroller; // 0x90
	private bool state; // 0x98
	private List<GameObject> rowsToRetire; // 0xA0

	// Methods

	// RVA: 0x8CF770 Offset: 0x8CDD70 VA: 0x1808CF770
	public void Toggle() { }

	// RVA: 0x8CF460 Offset: 0x8CDA60 VA: 0x1808CF460
	public void Toggle(bool newState) { }

	// RVA: 0x8CEB60 Offset: 0x8CD160 VA: 0x1808CEB60
	private void PopulateDynamicStats() { }

	[IteratorStateMachineAttribute] // RVA: 0x8AE10 Offset: 0x8A210 VA: 0x18008AE10
	// RVA: 0x8CF890 Offset: 0x8CDE90 VA: 0x1808CF890
	private IEnumerator WaitAndRelayout() { }

	// RVA: 0x8CEEA0 Offset: 0x8CD4A0 VA: 0x1808CEEA0
	private void PopulateGenericStats(List<ExpandedLifeStats.GenericStatDisplay> stats, Transform parent, PlayerLifeStory life) { }

	// RVA: 0x8CF1E0 Offset: 0x8CD7E0 VA: 0x1808CF1E0
	private void PopulateWeaponStats(List<PlayerLifeStory.WeaponStats> stats, Transform parent) { }

	// RVA: 0x8CF790 Offset: 0x8CDD90 VA: 0x1808CF790
	public void UpdateScrollGradient() { }

	// RVA: 0x8CF900 Offset: 0x8CDF00 VA: 0x1808CF900
	public void .ctor() { }

}

public struct ExpandedLifeStats.GenericStatDisplay // TypeDefIndex: 10925
{	// Fields
	public string statKey; // 0x0
	public Sprite statSprite; // 0x8
	public Translate.Phrase displayPhrase; // 0x10

}

private sealed class ExpandedLifeStats.<>c // TypeDefIndex: 10926
{	// Fields
	public static readonly ExpandedLifeStats.<>c <>9; // 0x0
	public static Comparison<PlayerLifeStory.WeaponStats> <>9__21_0; // 0x8

	// Methods

	// RVA: 0x8D9990 Offset: 0x8D7F90 VA: 0x1808D9990
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9700 Offset: 0x8D7D00 VA: 0x1808D9700
	internal int <PopulateDynamicStats>b__21_0(PlayerLifeStory.WeaponStats a, PlayerLifeStory.WeaponStats b) { }

}

private sealed class ExpandedLifeStats.<WaitAndRelayout>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10927
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExpandedLifeStats <>4__this; // 0x20

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

	// RVA: 0x8D9CF0 Offset: 0x8D82F0 VA: 0x1808D9CF0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x8D9EA0 Offset: 0x8D84A0 VA: 0x1808D9EA0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ExpandedLifeStats.<>c__DisplayClass23_0 // TypeDefIndex: 10928
{	// Fields
	public ExpandedLifeStats.GenericStatDisplay genericStatDisplay; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9800 Offset: 0x8D7E00 VA: 0x1808D9800
	internal bool <PopulateGenericStats>b__0(PlayerLifeStory.GenericStat p) { }

}
