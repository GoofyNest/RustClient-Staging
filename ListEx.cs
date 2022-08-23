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
	|-RVA: 0x1568B50 Offset: 0x1567150 VA: 0x181568B50
	|-ListEx.Shuffle<int>
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void Shuffle<T>(List<T> list, ref uint seed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572B10 Offset: 0x1571110 VA: 0x181572B10
	|-ListEx.Shuffle<PlaceMonumentsRailside.SpawnInfo>
	|-ListEx.Shuffle<PlaceMonumentsRoadside.SpawnInfo>
	|
	|-RVA: 0x15728C0 Offset: 0x1570EC0 VA: 0x1815728C0
	|-ListEx.Shuffle<int>
	|
	|-RVA: 0x15729E0 Offset: 0x1570FE0 VA: 0x1815729E0
	|-ListEx.Shuffle<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BubbleSort<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572700 Offset: 0x1570D00 VA: 0x181572700
	|-ListEx.BubbleSort<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void RemoveUnordered<T>(List<T> list, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572830 Offset: 0x1570E30 VA: 0x181572830
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

