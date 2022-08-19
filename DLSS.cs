public static class DLSS // TypeDefIndex: 8224
{	// Methods

	// RVA: 0x106BC90 Offset: 0x106A290 VA: 0x18106BC90
	public static extern bool InitDLSS() { }

	// RVA: 0x106BC20 Offset: 0x106A220 VA: 0x18106BC20
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x106BD00 Offset: 0x106A300 VA: 0x18106BD00
	public static extern bool InitializeFeatures(uint optimalWidth, uint optimalHeight, uint displayWidth, uint displayHeight, int isHDR, bool lowResMotionVectors, bool depthInverted, float depthScale, NVSDK_NGX_PerfQuality_Value quality) { }

	// RVA: 0x106BDF0 Offset: 0x106A3F0 VA: 0x18106BDF0
	public static extern bool QueryOptimalSettings(uint displayWidth, uint displayHeight, NVSDK_NGX_PerfQuality_Value quality, ref DlSSRecommendedSettings outRecommendedSettings) { }

	// RVA: 0x106BE90 Offset: 0x106A490 VA: 0x18106BE90
	public static extern bool ReleaseFeatures() { }

	// RVA: 0x106BF00 Offset: 0x106A500 VA: 0x18106BF00
	public static extern void ShutdownDLSS() { }

}

