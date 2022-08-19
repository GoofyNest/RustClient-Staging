internal static class GameAnalytics // TypeDefIndex: 5620
{	// Fields
	private static bool _endThread; // 0x33D0

	// Methods

	// RVA: 0x13C8180 Offset: 0x13C6780 VA: 0x1813C8180
	private static void .cctor() { }

	// RVA: 0x13C7200 Offset: 0x13C5800 VA: 0x1813C7200
	public static void ConfigureBuild(string build) { }

	// RVA: 0x13C7480 Offset: 0x13C5A80 VA: 0x1813C7480
	public static void ConfigureSdkGameEngineVersion(string sdkGameEngineVersion) { }

	// RVA: 0x13C7340 Offset: 0x13C5940 VA: 0x1813C7340
	public static void ConfigureGameEngineVersion(string gameEngineVersion) { }

	// RVA: 0x13C75C0 Offset: 0x13C5BC0 VA: 0x1813C75C0
	public static void ConfigureUserId(string uId) { }

	// RVA: 0x13C7700 Offset: 0x13C5D00 VA: 0x1813C7700
	public static void Initialize(string gameKey, string gameSecret) { }

	// RVA: 0x13C6D40 Offset: 0x13C5340 VA: 0x1813C6D40
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType) { }

	// RVA: 0x13C7080 Offset: 0x13C5680 VA: 0x1813C7080
	public static void AddDesignEvent(string eventId, IDictionary<string, object> fields) { }

	// RVA: 0x13C6F00 Offset: 0x13C5500 VA: 0x1813C6F00
	public static void AddDesignEvent(string eventId, double value) { }

	// RVA: 0x13C7DC0 Offset: 0x13C63C0 VA: 0x1813C7DC0
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13C7F00 Offset: 0x13C6500 VA: 0x1813C7F00
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13C8040 Offset: 0x13C6640 VA: 0x1813C8040
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13C7A90 Offset: 0x13C6090 VA: 0x1813C7A90
	public static void OnQuit() { }

	// RVA: 0x13C7A20 Offset: 0x13C6020 VA: 0x1813C7A20
	private static bool IsSdkReady(bool needsInitialized, bool warn) { }

	// RVA: 0x13C7880 Offset: 0x13C5E80 VA: 0x1813C7880
	private static bool IsSdkReady(bool needsInitialized, bool warn, string message) { }

}

private sealed class GameAnalytics.<>c__DisplayClass7_0 // TypeDefIndex: 5621
{	// Fields
	public string build; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE900 Offset: 0x13CCF00 VA: 0x1813CE900
	internal void <ConfigureBuild>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass8_0 // TypeDefIndex: 5622
{	// Fields
	public string sdkGameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CEBF0 Offset: 0x13CD1F0 VA: 0x1813CEBF0
	internal void <ConfigureSdkGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass9_0 // TypeDefIndex: 5623
{	// Fields
	public string gameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CEE50 Offset: 0x13CD450 VA: 0x1813CEE50
	internal void <ConfigureGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass10_0 // TypeDefIndex: 5624
{	// Fields
	public string uId; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDCC0 Offset: 0x13CC2C0 VA: 0x1813CDCC0
	internal void <ConfigureUserId>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass11_0 // TypeDefIndex: 5625
{	// Fields
	public string gameKey; // 0x10
	public string gameSecret; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDFE0 Offset: 0x13CC5E0 VA: 0x1813CDFE0
	internal void <Initialize>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass12_0 // TypeDefIndex: 5626
{	// Fields
	public string currency; // 0x10
	public int amount; // 0x18
	public string itemType; // 0x20
	public string itemId; // 0x28
	public string cartType; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE4A0 Offset: 0x13CCAA0 VA: 0x1813CE4A0
	internal void <AddBusinessEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass20_0 // TypeDefIndex: 5627
{	// Fields
	public string eventId; // 0x10
	public IDictionary<string, object> fields; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE580 Offset: 0x13CCB80 VA: 0x1813CE580
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass21_0 // TypeDefIndex: 5628
{	// Fields
	public string eventId; // 0x10
	public double value; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE630 Offset: 0x13CCC30 VA: 0x1813CE630
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass25_0 // TypeDefIndex: 5629
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE6F0 Offset: 0x13CCCF0 VA: 0x1813CE6F0
	internal void <SetCustomDimension01>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass26_0 // TypeDefIndex: 5630
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE7A0 Offset: 0x13CCDA0 VA: 0x1813CE7A0
	internal void <SetCustomDimension02>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass27_0 // TypeDefIndex: 5631
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CE850 Offset: 0x13CCE50 VA: 0x1813CE850
	internal void <SetCustomDimension03>b__0() { }

}

private sealed class GameAnalytics.<>c // TypeDefIndex: 5632
{	// Fields
	public static readonly GameAnalytics.<>c <>9; // 0x0
	public static Action <>9__35_0; // 0x8

	// Methods

	// RVA: 0x13CF0B0 Offset: 0x13CD6B0 VA: 0x1813CF0B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x13CDC20 Offset: 0x13CC220 VA: 0x1813CDC20
	internal void <OnQuit>b__35_0() { }

}

