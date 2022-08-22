public class ExpandedLifeStats : MonoBehaviour // TypeDefIndex: 10924
{	// Fields
	public GameObject DisplayRoot; // 0x18
	public GameObjectRef GenericStatRow; // 0x20
	[HeaderAttribute] // RVA: 0x8ACB0 Offset: 0x8A0B0 VA: 0x18008ACB0
	public Transform ResourcesStatRoot; // 0x28
	public List<ExpandedLifeStats.GenericStatDisplay> ResourceStats; // 0x30
	[HeaderAttribute] // RVA: 0x8AD80 Offset: 0x8A180 VA: 0x18008AD80
	public GameObjectRef WeaponStatRow; // 0x38
	public Transform WeaponsRoot; // 0x40
	[HeaderAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
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

	// RVA: 0x8CF880 Offset: 0x8CDE80 VA: 0x1808CF880
	public void Toggle() { }

	// RVA: 0x8CF570 Offset: 0x8CDB70 VA: 0x1808CF570
	public void Toggle(bool newState) { }

	// RVA: 0x8CEC70 Offset: 0x8CD270 VA: 0x1808CEC70
	private void PopulateDynamicStats() { }

	[IteratorStateMachineAttribute] // RVA: 0x8AE80 Offset: 0x8A280 VA: 0x18008AE80
	// RVA: 0x8CF9A0 Offset: 0x8CDFA0 VA: 0x1808CF9A0
	private IEnumerator WaitAndRelayout() { }

	// RVA: 0x8CEFB0 Offset: 0x8CD5B0 VA: 0x1808CEFB0
	private void PopulateGenericStats(List<ExpandedLifeStats.GenericStatDisplay> stats, Transform parent, PlayerLifeStory life) { }

	// RVA: 0x8CF2F0 Offset: 0x8CD8F0 VA: 0x1808CF2F0
	private void PopulateWeaponStats(List<PlayerLifeStory.WeaponStats> stats, Transform parent) { }

	// RVA: 0x8CF8A0 Offset: 0x8CDEA0 VA: 0x1808CF8A0
	public void UpdateScrollGradient() { }

	// RVA: 0x8CFA10 Offset: 0x8CE010 VA: 0x1808CFA10
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

	// RVA: 0x8D9AA0 Offset: 0x8D80A0 VA: 0x1808D9AA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9810 Offset: 0x8D7E10 VA: 0x1808D9810
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8D9E00 Offset: 0x8D8400 VA: 0x1808D9E00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8D9FB0 Offset: 0x8D85B0 VA: 0x1808D9FB0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ExpandedLifeStats.<>c__DisplayClass23_0 // TypeDefIndex: 10928
{	// Fields
	public ExpandedLifeStats.GenericStatDisplay genericStatDisplay; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x8D9910 Offset: 0x8D7F10 VA: 0x1808D9910
	internal bool <PopulateGenericStats>b__0(PlayerLifeStory.GenericStat p) { }

}

