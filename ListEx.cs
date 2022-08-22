public static class ListEx // TypeDefIndex: 6569
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetRandom<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1790 Offset: 0x5CFD90 VA: 0x1805D1790
	|-ListEx.GetRandom<ItemModEngineItem>
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetRandom<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1710 Offset: 0x5CFD10 VA: 0x1805D1710
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetRandom<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1800 Offset: 0x5CFE00 VA: 0x1805D1800
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Shuffle<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568A50 Offset: 0x1567050 VA: 0x181568A50
	|-ListEx.Shuffle<int>
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Shuffle<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572A10 Offset: 0x1571010 VA: 0x181572A10
	|-ListEx.Shuffle<PlaceMonumentsRailside.SpawnInfo>
	|-ListEx.Shuffle<PlaceMonumentsRoadside.SpawnInfo>
	|
	|-RVA: 0x15727C0 Offset: 0x1570DC0 VA: 0x1815727C0
	|-ListEx.Shuffle<int>
	|
	|-RVA: 0x15728E0 Offset: 0x1570EE0 VA: 0x1815728E0
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BubbleSort<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572600 Offset: 0x1570C00 VA: 0x181572600
	|-ListEx.BubbleSort<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void RemoveUnordered<T>(List<T> list, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572730 Offset: 0x1570D30 VA: 0x181572730
	|-ListEx.RemoveUnordered<CullingVolume>
	|-ListEx.RemoveUnordered<FoliageCell>
	|-ListEx.RemoveUnordered<PathList>
	|-ListEx.RemoveUnordered<IEnumerator>
	|-ListEx.RemoveUnordered<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static double TruncatedAverage(List<double> list, float pct) { }

}

private sealed class ListEx.<>c // TypeDefIndex: 6570
{	public static readonly ListEx.<>c <>9; // 0x0
	public static Func<double, double> <>9__7_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal double <TruncatedAverage>b__7_0(double x) { }

}

