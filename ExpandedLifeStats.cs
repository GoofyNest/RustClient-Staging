public class ExpandedLifeStats : MonoBehaviour // TypeDefIndex: 10928
{	public GameObject DisplayRoot; // 0x18
	public GameObjectRef GenericStatRow; // 0x20
	[HeaderAttribute] // RVA: 0x8AED0 Offset: 0x8A2D0 VA: 0x18008AED0
	public Transform ResourcesStatRoot; // 0x28
	public List<ExpandedLifeStats.GenericStatDisplay> ResourceStats; // 0x30
	[HeaderAttribute] // RVA: 0x8AF70 Offset: 0x8A370 VA: 0x18008AF70
	public GameObjectRef WeaponStatRow; // 0x38
	public Transform WeaponsRoot; // 0x40
	[HeaderAttribute] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
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

	[IteratorStateMachineAttribute] // RVA: 0x8B0B0 Offset: 0x8A4B0 VA: 0x18008B0B0
	private IEnumerator WaitAndRelayout() { }

	private void PopulateGenericStats(List<ExpandedLifeStats.GenericStatDisplay> stats, Transform parent, PlayerLifeStory life) { }

	private void PopulateWeaponStats(List<PlayerLifeStory.WeaponStats> stats, Transform parent) { }

	public void UpdateScrollGradient() { }

	public void .ctor() { }

}

public struct ExpandedLifeStats.GenericStatDisplay // TypeDefIndex: 10929
{	public string statKey; // 0x0
	public Sprite statSprite; // 0x8
	public Translate.Phrase displayPhrase; // 0x10

}

private sealed class ExpandedLifeStats.<>c // TypeDefIndex: 10930
{	public static readonly ExpandedLifeStats.<>c <>9; // 0x0
	public static Comparison<PlayerLifeStory.WeaponStats> <>9__21_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <PopulateDynamicStats>b__21_0(PlayerLifeStory.WeaponStats a, PlayerLifeStory.WeaponStats b) { }

}

private sealed class ExpandedLifeStats.<WaitAndRelayout>d__22 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10931
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExpandedLifeStats <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ExpandedLifeStats.<>c__DisplayClass23_0 // TypeDefIndex: 10932
{	public ExpandedLifeStats.GenericStatDisplay genericStatDisplay; // 0x10


	public void .ctor() { }

	internal bool <PopulateGenericStats>b__0(PlayerLifeStory.GenericStat p) { }

}

