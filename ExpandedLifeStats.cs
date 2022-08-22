public class ExpandedLifeStats : MonoBehaviour // TypeDefIndex: 10924
{	public GameObject DisplayRoot; // 0x18
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


	public void Toggle() { }

	public void Toggle(bool newState) { }

	private void PopulateDynamicStats() { }

	[IteratorStateMachineAttribute] // RVA: 0x8AE80 Offset: 0x8A280 VA: 0x18008AE80
	private IEnumerator WaitAndRelayout() { }

	private void PopulateGenericStats(List<ExpandedLifeStats.GenericStatDisplay> stats, Transform parent, PlayerLifeStory life) { }

	private void PopulateWeaponStats(List<PlayerLifeStory.WeaponStats> stats, Transform parent) { }

	public void UpdateScrollGradient() { }

	public void .ctor() { }

}

public struct ExpandedLifeStats.GenericStatDisplay // TypeDefIndex: 10925
{	public string statKey; // 0x0
	public Sprite statSprite; // 0x8
	public Translate.Phrase displayPhrase; // 0x10

}

private sealed class ExpandedLifeStats.<>c // TypeDefIndex: 10926
{	public static readonly ExpandedLifeStats.<>c <>9; // 0x0
	public static Comparison<PlayerLifeStory.WeaponStats> <>9__21_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <PopulateDynamicStats>b__21_0(PlayerLifeStory.WeaponStats a, PlayerLifeStory.WeaponStats b) { }

}

private sealed class ExpandedLifeStats.<WaitAndRelayout>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10927
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExpandedLifeStats <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ExpandedLifeStats.<>c__DisplayClass23_0 // TypeDefIndex: 10928
{	public ExpandedLifeStats.GenericStatDisplay genericStatDisplay; // 0x10


	public void .ctor() { }

	internal bool <PopulateGenericStats>b__0(PlayerLifeStory.GenericStat p) { }

}

