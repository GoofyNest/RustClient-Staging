public static class ListEx // TypeDefIndex: 6569
{
	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetRandom<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D1860 Offset: 0x5CFE60 VA: 0x1805D1860
	|-ListEx.GetRandom<ItemModEngineItem>
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetRandom<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D17E0 Offset: 0x5CFDE0 VA: 0x1805D17E0
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetRandom<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D18D0 Offset: 0x5CFED0 VA: 0x1805D18D0
	|-ListEx.GetRandom<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Shuffle<T>(List<T> list, uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568B90 Offset: 0x1567190 VA: 0x181568B90
	|-ListEx.Shuffle<int>
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Shuffle<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572B50 Offset: 0x1571150 VA: 0x181572B50
	|-ListEx.Shuffle<PlaceMonumentsRailside.SpawnInfo>
	|-ListEx.Shuffle<PlaceMonumentsRoadside.SpawnInfo>
	|
	|-RVA: 0x1572900 Offset: 0x1570F00 VA: 0x181572900
	|-ListEx.Shuffle<int>
	|
	|-RVA: 0x1572A20 Offset: 0x1571020 VA: 0x181572A20
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BubbleSort<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572740 Offset: 0x1570D40 VA: 0x181572740
	|-ListEx.BubbleSort<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void RemoveUnordered<T>(List<T> list, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572870 Offset: 0x1570E70 VA: 0x181572870
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

